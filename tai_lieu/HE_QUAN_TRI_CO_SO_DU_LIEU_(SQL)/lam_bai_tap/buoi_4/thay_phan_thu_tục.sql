chương 4. thủ tục - store procedure
------------------------------------
thủ tục là 1 hàm không trả về giá trị, không return, tương tự hàm
void trong c/c++ -> chỉ thực thi.
-----------------------------------
-- thủ tục có 2 loại:
     1. thủ tục không output
  2. thủ tục có  output (hay sử dụng)
-----------------------------------
1. thủ tục không output
   --là thủ tục thực thi không output
   --cú pháp thủ tục:
   create proc tenthutuc(@thambien1 kieudl1,@thambien2 kieudl2,...)
   as
   begin
      .....................
   end
-- gọi thủ tục:
   exec/execute tenthutuc doiso,doiso2,...
-- xóa thủ tục:
   drop proc tenthutuc
-- sửa lại nội dung thủ tục:
   alter <-> create -> chạy lại
------------------------------------------------
vd: CSDL QLKHO
Ton(mavt,tenvt,soluongT)
Nhap(sohdn,mavt,soluongN,dongiaN,ngayN)
Xuat(sohdx,mavt,soluongx,dongiaX,ngayX)
-------------------------------
vd1. viết thủ tục nhập dữ liệu cho bảng tồn với các tham biến truyền 
vào từ bàn phím mavt,tenvt,soluongT. Hãy kiểm tra xem tenvt đã có trong
bảng tồn chưa? Nếu có rồi thì đưa ra thong báo.
-------------------------------------------------
create proc nhapTon(@mavt nchar(10),@tvt nvarchar(20),@slt int)
as
begin
  if(exists(select * from ton where tenvt=@tvt))
     print(N'Vật tư này đã có')
  else
     begin
    insert into ton values(@mavt,@tvt,@slt)
    print(N'Nhập thành công')
  end
end
------------------------------
--gọi thủ tục:
exec nhapTon 'vt1',N'Kẹo kéo',300
exec nhapTon 'vt7',N'Kẹo dồi',300
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
create proc nhapNhap(@sohdn nchar(10),@mavt nchar(10),@sln int,
                       @dgn money,@ngayn date)
as
begin
  if(not exists(select * from ton where mavt=@mavt))
    print(N'Không có danh mục mavt nay')
  else
    begin
    insert into  nhap values(@sohdn,@mavt,@sln,@dgn,@ngayn)
    print(N'Successfully nhap')
 end
end
---
--sai
exec nhapNhap 'N05','vt10',100,3000,'3/6/2020'
--đúng
exec nhapNhap 'N05','vt1',100,3000,'3/6/2020'
--
select * from nhap
--
vd3. viết thủ tục nhập dữ liệu cho bảng xuất với các tham biến
sohdx,mavt,soluongx,dongiax,ngayx. Hãy kiểm tra xem mavt cần xuất
có trong bảng ton hay không? nếu không thì đưa ra thông báo.
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
exec xoaton 'vt6'