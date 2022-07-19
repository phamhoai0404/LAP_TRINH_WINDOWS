use master
go
create database QLKHO8
go
use QLKHO8
go
create table ton(
  mavt nchar(10) not null primary key,
  tenvt nvarchar(20) not null,
  soluongT int
)
create table nhap(
  sohdn nchar(10) not null ,
  mavt nchar(10) not null,
  soluongN int,
  dongiaN money,
  ngayN date,
  constraint PK1 primary key(sohdn,mavt), 
  constraint FK1 foreign key(mavt) references ton(mavt)
)
create table xuat(
  sohdx nchar(10) not null,
  mavt nchar(10) not null,
  soluongX int,
  dongiaX money,
  ngayX date,
 constraint PK2 primary key(sohdx,mavt), 
  constraint FK2 foreign key(mavt) references ton(mavt)
)


insert into ton values
('vt1',N' kẹo mút',200),
('vt2',N' kẹo kéo',300),
('vt3',N' kẹo dẻo',400)
go
insert into nhap values
('n1','vt1',500,4000,'2/2/2020'),
('n2','vt2',400,5000,'3/3/2020'),
('n3','vt3',300,8000,'4/4/2020')
go
insert into xuat values
('x1','vt1',400,6000,'8/2/2020'),
('x2','vt2',300,7000,'3/3/2020'),
('x3','vt3',200,10000,'5/4/2020')
 select*from ton
 select *from nhap
 select *from xuat

 create proc nxuat (@sohdx nchar(10), @mavt nchar(10), @slx int, @dongiax money, @ngayx date)
 as 
	begin
		if(not exists (select * from ton where mavt=@mavt and soluongT>=@slx))
			begin
				print(N'Không thỏa mãn yêu cầu đề bài!')
			end
		else
			begin
				insert into xuat values(@sohdx, @mavt, @slx, @dongiax, @ngayx)
				print(N'Xuất thành công !')
			end
	end

exec nxuat 'x5','vt55',40,6000,'8/2/2020'
exec nxuat 'x5','vt1',400,6000,'8/2/2020'
exec nxuat 'x5','vt1',40,6000,'8/2/2020'
select *from xuat

-----------câu 2
create function thongke( @mavt char(10), @ngayn date)
returns @bang table(
	ngayn date,
	mavt char(10),
	tenvt nvarchar(20),
	tongtiennhap money)
as 
	begin
		insert into @bang
			select ngayn, ton.mavt, tenvt, sum(soluongN*dongiaN)
			from nhap inner join ton on nhap.mavt=ton.mavt
			where ton.mavt=@mavt and ngayn=@ngayn
			group by ngayn, ton.mavt, tenvt
		return 
	end

select * from ton
select * from nhap

select * from thongke ('vt1', '2/2/2020')