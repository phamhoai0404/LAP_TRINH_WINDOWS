use master 
go 
create database QLKHO 
on primary(
	name='QLKHO_dat', filename='D:\QLKHO.mdf',
	size=5MB, maxsize=50MB, filegrowth=2MB
)
log on(
	name='QLKHO_log', filename='D:\QLKHO.ldf',
	size=5MB, maxsize=50MB, filegrowth=10%
)
go
use QLKHO
go
create table ton(
		mavt nchar(10) not null primary key,
		tenvt nvarchar(20),
		soluongt int 
)
create table nhap(
		sohdn nchar(10) not null,
		mavt nchar(10) not null,
		soluongn int,
		dongian float,
		ngayn datetime,
		constraint pk1 primary key (sohdn,mavt),
		constraint fk1 foreign key(mavt) references ton(mavt)
)
create table xuat(
		sohdx nchar(10) not null,
		mavt nchar(10) not null,
		soluongx int,
		dongiax float,
		ngayx datetime,
		constraint pk2 primary key (sohdx,mavt),
		constraint fk2 foreign key(mavt) references ton(mavt)
)
create view cau2
as
	select ton.mavt, tenvt, sum( soluongx*dongiax) as 'tienban'
	from xuat inner join ton on xuat.mavt=ton.mavt
	group by ton.mavt,tenvt
select * from cau2


create view cau3
as
	select ton.tenvt, sum(soluongx) as 'tong sl'
	from xuat inner join ton on xuat.mavt=ton.mavt
	group by ton.tenvt
select * from cau3



create view cau4
as
	select ton.tenvt, sum(soluongn) as 'tong sl'
	from nhap inner join ton on nhap.mavt=ton.mavt
	group by ton.tenvt
select * from cau4


create view cau5
as
	select ton.mavt, tenvt, sum(soluongn)-sum(soluongx)+ sum(soluongt) as 'soluongcon'
	from nhap inner join ton  on nhap.mavt=ton.mavt
				inner join xuat on ton.mavt=xuat.mavt
	group by ton.mavt, tenvt