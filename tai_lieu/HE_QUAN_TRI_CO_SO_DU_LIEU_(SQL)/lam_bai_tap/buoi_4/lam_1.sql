
use master 
go 
create database QLSV
on primary(
	name='QLSV_dat', filename='D:\QLSV.mdf',
	size=5MB, maxsize=50MB, filegrowth=2MB
)
log on(
	name='QLSV_log', filename='D:\QLSV.ldf',
	size=5MB, maxsize=50MB, filegrowth=10%
)
go
use QLSV
go
create table LOP(
		malop nchar(10) not null primary key,
		tenlop nvarchar(20),
		phong int 
)
create table SINHVIEN(
		masv nchar(10) not null primary key,
		tensv nvarchar(20),
		malop nchar(10) ,
		constraint fk1 foreign key(malop) references LOP(malop)
)
---------------
create function bai1( @malop nchar(10))
returns int 
as	
begin	
	declare @soluong int 
	set @soluong = ( select count (*)
					from SINHVIEN 
					where malop=@malop)
	return @soluong
end 

select * from SINHVIEN
select dbo.bai1('1')

--------------

create function cau2_2(@tenlop nchar(10))
returns @bang table(
			masv nchar(10),
			tensv nvarchar(20)
			)
as	
begin
	 insert into @bang
				select masv, tensv
				from SINHVIEN inner join LOP on SINHVIEN.malop=LOP.malop
				where LOP.tenlop= @tenlop
	return 
end 
select * from LOP
select * from SINHVIEN

select * from cau2_2('CD')  
