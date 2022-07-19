use master 
go

create database QLKHO1

use QLKHO1
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

create function thongke(@ngayx date, @mavt nchar(10))
returns @ds table(
					maVT nchar(10),
					tenVT nvarchar(30),
					tongTienBan money
					)
as
begin
	insert into @ds
	select Ton.maVT, tenVT, sum(soLuongX*donGiaX)
	from Ton inner join Xuat on Ton.maVT=Xuat.maVT and ngayX=@ngayx and Ton.maVT=@mavt
	group by Ton.maVT,tenVT
	return
end

--test
select * from dbo.thongke('11/5/2018', 'VT2')

--câu 3

create proc xoavt(@mavt nchar(10))
as
begin
	if(exists(select * from Nhap where maVT=@mavt) or exists(select * from Xuat where maVT=@mavt))
		print (N'Không được xóa')
	else
		begin
			delete from Ton where maVT=@mavt
		end		
end

--test

select * from Nhap
select * from Xuat

exec xoavt'VT4'
select * from Ton

--câu 4

alter trigger trg_nhap
on Nhap
for insert 
as
begin
	declare @mavt nchar(10)
	declare @sln int
	select @mavt=maVT, @sln= soLuongN  from inserted
	
	if(not exists(select * from Ton where maVT=@mavt))
	begin
		raiserror (N' maVT chưa có mặt trong bảng Ton',16,1)
		rollback transaction
	end
	else
		begin
			update Ton set soLuongT=soLuongT+@sln
			where maVT=@mavt
		end
end

--test
select * from Ton
select * from Nhap

insert into Nhap values ('N4', 'VT3', 20, 10000, '5/5/2019')