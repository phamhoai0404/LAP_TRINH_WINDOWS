use master
go
create database QUANLYDIEM_NHOM_8
go
use QUANLYDIEM_NHOM_8
go


Create table [DangNhap] (
	[maDangNhap] Integer NOT NULL,
	[hotenDangNhap] Nvarchar(50) NOT NULL,
	[matKhauDangNhap] Varchar(20) NOT NULL,
Constraint [pk_DangNhap] Primary Key  ([maDangNhap])
) 
go

Create table [KhoaDaoTao] (
	[maKhoa] Varchar(20) NOT NULL,
	[tenKhoa] Nvarchar(50) NOT NULL,
	[dienThoaiLienHe] Varchar(20) NOT NULL,
Constraint [pk_KhoaDaoTao] Primary Key  ([maKhoa])
) 
go

Create table [Lop] (
	[maLop] Varchar(20) NOT NULL,
	[tenLop] Nvarchar(50) NOT NULL,
	[heDaoTao] Nvarchar(50) NOT NULL,
	[khoaHoc] Varchar(10) NOT NULL,
	[siSo] Integer NOT NULL,
	[maKhoa] Varchar(20) NOT NULL,
Constraint [pk_Lop] Primary Key  ([maLop])
) 
go

Create table [SinhVien] (
	[maSV] Varchar(20) NOT NULL,
	[hoTenSV] Nvarchar(50) NOT NULL,
	[ngaySinh] Date NOT NULL,
	[gioiTinh] Nvarchar(10) NOT NULL,
	[email] Varchar(30) NOT NULL,
	[queQuan] Nvarchar(200) NOT NULL,
	[maLop] Varchar(20) NOT NULL,
Constraint [pk_SinhVien] Primary Key  ([maSV])
) 
go

Create table [HocKy] (
	[maHocKy] Varchar(10) NOT NULL,
	[tenHocKy] Nvarchar(30) NOT NULL,
Constraint [pk_HocKy] Primary Key  ([maHocKy])
) 
go

Create table [MonHoc] (
	[maMonHoc] Varchar(20) NOT NULL,
	[tenMonHoc] Nvarchar(50) NOT NULL,
	[soTinChi] Integer NOT NULL,
	[maHocKy] Varchar(10) NOT NULL,
Constraint [pk_MonHoc] Primary Key  ([maMonHoc])
) 
go

Create table [GiangVien] (
	[maGV] Varchar(20) NOT NULL,
	[hoTenGV] Nvarchar(50) NOT NULL,
	[ngaySinh] Date NOT NULL,
	[gioiTinh] Nvarchar(10) NOT NULL,
	[email] Varchar(30) NOT NULL,
	[queQuan] Nvarchar(200) NOT NULL,
	[namBatDauCongTac] Date NOT NULL,
Constraint [pk_GiangVien] Primary Key  ([maGV])
) 
go

Create table [GiangVien_MonHoc] (
	[maGV] Varchar(20) NOT NULL,
	[maMonHoc] Varchar(20) NOT NULL,
	[phongHocTheoMon] Nvarchar(30) NOT NULL,
	[thoiGianBatDauMonHoc] Nvarchar(20) NOT NULL,
Constraint [pk_GiangVien_MonHoc] Primary Key  ([maGV],[maMonHoc])
) 
go

Create table [DiemThi] (
	[maMonHoc] Varchar(20) NOT NULL,
	[maSV] Varchar(20) NOT NULL,
	[diem] Float NOT NULL,
Constraint [pk_DiemThi] Primary Key  ([maMonHoc],[maSV])
) 
go


Alter table [Lop] add Constraint [chua] foreign key([maKhoa]) references [KhoaDaoTao] ([maKhoa]) 
go
Alter table [SinhVien] add Constraint [co] foreign key([maLop]) references [Lop] ([maLop]) 
go
Alter table [DiemThi] add  foreign key([maSV]) references [SinhVien] ([maSV]) 
go
Alter table [MonHoc] add Constraint [tontai] foreign key([maHocKy]) references [HocKy] ([maHocKy]) 
go
Alter table [GiangVien_MonHoc] add  foreign key([maMonHoc]) references [MonHoc] ([maMonHoc]) 
go
Alter table [DiemThi] add  foreign key([maMonHoc]) references [MonHoc] ([maMonHoc]) 
go
Alter table [GiangVien_MonHoc] add  foreign key([maGV]) references [GiangVien] ([maGV]) 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


---Thêm dữ liệu vào các bảng
--Bảng DangNhap
go
insert into DangNhap  values
	(1, 'admin','admin'),
	(2, '4','4')

-------------bảng KhoaDaoTao
go 
insert into KhoaDaoTao values
	('CNTT',N'Công Nghệ Thông Tin', '0373317715'),
	('KTKT',N'Kế Toán - Kiểm Toán', '0389569596'),
	('CK',N'Cơ Khí', '0378488455'),
	('DDT',N'Điện - Điện Tử', '0396599854'),
	('TC',N'Tài Chính', '0346599853'),
	('QTKD',N'Quản Trị Kinh Doanh', '0396533354'),
	('NN',N'Ngôn Ngữ', '0396599854'),
	('DL',N'Du Lịch', '0396666543'),
	('NG',N'Ngoại Giao', '0396599854')



---------------------bảng Lop
go
insert into Lop values
	('CNTT01', N'Công nghệ thông tin 1', N'Đại Học', 'K13',70, 'CNTT'),
	('CNTT02', N'Công nghệ thông tin 2', N'Đại Học', 'K12',69, 'CNTT'),
	('CNTT03', N'Công nghệ thông tin 3', N'Đại Học', 'K13',67, 'CNTT'),
	('KT01', N'Kế toán 1', N'Đại Học', 'K13',75, 'KTKT'),
	('KT02', N'Kế toán 2', N'Đại Học', 'K13',70, 'KTKT'),
	('KT03', N'Kế toán 3', N'Đại Học', 'K13',71, 'KTKT'),
	('CK01', N'Cơ khí 1', N'Đại Học', 'K12',70, 'CK'),
	('CK02', N'Cơ khí 2', N'Đại Học', 'K13',70, 'CK'),
	('CK03', N'Cơ khí 3', N'Đại Học', 'K13',70, 'CK'),
	('CK04', N'Cơ khí 4', N'Đại Học', 'K13',70, 'CK'),
	('DDT1', N'Điện tử 1', N'Đại Học', 'K13',70, 'DDT'),
	('DDT2', N'Điện tử 2', N'Đại Học', 'K13',71, 'DDT'),
	('TC1', N'Tài chính 1', N'Đại Học', 'K13',71, 'TC'),
	('QTKD1', N'Quản trị kinh doanh 1', N'Đại Học', 'K13',71, 'QTKD'),
	('NN1', N'Tiếng Trung', N'Đại Học', 'K13',71, 'NN'),
	('DL1', N'Du lịch 1', N'Đại Học', 'K13',71, 'DL'),
	('NG1',N'Ngoại giao 1',  N'Đại Học', 'K13',71, 'NG')
	



-----------------bảng sinh viên
go
insert into SinhVien values
	('2018603058', N'Phạm Quang Long', '9/8/2000',N'Nam','long778@gmail.com', N'Nam Định', 'CNTT01'),
	('2018602358', N'Tăng Thanh Hà', '3/4/2000',N'Nữ','ha85@gmail.com', N'Hải Dương', 'CNTT01'),
	('2018547257', N'Hà Thị Huệ', '1/2/2000',N'Nữ','hue784@gmail.com', N'Nam Định', 'CNTT01'),
	('2018275555', N'Phạm Thị Hoài', '1/9/2000',N'Nữ','hoai1458@gmail.com', N'Phú Thọ', 'CNTT02'),
	('2018275556', N'Phạm Xuân Trung', '2/8/2000',N'Nam','XuanTrung545@gmail.com', N'Đắc Lắc', 'CNTT02'),
	('2018275578', N'Ngô Văn Hải', '6/8/2000',N'Nam','Hai545@gmail.com', N'Điện Biên', 'CNTT03'),
	('2018275579', N'Phạm Sĩ Đoàn', '2/8/2000',N'Nam','Daon945@gmail.com', N'Lào Cai', 'CNTT03'),
	('2018275580', N'Phạm Xuân Nam', '2/3/2000',N'Nam','Nam545@gmail.com', N'Ninh Thuận', 'CNTT03'),
	('2018613058', N'Trần Thị Hằng', '12/5/1999',N'Nữ','hang78454@gmail.com', N'Nghệ An', 'KT01'),
	('2018261558', N'Nguyễn Hà Hương Dịu', '9/4/2000',N'Nữ','diu88@gmail.com', N'Hà Nội', 'KT01'),
	('2018587458', N'Trần Bình Minh', '4/2/1999',N'Nam','minh878@gmail.com', N'Hà Nội', 'KT02'),
	('2018287459', N'Trần Quang Đại', '2/7/2000',N'Nam','dai254@gmail.com', N'Hà Nam', 'KT02'),
	('2018287460', N'Ngô Văn An', '9/9/2000',N'Nam','an254@gmail.com', N'Hà Nội', 'KT03'),
	('2018287461', N'Phạm Văn Toàn', '4/3/2000',N'Nam','minh878@gmail.com', N'Hà Nội', 'KT03'),
	('2018287462', N'Phạm Thanh Hà', '4/9/2000',N'Nữ','ha145@gmail.com', N'Hải Dương', 'CK01'),
	('2018287463', N'Lê Thị Yến', '2/3/2000',N'Nữ','yen154@gmail.com', N'Hưng Yên', 'CK01'),
	('2018287464', N'Lê Thị Lan', '2/3/2000',N'Nữ','lan475@gmail.com', N'Yên Bái', 'CK02'),
	('2018287465', N'Phạm Văn Phong', '7/7/2000',N'Nam','phong12@gmail.com', N'Lào Cai', 'CK02'),
	('2018287466', N'Thào Mỷ', '6/7/2000',N'Nữ','phong12@gmail.com', N'Lào Cai', 'CK03'),
	('2018287467', N'Ngô Thị Thủy', '7/9/2000',N'Nữ','thuy78@gmail.com', N'Bắc Giang', 'CK03'),
	('2018287468', N'Vũ Văn Doan', '3/9/2000',N'Nam','Doan45@gmail.com', N'Nam Định', 'CK04'),
	('2018287469', N'Đỗ Vinh Hà', '8/9/2000',N'Nam','Ha4785@gmail.com', N'Bắc Giang', 'CK04'),
	('2018287470', N'Đinh Hoàng Nam', '7/3/2000',N'Nam','Nam475@gmail.com', N'Hải Phòng', 'DDT1'),
	('2018287471', N'Đỗ Thị Hà', '8/9/2000',N'Nữ','Ha4785@gmail.com', N'Hải Dương', 'DDT1'),
	('2018287472', N'Bùi Văn Sơn', '8/1/2000',N'Nam','Son455@gmail.com', N'Hải Dương', 'DDT2'),
	('2018287473', N'Ngô Hải Yến', '4/5/2000',N'Nữ','yen452@gmail.com', N'Quảng Nam', 'DDT2'),
	('2018287474', N'Nguyễn Văn Ki', '9/5/2000',N'Nam','Ki452@gmail.com', N'Nam Định', 'TC1'),
	('2018287475', N'Ngô Quốc Vũ', '4/5/2000',N'Nữ','Vu1452@gmail.com', N'Hà Nội', 'TC1'),
	('2018287476', N'Hồ Văn Hải', '7/8/2000',N'Nam','Hai255@gmail.com', N'Hà Nam', 'QTKD1'),
	('2018287477', N'Hà Thị Huệ', '4/9/2000',N'Nữ','Hue542@gmail.com', N'Hà Nội', 'QTKD1'),
	('2018287478', N'Phùng Thị Sim', '9/9/2000',N'Nữ','Sim452@gmail.com', N'Hải Phòng', 'NN1'),
	('2018287479', N'Dương Quốc Tú', '3/3/2000',N'Nam','Tu1254@gmail.com', N'Tuyên Quang', 'NN1'),
	('2018287480', N'Hà Văn Thái', '3/3/2000',N'Nam','Thai245@gmail.com', N'Thái Nguyên', 'DL1'),
	('2018287481', N'Vũ Tiến Lộc', '8/3/2000',N'Nam','Loc485@gmail.com', N'Phú Thọ', 'DL1'),
	('2018287482', N'Phạm Quang Trung', '8/6/2000',N'Nam','Trung55@gmail.com', N'Vĩnh Phúc', 'NG1'),
	('2018287483', N'Phạm Vũ Phong', '1/8/2000',N'Nam','Phong748@gmail.com', N'Hải Dương', 'NG1'),
	('2018287484', N'Phạm Trấn', '2/8/2000',N'Nam','Tran@gmail.com', N'Hải Dương', 'NG1')
	

---------------------hoc ky
go
insert into HocKy values
	('m1', N'Học kỳ 1'),
	('m2', N'Học kỳ 2'),
	('m3', N'Học kỳ 3'),
	('m4', N'Học kỳ 4'),
	('m5', N'Học kỳ 5'),
	('m6', N'Học kỳ 6'),
	('m7', N'Học kỳ 7'),
	('m8', N'Học kỳ 8')

-------------môn học 
go
insert into MonHoc values
	('SQL',N'Hệ quản trị cơ sở dữ liệu', 3, 'm6'),
	('JAVA',N'Lập trình Java', 4, 'm6'),
	('QLDA',N'Quản lý dự án CNTT', 3, 'm5'),
	('XSTK',N'Xác suất thống kê', 4, 'm5'),
	('LTCB',N'Lập trình căn bản', 3, 'm1'),
	('PLDC',N'Pháp luật đại cương', 3, 'm5'),
	('WIN',N'Lập trình Windows', 3, 'm5'),
	('TA',N'Tiếng Anh', 6, 'm5'),
	('PTTKHT',N'Phân tích hệ thống', 3, 'm5'),
	('CSDL',N'Cơ sở dữ liệu', 3, 'm3'),
	('KTS',N'Kĩ thuật số', 3, 'm3'),
	('XML',N'Công nghệ XML', 3, 'm3'),
	('DHUD',N'Đồ họa ứng dụng', 3, 'm3'),
	('MAC',N'Chủ nghĩa Mac-Lenin', 3, 'm3'),
	('TRR',N'Toán rời rạc', 3, 'm3'),
	('TCC',N'Toán cao cấp 2A', 3, 'm3'),
	('TTHCM',N'Tư tưởng Hồ Chí Minh', 3, 'm3'),
	('VL',N'Vật lý', 3, 'm3'),
	('KTMT',N'Kiến trúc máy tính', 3, 'm3'),
	('PPT',N'Phương pháp tính', 3, 'm3'),
	('DHMT',N'Đồ họa máy tính', 3, 'm3')



---------------điểm
go
insert into DiemThi values
	('JAVA', '2018603058',10),
	('JAVA', '2018602358',8.2),
	('JAVA', '2018547257',6),
	('SQL', '2018603058',10),
	('SQL', '2018602358',5),
	('SQL', '2018547257',8.9),
	('SQL', '2018275555',7.5),
	('PLDC', '2018603058',8.5),
	('PLDC', '2018602358',7.8),
	('PLDC', '2018547257',9),
	('QLDA', '2018603058',10),
	('QLDA', '2018602358',5.2),
	('XSTK', '2018275555',4),
	('XSTK', '2018275556',7),
	('XSTK', '2018275578',1),
	('XSTK', '2018275579',5.5),
	('LTCB', '2018275556',8),
	('LTCB', '2018275578',10),
	('LTCB', '2018275579',6),
	('LTCB', '2018275580',9.2),
	('WIN', '2018275580',6.3),
	('WIN', '2018613058',10),
	('WIN', '2018261558',8),
	('WIN', '2018587458',7.4),
	('TA', '2018613058',9.4),
	('TA', '2018261558',10),
	('TA', '2018587458',1),
	('TA', '2018287459',5),
	('PTTKHT', '2018287459',8.4),
	('PTTKHT', '2018287460',7),
	('PTTKHT', '2018287461',6.5),
	('PTTKHT', '2018287462',6.5),
	('CSDL', '2018287460',5.5),
	('CSDL', '2018287461',4),
	('CSDL', '2018287462',3),
	('CSDL', '2018287463',9),
	('CSDL', '2018287464',8),
	('CSDL', '2018287465',5),
	('JAVA', '2018287463',10),
	('JAVA', '2018287464',8),
	('JAVA', '2018287465',9.1),
	('JAVA', '2018287466',4.5),
	('SQL', '2018287466',9),
	('SQL', '2018287467',7),
	('SQL', '2018287468',6),
	('SQL', '2018287469',10),
	('SQL', '2018287470',10),
	('PLDC', '2018287467',8.5),
	('PLDC', '2018287468',6.3),
	('PLDC', '2018287469',7.1),
	('PLDC', '2018287470',6.8),
	('QLDA', '2018287471',8.4),
	('QLDA', '2018287472',9.2),
	('QLDA', '2018287473',10),
	('QLDA', '2018287474',3.5),
	('XSTK', '2018287471',3.2),
	('XSTK', '2018287472',10),
	('XSTK', '2018287473',8.4),
	('XSTK', '2018287474',7.9),
	('LTCB', '2018287475',10),
	('LTCB', '2018287476',6.5),
	('LTCB', '2018287477',5),
	('LTCB', '2018287478',1),
	('WIN', '2018287475',0),
	('WIN', '2018287476',5.6),
	('WIN', '2018287477',4),
	('WIN', '2018287478',3),

	('TA', '2018287479',5),
	('TA', '2018287480',8),
	('TA', '2018287481',10),
	('TA', '2018287482',8.4),
	('TA', '2018287483',7.5),
	('TA', '2018287484',8),
	('PTTKHT', '2018287479',6),
	('PTTKHT', '2018287480',10),
	('PTTKHT', '2018287481',9),
	('PTTKHT', '2018287482',8),
	('PTTKHT', '2018287483',9.5),
	('PTTKHT', '2018287484',10)

go
select * from DiemThi
----------------giảng viên
go
insert into GiangVien values
	('GV_1111', N'Đinh Thúy Hà', '9/8/1978',N'Nữ','ha8795@gmail.com', N'Nam Định', '8/7/2010'),
	('GV_1112', N'Nghiêm Thị Việt Anh', '3/4/1982',N'Nữ','vietanh2515@gmail.com', N'Hải Dương', '8/2/2003'),
	('GV_1113', N'Nguyễn Thị Phượng', '1/2/1975',N'Nữ','phuong7857@gmail.com', N'Nam Định', '6/7/2006'),
	('GV_1114', N'Nguyễn Hà Thành', '12/5/1993',N'Nam','thanh785@gmail.com', N'Nghệ An', '6/7/2010'),
	('GV_1115', N'Phạm Thị Hương', '1/9/1986',N'Nữ','huong87985@gmail.com', N'Phú Thọ', '8/1/2011'),
	('GV_1116', N'Đinh Văn Tín', '9/4/1986',N'Nam','tintinh@gmail.com', N'Hà Nội', '7/7/2010'),
	('GV_1117', N'Mai Thị Thúy', '4/2/1990',N'Nữ','thuy78589@gmail.com', N'Hà Nội', '2/9/2015'),
	('GV_1118', N'Tăng Văn Quân', '5/2/1990',N'Nam','quan587@gmail.com', N'Hải Dương', '7/9/2015'),
	('GV_1119', N'Nguyễn Tùng Lâm', '4/2/1987',N'Nam','lam45@gmail.com', N'Hà Nam', '2/9/2013'),
	('GV_1120', N'Trần Văn Huân', '8/2/1990',N'Nam','huan45@gmail.com', N'Hà Nội', '9/9/2013'),
	('GV_1121', N'Thái Văn Sang', '4/2/1988',N'Nam','Sang151@gmail.com', N'Hải Phòng', '2/9/2015'),
	('GV_1122', N'Phạm Thị Hà', '4/6/1990',N'Nữ','ha578@gmail.com', N'Tuyên Quang', '8/9/2014'),
	('GV_1123', N'Phạm Thị Thư', '5/2/1988',N'Nữ','thu458@gmail.com', N'Hà Nội', '2/9/2015'),
	('GV_1124', N'Hoàng Duy Nam', '9/6/1990',N'Nam','nam7855@gmail.com', N'Hà Nội', '2/9/2011'),
	('GV_1125', N'Tống Văn Hoàng', '4/2/1990',N'Nam','hoang558@gmail.com', N'Thái Nguyên', '2/9/2012'),
	('GV_1126', N'Vũ Tiến Lộc', '4/9/1990',N'Nam','loc458@gmail.com', N'Hà Nội', '6/9/2012'),
	('GV_1127', N'Phạm Thị Lan', '1/9/1990',N'Nữ','lan4878@gmail.com', N'Vĩnh Phúc', '7/9/2015'),
	('GV_1128', N'Trần Quốc Bảo', '4/2/1990',N'Nam','bao785@gmail.com', N'Vĩnh Phúc', '2/9/2015'),
	('GV_1129', N'Hoàng Văn Thắng', '5/2/1990',N'Nam','thang458@gmail.com', N'Nam Định', '6/9/2010'),
	('GV_1130', N'Lê Thành Công', '8/2/1988',N'Nam','cong785@gmail.com', N'Hà Nội', '2/9/2010'),
	('GV_1131', N'Đoàn Duy Nam', '4/9/1990',N'Nam','nam123@gmail.com', N'Nam Định', '3/9/2012'),
	('GV_1132', N'Lê Anh Tuấn', '8/8/1990',N'Nam','tuan1444@gmail.com', N'Lào Cai', '4/9/2015'),
	('GV_1133', N'Nguyễn Đức Điệp', '6/9/1989',N'Nam','diep411@gmail.com', N'Bắc Ninh', '2/3/2015'),
	('GV_1134', N'Nguyễn Thị Thúy', '4/2/1990',N'Nữ','thuy777@gmail.com', N'Lào Cai', '8/9/2012'),
	('GV_1135', N'Phạm Mỹ Linh', '4/2/1976',N'Nữ','linh555@gmail.com', N'Bắc Giang', '2/7/2015'),
	('GV_1136', N'Nguyễn Anh Linh', '4/2/1991',N'Nam','linh444@gmail.com', N'Bắc Ninh', '3/9/2015'),
	('GV_1137', N'Ngô Hải Nam', '4/2/1990',N'Nam','nam666@gmail.com', N'Hà Nội', '2/9/2015')


-------------------giảng viên - môn học 
go
insert into GiangVien_MonHoc values
	('GV_1111','SQL','A1-402',N'Tiết 4'),
	('GV_1111','JAVA','A1-406',N'Tiết 6'),
	('GV_1111','QLDA','A1-202',N'Tiết 4'),
	('GV_1112','SQL','A1-209',N'Tiết 1'),
	('GV_1112','JAVA','A1-402',N'Tiết 7'),
	('GV_1112','QLDA','A1-201',N'Tiết 4'),
	('GV_1113','SQL','A1-402',N'Tiết 10'),
	('GV_1113','QLDA','A1-302',N'Tiết 4'),
	('GV_1113','JAVA','A1-609',N'Tiết 1'),
	('GV_1114','XSTK','A10-109',N'Tiết 1'),
	('GV_1115','XSTK','A10-209',N'Tiết 1'),
	('GV_1116','XSTK','A10-309',N'Tiết 1'),
	('GV_1114','LTCB','A10-301',N'Tiết 1'),
	('GV_1115','LTCB','A10-302',N'Tiết 1'),
	('GV_1116','LTCB','A10-303',N'Tiết 1'),

	('GV_1117','WIN','A8-609',N'Tiết 1'),
	('GV_1118','WIN','A8-709',N'Tiết 1'),
	('GV_1119','WIN','A8-210',N'Tiết 1'),
	('GV_1117','TA','A8-309',N'Tiết 1'),
	('GV_1118','TA','A8-409',N'Tiết 1'),
	('GV_1119','TA','A8-409',N'Tiết 1'),
	('GV_1120','PTTKHT','A8-609',N'Tiết 1'),
	('GV_1121','PTTKHT','A8-509',N'Tiết 1'),
	('GV_1122','PTTKHT','A8-509',N'Tiết 1'),
	('GV_1123','PTTKHT','A8-610',N'Tiết 1'),
	('GV_1120','JAVA','A8-101',N'Tiết 6'),
	('GV_1121','JAVA','A8-102',N'Tiết 6'),
	('GV_1122','JAVA','A8-103',N'Tiết 6'),
	('GV_1123','JAVA','A8-104',N'Tiết 6'),
	('GV_1124','SQL','A8-105',N'Tiết 1'),
	('GV_1125','SQL','A8-901',N'Tiết 1'),
	('GV_1126','SQL','A8-902',N'Tiết 1'),
	('GV_1127','SQL','A8-903',N'Tiết 1'),
	('GV_1128','SQL','A8-904',N'Tiết 1'),
	('GV_1129','SQL','A8-905',N'Tiết 1'),
	('GV_1124','QLDA','A8-906',N'Tiết 4'),
	('GV_1125','QLDA','A8-907',N'Tiết 4'),
	('GV_1126','QLDA','A8-908',N'Tiết 4'),
	('GV_1127','QLDA','A8-909',N'Tiết 4'),
	('GV_1128','QLDA','A8-202',N'Tiết 4'),
	('GV_1129','QLDA','A8-203',N'Tiết 4'),
	('GV_1130','XSTK','A8-204',N'Tiết 1'),
	('GV_1131','XSTK','A8-205',N'Tiết 1'),
	('GV_1132','XSTK','A9-201',N'Tiết 1'),
	('GV_1133','XSTK','A9-202',N'Tiết 1'),
	('GV_1134','XSTK','A9-203',N'Tiết 1'),
	('GV_1135','XSTK','A9-204',N'Tiết 1'),
	('GV_1136','XSTK','A9-205',N'Tiết 1'),
	('GV_1130','LTCB','A9-206',N'Tiết 1'),
	('GV_1131','LTCB','A9-207',N'Tiết 1'),
	('GV_1132','LTCB','A9-208',N'Tiết 1'),
	('GV_1133','LTCB','A9-209',N'Tiết 1'),
	('GV_1134','LTCB','A9-301',N'Tiết 1'),
	('GV_1135','LTCB','A9-302',N'Tiết 1'),
	('GV_1136','LTCB','A9-303',N'Tiết 1'),
	('GV_1137','WIN','A9-304',N'Tiết 1'),
	('GV_1136','WIN','A9-305',N'Tiết 1'),
	('GV_1135','WIN','A9-306',N'Tiết 1'),
	('GV_1134','WIN','A9-307',N'Tiết 1'),
	('GV_1133','WIN','A9-308',N'Tiết 1'),
	('GV_1132','WIN','A9-309',N'Tiết 1'),

	('GV_1137','TA','A9-401',N'Tiết 1'),
	('GV_1136','TA','A9-402',N'Tiết 1'),
	('GV_1135','TA','A9-403',N'Tiết 1'),
	('GV_1133','TA','A9-404',N'Tiết 1'),
	('GV_1132','TA','A9-405',N'Tiết 1')


----------------------

go
select * from sinhvien
select * from Lop
select * from HocKy
select * from KhoaDaoTao
select * from MonHoc 
select * from DangNhap
select * from GiangVien_MonHoc

select * from DiemThi




---------------------------------------------tạo view
go
create view danhsachSV
as
	select SinhVien.maSV,hoTenSV,gioiTinh,ngaySinh,queQuan,Lop.maLop,maKhoa,khoaHoc,round(sum(diem*soTinChi)/sum(soTinChi),1)as N'Điểm trung bình'
	from DiemThi inner join SinhVien on SinhVien.maSV = DiemThi.maSV
				inner join Lop on Lop.maLop = SinhVien.maLop
				inner join MonHoc on MonHoc.maMonHoc = DiemThi.maMonHoc
	group by SinhVien.maSV,hoTenSV,gioiTinh,ngaySinh,queQuan,Lop.maLop,maKhoa,khoaHoc

go 


--------------------------------tạo funtion 
----
go
create function timtheomasinhvien(@masv varchar(20))
returns @bang table(
	masv varchar(20),
	hotensv nvarchar(50),
	gioitinh nvarchar(10),
	ngaySinh date,
	quequan nvarchar(20),
	malop varchar(20),
	makhoa varchar(20),
	khoahoc varchar(10),
	diem float)
as
begin
	insert into @bang
		select SinhVien.maSV,hoTenSV,gioiTinh,ngaySinh,queQuan,Lop.maLop,maKhoa,khoaHoc,round(sum(diem*soTinChi)/sum(soTinChi),1)as N'TB'
		from DiemThi inner join SinhVien on SinhVien.maSV = DiemThi.maSV
					inner join Lop on Lop.maLop = SinhVien.maLop
						inner join MonHoc on MonHoc.maMonHoc = DiemThi.maMonHoc
		where SinhVien.maSV = @masv
		group by SinhVien.maSV,hoTenSV,gioiTinh,ngaySinh,queQuan,Lop.maLop,maKhoa,khoaHoc
	return 

end



--------
go
create function timtheomalop(@malop varchar(20))
returns @bang table(
	masv varchar(20),
	hotensv nvarchar(50),
	gioitinh nvarchar(10),
	ngaySinh date,
	quequan nvarchar(20),
	malop varchar(20),
	makhoa varchar(20),
	khoahoc varchar(10),
	diem float)
as
begin
	insert into @bang
		select SinhVien.maSV,hoTenSV,gioiTinh,ngaySinh,queQuan,Lop.maLop,maKhoa,khoaHoc,round(sum(diem*soTinChi)/sum(soTinChi),1) as'TB' 
		from DiemThi inner join SinhVien on SinhVien.maSV = DiemThi.maSV
					inner join Lop on Lop.maLop = SinhVien.maLop
					inner join MonHoc on MonHoc.maMonHoc = DiemThi.maMonHoc
		where Lop.maLop=@malop
		group by SinhVien.maSV,hoTenSV,gioiTinh,ngaySinh,queQuan,Lop.maLop,maKhoa,khoaHoc
	return 

end



------------

go
create function timtheotenkhoa(@tenkhoa nvarchar(50))
returns @bang table(
	masv varchar(20),
	hotensv nvarchar(50),
	gioitinh nvarchar(10),
	ngaySinh date,
	quequan nvarchar(20),
	malop varchar(20),
	makhoa varchar(20),
	khoahoc varchar(10),
	diem float)
as
begin
	insert into @bang
		select SinhVien.maSV,hoTenSV,gioiTinh,ngaySinh,queQuan,Lop.maLop,Lop.maKhoa,khoaHoc,round(sum(diem*soTinChi)/sum(soTinChi),1) as'TB' 
		from DiemThi inner join SinhVien on SinhVien.maSV = DiemThi.maSV
					inner join Lop on Lop.maLop = SinhVien.maLop
					inner join KhoaDaoTao on Lop.maKhoa = KhoaDaoTao.maKhoa
					inner join MonHoc on MonHoc.maMonHoc = DiemThi.maMonHoc
		where KhoaDaoTao.tenKhoa = @tenkhoa
		group by SinhVien.maSV,hoTenSV,gioiTinh,ngaySinh,queQuan,Lop.maLop,Lop.maKhoa,khoaHoc
	return 
end 


----------------
go
create function timtheokhoahoc(@khoahoc varchar(10))
returns @bang table(
	masv varchar(20),
	hotensv nvarchar(50),
	gioitinh nvarchar(10),
	ngaySinh date,
	quequan nvarchar(20),
	malop varchar(20),
	makhoa varchar(20),
	khoahoc varchar(10),
	diem float)
as
begin
	insert into @bang
		select SinhVien.maSV,hoTenSV,gioiTinh,ngaySinh,queQuan,Lop.maLop,Lop.maKhoa,khoaHoc,round(sum(diem*soTinChi)/sum(soTinChi),1) as 'TB'
		from DiemThi inner join SinhVien on SinhVien.maSV = DiemThi.maSV
					inner join Lop on Lop.maLop = SinhVien.maLop
					inner join MonHoc on MonHoc.maMonHoc = DiemThi.maMonHoc
		where khoaHoc= @khoahoc
		group by SinhVien.maSV,hoTenSV,gioiTinh,ngaySinh,queQuan,Lop.maLop,Lop.maKhoa,khoaHoc
	return 
end 


-------------------------------------------tạo các view và function cho thông tin chi tiết của sinh viên
go
create function thongtinCanhanMotSinhvien(@masv varchar(20))
returns @bang table(
	masv varchar(20),
	hoten nvarchar(50),
	ngaysinh date,
	gioitinh nvarchar(10),
	email varchar(30),
	que nvarchar(200))
as
begin
	insert into @bang
		select maSV, hoTenSV,ngaySinh,gioiTinh,email,queQuan
		from SinhVien
		where maSV=@masv
	return
end

------------
go
create function thongtinChungSinhvien(@masv varchar(20))
returns @bang table(
	khoahoc varchar(10),
	tenkhoa nvarchar(50),
	malop varchar(20))
as
begin
	insert into @bang
		select khoaHoc,tenKhoa,Lop.maLop
		from Lop inner join SinhVien on Lop.maLop = SinhVien.maLop
				inner join KhoaDaoTao on Lop.maKhoa = KhoaDaoTao.maKhoa
		where maSV = @masv
		return
end

----------------------
go
create function cacMonDiemSinhvien(@masv varchar(20))
returns @bang table(
	mamon varchar(20),
	tenmon	nvarchar(50),
	sotc int,
	diem float)
as
begin
	insert into @bang
		select DiemThi.maMonHoc,tenMonHoc,soTinChi,diem
		from DiemThi inner join SinhVien on SinhVien.maSV = DiemThi.maSV
					 inner join MonHoc on MonHoc.maMonHoc = DiemThi.maMonHoc
		where Sinhvien.maSV = @masv
	return
end

--------------------
go
create function tongSoTinchiSinhVien(@masv varchar(20))
returns @bang table(
	tongtinchi int)
as
begin
	insert into @bang
		select sum(soTinChi)
		from DiemThi inner join MonHoc on MonHoc.maMonHoc = DiemThi.maMonHoc
		where maSV=@masv
	return
end
-----------------------
go
create function diemTichluySV(@masv varchar(20))
returns @bang table(
	diemtichluy float)
as
begin
	insert into @bang
		select round(sum(diem*soTinChi)/sum(soTinChi),1) 
		from DiemThi inner join MonHoc on MonHoc.maMonHoc = DiemThi.maMonHoc
		where maSV = @masv
	return
end

go







