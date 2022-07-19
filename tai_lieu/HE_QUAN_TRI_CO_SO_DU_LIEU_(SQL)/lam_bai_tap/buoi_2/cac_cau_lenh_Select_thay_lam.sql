các câu lệnh select:
---------------------------------
select */cột 1,2,.../distinct *, cot,.../top N/top N
       percent ...
from ...
where ....
group by ...
having ....
order by ... asc/desc
-----------------------------------------------

1. đưa ra thông tin tất cả các sản phẩm
select * from sanpham

2. đưa ra masp,tensp,mausac,soluong của các sản phẩm:
select masp,tensp,mausac,soluong from sanpham

3. đưa ra tên quê quán duy nhất không lặp lại của các nhân viên
select distinct diachi from nhanvien

4. đưa ra 5 sản phẩm đầu tiên 
select top 5 * from sanpham
select top 10 masp,tensp from sanpham

--ứng dụng:

đưa ra 5 sản phẩm có gia cao nhất
select top 5 masp,tensp from sanpham 
where chungloai='tivi'
order by giaban desc

-- đưa ra 10% sản phẩm tivi có giá bán thấp nhất
select top 10 percent *
from sanpham
where chungloai='tivi'
order by giaban asc

5. where: lọc dữ liệu từ from
=,>,>=,<,<=,<>, and, or
---------------------------
6. kết nối bảng(nội kết nối): inner join ... on ...
vd. 
SanPham(MaSP, MaHangSX, TenSP, SoLuong, MauSac, GiaBan, DonViTinh, MoTa)
HangSX(MaHangSX, TenHang, DiaChi, SoDT, Email)
NhanVien(MaNV, TenNV, GioiTinh, DiaChi, SoDT, Email, TenPhong)
Nhap(SoHDN, MaSP, SoLuongN, DonGiaN)
PNhap(SoHDN,NgayNhap,MaNV)
Xuat(SoHDX, MaSP, SoLuongX)
PXuat(SoHDX,NgayXuat,MaNV)
vd. đưa ra masp,tensp,mausac,soluong,giaban của các sản phẩm hãng
samsung sản xuất.
select masp,tensp,mausac,soluong,giaban
from sanpham inner join hangsx on sanpham.mahangsx=hangsx.mahangsx
where tenhang='Samsung'
vd2. đưa ra masp,tensp của các sản phẩm samsung được nhập ngày 2/9/2020
select sanpham.masp,tensp 
from sanpham inner join hangsx on sanpham.mahangsx=hangsx.mahangsx
        inner join nhap on sanpham.masp=nhap.masp
 inner join pnhap on nhap.sohdn=pnhap.sohdn
where ngaynhap='2/9/2020' and tenhang=N'samsung'
----------------------------------------------
chú ý: Nếu 1 trường nào đó trong select thuộc vào >1 bảng thì 
phải chỉ rõ trường đó thuộc bảng nào.   bang.tencot
--------------------------------------------------------
6. like N'%chuoi%'  --> thuwowmgf dùng trong search
-------------------------
vd. đưa ra tên sản phẩm có chữ Galaxy
select masp,tensp 
from sanpham 
where tensp like N'%'+chuoitim+'%'
-----------------------------------
vd2. Đưa ra tên sản phẩm có chữ Note
select masp,tensp
from sanpham
where tensp like N'%Note%'
--------------------------------------
7. between ... and...
đưa ra các sản phẩm có giá từ 1000000 đến 2000000
select masp,tensp
from sanpham
where giaban between 1000000 and 2000000
<=>  giaban >=1000000 and giaban <=2000000
8. In/Not in(danh sách)
vd. đưa ra các hãng sx có địa chỉ là HD, HY, HP và không phải 
BN,BG,BK
select mahangsx,tenhang
from hangsx
where diachi in(N'HD',N'HY',N'HP') and diachi Not In(N'BN',N'BG',N'BK')
----------------------------
<=> diachi=N'HD' or diachi=N'HY' or ...
<-> thường ứng dụng trojg select lồng:
đưa ra cacs hãng sản xuất chưa cung ứng sản phẩm nào cả.
select mahangsx,tenhang 
from hangsx 
where mahangsx not in(
                     select mahangsx from sanpham)
9. một số lẹnh ngày tháng:
getdate() ngày tháng năm hiện thời
select getdate()
select year(getdate())
select month(getdate())
select day(getdate())
-------------------------------------------
vd. đưa ra masv,hoten,quequan,tuoi của các sinh viên.
select masv,hoten,quequan,year(getdate())-year(ngaysinh) as N'tuoi'
from sv
10. một số hàm thống kê:
sum(cột), count(*): đếm, min, max, avg
vd. 
đưa ra tổng số lượng các sản phẩm
select sum(soluong) as N'tong'
from sanpham
---các biểu thức trong câu lệnh select không có tên (No column)
-->> đặt tên mới cho biểu thức:
as [ten cot]
-- đếm có bao nhiêu sản phẩm samsung cung ứng
select count(*) as N'tổng số sản phẩm'
from sanpham inner join hangsx on sanpham.mahangsx=hangsx.mahangsx
where tenhang='Samsung'

11. group by.. having: gom nhóm dữ liệu
vd1. đếm có bao nhiêu sản phẩm hãng samsung sản xuất
--> cụ thể hãng: samsung.
select count(*) as N'tổng số sản phẩm'
from sanpham inner join hangsx on sanpham.mahangsx=hangsx.mahangsx
where tenhang='Samsung'
vd2. đếm có bao nhiêu sản phẩm của mỗi hãng cung ứng.????
-- đã cụ thể hãng nào chưa???
select mahangsx,tenhang,count(*) as N'soloai'
from hangsx inner join sanpham on hangsx.mahangsx=sanpham.mahangsx
group by mahangsx,tenhang
--> quy trình:
1. from:  nguồn dữ liệu
2. group by: gom nhóm theo từng hãng sx
3. select trên mỗi nhóm con.
--------------------------
vd. thống kê xem trong lớp HTTT mỗi quê có bao nhiêu sv.
--> lấy lớp HTTT:  where
--> bảo các bạn ở các quê về ngồi gần nhau thành vòng tròn (group by)
--> đếm trên mỗi vòng tròn đó: select
select que,count(*) as N'tong so sv'
from lop inner join sv on lop.malop=sv.malop
where tenlop='HTTT'
group by que
-->
1. from : ngồn sv học lớp nào
2. where: lọc ra các sv học lớp httt
3. group by: que --> gom nhóm theo que
4. select trên các nhóm.
chú ý:
1. trên select có các cột nào thì trên group by có các cột đó
2. các lệnh thống kê không được sử dụng trong where.
----------------------------
vd4. thống kê các  quê của lớp httt   có bao nhiêu sv nam để lập
đội bóng đá yêu cầu các quê phải >=10 sv nam.
 chưa biết: quê nào??? -- không cụ thể --> group by
            biết: HTTT, nam  --> where
-- các quê, mà số lượng sv Nam mỗi quê >=10: chưa biết quê nào
--> chưa biết soluong sv nam mỗi quê nào cả --> having
(điều kiện nhóm)
------------------------------------
select que,count(*) as N'tong sv nam'
from sv inner join lop on sv.malop=lop.malop
where tenlop='HTTT' and gioitinh=N'Nam'
group by que
having count(*) >=10
-------------------------------------------------
quy trình:
1. from: lấy toàn bộ
2. where: lọc ra httt và nam
3. nhóm theo vcacs nhóm quê
4. điều kiên trên các nhóm count(trên mỗi nhóm) >=10
5. select ra keetq quả trên mỗi nhóm.
--------------------------------------------
select que,count(*) as N'tong sv nam'
from sv inner join lop on sv.malop=lop.malop
where tenlop='HTTT' and gioitinh=N'Nam'
group by que
having count(*) >=10
Bình luận
Viết bình luận...









=============mình viết thêm============
--thay thế tên thì có 3 kiểu sau:
select 'họ và tên'= hoten, school ' trường học', Masv as 'Mã Sinh Viên'
from thongtin


------ lựa chọn có hai kiểu trình bày 
vd 
select hoten, masv, case gioitinh
						when 1 then nam 
						else nu
						end  AS gioitinh
						-----từ case đến end là cấu trúc của lựa chọn
from sinhvien

vd select hoten, masv, case 
						when gioitinh=1 then nam 
						else nu
						end as gioitinh
from sinhvien




-------------vd sử dụng between - and kết hợp với lấy thời gian
vd; anh này tên bình và có độ tuổi ở 20 đến 30 mà mình kiểu chép ở slide và nó không có dấu() ở chỗ year(getdate())-year(ngaysinh) between 20 and 30 nó chỉ làm như vậy mà thôi
select masv, ten, dia chi
from sinhvien
where ten='bình' and year(getdate())-year(ngaysinh) between 20 and 30 

---------------rất hay có cái kiểu là 
select year(getdate())-year(ngaysinh) as tuoi


-----------muốn gộp hai bảng hay nhiều truy vấn  thì có cáu trúc 
(select.......) union (select......).....
nếu có các trường giống nhau theo kết quả ở trên thì nó chỉ giữ lại một dòng còn nếu muốn nó xuất hiện với đúng số lần nó xuất hiện thì thêm từ All
(select.......) union all (select......).....



-------------lấy một cái đã có trùng với cái đã biết là dùng vd
....
select hoten, namsinh
from sinhvien
where lop='cntt03'  namsinh= any(select hoten, namsinh
								from sinhvien
								where lop='cntt04')


--------theo mình nghĩ thì cách dùng 
in != not in 
not in= not exists

