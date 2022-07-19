II. table valued function
(Rất hay sử dụng)
--trả về 1 bảng dữ liệu (dữ liệu trả về kiểu table)
--cú pháp hàm:
create function tenham(@thambien1 kieudl1,@thambien2 kieudl2,...)
returns @bangtam table(
                       truong1 kieudl11,
    truong2 kieudl22,
    ...
    )
as
begin
   ............
   insert into @bangtam
                   select truong1,truong2,...
    from ...
    .............
   return
end
---------------------
vi du:viet ham dua ra cac vat tu duoc nhap vao ngay x
nhap vao  tu ban phim
--> tham bien: ngay x-> date
--> nhieu vt duoc nhap 1 ngay -> table
create function vdu1(@ngayn date)
returns @bang table(
                    mavt nchar(10),
					 tenvt nvarchar(20),
					 soluongt int
    )
as
begin
  insert into @bang
                select ton.mavt,tenvt,soluongt
				 from ton inner join nhap on ton.mavt=nhap.mavt
				 where ngayn=@ngayn
  return
end
--gọi hàm table:
select * from tenham(doiso1,doiso2,...)
--
select * from nhap
select * from vdu1('03/5/2020')
--
--xoa ham: drop table tenham
-- sua lai dinh nghia ham:
thay the  create <-> alter va chay lai ham