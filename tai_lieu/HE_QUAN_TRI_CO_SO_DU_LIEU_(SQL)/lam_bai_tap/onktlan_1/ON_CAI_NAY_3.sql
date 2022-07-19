create database QLHANG11

create table hang(
	mahang char(10) not null primary key,
	tenhang nvarchar(50) not null,
	dvtinh nvarchar(50) not null,
	sl int)
go
 create table hdban(
	mahd char(10) not null primary key,
	ngayban date,
	hotenkhach nvarchar(50))
go 
create table hangban(
	mahd char(10) not null,
	mahang char(10) not null,
	dongia money,
	soluong int,
	constraint PK primary key(mahd,mahang),
	constraint fk1_hangban_hang foreign key (mahang) references hang(mahang),
	constraint fk2_hangban_hdban foreign key (mahd) references hdban(mahd))

insert into hang values
	('h1', N'Kéo', N'Chiếc', 200),
	('h2', N'Dao', N'Lô', 350)

insert into hdban values
	('d1', '7/8/2020', N'Phạm Thị Khánh Linh'),
	('d2', '6/5/2020', N'Nguyễn Lan')
insert into hangban values
	('d1', 'h2', 25000, 12),
	('d2', 'h2', 35000, 10),
	('d2', 'h1', 75000, 7),
	('d1', 'h1', 80000, 30)


select * from hang
select * from hdban
select * from hangban


-------------cau2
create view cau2
as
	select hang.mahang, tenhang, sum(soluong*dongia) as N'Tổng tiền bán'
	from hangban inner join hang on hang.mahang=hangban.mahang
	group by hang.mahang, tenhang

select * from cau2


----cau3

create function cau3( @tenkhachhang nvarchar(50), @x date, @y date)
returns @bang table(
	mahang char(10),
	tenhang nvarchar(50),
	soluong int,
	dongia money)
as
	begin
		insert into @bang	
			select hang.mahang, tenhang, soluong,dongia
			from hang inner join hangban on hang.mahang=hangban.mahang
					  inner join hdban on hangban.mahd=hdban.mahd
			where hotenkhach=@tenkhachhang and ngayban between @x and @y
		return
	end

select * from hang
select * from hdban
select * from hangban
select * from cau3(N'Trần', '7/8/2020', '8/8/2020')
select * from cau3(N'Phạm Thị Khánh Linh', '7/7/2020', '8/8/2020')

------cau4
alter proc xoadonhang(@mahd char(10))
as
	begin 
		if( not exists( select * from hdban where mahd=@mahd))
			print(N' Không có mã hàng này !')
		else 
			begin
				delete from hangban where mahd=@mahd
				delete from hdban where mahd=@mahd
				print(N' sucessfull !!!!!!')
			end
	end

exec xoadonhang 'k1'


select * from hdban
exec xoadonhang 'd1'