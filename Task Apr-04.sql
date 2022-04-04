use AdventureWorks2019
go
--TASK 1
--USING COUNT()
select *from  [Production].[ProductCostHistory]
select  COUNT(+[StandardCost]) Totalnoofrows
from [Production].[ProductCostHistory]
--USING SUM()
select SUM([StandardCost]) SumCost
from [Production].[ProductCostHistory]
--USING DATEDIFF()
select DATEDIFF(YY,StartDate,EndDate) datedifference
from [Production].[ProductCostHistory]
--USING ADDDATE()
SELECT DATEADD(year, 3, '2017/08/25') AS DateAdd
--USING CONVERT()
SELECT CONVERT(int,88.77);
--USING LEFT()
SELECT LEFT('KEERTHU', 3) AS ExtractString;
--USING LEN()
select LEN('HARISWAR')
--USING REVERSE()
select REVERSE('HARIS WAR')

--TASK 2
create function fn_RupeesC(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'₹'+@amount)
end
select BusinessEntityID,dbo.fn_RupeesC(rate) as Rupees
from HumanResources.EmployeePayHistory

--TASK 3
create table tbl_student
(
Sno int,
StuName varchar(20),
StuAge int
)
alter table tbl_student
add Gender char(1)
select * from tbl_student
alter table tbl_student
add MobileNO int
insert into tbl_student values(1,'HARIS',19,'M',7530077615)
alter table tbl_student
alter column MobileNO char(10)
create view task3
as
select [Sno],[StuName],[StuAge]
from [dbo].[tbl_student]
go
select *from task3
insert into tbl_student values(2,'Raveena',19,'F',7530077615)

--TASK 4


--TASK 5
select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))

--TASK 6
select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]

--TASK 7
select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name