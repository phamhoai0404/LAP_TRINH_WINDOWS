chương 4. Hàm --function
------------------------------
--Hàm: dùng để kết xuất dữ liệu -> có trả về --> có return
--Hàm thay thé view trong các trường hợp:
     ta thấy rằng view là cố định -> không thể truyền tham biến
  để xuất kết quả tùy biến.
vd.
create view dssv
as
   select masv,tensv,que,gioitinh
   from sv inner join lop on sv.malop=lop.malop
   where tenlop='KHMT2'
---------------------------------------
--> chỉ đưa ra đc dssv lớp khmt2 --> khmt3,khmt4????
--> view khác???
--> Hàm --> trả về giá trị tùy biến dựa trên các đối số.
--------------------------------------------
Hàm có 2 loại hàm:
1. Hàm trả về giá trị cụ thể  (Scalar valued function)
2. Hàm trả về giá trị bảng    (Table valued function)
   (Ứng dụng rất nhiều trong lập trình  app, web,...)
---------------------------------------------
1. scalar valued function: Hàm trả về 1 giá trị cụ thể duy nhất.
--gia trị có kiểu: int, float, char, nvarchar,...
------------------------
--cú pháp hàm:
create function tenham(@thambien1 kieudl1,@thambien2 kieudl2,...)
  returns kieutrave
as
begin
  declare @bien kieutrave   --Biến cục bộ
  ..............
  return @bien
end
----------------------------------
--xóa hàm: drop function tenham
------------------------------------
--gọi hàm:
select dbo.tenham(doiso1,doiso2,...)
----------------------------------------
vd1. viết hàm đưa ra tên vật tư khi biết mã vt từ bàn phím.
-- tham biến: mavt - nchar(10)
--trả về: tenvt - nvarchar(20)
----------------------------------------
create function vd1(@mvt nchar(10))
returns nvarchar(20)
as
begin
   declare @tvt nvarchar(20)
   --set là lệnh gán -> biến @tvt --> giá trị: tenvt từ bảng tồn
   --Tương ứng với mavt là @mvt truyền vào từ hàm
   set @tvt = (select tenvt from ton where mavt = @mvt)
   return @tvt
end
insert into ton values('vt1',N'Kẹo kéo',200)
insert into ton values('vt2',N'Kẹo mút',400)
insert into ton values('vt3',N'Kẹo dẻo',300)
insert into ton values('vt4',N'Kẹo dừa',100)
select dbo.vd1('vt2')
vd2. viết hàm đưa ra số lượng xuất của 1 sản phẩm có
tên vật tư và ngày xuất nhập từ bàn phím.
create function vd2(@tvt nvarchar(20),@ngayx date)
returns int
as
begin
  declare @tong int
  set @tong=(select sum(soluongx) from xuat
                 inner join ton on xuat.mavt=ton.mavt
   where tenvt=@tvt and ngayx=@ngayx)
  return @tong
end
select dbo.vd2(N'Kẹo kéo','3/2/2020')
select dbo.vd2(N'Kẹo mút','11/19/2019')
---------------------------------------


vd3. viết hàm đưa ra tổng số lượng nhập của 1 sản phẩm
có tên sp nhập từ bàn phím từ năm x đến năm y từ bàn phím.


create function vd3(@tenvt nvarchar(20),@x int,@y int)
returns int
as
begin
   declare @tong int
   set @tong=(select sum(soluongn) from nhap
                inner join ton on nhap.mavt=ton.mavt
      where tenvt=@tenvt and 
         year(ngayn) between @x and @y
 )
 return @tong
end 



select dbo.vd3(N'kẹo mút',2019,2020)




vd4. viết hàm đếm có bao nhiêu vật tư có soluong tồn 
>= số lượng tồn truyền từ bàn pím.
create function vd4( @soluongnhap int )
returns int 
as
begin
	declare @soluong int 
	set @soluong=(select count (*)
					from ton 
					where soluongt >= @soluongnhap)
	return @soluong					
end
select dbo.vd4('122')
------------------



vd5. viết hàm đưa ra đơn giá xuất của 1 sản phẩm
khi biết ngày xuất và số hdx nhập từ bàn hpims.
create function vd5( @ngayxuat datetime, @hoadonxuat nchar(10))
returns float 
as
begin
	declare @dongiax float 
	set @dongiax= ( select sum(dongiax)
					from xuat
					where  ngayx = @ngayxuat and sohdx=@hoadonxuat)
	return @dongiax
end
select dbo.vd5('7/12/2020','1')
--------------