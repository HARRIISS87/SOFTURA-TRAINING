create database WORKWISHERS
go
create table Regform
(
Sno int identity(1,1),
Firstname char(25),
Lastname char(25),
DOB varchar(20),
Age int
check(age>=18),
Address varchar(100),
Contact char(10),
Gender varchar(10)
check (Gender in('Male','Female','Transgender')),
Qualification varchar(10)
)
insert into Regform(Firstname ,Lastname ,DOB ,Age,Address,Contact,Gender ,Qualification)
values('S','HARIS','13-06-2002',19,'ARANI','7530076615','Male','BE')
exec sp_help 'Regform'
