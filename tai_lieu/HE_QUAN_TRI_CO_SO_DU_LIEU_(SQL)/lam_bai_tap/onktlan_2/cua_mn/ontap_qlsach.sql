use master
go

create database QLSACH

use QLSACH
go

create table NHAXUATBAN(
	MaNXB char(10) not null primary key,
	TenNXB nvarchar(30),
	SoLuongXB int
)

create table TACGIA(
	MaTG char(10) not null primary key,
	TenTG nvarchar(30)
)

create table SACH(
	MaSach char(10) not null primary key,
	TenSach nvarchar(30),
	NamXB int,
	SoLuong int,
	DonGia money,
	MaTG char(10),
	MaNXB char(10),
	constraint fk_nxb foreign key(MaNXB)
		references NHAXUATBAN(MaNXB),
	constraint fk_sach foreign key(MaTG)
		references TACGIA(MaTG)
)

insert into NHAXUATBAN
values ('N1', N'Nguyễn Văn A', 100),
		('N2', N'Lê Văn B', 200)

insert into TACGIA
values ('TG1', N'Tiến'),
		('TG2', N'Dũng')

insert into SACH
values ('S1', N'toán', 2000, 200, 10, 'TG1', 'N2'),
		('S2', N'văn', 2015, 500, 30, 'TG2', 'N1'),
		('S3', N'anh', 2019, 100, 20, 'TG1', 'N2'),
		('S4', N'lịch sử', 1999, 50, 5, 'TG1', 'N1'),
		('S5', N'địa lý', 2005, 20, 8, 'TG2', 'N2'),
		('S6', N'sinh học', 2010, 80, 15, 'TG1', 'N2')

select * from NHAXUATBAN
select * from TACGIA
select * from SACH

--Câu 2:

create view cau2
as
select MaNXB, TenNXB, sum(SoLuongXB) as N'tổng sl'
from NHAXUATBAN
group by MaNXB, TenNXB

--test

select * from cau2

--Câu 3:

create function cau3(@ten nvarchar(30), @x int, @y int)
returns @ds table(
					masach char(10),
					tensach nvarchar(30),
					tenTG nvarchar(30),
					dongia money
					)
as
begin
	insert into @ds
	select masach, tensach, tenTG, dongia
	from NHAXUATBAN inner join SACH on SACH.MaNXB=NHAXUATBAN.MaNXB
					inner join TACGIA on SACH.MaTG=TACGIA.MaTG
	where TenNXB=@ten and NamXB between @x and @y
	return
end

select * from dbo.cau3(N'Nguyễn Văn A', 1900, 2400)

--Câu 4:

create proc cau4(@masach char(10))
as
begin
	delete from SACH where MaSach=@masach
end

--test

exec cau4 'S1'
select * from SACH


create view cau22
as
select NHAXUATBAN.MaNXB, TenNXB, sum(SoLuongXB) as N'tổng sl', sum(SoLuong*DonGia) as N'tổng tiền sách'
from SACH inner join NHAXUATBAN on SACH.MaNXB=NHAXUATBAN.MaNXB
group by NHAXUATBAN.MaNXB, TenNXB

select * from cau22

create view tong
as
select MaNXB, TenNXB, sum(SoLuongXB) as N'tong sl xb'
from NHAXUATBAN
group by MaNXB, TenNXB

select * from tong

create function cau33(@ten nvarchar(30), @x int, @y int)
returns @ds table(
					maSach char(10),
					tenSach nvarchar(30),
					tenTG nvarchar(30),
					donGia money
					)
as
begin 
	insert into @ds
	select maSach, tenSach, tenTG, donGia
	from SACH inner join TACGIA on SACH.MaTG=TACGIA.MaTG
				inner join NHAXUATBAN on sach.MaNXB=NHAXUATBAN.MaNXB
	where  TenNXB=@ten and NamXB between @x and @y
	return
end
select * from SACH
select * from dbo.cau33(N'Lê Văn B', 1900, 2020)


create proc cau44(@masach char(10))
as
begin 
	delete from SACH where MaSach=@masach
end

exec cau44 'S3'
select * from SACH


