use master
go

create database QLKHO3

use QLKHO3
go

create table Ton(
	maVT nchar(10) not null primary key,
	tenVT nvarchar(30),
	soLuongT int
)

create table Nhap(
	soHDN nchar(10),
	maVT nchar(10),
	soLuongN int,
	donGiaN money,
	ngayN date,
	constraint pk_nhap primary key(soHDN,maVT),
	constraint fk_ton foreign key(maVT)
		references Ton(maVT)
)

create table Xuat(
	soHDX nchar(10),
	maVT nchar(10),
	soLuongX int,
	donGiaX money,
	ngayX date,
	constraint pk_xuat primary key(soHDX,maVT),
	constraint fk_kho foreign key(maVT)
		references Ton(maVT)
)

insert into Ton
values  ('VT1', N'kẹo lạc', 200),
		('VT2', N'kẹo dừa', 100),
		('VT3', N'kẹo mút', 500),
		('VT4', N'kẹo vừng', 700)

insert into Nhap
values  ('N1', 'VT2', 200, 5000, '10/22/2018'),
		('N2', 'VT1', 300, 30000, '5/26/2019'),
		('N3', 'VT3', 400, 10000, '5/15/2020')

insert into Xuat
values  ('X1', 'VT1', 500, 20000, '9/25/2019'),
		('X2', 'VT3', 300, 60000, '10/25/2020'),
		('X3', 'VT1', 400, 50000, '8/22/2019')



select * from Ton
select * from Nhap
select * from Xuat

--câu 2

create function thongke(@mavt nchar(10), @ngayn date)
returns @bang table(
					maVT nchar(10),
					tenVT nvarchar(30),
					ngayN date,
					tongTienN money
					)
as
begin
	insert into @bang
	select Ton.maVT, tenVT, ngayN, sum(soLuongN*donGiaN) 
	from Ton inner join Nhap on Ton.maVT=Nhap.maVT and Ton.maVT=@mavt and ngayN=@ngayn
	group by Ton.maVT, tenVT, ngayN
	return
end

--test
select * from Ton
select * from Nhap
select * from Xuat
select * from dbo.thongke('VT2', '10/22/2018')

--câu 3
alter proc cau3(@sohdx nchar(10), @mavt nchar(10), @slxuat int, @dongiax money, @ngayx date, @trave int output)
as
begin
	declare @slx int
	declare @slt int
	select @slx=soLuongX from Xuat
	select @slt=soLuongT from Ton
	if(@slx>@slt)
		set @trave=1
	else
	begin
		insert into Xuat
		values (@sohdx, @mavt, @slxuat, @dongiax, @ngayx)
			set @trave=0
	end
end

--test 
declare @bien int
exec cau3 'X5', 'VT2', 200, 15000, '10/10/2019', @bien output
select @bien

declare @bien1 int
exec cau3 'X6', 'VT3', 20, 15000, '10/10/2019', @bien1 output
select @bien1

select * from Ton
select * from Nhap
select * from Xuat 