use master
go 
create database QLbanhang
go
use QLbanhang
go
create table congty(
	macongty char(10) not null primary key,
	tencongty nvarchar(50) not null,
	diachi nvarchar(50) not null)
go 
create table sanpham(
	masanpham char(10) not null primary key,
	tensanpham nvarchar(50),
	soluongco int,
	giaban money)
go
create table cungung(
	macongty char(10) not null,
	masanpham char(10) not null,
	soluongcungung int,
	ngaycungung date,
	constraint pk primary key(macongty, masanpham),
	constraint fk_1 foreign key(macongty) references congty(macongty),
	constraint fk_2 foreign key(masanpham) references sanpham(masanpham))


insert into congty values
	('ct1',N'Bùi Văn Tuyền',N'Hui'),
	('ct2',N'Havina',N'Cuối'),
	('ct3',N'Thanh Bình',N'Hải Dương')
go
insert into sanpham values
	('sp1',N'Áo len', 200, 12000),
	('sp2',N'Áo khoác', 400, 15000),
	('sp3',N'Gang tay', 100, 20000)
go
insert into cungung values
	('ct1','sp1',10,'5/8/2020'),
	('ct1','sp2',20,'7/8/2020'),
	('ct1','sp3',40,'6/7/2020'),
	('ct2','sp1',50,'7/8/2020'),
	('ct3','sp3',30,'5/9/2020')

insert into cungung values
	('ct2','sp3',10,'7/8/2020')

select * from congty

select * from sanpham

select * from cungung



----------------------
create function cau2(@tencongty nvarchar(50), @ngaycungung date)
returns @bang table(
	tensanpham nvarchar(50),
	soluong int,
	giaban money)
as
	begin
		insert into @bang
			select tensanpham, soluongcungung, giaban
			from congty inner join cungung on congty.macongty=cungung.macongty
						inner join sanpham on cungung.masanpham=sanpham.masanpham
			where tencongty=@tencongty and ngaycungung=@ngaycungung
		return 
	end

select * from cau2(N'sfsf', '8/5/2020')
select * from cau2(N'Bùi Văn Tuyền', '5/8/2020')
select * from cau2(N'Havina', '7/8/2020')




-------------------------\


alter proc cau3( @mact char(10), @tenct nvarchar(50), @diachi nvarchar(50), @trave int output)
as	
	begin
		if(exists(select * from congty where tencongty=@tenct))
			begin
				set @trave=1
				
			end
		else
			begin
				set @trave=0
				insert into congty values (@mact, @tenct,@diachi)
			end
	end


declare @bien int 
exec cau3 'ct3', N'Havina', N'Cuoi', @bien output
select @bien



declare @bien int 
exec cau3 'ct33', N'Havi22na', N'Cuoi', @bien output
select @bien


declare @bien int 
exec cau3 'ct3', N'Havi22na', N'Cuoi', @bien output
select @bien


----------------------------------------------

create trigger ktcungung
on cungung
for update
as
	begin
		declare @slm int
		declare @slc int
		declare @masanpham char(10)
		select @slm=soluongcungung, @masanpham=masanpham from inserted
		select @slc=soluongcungung from deleted
		if( not exists(select * from sanpham where masanpham=@masanpham and ((@slm-@slc)<=soluongco)))
			begin
				raiserror(N'Không update được nha !', 16,1)
				rollback transaction
			end
		else
			begin
				update sanpham
				set soluongco=soluongco+@slc-@slm
				where masanpham=@masanpham
				print(N'Cập nhật thành công!')
			end
	end


update cungung
set soluongcungung=3000
where masanpham='sp1' and macongty='ct1'

select * from congty

select * from sanpham

select * from cungung



update cungung
set soluongcungung=180
where masanpham='sp1' and macongty='ct1'


-----------------------------------------Đề khác---------
select * from congty

select * from sanpham

select * from cungung

create function tongtien(@tencongty nvarchar(50), @nam int)
returns money
as
	begin
		declare @tong money
		set @tong=(select sum(soluongcungung*giaban)
				   from congty inner join cungung on congty.macongty=cungung.macongty
							   inner join sanpham on sanpham.masanpham=cungung.masanpham
				   where tencongty=@tencongty and year(ngaycungung)=@nam)
		return @tong
	end


select dbo.tongtien(N'Bùi Văn Tuyền',2020) as' Tổng tiền trong năm'



-------------------------------------
create proc cau3_dekhac(@tenct nvarchar(50), @tensp nvarchar(50), @slcu int, @ngaycu date)
as
	begin
		declare @mact char(10)
		declare @masp char(10)
		set @masp=(select masanpham from sanpham where tensanpham=@tensp)
		set @mact=(select macongty from congty where tencongty=@tenct)
		insert into cungung values(@mact,@masp, @slcu, @ngaycu)
	end


exec cau3_dekhac N'Thanh Bình', N'Áo khoác', 20000, '8/8/2020'



-------------------------------------
alter  trigger them
on cungung
for insert
as
	begin
		declare @masp char(10)
		declare @slcungung int
		select @masp=masanpham, @slcungung=soluongcungung from inserted
		if(not exists(select * from sanpham where masanpham=@masp and @slcungung<=soluongco))
			begin
				raiserror(N'Không được vì số lượng cung ứng lớn hơn số lượng có!',16,1)
				rollback transaction
			end
		else
			begin
				update sanpham
				set soluongco=soluongco-@slcungung
				where masanpham=@masp
			end
	end


insert into cungung values
	('ct3','sp1',101,'5/8/2020')


insert into cungung values
	('ct3','sp1',10,'5/8/2020')

select * from sanpham

select * from cungung