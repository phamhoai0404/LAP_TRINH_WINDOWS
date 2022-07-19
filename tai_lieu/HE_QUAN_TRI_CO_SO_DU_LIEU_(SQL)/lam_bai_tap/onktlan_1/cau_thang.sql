select * from nhap
select * from xuat
select * from ton

create view cau8
as	
	select month(ngayn) as 'thang'  , year(ngayn) as 'nam' , sum(soluongn) as 'tongsl'
	from nhap
	group by month(ngayn), year(ngayn)

select * from cau8
select * from nhap