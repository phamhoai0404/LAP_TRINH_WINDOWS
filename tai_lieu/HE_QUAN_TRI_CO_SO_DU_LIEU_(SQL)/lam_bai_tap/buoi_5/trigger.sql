 create database QLHangBan
 use QLHangBan


 create table hang
 (
	mahang char(10) not null primary key,
	tenhang nvarchar(50) not null,
	soluong int,
	giaban money)
go
create table hoadon(
	mahd char(10) not null primary key,
	mahang char(10) not null, 
	soluongban int,
	ngayban date,
	constraint fk_hoadon_hang foreign key (mahang) references hang(mahang))

insert into hang values
	('m1', N'Gáo dừa', 300, 40000),
	('m2', N'Dao kéo', 300, 40000),
	('m3', N'Thớt là', 300, 40000)


-----------------------------------------------------phần insert ---------------

create trigger lan1vephaninserthoadon 
on hoadon
for insert
as
	begin
		if(not exists(select * from hang inner join inserted on hang.mahang=inserted.mahang))/*chỗ phần này thầy bảo nó rằng buộc ngay khi mình tạo bảng có khóa ngoài rồi nhưng vẫn cứ viết vào thầy bảo vậy còn không test cái trường hợp sai này 
		*/
			begin
				raiserror (N'Không có mã hàng này ở bảng hàng nên không thêm được vào bảng hóa đơn!',16,1)
				rollback transaction
			end
		else
			begin
				declare @soluong int 
				declare @soluongban int
				set @soluong=(select soluong from hang inner join inserted on hang.mahang=inserted.mahang)
				set @soluongban=(select soluongban from inserted)
				if(@soluong<@soluongban)
					begin
						raiserror(N'Không bán được nha vì số lượng ít hơn !',16,1)
						rollback transaction
					end
				else
					begin
						update hang set soluong=soluong-@soluongban
						from hang inner join inserted on hang.mahang=inserted.mahang
					end		
			end
	end

insert into hoadon values('h1','m1', 4000,'7/7/2020')
insert into hoadon values('h2','m1', 40,'7/7/2020')
insert into hoadon values('h1','m2', 100,'7/4/2020')
insert into hoadon values('h3','m1', 50,'9/7/2020')
insert into hoadon values('h4','m3', 50,'12/7/2020')

select*from hang
select*from hoadon
-----------------------------------------

---------------------------phần delete-----------------
alter trigger vdphandeletecuahoadon
on hoadon
for delete
as
	begin
		/*declare @k char(10)
		set @k=(select mahd from deleted)
		if(not exists (select * from hang inner join deleted on hang.mahang=deleted.mahang))/*chỗ này vẫn là câu hỏi */
			begin
				raiserror(N'Mã này có tồn tại ở bảng hóa đơn đâu mà xóa !',16,1)
				rollback transaction
			endend
		elsebegin*/	
			
				raiserror(N'Xóa thành công sucessecful~!',16,1)
				update hang set soluong=soluong+(select sum(soluongban)
												 from deleted)/*chú ý cái phần này này  mình nghĩ mới ra cái kiểu như này thôi*/
												  						 
				from hang inner join deleted on hang.mahang=deleted.mahang
			
	end

delete from hoadon
where mahd='h22'

delete from hoadon
where mahang='m2'

select*from hang
select*from hoadon

-------------------------------update-----------
alter trigger phanupdate 
on hoadon
for update
as
	begin
		declare @truoc int
		declare @sau int
		set @truoc=(select soluongban from deleted)
		set @sau=(select soluongban from inserted)
		update hang set soluong=soluong+@truoc-@sau
		from hang inner join deleted on hang.mahang=deleted.mahang
				  inner join inserted on hang.mahang=inserted.mahang

	end
update hoadon
set soluongban=14
where mahang='m2'

select*from hang
select*from hoadon
