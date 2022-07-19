use master
go
create  database QLKHO1

create table ton(
	mavt char(10) not null primary key,
	tenvt nvarchar(50) not null,
	soluongt int)
go

create table nhap(
	sohdn char(10) not null primary key,
	mavt char(10) not null,
	soluongn int,
	dongian money,
	ngayn datetime,
	constraint fk1_nhap_ton foreign key (mavt) references ton(mavt) )
go
create table xuat(
	sohdx char(10) not null primary key,
	mavt char(10) not null,
	soluongx int,
	dongiax money,
	ngayx datetime,
	constraint fk2_xuat_ton foreign key (mavt) references ton(mavt))

insert into ton values
	('m1',N'Kéo',20),
	('m2',N'Dao',10),
	('m3',N'Nồi',30)

insert into ton values
	('m4',N'Nhựa',30)
select * from ton

insert into nhap values
	('n1','m1', 20, 2300, '3/7/2020'),
	('n2','m3', 50, 1300, '3/8/2020'),
	('n3','m1', 10, 3500, '4/5/2020')
select * from nhap

insert into xuat values
	('x1','m2', 10, 4000, '3/7/2020'),
	('x2','m1', 15, 8900, '3/3/2020'),
	('x3','m1', 7, 5600, '4/3/2020')

insert into xuat values
	('x4','m2', 10, 4000, '3/7/2021')
select * from xuat
----cau2'

select * from ton
select * from xuat
select * from nhap


create view cau2
as
	select ton.mavt, tenvt, sum(soluongx*dongiax) as N'Tiền bán'
	from ton inner join xuat on ton.mavt=xuat.mavt
	group by ton.mavt, tenvt
	 
select * from cau2
select * from ton
select * from xuat
select * from nhap


create view cau3
as
	select tenvt, sum(soluongx) as N'Tổng slx'
	from ton inner join xuat on ton.mavt=xuat.mavt
	group by tenvt


select * from cau2
select * from cau3
select * from xuat


----cau4
create view cau4
as
	select tenvt, sum(soluongn) as N'Tổng sln'
	from ton inner join nhap on ton.mavt=nhap.mavt
	group by tenvt


select * from cau2
select * from cau4
select * from nhap



---cau5
create view cau5
as
	select ton.mavt, tenvt, sum(soluongt+soluongn-soluongx) as N'còn lại sau khi xuất và nhập'
	from ton inner join nhap on ton.mavt=nhap.mavt
			inner join xuat on ton.mavt=xuat.mavt
	group by ton.mavt, tenvt

select * from cau5
select * from nhap
select * from xuat
select * from ton--------vừa có nhập vừa có xuất thì đầu tiên là nối bảng rồi sau đó tính từng dòng rồi gom nhóm cộng



create view cau6	
as	
	select tenvt, soluongt as N'tồn nhiều nhất'
	from ton
	where soluongt=( select max(soluongt)
					  from ton)
select * from cau6


----cau7
create view cau7
as	
	select tenvt, sum(soluongx) as 'Tổng slx'
	from xuat inner join ton on xuat.mavt=ton.mavt
	group by tenvt
	having sum(soluongx)>9

select * from xuat
select * from cau7



----cau8
create view cau8
as	
	select month(ngayx) as N'Tháng xuất',  year(ngayx) as N'Năm xuất', sum(soluongx) as N'Tổng xuất'
	from xuat
	group by month(ngayx), year(ngayx)
select * from xuat
select * from cau8



----cau9
create view cau9
as
	select ton.mavt, tenvt, soluongn, soluongx, dongian, dongiax, ngayn, ngayx
	from ton inner join nhap on ton.mavt=nhap.mavt
			inner join xuat on ton.mavt=xuat.mavt

select * from ton
select * from nhap
select * from xuat
select * from cau9




-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------
-------------------------------------------

create function thongke ( @malop char(10))
return