chương 3. view -- khung nhìn -- bảng ảo
-- view là 1 bảng ảo dùng để lưu lại câu lệnh sql, view không phải
là 1 bảng vật lý (table), gọi view -> Trích xuất ra dữ liệu từ các
bảng vật lý dựa trên các câu lệnh select.
-- view ko phải là 1 bảng vật lý -> view không dùng được các
lệnh insert/delete dữ liệu vào view.
-- view là 1 bảng -> có thể select dữ liệu trên view.
----------------------------------------------------
--cú pháp view:
create view tenview
as
   select .....
-----------------------------------
--xóa view:
drop view tenview
--gọi view:
select * from tenview
----------------------------------
mục đích xây dựng view:
1. tốc độ truy cập nhanh hơn
2. có thể 1 số bảng vật lý không cho quyền truy cập với mọi người dùng
vì lý do bảo mật, --> viết các view cho phép người dùng truy cập 1 số
thành phần dữ liệu.