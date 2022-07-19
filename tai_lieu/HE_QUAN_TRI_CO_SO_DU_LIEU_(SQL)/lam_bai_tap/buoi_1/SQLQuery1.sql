
use master 
go
create database MarkManagement 
on primary(
	name='MarkManagement', filename='D:\MarkManagement.mdf',
	size=5MB, maxsize=50MB, filegrowth=2MB
)
log on(
	name='MarkManagement', filename='D:\MarkManagement.ldf',
	size=5MB, maxsize=50MB, filegrowth=10%
)
go 
use MarkManagement 
go

create table Students(
	StudentID Nvarchar(12) not null primary key,
	StudentName Nvarchar(25) not null,
	DateofBirth Datetime not null,
	Email Nvarchar(40),
	Phone Nvarchar(12),
	Class Nvarchar(10),
)
create table Subjects(
	SubjectID Nvarchar(10) not null primary key,
	SubjectName Nvarchar(25) not null,
)
create table Mark(
	StudentID Nvarchar(12) not null,
	SubjectID Nvarchar(10) not null,
	Dates Datetime,
	Theory Tinyint,
	Practical Tinyint,
	constraint PK_Mark primary key(StudentID, SubjectID),
	constraint fk_Mark_Students foreign key(StudentID) references Students(StudentID)
		on delete cascade on update cascade,
	constraint fk_Mark_Subjects foreign key(SubjectID) references Subjects(SubjectID)
		on delete cascade on update cascade,
)
-----
insert into Students values('AV0807005', N'Mai Trung Hiếu', N'11/10/1989', N'trunghieu@yahoo.com', N'0904115116', N'AV1')
insert into Students values('AV0807006', N'Nguyễn Quý Hùng', N'2/12/1989', N'quyhung@yahoo.com', N'090455516', N'AV1')
insert into Students values('AV0807007', N'Đỗ Đắc Huỳnh', N'11/10/1989', N'dachuynh@yahoo.com', N'0904187878', N'AV1')
insert into Students values('AV0807008', N'An Đăng Khuê', N'11/10/1989', N'dangkhue@yahoo.com', N'0904115446', N'AV1')
insert into Students values('AV0807009', N'Nguyễn Thị Tuyết Lan', N'11/10/1989', N'tuyetlan@yahoo.com', N'0904115116', N'AV1')
insert into Students(StudentID, StudentName, DateofBirth, Email, Class) values('AV0807010', N'Đinh Phụng Long', N'11/10/1989', N'phunglong@yahoo.com', N'AV1')
insert into Students(StudentID, StudentName, DateofBirth, Email, Class) values('AV0807012', N'Nguyễn Tuấn Nam', N'11/10/1989', N'tuannam@yahoo.com', N'AV1')
----
insert into Subjects values('S001', N'SQL')
insert into Subjects values('S002', N'Java Simplefiled')
insert into Subjects values('S003', N'Active Server Page')
-----
insert into Mark values('AV0807005', 'S001', 8, 25, 6/5/2008)insert into Mark values('AV0807006', 'S002', 16, 30, 6/5/2008)insert into Mark values('AV0807007', 'S001', 10, 25, 6/5/2008)insert into Mark values('AV0807009','S003', 7, 13, 6/5/2008)insert into Mark values('AV0807010','S003',9 ,16 , 6/5/2008)insert into Mark values('AV0807011', 'S002', 8, 30,  6/5/2008)insert into Mark values('AV0807012', 'S001',7 ,31 , 6/5/2008)insert into Mark values('AV0807005', 'S002',12 ,11, 6/6/2008)insert into Mark values('AV0807009', 'S003',11 ,20 , 6/6/2008)insert into Mark values('AV0807010', 'S001', 7, 6, 6/6/2008)
select * from Students
select * from Subjects
select * from Mark