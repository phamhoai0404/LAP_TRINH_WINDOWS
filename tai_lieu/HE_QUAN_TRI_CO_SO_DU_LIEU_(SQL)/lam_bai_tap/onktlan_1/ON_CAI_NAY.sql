



-------------------------------------------------------function co 2 loai-------------------------------------------------
-------------------------------------------------------function co 2 loai-------------------------------------------------
-------------------------------------------------------function co 2 loai-------------------------------------------------
-------------------------------------------------------function co 2 loai-------------------------------------------------
create function vidu_trave1giatri( @vidu char(10))
returns int 
as		
	begin
		declare @tinh int
		set @tinh=(select count(*)
				   from sinhvien
				   where masv=@vidu)
		return @tinh
	end


select dbo.vidu_trave1giatri('xinh gai')



create function vidu_trave1bang( @vidu char(10))
returns @bang table(
	xinhgai char(10),
	tuoi int,
	gioitinh char(30))
as		
	begin
		insert into @bang values
			select xinhkhong, tuoido, gioitinhdo
			from sinhvien
			where masv=@vidu
		return
	end

select * from vidu_trave1bang('xinh gai')

-------------------------------------------------------thu tuc ( proc theo minh nghi co 3 loai)-------------------------------------------------
-------------------------------------------------------thu tuc ( proc theo minh nghi co 3 loai)-------------------------------------------------
-------------------------------------------------------thu tuc ( proc theo minh nghi co 3 loai)-------------------------------------------------
-------------------------------------------------------thu tuc ( proc theo minh nghi co 3 loai)-------------------------------------------------
-------------------------------------------------------thu tuc ( proc theo minh nghi co 3 loai)-------------------------------------------------
-------------------------------------------------------thu tuc ( proc theo minh nghi co 3 loai)-------------------------------------------------
create proc vidu_thutuc_khongtravegiatri( @gido char(10))
as
	begin
		if(exists())
			print('khong phai la sao!')
		else 
			begin
				insert into ton where.....
				print('')
			end
			 
	end


exec vidu_thutuc_khongtravegiatri 'xinh gai'

--------------
create proc vidu_thutuc_khongtravecoOutput( @gido char(10), @trave int output)
as	
	begin
		if()
			set @trave=1
		else
			set @trave=2
		return @trave
	end

declare @bien int 
exec vidu_thutuc_khongtravecoOutput '22k', @bien output
select @bien
------------
create proc vidu_thutuc_kieunghiraha
as	
	begin
		select .....
		return 
	end

create proc cau4 (@tentg nvarchar(50), @tennxb nvarchar(50))
as
	begin
		select masach, tensach, tennxb, tentg, namxb, sluong,dongia, sluong*dongia
		from sach inner join tacgia on tacgia.matg=sach.matg
				  inner join nhaxuatban on sach.manxb=nhaxuatban.manxb
		where tentg=@tentg and tennxb=@tennxb
		return
	end