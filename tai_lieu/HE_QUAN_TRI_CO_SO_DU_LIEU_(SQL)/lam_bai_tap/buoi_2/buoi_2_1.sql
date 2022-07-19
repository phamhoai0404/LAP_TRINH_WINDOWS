use master 
go
create database QLB_Hang
on primary(
	name='qlbanhang_dat', filename='D:\qlbanhang.mdf',
	size=5MB, maxsize=50MB, filegrowth=10%
)
log on(
	name='qlbanhang_log', filename='D:\qlbanhang.ldf',
	size=1MB, maxsize=5MB, filegrowth=10%
)
go 
use QLB_Hang
go
create table HangSX(
	MaHangSX Nvarchar(12) not null primary key,
	TenHang Nvarchar(25) not null,
	SoDT Nvarchar(12),
	DiaChi Nvarchar(30),
	Email Nvarchar(40),
)
create table SanPham(
	MaSP Nvarchar(12) not null primary key,
	MaHangSX Nvarchar(12),
	TenSP Nvarchar(25) not null,
	SoLuong int,
	MauSac Nvarchar(12),
	GiaBan float,
	DonViTinh Nvarchar(12),
	MoTa text,
	constraint FK_SanPham_HangSX foreign key(MaHangSX) 
		references HangSX(MaHangSX)
)
create table NhanVien(
	MaNV Nvarchar(12) not null primary key,
	TenNV Nvarchar(30),
	GioiTinh Nvarchar(25),
	SoDT Nvarchar(12),
	DiaChi Nvarchar(30),
	Email Nvarchar(40),
	TenPhong Nvarchar(20),
)
create table PNhap(
	SoHDN Nvarchar(12) not null primary key,
	MaNV Nvarchar(12),
	Dates Datetime,
	constraint FK_PNhap_NhanVien foreign key(MaNV) 
		references NhanVien(MaNV),
)
create table Nhap(
	SoHDN Nvarchar(12) not null,
	MaSP Nvarchar(12) not null,
	SoLuongN int,
	DonGiaN float,
	constraint PK_Nhap primary key(SoHDN,MaSP),
	constraint fk_Nhap_SoHDN foreign key(SoHDN) 
		references PNhap(SoHDN),
	constraint fk_Nhap_SanPham foreign key(MaSP) 
		references SanPham(MaSP)
)
create table PXuat(
	SoHDX Nvarchar(12) not null primary key,
	MaNV Nvarchar(12),
	NgayXuat datetime,
	constraint FK_PXuat_NhanVien foreign key(MaNV) 
		references NhanVien(MaNV)
)
create table Xuat(
	SoHDX Nvarchar(12) not null,
	MaSP Nvarchar(12) not null,
	SoLuongN int,
	constraint PK_Xuat primary key(SoHDX,MaSP),
	constraint fk_Xuat_SoHDX foreign key(SoHDX) 
		references PXuat(SoHDX),
	constraint fk_Xuat_SanPham foreign key(MaSP) 
		references SanPham(MaSP)
)
	