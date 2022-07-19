use master
go
create database QLSinhVien
go
use QLSinhVien
go
create table Khoa(	
	maKhoa char(10) not null primary key,
	tenKhoa nvarchar(50) not null
)
go

create table lop(	
	maLop char(10) not null primary key,
	tenLop nvarchar(50) not null,
	siSo int not null,
	maKhoa char(10) not null,
	constraint fk_1 foreign key(maKhoa) references Khoa(maKhoa)
)
go
create table SinhVien(	
	maSV char(10) not null primary key,
	hoTen nvarchar(50) not null,
	ngaySinh date not null,
	gioiTinh nvarchar(50) not null,
	maLop char(10) not null,
	constraint fk_2 foreign key(maLop) references Lop(maLop)
)
go

insert into Khoa values
	('CNTT',N'Công Nghệ Thông Tin'),
	('KT',N'Kế Toán')
go 

insert into Lop values
	('CNTT1',N'Công Nghệ 1', 32, 'CNTT'),
	('KT07',N'Kế Toán 7', 32, 'KT')

go
insert into SinhVien values
	('m1',N'Phạm Lan', '03/04/2010',N'Nữ','CNTT1'),
	('m2',N'Phạm Phong', '07/04/2012',N'Nam','CNTT1'),
	('m3',N'Trần Ngọc', '05/04/2000',N'Nữ','CNTT1'),
	('m4',N'Nguyễn Ánh', '09/09/1997',N'Nữ','KT07'),
	('m5',N'Phan Nam', '05/09/2012',N'Nam','KT07')

/*-----------xóa dữ liệu cũ delete  from sinhvien*/
select * from Khoa
select * from lop
select * from sinhvien

---
go
create function thongke(@tenkhoa nvarchar(50))
returns @bang table(
	masv char(10),
	tensv nvarchar(50),
	tuoi int)
as
	begin
		insert into @bang
			select maSV, hoTen, YEAR(getdate())- year(ngaySinh)
			from sinhvien inner join lop on lop.maLop = SinhVien.maLop
						  inner join khoa on khoa.maKhoa = lop.maKhoa
			where tenKhoa = @tenkhoa
			
		return
	end

go
select * from thongke(N'Công Nghệ Thông Tin')

go
create proc cau3( @tutuoi int, @dentuoi int)
as	
	begin
		select maSV, hoTen, ngaySinh, tenLop, tenKhoa,YEAR(getdate())- year(ngaySinh)
		from sinhvien inner join lop on lop.maLop = SinhVien.maLop
					  inner join khoa on khoa.maKhoa = lop.maKhoa 
		where YEAR(getdate())- year(ngaySinh) between @tutuoi and @dentuoi
	end


go
exec cau3 0,123


go 
go
alter trigger kiemtrathemssv
on sinhvien
for insert
as
	begin
		declare @malop char(10)
		select @malop = maLop from inserted
		if(exists(select * from lop where maLop = @malop and siSo>=33))
			begin
				raiserror(N'Số lượng đã quá đông để thêm sinh viên vào lớp này',16,1)
				rollback transaction
			end
		else
			begin
				update lop
				set siSo = siSo+ 1
				where maLop = @malop
				print(N'Thành công nha!')
			end
	end

insert into SinhVien values
	('m8',N'Phạm Lan', '03/04/2010',N'Nữ','KT07')


select * from sinhvien
select * from lop