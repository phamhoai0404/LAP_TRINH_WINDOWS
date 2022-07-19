--- tao database  
use master 
go
create database DeptEmp 
on primary(
	name='DeptEmp', filename='D:\DeptEmp.mdf',
	size=5MB, maxsize=50MB, filegrowth=2MB
)
log on(
	name='DeptEmp', filename='D:\DeptEmp.ldf',
	size=5MB, maxsize=50MB, filegrowth=10%
)
go 
use DeptEmp 
go
--- tao bang 
create table Department(
	DepartmentNo integer not null primary key,
	DepartmentName char(25) not null,
	Location char(25) not null,
)
create table Employee(
	EmpNo integer not null primary key,
	Fname varchar(15) not null,
	Lname varchar(15) not null,
	Job varchar(25) not null,
	HireDate datetime not null,
	Salary numeric not null,
	Commision numeric,
	DepartmentNo integer,
	constraint fk_Employee_Department foreign key(DepartmentNo) references Department(DepartmentNo )
		on delete cascade on update cascade
) 
----------
insert into Department values(10, 'Accounting',  'Melbourne')
insert into Department values(20, 'Research', 'Adealide')
insert into Department values(30,'Sales' ,'Sydney')
insert into Department values(40, 'Operations', 'Perth')
--------
insert into Employee(EmpNo,Fname, Lname, Job, HireDate, Salary, DepartmentNo) values(1, 'John', 'Smith', 'Clerk', N'17-Dec-1980' ,800, 20)
insert into Employee values(2,'Peter','Allen','Salesman', '20-Feb-1981', 100, 300 ,30)
insert into Employee values(3, 'Kate', 'Ward', 'Salesman', '22-Feb-1981', 1250 ,500, 30)
insert into Employee(EmpNo,Fname, Lname, Job, HireDate, Salary, DepartmentNo) values(4,'Jack' ,'Jones', 'Manager', '02-Apr-1981' ,2975,  20)
insert into Employee values(5,'Joe', 'Martin', 'Salesman', '28-Sep-1981', 1250, 1400, 30)

---------hien bang
select * from Department
select * from Employee
1. Hiển thị nội dung bảng Department
select * from Department; 

2. Hiển thị nội dung bảng Employee
select * from Employee;

3. Hiển thị employee number, employee first name và employee last name từ bảng Employee mà employee first name có tên là ‘Kate’
select EmpNo, Fname, Lname
from Employee
where Fname='Kate'

4. Hiển thị ghép 2 trường Fname và Lname thành Full Name, Salary,
10%Salary (tăng 10% so với lương ban đầu). 
select Fname+' '+Lname as'Ten',Salary, Salary*0.1 as 'Tangluong'
from Employee

5. Hiển thị Fname, Lname, HireDate cho tất cả các Employee có HireDate là
năm 1981 và sắp xếp theo thứ tự tăng dần của Lname.select Fname, Lname, HireDatefrom Employeewhere year(HireDate)='1981'order by Lname asc6. Hiển thị trung bình(average), lớn nhất (max) và nhỏ nhất(min) của
lương(salary) cho từng phòng ban trong bảng Employee.
select AVG( Salary) as'TrungBinh', max( Salary) as 'CaoNhat', min( Salary) as 'ThapNhat'
from Employee
group by DepartmentNo

7. Hiển thị DepartmentNo và số người có trong từng phòng ban có trong bảng
Employee.
select DepartmentNo, count(*) as 'SoNguoi'
from Employee
group by DepartmentNo

8. Hiển thị DepartmentNo, DepartmentName, FullName (Fname và Lname),
Job, Salary trong bảng Department và bảng Employee.select Department.DepartmentNo , Department.DepartmentName, Employee.Fname +'' +Employee.Lname  as 'FullName',Employee.Job, Employee.Salary
from Department inner join Employee on Department.DepartmentNo=Employee.DepartmentNo

9. Hiển thị DepartmentNo, DepartmentName, Location và số người có trong
từng phòng ban của bảng Department và bảng Employee.select Department.DepartmentNo,Department.DepartmentName,Department.Location, count(Department.DepartmentNo) as 'SoNguoi'
from Department inner join Employee on Department.DepartmentNo=Employee.DepartmentNo
group by Department.DepartmentNo,Department.DepartmentName,Department.Location

10. Hiển thị tất cả DepartmentNo, DepartmentName, Location và số người có
trong từng phòng ban của bảng Department và bảng Employee
select Department.DepartmentNo,Department.DepartmentName,Department.Location, count(Department.DepartmentNo) as 'SoNguoi'
from Department inner join Employee on Department.DepartmentNo=Employee.DepartmentNo
group by Department.DepartmentNo,Department.DepartmentName,Department.Location