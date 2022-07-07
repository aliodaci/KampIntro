--Select 
--ANSI
--Select ContactName,CompanyName,City from Customers

select ContactName Adi,CompanyName Sirket,City Sehir from Customers
select * from Customers where City='London'

--case insensitive
select * from Products
select * from Products where CategoryID=1 or CategoryID=3
select * from Products where CategoryID=1 and UnitPrice>=10

select *  from Products order by ProductName asc

select * from Products order by CategoryID, ProductName

Select * from Products order by UnitPrice desc --ascending --desc(descending)

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) Adet from Products where CategoryID=2

select categoryID, count(*) from Products group by CategoryID

select categoryID, COUNT(*) from Products group by CategoryID having COUNT(*)<10

--select categoryID, count(*) from Products group by 
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID where Products.UnitPrice>10

--DTO Data Transformation object
--inner join : sadece eşleşen kayıtları getirir. inner join 2 tabloda da eşleşiyorsa getirir.
--left join : solda olup sağda olmayanların da getirir.
--right join : sağda olup solda olmayanları getirir.
select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o on o.OrderID=od.OrderID

select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

select distinct country from Customers
