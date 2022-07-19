use master 
go

create database QLKHO2

use QLKHO2
go

create table Ton(
	maVT nchar(10) primary key,
	tenVT nvarchar(30),
	soLuongT int
)

create table Nhap(
	soHDN nchar(10),
	maVT nchar(10),
	soLuongN int,
	donGiaN money,
	ngayN date,
	constraint pk_nhap primary key(soHDN, maVT),
	constraint fk_nhap_ton foreign key(maVT)
		references Ton(maVT)
)

create table Xuat(
	soHDX nchar(10),
	maVT nchar(10),
	soLuongX int,
	donGiaX money,
	ngayX date,
	constraint pk_xuat primary key(soHDX, maVT),
	constraint fk_xuat_ton foreign key(maVT)
		references Ton(maVT)
)

insert into Ton
values ('VT1', N'kẹo lạc', 100),
		('VT2', N'kẹo vừng', 500),
		('VT3', N'kẹo dừa', 2500),
		('VT4', N'kẹo kéo', 300)

insert into Nhap
values ('N1', 'VT1', 50, 5000, '10/5/2018'),
		('N2', 'VT3', 70, 10000, '3/16/2019'),
		('N3', 'VT1', 85, 50000, '5/8/2020')

insert into Xuat
values ('X1', 'VT2', 20, 8000, '11/5/2018'),
		('X2', 'VT3', 35, 15000, '5/11/2019'),
		('X3', 'VT1', 60, 70000, '6/10/2020')

select * from Ton
select * from Nhap
select * from Xuat

--câu 2

alter function thongketien(@mavt nchar(10), @ngayn date)
returns @ds table(
						maVT nchar(10),
						tenVT nvarchar(30),
						ngayN date,
						tongTienNhap money
					)
as
begin
	insert into @ds
	select Ton.maVT, tenVT, ngayN, sum(soLuongN*donGiaN)
	from Ton inner join Nhap on Ton.maVT=Nhap.maVT
	where Ton.maVT=@mavt and ngayN=@ngayn
	group by Ton.maVT,tenVT, ngayN
	return
end

--test

select * from dbo.thongketien('VT1', '10/5/2018')

--câu 3

create function cau3(@tenvt nvarchar(30), @ngayx date)
returns money
as
begin
	declare @tong money
	select @tong=sum(soLuongX*donGiaX) from Ton inner join Xuat on Ton.maVT=Xuat.maVT where tenVT=@tenvt and ngayX=@ngayx
	return @tong
end

--test
select dbo.cau3(N'kẹo vừng', '11/5/2018') as N'tổng tiền'

--câu 4

alter trigger trg_cau4
on Xuat
for insert
as
begin
	declare @slx int
	declare @sl int
	declare @mavt nchar(10)
	select @slx=inserted.soLuongX, @mavt=maVT from inserted
	select @sl=soLuongT from Ton where maVT=@mavt
	if(@slx>@sl)
		begin
			raiserror (N'hãy ktra lại mavt hoặc slx',16,1)
			rollback transaction
		end
	else
		begin
			update Ton set soLuongT=soLuongT-@slx
			where maVT=@mavt
		end
end

select * from Ton
select * from Xuat

insert into Xuat values('X6', 'VT1', '5', 20000, '10/20/2018')