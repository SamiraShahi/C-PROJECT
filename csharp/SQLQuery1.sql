CREATE database Employee
use Employee
go

create table emp(
id int not null primary key identity(1,1),
name nvarchar(255)not null,
address nvarchar(255)not null,
salary int not null
)
Insert into emp(name,address,salary)Values('sammy','Kirtipur','2000')
update emp set salary='5000' where id=2
Delete from emp where id=3
Select * from emp