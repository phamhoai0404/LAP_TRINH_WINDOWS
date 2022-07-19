-------------select mà count còn nhiều cái khác nữa thì phải group



select * from SINHVIEN
select * from LOP

create function demsvlop( @malop nchar(19))
returns int 
as	
	begin
		declare @dem int
		select @dem=count(*)
		from SINHVIEN 
		where malop=@malop
		return @dem
	end

select dbo.demsvlop('6')



----------bài này chép nhưng giống câu demsvlop ấy nhưng không biết tại sao lại phải dài dòng như vậy
create function thongke( @malop nchar(10))
returns int 
as
	begin
		declare @sl int
		declare @tenlop nvarchar(20)
		select @tenlop=tenlop, @sl=count(SINHVIEN.masv)
		from LOP, SINHVIEN
		where LOP.malop=SINHVIEN.malop and LOP.malop=@malop
		group by tenlop
		return @sl
	end	



select dbo.demsvlop('1')
select dbo.thongke('1')

select dbo.demsvlop('6')
select dbo.thongke('6')

-----------------------------------------------------------------------------------
create function dssvhoclop( @tenlop nvarchar(20))
returns @bang table (
				masv nchar (10),
				tensv nvarchar(20)
				)
as	
	begin
		insert into @bang
			select masv, tensv 
			from SINHVIEN inner join LOP ON SINHVIEN.malop=LOP.malop
			where tenlop=@tenlop
		return 
	end


select * from LOP
select * from SINHVIEN
select * from dssvhoclop('CD')
-----------------------------------------------------------



---------------------------------------------------------------
create function thongkedominh( @tenlop nvarchar(20))
returns @bang table(
			malop nchar(10),
			tenlop nvarchar(20),
			soluongsv int)
as
	begin
		if( not exists( select malop from LOP where tenlop=@tenlop))
			begin
				insert into @bang
					select LOP.malop, tenlop, count(*)
					from LOP inner join SINHVIEN ON LOP.malop=SINHVIEN.malop
					group by LOP.malop, tenlop
			end
		else
			begin
				insert into @bang
					select LOP.malop, tenlop, count(*)
					from LOP inner join SINHVIEN ON LOP.malop=SINHVIEN.malop
					where tenlop=@tenlop
					group by LOP.malop, tenlop
			end
		return
	end

select * from SINHVIEN
select * from LOP
select * from thongkedominh('CH')



-------------------------------------------------
---đưa ra phòng học có tên sinh viên nhập từ hàm 
create function phonghoc( @tensv nvarchar(20))
returns int
as	
	begin
		declare @phong int
		select @phong=phong 
		from SINHVIEN inner join LOP on SINHVIEN.malop=LOP.malop
		where tensv=@tensv
		return @phong
	end

select * from SINHVIEN
select * from LOP
select dbo.phonghoc('P')
select dbo.phonghoc('B')

--------------------------------------------------------------------------------
create function thongketheophong( @phong int)
returns @bang table(
			masv nchar(10),
			tensv nvarchar(20),
			tenlop nvarchar(20),
			phong int
			)
as
	begin
		if( not exists(select phong from LOP where phong=@phong))
			begin
				insert into @bang
					select masv, tensv, tenlop, phong
					from LOP inner join SINHVIEN on LOP.malop=SINHVIEN.malop	
			end
		else
			begin 
				insert into @bang
					select masv, tensv, tenlop, phong
					from LOP inner join SINHVIEN on LOP.malop=SINHVIEN.malop
					where phong=@phong
			end
		return 
	end

select * from thongketheophong('5')
select * from thongketheophong('1')


----------------------------------------------------------------
create function demlophocophong( @phong int)
returns int
as
	begin
		declare @dem int
		if( not exists(select phong from LOP where phong=@phong))
			 set @dem = 1111
		else
			begin
				select @dem=count(*)
				from LOP
				where phong=@phong
			end
		return @dem
	end

select * from LOP
select dbo.demlophocophong('11')
select dbo.demlophocophong('2')