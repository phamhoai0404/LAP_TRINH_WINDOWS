---------------------------------------------------------
--SINH VIEN: NGUYỄN VĂN A
--LỚP: AV18
------------------------------------------------------------A. Tao CSDL DeptEmp
use master 
go
create database DeptEmp
on primary
(name='DeptEmp_Dat',Filename='D:DeptEmp_dat.mdf')
Log on
(name='DeptEmp_Log',Filename='D:DeptEmp_log.ldf')
--Su dung CSDL DeptEmp
go
use DeptEmp
go
--B: Tao cac bang du lieu trong CSDL
create table Department
(
DepartmentNo int not null primary key,
DepartmentName varchar(25) not null,
Location varchar(25) not null
)
create table Employee
(
	EmpNo int not null primary key,
	FName varchar(15) not null,
	LName varchar(15) not null,
	Job varchar(25) not null,
	HireDate datetime not null,
	Salary numeric not null,
	Commision numeric,
	DepartmentNo int,
	Constraint FK_DepartmentNo
	Foreign key(DepartmentNo) references Department(DepartmentNo)
)



--C: Chen du lieu vao 2 bang tren
--Department
insert into Department values(10,'Accounting','Melbourne')
insert into Department values(20,'Research','Adealide')
insert into Department values(30,'Sales','Sydney')
insert into Department values(40,'Operations','Perth')



--Employee
--Khong co truong Comision vi = null
insert into Employee(EmpNo,FName,LName,Job,HireDate,Salary,DepartmentNo) values(1,'John','Smith','Clerk','17-Dec-1980',800,20)
--co Comision vi <> null
insert into Employee(EmpNo,FName,LName,Job,HireDate,Salary,commision,DepartmentNo) values(2,'Peter','Allen','Salesman','20-Feb-1981',1600,300,30)
insert into Employee values(3,'Kate','Ward','Salesman',
'22-Feb-1981', 1250,500,30)
insert into Employee(EmpNo,FName,LName,Job,HireDate,Salary,DepartmentNo) values(4,'Jack','Jones','Manager','02-Apr-1981', 2975,20)
insert into Employee values(5,'Joe','Martin','Salesman', '28-Sep-1981',1250,1400,30)




--D: Thuc hien truy van
--1.
	Select * from Department
--2.
	Select * from Employee
--3.
select EmpNo,FName,LName 
from Employee
where FName='Kate'
--4.
Select FName+ ' ' +LName as 'Fullname',Salary,Salary*0.1 as 'Tang luong'
from Employee
--5.
select FName,Lname,HireDate fromEmployee
where YEAR(Hiredate)='1981'
order by LName ASC
--6.
select avg(salary)as 'TB Luong',max(salary) as 'Luong cao nhat',min(salary)as 'Luong thap nhat'
from Employee
group by DepartmentNo

--7.
select DepartmentNo,count(*) as 'So nguoi'
from Employee
group by DepartmentNo


--8.DepartmentName Trong bang Derpartment, con lai trong bang Employee
--Duoc ket noi thong qua truong DepartmentNo
select Department.DepartmentNo,Department.DepartmentName,
Employee.FName+' '+Employee.LName as 'Fullname',Employee.Job,Employee.Salary
from Department inner join Employee
on Department.DepartmentNo=Employee.DepartmentNo



--9. Tuong tu 8

--Tao bang phu SoNguoi de luu tongnguoi trong tung phong ban (DepartmentNo)
select count(*)AS 'Tongnguoi',Employee.DepartmentNo intoSoNguoi
from Employee
group by Employee.DepartmentNo

--Dung bang phu de ket noi
select Department.DepartmentNo,Department.DepartmentName,Department.Location,SoNguoi.Tongnguoi
from Department inner join SoNguoi
on Department.DepartmentNo=SoNguoi.Department