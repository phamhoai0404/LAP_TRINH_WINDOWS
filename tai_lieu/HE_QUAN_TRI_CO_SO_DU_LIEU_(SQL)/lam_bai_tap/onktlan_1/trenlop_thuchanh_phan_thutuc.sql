
-------------------làm thoi không biết có dudsngs không
-------nhưng khả năng đúng khá cao


use master 
go 
create database	QLNV
select * from tblchucvu
select * from tblnhanvien

create proc sp_them_nhan_vien(@manv nvarchar(4), @macv nvarchar(2), @tennv nvarchar(50), @ngaysinh datetime, @luongcoban float, @ngaycong int, @phucap float)
as
	begin
		if(not exists ( select * from tblchucvu where macv=@macv))
			print ' khong ton tai ma chuc vu ' +@macv
		else 
			if(@ngaycong>30)
				print 'ngay cong nhap vao khong thoa man vi lon hon 30'
			else 
				insert into tblnhanvien values(@manv, @macv, @tennv, @ngaysinh, @luongcoban, 
				@ngaycong, @phucap)
	end

select * from tblchucvu
exec sp_them_nhan_vien N'1', N'bg', N'Trịnh Thị Hoa','12/2/2000' , 3, 12, 2.1
exec sp_them_nhan_vien N'1', N'VS', N'Trịnh Thị Hoa','12/2/2000' , 3, 33, 2.1
exec sp_them_nhan_vien N'1', N'VS', N'Trịnh Thị Hoa','12/2/2000' , 3, 30, 2.1

create proc sp_capnhat_nhan_vien(@manv nvarchar(4), @macv nvarchar(2), @tennv nvarchar(50), @ngaysinh datetime, @luongcoban float, @ngaycong int, @phucap float)
as
	begin
		if(not exists ( select * from tblchucvu where macv=@macv))
			print ' khong ton tai ma chuc vu ' +@macv
		else 
			if(not exists (select * from tblnhanvien where manv=@manv and macv=@macv))
				print ' trong chuc vu không có mã nhân viên này mà cap nhat do nha!'
			else
				if(@ngaycong>30)
					print 'ngay cong nhap vao khong thoa man vi lon hon 30'
				else 
					update tblnhanvien 
					set tennv=@tennv, ngaysinh=@ngaysinh, luongcoban=@luongcoban,ngaycong=@ngaycong, phucap=@phucap
					where manv=@manv
	end

select * from tblchucvu
select * from tblnhanvien
exec sp_capnhat_nhan_vien N'1', N'd', N'Trịnh Thị Hoa','12/2/2000' , 3, 30, 2.1
exec sp_capnhat_nhan_vien N'1111', N'KT', N'Trịnh Thị Hoa','12/2/2000' , 3, 30, 2.1
exec sp_capnhat_nhan_vien N'NV03', N'KT', N'Trịnh Thị Hoa','12/2/2000' , 3, 31, 2.1
exec sp_capnhat_nhan_vien N'NV03', N'KT', N'Trịnh Thị Hoa Ngọc','12/2/2000' , 3, 28, 2.1


create proc dbo.sp_luongln 
as
	begin
		select top 1 manv, tennv, ngaysinh, (Luongcoban*ngaycong+phucap) as Luong
		from tblnhanvien
		order by Luong desc
		return 
	end


create proc sp_luongln1 
as
	begin
		select top 1 manv, tennv, ngaysinh, (Luongcoban*ngaycong+phucap) as 'Luong'
		from tblnhanvien
		order by 'Luong'  desc
		return 
	end


create proc sp_luongln22
as
	begin
		select manv, tennv, ngaysinh, (Luongcoban*ngaycong+phucap) as 'Luong'
		from tblnhanvien
		order by 'Luong'  desc
		return 
	end

exec sp_luongln1
exec sp_luongln
exec sp_luongln22









------------------------------------------------cái này làm đúng rồi đó nha--------------------------
create function luongtb()
returns @bang table (
	manv nvarchar(4),
	macv nvarchar(2),
	tennv nvarchar(50),
	luong float,
	luongtb float)
as
	begin 
		insert into @bang 
			select manv,  macv, tennv, (luongcoban*ngaycong+phucap) as 'luong', (luongcoban*ngaycong+phucap)/ngaycong as 'TB luong /ngay'
			from tblnhanvien
			where ngaycong<25
		insert into @bang 
			select manv,  macv, tennv, (luongcoban*24+phucap +luongcoban*(ngaycong-24)*2) as 'luong',(luongcoban*24+phucap +luongcoban*(ngaycong-24)*2)/ngaycong as 'TB luong /ngay'
			from tblnhanvien
			where ngaycong>=25
		return 
	end 

select * from luongtb()
select * from luongt1b()

------------------------cái này làm khác chỉ để test lại xem cái kq của phần trên ra có đúng không thôi------------------
create function luongt1b()
returns @bang table (
	manv nvarchar(4),
	macv nvarchar(2),
	tennv nvarchar(50),
	luong float,
	luongtb float)
as
	begin 
		insert into @bang 
			select manv,  macv, tennv, (luongcoban*ngaycong+phucap) as 'luong', (luongcoban*ngaycong+phucap)/ngaycong as 'TB luong /ngay'
			from tblnhanvien
		return 
	end
------------------------------------------------------------------------------------------