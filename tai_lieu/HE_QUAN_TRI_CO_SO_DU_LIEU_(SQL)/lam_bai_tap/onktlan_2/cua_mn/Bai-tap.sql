use master
go
create database QLKHO3
use QLKHO3
go 
--Cau 1:
create table Ton(
	MaVT char(10) not null primary key,
	TenVT nvarchar(30),
	SoLuongT int
)

create table Nhap(
	SoHDN char(10) not null primary key,
	MaVT char(10) not null,
	SoLuongN int,
	DonGiaN int,
	NgayN datetime 

	constraint FK1 Foreign key(MaVT) references Ton(MaVT)

)

create table Xuat(
	SoHDX char(10) not null primary key,
	MaVT char(10) not null,
	SoLuongX int,
	DonGiaX int,
	NgayX datetime 

	constraint FK2 Foreign key(MaVT) references Ton(MaVT)

)


insert into Ton values ('A', 'hang a', 50)
insert into Ton values ('B', 'hang b', 50)
insert into Ton values ('C', 'hang c', 50)
insert into Ton values ('D', 'hang d', 50)

insert into Nhap values ('N1','A', 5,100,'8/6/2010')
insert into Nhap values ('N2','B', 1,100,'4/10/2010')
insert into Nhap values ('N3','A', 6,100,'5/6/2010')

insert into Xuat values ('X1','A', 5,100,'8/5/2010')
insert into Xuat values ('X2','C', 7,100,'1/6/2010')
insert into Xuat values ('X3','D', 2,100,'11/6/2010')

--Cau 2: Tham so NgayNhap, MaVT -> NgayN,MaVT, TenVT, TienNhap

create function Ham1 (@ngay datetime, @MaVT char(10))
returns @bang1 table (
			NgayNhap datetime,
			MaVT char(10),
			TenVT nvarchar(30),
			TienNhap int
			)
AS 
		Begin 
		insert into @bang1 
			select NgayN,Ton.MaVT,TenVT, (SoLuongN *DonGiaN)
			from Ton inner join Nhap on Ton.MaVT=Nhap.MaVT
			where NgayN=@ngay and Ton.MaVT = @MaVT
			return
End

select * from Ham1 ('8/6/2010','A')

-- Cau 3: 
create proc ThuTuc( @SoHDX char(10) ,
					@MaVT char(10) ,
					@SoLuongX int,
					@DonGiaX int,
					@NgayX datetime,
					@KQ int output
					)
AS
	Begin 
		if ( Exists (select * from Ton inner join Xuat on Ton.MaVT = Xuat.MaVT
		where SoLuongX <= SoLuongT and Ton.MaVT = @MaVT) )

			BEGIN
				insert into Xuat values ( @SoHDX  ,
											@MaVT  ,
											@SoLuongX ,
											@DonGiaX ,
											@NgayX 
										)
				Set @KQ=1 
			END

	Else set @KQ=0
		
		return @KQ 
			
	End


Declare @LOI int 
EXEC ThuTuc 'Them1','A', 500,100,'8/5/2010', @LOI output -- tra ve 0 thi  dung vi SoluongX > SoLuongT
select @LOI 
select * from Xuat