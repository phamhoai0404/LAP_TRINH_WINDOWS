use master 
go
if(exists(select * from sysdatabases where name='QLHANG'))
	drop database QLHANG
go
create database QLHANG
go
use QLHANG
go
create table hang(
	mahang int primary key,
	tenhang nchar(10) not null,
	dvtinh nchar(10) not null,
	sl int
)
create table hdban(
	mahd int primary key,
	ngayban datetime not null,
	hotenkhach nchar(10) not null
)
create table hangban(
	mahd int,
	mahang int,
	dongia int,
	soluong int,
	constraint PK_hangban primary key(mahd,mahang),
	constraint FK_hangban_hdban foreign key(mahd) references hdban(mahd),
	constraint FK_hangban_hang foreign key(mahang) references hang(mahang)
)
insert into hang values
(1,'h1','cai',2),
(2,'h2','cai',3)
insert into hdban values
(3,'2/3/2002','lan'),
(4,'2/4/2002','hoa')
insert into hangban values
(3,1,2000,7),
(3,2,2400,1),
(4,1,2000,3),
(4,2,2400,4)

select *from hang
select *from hdban
select *from hangban
---cau2
create view cau2
as
	select hang.mahang, tenhang, sum(soluong)*dongia as'tongtien'
	from hangban inner join hang on hangban.mahang=hang.mahang
	group by hang.mahang, tenhang,dongia

SELECT * FROM CAU2
--cau3
create function ham(@hotenkhach nchar(10), @x datetime, @y datetime)
returns @bang table(
	mahang int,
	tenhang nchar(10),
	soluong int,
	dongia int
	)
as
begin
	insert into @bang 
		select hangban.mahang, tenhang, soluong, dongia
		from hang inner join hangban on hang.mahang=hangban.mahang inner join hdban on hangban.mahd=hdban.mahd
		where hotenkhach=@hotenkhach and day(ngayban) between @x and @y
	return 
end
drop function ham
select *from ham('lan','1/3/2002','4/3/2002')
---cau4
create proc xoa(@mahd int)
as
begin
	delete from hangban 
	where mahd=@mahd
end 
exec xoa 3
select *from hangban
---------------2
create function hamm(@tenhang nchar(10), @x int)
returns int
as
begin
	declare @tong int
	set @tong= (select sum(soluong) from hdban inner join hangban on hdban.mahd=hangban.mahd inner join hang on hangban.mahang=hang.mahang
				where tenhang=@tenhang and day(ngayban)=@x)

	return @tong
end
drop function hamm
select dbo.hamm('h1','2')
----------------3





