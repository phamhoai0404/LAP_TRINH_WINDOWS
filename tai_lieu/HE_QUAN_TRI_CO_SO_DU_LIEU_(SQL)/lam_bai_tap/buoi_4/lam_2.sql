vd3. viết thủ tục nhập dữ liệu cho bảng xuất với các tham biến
sohdx,mavt,soluongx,dongiax,ngayx. Hãy kiểm tra xem mavt cần xuất
có trong bảng ton hay không? nếu không thì đưa ra thông báo.

create proc nhapXuat ( @sohdx nchar(10), @mavt nchar(10), @soluongx int, @dongiax float, @ngayx datetime)
as
begin
	if(not exists(select * from ton where mavt = @mavt))
		print(N' không có trong danh mục mavt này!')
	else 
		begin
			insert into nhap values( @sohdx,@mavt,  @soluongx, @dongiax , @ngayx )
			print(N'Nhập thành công!')
		end
end

select * from ton
exec nhapXuat '1','1',1,2,'2/3/2000'
select * from nhap



vd4. viết thủ tục xóa 1 vật tư khỏi bảng tồn với tham biến truyền vào 
là mavt, hãy kiểm tra xem mavt này có tromg bảng tồn không? Nếu không 
thì đưa ra thông báo.
create proc xoaTon(@mvt nchar(10))
as
begin
   if(NOT exists(select * from ton where mavt=@mvt))
     print(N'Không có vt này')
   else
     begin
     delete from ton where mavt=@mvt
 print(N'Vật tư này đã được xóa successfully')
  end
end
---
exec xoaton '2'

