use master
go
create database siv
go
use siv
go
create table ton (
	mavt char(10) not null primary key,
	tenvt nvarchar(50),
	soluongt int,
	giagoc money)
create table xuat(
	sohdx char(10) not null,
	mavt char(10) not null,
	soluongx int,
	giaban money,
	ngayb date,
	constraint pk primary key (sohdx, mavt),
	constraint fk foreign key (mavt) references ton(mavt))




-------------chú ý là phần view thì tất cả phải có tên ở select nếu không có tên nó sẽ báo lỗi
create view cau2
as
	select * 
	from ton

select * from cau2
--------------------------------function----------
create function lsf(@d date)
returns int
as
	begin
		declare @kq int
		set @kq=20
		return @kq 
	end


select dbo.lsf('2/3/2020')

create function kt(@k int)
returns @bang table(
	a char(10),
	nvt nvarchar(50),
	uongt int,
	goc money)
as	
	begin
		insert into @bang
			select * from ton
		return
	end

select * from kt(34)
---------------------------thủ tục-------------
alter proc tin
as
	begin
		select * from ton
		return
	end
exec tin


----
create proc congnghe(@k int output)
as
	begin
		set @k=30
		return @k
	end

declare @trave int
exec congnghe @trave output
select @trave as N'trả về'

----

alter proc khongtrave(@k int)
as
	begin
		if(@k=40)print(N'là bằng 40 thôi!')
		else print(N'khác 40!')
	end

exec khongtrave 20



-------------------trigger
alter trigger ktnhap
on ton
for insert
as
	begin
		declare @k int
		set @k=40
		if(@k=50)
			begin
				raiserror(N'K bằng 50', 16,1)
				rollback transaction
			end
		else
			begin
				print(N'kiểu thế')
			end
	end

insert into ton values( 'h4', N'Chuột', 30,12000)



raiserror (N'',16,1)