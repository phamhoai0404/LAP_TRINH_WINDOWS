I. thủ tục có output
-- thủ tục vừa thực thi vừa output
-- cú pháp thủ tục:
create proc tenthutuc(@thambien1 kieudl1,@thambien2 kieudl2,...,
                      @bientrave kieudl output)
as
begin
  ......thực thi
  return @bientrave
end
--------------------------------------
vd. viết thủ tục nhập dữ liệu cho bảng nhập với các tham biến
sohdn,mavt,soluongN,dongiaN,ngayN. Hãy kiểm tra xem mavt có trong
bảng tồn hay không, nếu không trả về 1. Kiểm tra xem soluongN<=0? Nếu
soluongN<=0 thì trả về 2, ngược lại thảo mãn tất cả thì cho phép
nhập và trả về 0.
create proc nhapBangNhap(@sohdn nchar(10),@mavt nchar(10),
                   @sln int,@dongiaN money,@nn date,
    @trave int output)
as
begin
  if(not exists(select * from ton where mavt=@mavt))
     set @trave=1
  else
    if(@sln<=0)
    set @trave=2
 else
    begin
       insert into nhap values(@sohdn,@mavt,@sln,@dongiaN,@nn)
   set @trave=0
    end
   return @trave
end
---
--ứng dụng rất nhiều trong lập trình, chúng ta sẽ không dùng không 
--output, mà chuyển tất cả về có output
--vì không output --> lệnh print chỉ xuất trên sql, nếu chúng ta
--lập trình asp/php/python/nodejs/...
--> gọi thủ tục -> không thấy được các thông báo
-- gọi thủ tục -> xuất ra mã trên ctrinh -> dựa trên mã để viết
--thông báo lỗi theo ctrinh mà mình đang lt.
--gọi ctr:
declare @bien int  --cùng kiểu biến trả về
exec nhapBangNhap 'N06','vt9',-10,2000,'4/5/2020',@bien output
select @bien
declare @bien int  --cùng kiểu biến trả về
exec nhapBangNhap 'N07','vt2',10,2000,'4/5/2020',@bien output
select @bien
--
select * from nhap
--bài tập: 
chuyển tất cả các bài về không output thủ tục -> có output và chạy