==================CHUYỂN VỀ PHẦN THỦ TỤC CÓ OUTPUT========================


vd: CSDL QLKHO
Ton(mavt,tenvt,soluongT)
Nhap(sohdn,mavt,soluongN,dongiaN,ngayN)
Xuat(sohdx,mavt,soluongx,dongiaX,ngayX)
-------------------------------
vd1. viết thủ tục nhập dữ liệu cho bảng tồn với các tham biến truyền 
vào từ bàn phím mavt,tenvt,soluongT. Hãy kiểm tra xem tenvt đã có trong
bảng tồn chưa? Nếu có rồi thì đưa ra thong báo.
-------------------------------------------------
create proc nhapTon_3(@mavt nchar(10),@tvt nvarchar(20),@slt int, @trave int output)
as
begin
  if(exists(select * from ton where tenvt=@tvt))
     set @trave=0
  else
     begin
		insert into ton values(@mavt,@tvt,@slt)
		set @trave=1
	end
	return @trave
end
----trả về bằng 0
declare @bien int  
exec nhapTon_3 '11299','vt3',10,@bien output
select @bien
----- trả về bằng 1
declare @bien int
exec nhapTon_3 '1234','thg',10,@bien output
select @bien

select * from ton

--------------------------------------
vd: CSDL QLKHO
Ton(mavt,tenvt,soluongT)
Nhap(sohdn,mavt,soluongN,dongiaN,ngayN)
Xuat(sohdx,mavt,soluongx,dongiaX,ngayX)
----
vd2. viết thủ tục nhập dữ liệu cho bảng Nhap với các tham biến truyền
vào là sohdn,mavt,soluongN,dongiaN,ngayN. Hãy kiểm tra xem mavt có trong
bảng ton hay không? nếu không thì đưa ra thông báo.
---
create proc nhapNhap_2(@sohdn nchar(10),@mavt nchar(10),@sln int, @dgn money,@ngayn date, @trave int output)
as
begin
  if(not exists(select * from ton where mavt=@mavt))
	set @trave=0
  else
    begin
		insert into  nhap values(@sohdn,@mavt,@sln,@dgn,@ngayn)
		set @trave=1
	end
	return @trave
end
---
--sai
declare @bien int 
exec nhapNhap_2 'nv2','vt10',100,3000,'3/6/2020', @bien output
select @bien
--đúng
declare @bien int 
exec nhapNhap_2 '111','1',100,3000,'3/6/2020', @bien output
select @bien 
--
select * from ton
select * from nhap
--
vd3. viết thủ tục nhập dữ liệu cho bảng xuất với các tham biến
sohdx,mavt,soluongx,dongiax,ngayx. Hãy kiểm tra xem mavt cần xuất
có trong bảng ton hay không? nếu không thì đưa ra thông báo.

create proc nhapXuat_2( @sohdx nchar(10), @mavt nchar(10), @soluongx int, @dongiax float, @ngayx datetime, @trave int output)
as
begin
	if(not exists(select * from ton where mavt = @mavt))
		set @trave=0
	else 
		begin
			insert into nhap values( @sohdx,@mavt,  @soluongx, @dongiax , @ngayx )
			set @trave=1
		end
	return @trave
end

-------sai( ý là không tồn tại ấy )
declare @bien int
exec nhapXuat_2 '222','90',1,2,'2/3/2000', @bien output
select @bien

--đúng ( ý là có tồn tại ấy )
declare @bien int
exec nhapXuat_2 '222','1',1,2,'2/3/2000', @bien output
select @bien

select * from nhap

vd4. viết thủ tục xóa 1 vật tư khỏi bảng tồn với tham biến truyền vào 
là mavt, hãy kiểm tra xem mavt này có tromg bảng tồn không? Nếu không 
thì đưa ra thông báo.
create proc xoaTon_2(@mvt nchar(10), @trave int output)
as
begin
   if(NOT exists(select * from ton where mavt=@mvt))
     set @trave=0
   else
     begin
		delete from ton where mavt=@mvt
		set @trave=1
	 end
	return @trave
end

----sai( ý là không tồn tại ấy )
declare @bien int 
exec xoaTon_2 'vt6', @bien output
select @bien

------đúng( ý là có tồn tại ấy )
declare @bien int 
exec xoaTon_2 '11', @bien output
select @bien


select * from ton