select * from nhap
select * from xuat
select * from ton
----------------------------------------
create trigger trgg_nhap
on nhap
for insert 
as
begin
	declare @mavt nchar(10)
	set @mavt=(select mavt from inserted)
	if(not exists( select * from ton where mavt=@mavt))
		begin
			raiserror (N' Không có vật tư này',16,1)
			rollback transaction
		end
	else
		begin
			declare @sln int 
			set @sln=(select soluongn from inserted)
			update ton  set soluongt=@sln+soluongt
			where mavt=@mavt
		end
end
insert nhap values('10222','1',20888,32,'2/8/2020')