--Select
--ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
seLecT * from Products where CategoryID=1 or CategoryID=3

seLecT * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by ProductName

select * from Products order by CategoryID,ProductName

select * from Products order by UnitPrice desc --ascending (artan) descending(azalan)

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) Adet from Products where CategoryID=2

select CategoryID, count(*) Adet from Products where UnitPrice >= 20 group by CategoryID having count(*) <=10

select P.ProductID,P.ProductName,P.UnitPrice,C.CategoryName from Products P inner join Categories C on P.CategoryID = C.CategoryID where P.UnitPrice >=10

--DTO Data Transformation Object


select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null




