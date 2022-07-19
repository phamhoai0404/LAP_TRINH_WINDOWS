use master
go

create database QLKHO4

use QLKHO4
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
	constraint pk_nhap primary key(soHDN, maVT),
	constraint fk_ton foreign key(maVT)
		references Ton(maVT)
)	

create table Xuat(
	soHDX nchar(10),
	maVT nchar(10),
	soLuongX int,
	donGiaX money,
	ngayX date,
	constraint pk_xuat primary key(soHDX, maVT),
	constraint fk_ton1 foreign key(maVT)
		references Ton(maVT)
)		

insert into Ton
values  ('VT1', N'kẹo lạc', 200),
		('VT2', N'kẹo vừng', 300),
		('VT3', N'kẹo dừa', 400),
		('VT4', N'kẹo mút', 500)	

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
create proc cau2(@sohdx nchar(10), @mavt nchar(10), @slx int, @dongiax money, @nx date, @trave nvarchar(50) output)
as
begin
	declare @slt int
	select @slt=soLuongT from Ton
	if(@slx>@slt)
		set @trave= N'không thỏa mãn'
	else
		begin
			insert into Xuat 
			values(@sohdx, @mavt, @slx, @dongiax, @nx)
			set @trave= N'nhập thành công'
		end
end

--test
declare @bien nvarchar(50)
exec cau2 'X4', 'VT3', 1000, 10000, '10/5/2019', @bien output
select @bien

declare @bien1 nvarchar(50)
exec cau2 'X4', 'VT3', 150, 10000, '10/5/2019', @bien1 output
select @bien1

select * from Xuat
select * from Ton

--câu 3
alter function cau3(@tenvt nvarchar(30), @ngayn date)
returns money
as
begin
	declare @tong money
	select @tong=sum(donGiaN*soLuongN) 
	from Ton inner join Nhap on Ton.maVT=Nhap.maVT and tenVT=@tenvt and ngayN=@ngayn
	group by Ton.maVT, tenVT
	return @tong
end

--test
select dbo.cau3(N'kẹo lạc', '10/5/2018') as N'tổng tiền nhập'

select * from Nhap

--câu 4
create trigger trg_cau4
on Nhap
for insert
as
begin
	declare @mavt nchar(10)
	declare @sln int
	select @sln=inserted.soLuongN,@mavt=maVT from inserted
	if(not exists(select * from Ton where maVT=@mavt))
		begin
			raiserror(N'mã vt chưa có mặt trong bảng Ton',16,1)
			rollback transaction
		end
	else
		begin
			update Ton set soLuongT=soLuongT + @sln
			where maVT=@mavt
		end
end

--test
select * from Ton
select * from Nhap

insert into Nhap values ('N4', 'VT7', 20, 10000, '5/5/2020')
insert into Nhap values ('N4', 'VT3', 20, 10000, '5/5/2020')