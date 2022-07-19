
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
	Theory Tinyint,
	Practical Tinyint,
	Dates Datetime,
	constraint PK_Mark primary key(StudentID, SubjectID),
	constraint fk_Mark_Students foreign key(StudentID) references Students(StudentID)
		on delete cascade on update cascade,
	constraint fk_Mark_Subjects foreign key(SubjectID) references Subjects(SubjectID)
		on delete cascade on update cascade,
)
-----
insert into Students values('AV0807005', N'Mai Trung Hiếu', N'10/11/1989', N'trunghieu@yahoo.com', N'0904115116', N'AV1')
insert into Students values('AV0807006', N'Nguyễn Quý Hùng', N'12/2/1988', N'quyhung@yahoo.com', N'090455516', N'AV2')
insert into Students values('AV0807007', N'Đỗ Đắc Huỳnh', N'1/2/1990', N'dachuynh@yahoo.com', N'0904187878', N'AV2')
insert into Students values('AV0807008', N'An Đăng Khuê', N'6/3/1986', N'dangkhue@yahoo.com', N'0904115446', N'AV1')
insert into Students values('AV0807009', N'Nguyễn Thị Tuyết Lan', N'7/12/1989', N'tuyetlan@yahoo.com', N'0904115116', N'AV2')
insert into Students(StudentID, StudentName, DateofBirth, Email, Class) values('AV0807011', N'Đinh Phụng Long', N'12/2/1989', N'phunglong@yahoo.com', N'AV1')
insert into Students(StudentID, StudentName, DateofBirth, Email, Class) values('AV0807012', N'Nguyễn Tuấn Nam', N'3/2/1989', N'tuannam@yahoo.com', N'AV1')
----
insert into Subjects values('S001', N'SQL')
insert into Subjects values('S002', N'Java Simplefiled')
insert into Subjects values('S003', N'Active Server Page')
-----
insert into Mark values('AV0807005', 'S001', 8, 25, N'6/5/2008')
insert into Mark values('AV0807006', 'S002', 16, 30, N'6/5/2008')
insert into Mark values('AV0807007', 'S001', 10, 25, N'6/5/2008')
insert into Mark values('AV0807009','S003', 7, 13,N'6/5/2008')
insert into Mark values('AV0807010','S003',9 ,16 , N'6/5/2008')
insert into Mark values('AV0807011', 'S002', 8, 30, N'6/5/2008')
insert into Mark values('AV0807012', 'S001',7 ,31 , N'6/5/2008')
insert into Mark values('AV0807005', 'S002',12 ,11, N'6/6/2008')
insert into Mark values('AV0807009', 'S003',11 ,20 , N'6/6/2008')
insert into Mark values('AV0807010', 'S001', 7, 6, N'6/6/2008')

1. Hiển thị nội dung bảng Students
select * from Students

2. Hiển thị nội dung danh sách sinh viên lớp AV1
select *
from Students
where Class='AV1'


3. Sử dụng lệnh UPDATE để chuyển sinh viên có mã AV0807012 sang lớp
AV2
UPDATE  Students  
SET  Class='AV2'
where StudentID='AV0807012'

4. Tính tổng số sinh viên của từng lớp
select Class, count(*) as 'SoSinhVien'
from Students
group by Class

5. Hiển thị danh sách sinh viên lớp AV2 được sắp xếp tăng dần theo
StudentNameselect *
from Students
where Class='AV1'
order by StudentName asc

6. Hiển thị danh sách sinh viên không đạt lý thuyết môn S001 (theory <10) thi
ngày 6/5/2008select Students.StudentID,Students.StudentNamefrom Students inner join Mark on Students.StudentID=Mark.StudentIDwhere Mark.Theory<10 and Mark.Dates='6/5/2008'7. Hiển thị tổng số sinh viên không đạt lý thuyết môn S001. (theory <10)select  count(*) as 'SoLuong'from Markwhere Theory<108. Hiển thị Danh sách sinh viên học lớp AV1 và sinh sau ngày 1/1/1980select StudentID, StudentName, DateofBirthfrom Studentswhere Class='AV1' and DateofBirth>'1/1/1980'9. Xoá sinh viên có mã AV0807011delete from Studentswhere StudentID='AV0807011'10.Hiển thị danh sách sinh viên dự thi môn có mã S001 ngày 6/5/2008 bao gồm các trường sau : StudentID, StudentName, SubjectName, Theory, Practical,Dates
select Students.StudentID, Students.StudentName,Subjects.SubjectName, Mark.Theory, Mark.Practical, Mark.Dates
from ((Mark inner join Students  on Students.StudentID=Mark.StudentID)
			inner join Subjects  on Mark.SubjectID=Subjects.SubjectID)
where  Subjects.SubjectID='S001' and Mark.Dates='6/5/2008'