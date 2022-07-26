use master
go
if DB_ID('sinhviendb') is not null
	drop database sinhviendb
go
create database sinhviendb
go
USE [sinhviendb]
GO
/****** Object:  Table [dbo].[lophoc]    Script Date: 07/27/2015 11:22:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lophoc](
	[malop] [int] IDENTITY(1,1) NOT NULL,
	[tenlop] [nvarchar](30) NULL,
	[giangvien] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[malop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[lophoc] ON
INSERT [dbo].[lophoc] ([malop], [tenlop], [giangvien]) VALUES (1, N'Công nghệ thông tin', N'Thu Thảo')
INSERT [dbo].[lophoc] ([malop], [tenlop], [giangvien]) VALUES (2, N'Kỹ thuật phần mềm', N'Hữu Tiến')
SET IDENTITY_INSERT [dbo].[lophoc] OFF
/****** Object:  Table [dbo].[sinhvien]    Script Date: 07/27/2015 11:22:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinhvien](
	[masv] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](20) NULL,
	[diachi] [nvarchar](12) NULL,
	[dienthoai] [nvarchar](12) NULL,
	[malop] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[sinhvien] ON
INSERT [dbo].[sinhvien] ([masv], [hoten], [diachi], [dienthoai], [malop]) VALUES (1, N'Lan Anh', N'Ha noi', N'09876543', 1)
INSERT [dbo].[sinhvien] ([masv], [hoten], [diachi], [dienthoai], [malop]) VALUES (2, N'Văn Tuấn', N'Hai phong', N'06876542', 1)
INSERT [dbo].[sinhvien] ([masv], [hoten], [diachi], [dienthoai], [malop]) VALUES (3, N'Nga Đăng', N'Ha noi', N'09876549', 2)
INSERT [dbo].[sinhvien] ([masv], [hoten], [diachi], [dienthoai], [malop]) VALUES (4, N'Hải Vân', N'Quang ninh', N'01876547', 2)
INSERT [dbo].[sinhvien] ([masv], [hoten], [diachi], [dienthoai], [malop]) VALUES (5, N'Mai Hương', N'Lao Cai', N'05876546', 1)
INSERT [dbo].[sinhvien] ([masv], [hoten], [diachi], [dienthoai], [malop]) VALUES (6, N'Mạnh Hùng', N'Quang ninh', N'0787657646', 1)


SET IDENTITY_INSERT [dbo].[sinhvien] OFF
/****** Object:  StoredProcedure [dbo].[demSV]    Script Date: 07/27/2015 11:22:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[demSV]
@dc nvarchar(20),
@sl int out
as
select @sl=COUNT(diachi) from sinhvien where diachi=@dc
GO
/****** Object:  StoredProcedure [dbo].[nhapSinhvien]    Script Date: 07/27/2015 11:22:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[nhapSinhvien]
@hoten nvarchar(20), 
@diachi nvarchar(20),
@dt nvarchar(12),
@malop int
as
insert into sinhvien values(@hoten,@diachi,@dt,@malop)
GO
/****** Object:  ForeignKey [FK__sinhvien__malop__08EA5793]    Script Date: 07/27/2015 11:22:31 ******/
ALTER TABLE [dbo].[sinhvien]  WITH CHECK ADD FOREIGN KEY([malop])
REFERENCES [dbo].[lophoc] ([malop])
GO
--
go
create proc suaSinhvien
@hoten as nvarchar(20),
@diachi as nvarchar(20),
@dienthoai as nvarchar(20),
@malop as int,
@masv as int
as
update sinhvien set hoten=@hoten, diachi=@diachi,
dienthoai=@dienthoai, malop=@malop
where masv=@masv
go
exec dbo.suaSinhvien 'Thùy Linh', 'Ha noi', '31245631', 2,1 
--
go
create proc xoaSinhvien
@masv int
as
delete from sinhvien where masv=@masv
go
exec dbo.xoaSinhvien 4
--
select * from sinhvien
select * from lophoc


