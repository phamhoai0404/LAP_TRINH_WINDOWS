use master
go
create database QLSinhVien	
go
use QLSinhVien
go
create table khoa(
	makhoa char(10) not null primary key,
	tenkhoa nvarchar(50) not null)
go
create table lop(
	malop char(10) not null primary key,
	tenlop nvarchar(50) not null,
	siso int,
	makhoa char(10),
	constraint fk foreign key (makhoa) references khoa(makhoa))
go
create table sinhvien(
	masv char(10) not null primary key,
	hoten nvarchar(50),
	ngaysinh date,
	gioitinh nvarchar(50),
	malop char(10),
	constraint fk_2 foreign key(malop) references lop(malop))

insert into khoa values
	('k1',N'CNTT'),
	('k2',N'Cơ khí')
insert into lop values
	('l1',N'Cntt03', 70, 'k1'),
	('l2',N'CK_01', 70, 'k2')
insert into sinhvien values
	('m1',N'Phan Na','2/5/2020',N'Nữ','l1'),
	('m2',N'Đặng Tuấn','4/5/2020',N'Nam','l1'),
	('m3',N'Trần Hằng','9/2/2020',N'Nữ','l2'),
	('m4',N'Phạm Hà','2/23/2020',N'Nữ','l2'),
	('m5',N'Đinh Thúy','8/8/2020',N'Nữ','l1')

select * from khoa
select * from  lop
select * from sinhvien

---------------
alter function thongtin(@tenkhoa nvarchar(50))
returns @bang table(
	masv char(10),
	hoten nvarchar(50),
	tuoi int)
as	
	begin
		insert into @bang
			select masv, hoten, year(getdate())-year(ngaysinh)
			from khoa inner join lop on khoa.makhoa=lop.makhoa
					  inner join sinhvien on lop.malop=sinhvien.malop
			where tenkhoa=@tenkhoa
		return 
	end

select * from thongtin(N'CNTT')



-------------------






alter proc timkiem(@tutuoi int, @dentuoi int)
as	
	begin
		select masv, hoten, ngaysinh, tenlop, tenkhoa, year(getdate())-year(ngaysinh) as N'Tuổi'
		from khoa inner join lop on khoa.makhoa=lop.makhoa
				  inner join sinhvien on sinhvien.malop=lop.malop
		where year(getdate())-year(ngaysinh) between @tutuoi and @dentuoi
	end
exec timkiem -12,2



----------------------
alter trigger ktsinhvien
on sinhvien
for insert 
as
	begin
		declare @malop char(10)
		select @malop=malop from inserted
		if(exists(select * from lop where malop=@malop and siso>80))
			begin
				raiserror(N'Sinh viên trong lớp này đã lớn hơn 80 và không thêm vào được', 16,1)
				rollback transaction
			end
		else
			begin
				update lop
				set siso=siso+1
				where malop=@malop
				print(N'Cập nhật sinh viên thành công !')
			end
	end


insert into sinhvien values
	('m1111',N'Phan Na','2/5/2020',N'Nữ','l2')



-----------------------------------------------
alter function cau2_dekhac(@tenkhoa nvarchar(50))
returns @bang table(
	malop char(10),
	tenlop nvarchar(50),
	siso int)
as
	begin
		insert into @bang	
			select malop, tenlop, siso
			from khoa inner join lop on khoa.makhoa=lop.makhoa
			where tenkhoa=@tenkhoa
		return
	end

select * from cau2_dekhac(N'CNTT')

-----------------------

alter proc cau3_dekhac(@masv char(10), @hoten nvarchar(50), @ngaysinh date, @gioitinh nvarchar(50), @tenlop nvarchar(50))
as 
	begin
		if(not exists ( select * from lop where tenlop=@tenlop))
			begin
				print(N'Không tồn tại ở trong bảng lớp !')
			end
		else
			begin
				declare @malop char(10)
				select @malop=malop from lop where tenlop=@tenlop
				print(N'Thêm sinh viên thành công!')
				insert into sinhvien values (@masv, @hoten, @ngaysinh, @gioitinh, @malop)
			end
	end

exec cau3_dekhac 'm111',N'Phan Na','2/5/2020',N'Nữ', N'Cntt0311'
exec cau3_dekhac 'm192',N'Phan Na','2/5/2020',N'Nữ', N'Cntt03'

select * from khoa
select * from  lop
select * from sinhvien



----------------------
alter  trigger ktcaptnhat
on sinhvien
for update
as
	begin
		declare @malopmoi char(10)
		select @malopmoi=malop from inserted
		if(exists(select * from lop where malop=@malopmoi and siso>=80))
			begin 
				raiserror(N'Thêm sinh viên vào lớp này không thành công !',16,1)
				rollback transaction
			end
		else
			begin
				declare @malopcu char(10)
				select @malopcu=malop from deleted

				update lop
				set siso=siso+1
				where malop=@malopmoi

				update lop
				set siso=siso-1
				where malop=@malopcu

				print(N'Cập nhật thành công !')

			end
	end

update sinhvien
set malop='l1'
where masv='m1'

select * from khoa
select * from  lop
select * from sinhvien

update sinhvien
set malop='l1'
where masv='m11'










