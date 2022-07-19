use master
go
create database QLKHO__11
go
use QLKHO__11
go
create table ton(	
	mavt char(10) not null primary key,
	tenvt nvarchar(50) not null,
	soluongt int)
go
create table nhap(
	sohdn char(10) not null,
	mavt char(10) not null,	
	soluongn int,
	dongian money,
	ngayn date,
	constraint pk primary key(sohdn, mavt),
	constraint fk_1 foreign key(mavt) references ton(mavt))
go
create table xuat(
	sohdx char(10) not null,
	mavt char(10) not null,
	soluongx int,
	dongiax money,
	ngayx date,
	constraint pk_2 primary key(sohdx, mavt),
	constraint fk_2 foreign key(mavt) references ton(mavt))


insert into ton values
	('vt1', N'Thước đo', 100),
	('vt2', N'Dao to', 120),
	('vt3', N'Ghế ngồi', 90),
	('vt4', N'Quần áo', 70)

insert into nhap values
	('n1','vt1',200,15000,'7/8/2020'),
	('n3','vt2',180,17000,'7/9/2020'),
	('n1','vt2',400,14000,'5/6/2020')

insert into xuat values
	('x2','vt1',80,21000,'9/8/2020'),
	('x1','vt3',10,45000,'9/9/2020'),
	('x1','vt2',50,23000,'6/7/2020')

insert into xuat values
	('x111','vt1',8,21000,'9/8/2020')
insert into nhap values
	('n11','vt1',200,15000,'7/8/2020')

select * from ton
select * from nhap
select * from xuat

go
create function thongke(@ngayx date, @mavt char(10))
returns @bang table(
	mavt char(10),
	tenvt nvarchar(50),
	tienban money)
as
	begin
		insert into @bang
			select ton.mavt, tenvt, sum(soluongx*dongiax)
			from xuat inner join ton on xuat.mavt=ton.mavt
			where ton.mavt=@mavt and ngayx=@ngayx
			group by ton.mavt, tenvt
		return
	end

go
select * from thongke('9/8/2020','vt1')



-------------------------------------------------------------------------------------------------------
go
create function thongke_tiennhap (@ngayn date, @mavt char(10))
returns money
as 
	begin
		declare @tongn money
		set @tongn=(select sum(soluongn*dongian)
					from nhap
					where ngayn=@ngayn and mavt=@mavt
					group by mavt, ngayn)--đây cái dòng này không cần vẫn đúng 
					                     --vì phần select chỉ có mỗi sum mà thôi nhưng đi thi cứ viết ra 				 
		return @tongn
		
	end
go
select dbo.thongke_tiennhap('7/8/2020','vt1') as'Tổng tiền nhập'




------------------------------------------------------------------------------
go
create trigger kiemtra
on nhap	
for insert
as
	begin
		declare @mavt char(10)
		declare @soluongn int 
		select @mavt=mavt, @soluongn = soluongn  from inserted
		if(not exists(select * from ton where mavt=@mavt))
			begin
				raiserror(N'Mã VT chưa có mặt trong bảng Ton!',16,1)
				rollback transaction
			end
		else
			begin
				update ton
				set soluongt=soluongt+@soluongn
				where mavt=@mavt
				print(N'Thành công !!!')
			end
	end

-------------------------------------------------------------------------------------------
go
create trigger kiemtraxuat
on xuat
for insert
as
	begin
		declare @soluongx int
		declare @mavt char(10)
		select @soluongx=soluongx, @mavt=mavt from inserted
		if(not exists(select * from ton where mavt=@mavt and soluongt>=@soluongx))
			begin
				raiserror(N'Hãy kiểm tra lại mã VT hoặc số lượng xuất!',16,1)
				rollback transaction
			end
		else
			begin
				update ton
				set soluongt=soluongt-@soluongx
				where mavt=@mavt
				print(N'Thành công nha!')
			end
	end


------------------------------------------------------------------cách khác
-------------------------------------------------------------------