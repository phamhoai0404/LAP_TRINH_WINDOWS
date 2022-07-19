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