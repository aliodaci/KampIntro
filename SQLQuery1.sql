
select distinct country from Customers
select count(distinct country) from Customers
select * from Customers where Country='Mexico';
select * from Products where UnitPrice between 50 and 60
select * from Customers where City like 's%';
select * from Customers where City in('London','Paris');
select * from Customers where Country='Germany' and City='Berlin';
select * from Customers where City='Berlin' or City='München';
Select * from Customers where Country='Germany' or Country='Spain';
select * from Customers where not Country='Germany';
SELECT * FROM Customers WHERE Country='Germany' AND (City='Berlin' OR City='München');
SELECT * FROM Customers WHERE NOT Country='Germany' AND NOT Country='USA';
select * from Customers order by Country
select * from Customers order by Country asc
select * from Customers order by Country, CompanyName
select * from Customers order by Country ASC, ContactName desc
------------------------------------------
insert into Customers(CustomerName, ContactName, Address,City, PostalCode, Country) values('Cardinal','Tom B. Erichsen', 'Skangen 21','Stavanger', '4009','Norway');
----------------------------------
select ProductName from Products where ProductName is null;

select CompanyName,ContactName,Address from Customers where Address is not null;

-----------------------------------
update Customers set ContactName='Alfred Schmidt', City='Frankurt' where CustomerID = 'ALFKI';
--------------------------------------
Delete from Customers where ContactName='Alfred Schmidt';

select top 3 * from Customers
select * from Customers limit 
select * from Customers fetch first 3 rows only;
select top 50 percent * from Customers
select min(UnitPrice) as SmallestPrice from Products
select max(UnitPrice) as LargestPrice from Products
select count(Freight) from Orders
select count(ProductID) from Products
select avg(UnitPrice) from Products
select sum(Quantity) from [Order Details]

select * from Customers where ContactName not like 'a%';
select * from Customers where City like 'ber%';
select * from Customers where City like'_ondon';
select * from Customers where City like '[!bsp]%';
select * from Customers where City like '[a-c]%';
select * from Customers where City not like '[bsp]%';

Select * from Customers where Country in('Germany','France','UK');
select * from Customers where Country not in ('Germany','France', 'UK');
select * from Customers where Country in (Select Country from Suppliers)
select * from Products where UnitPrice between 10 and 20
select * from Products where UnitPrice not between 10 and 20
select * from Products where UnitPrice between 10 and 20 and CategoryID in (1,2,3)
select * from Products where ProductName between 'Carnarvon Tigers' and 'Mozzarella di Giovanni' order by ProductName
SELECT * FROM Products WHERE ProductName BETWEEN 'Carnarvon Tigers' AND 'Chef Antons Cajun Seasoning' ORDER BY ProductName;
SELECT * FROM Products WHERE ProductName NOT BETWEEN 'Carnarvon Tigers' AND 'Mozzarella di Giovanni' ORDER BY ProductName;
SELECT * FROM Orders WHERE OrderDate BETWEEN '#07/01/1996#' AND '#07/31/1996#';
SELECT * FROM Orders WHERE OrderDate BETWEEN '1996-07-01' AND '1996-07-31';
select CustomerID as ID, ContactName as Customer from Customers
select ContactName as Customer, ContactName as [Contact Person] from Customers

select o.OrderID, o.OrderDate,c.ContactName from Customers as c, Orders as o where c.ContactName='Around' and c.CustomerID=o.CustomerID
select Orders.OrderID,Orders.OrderDate,Customers.ContactName from Customers,Orders where Customers.ContactName='Alejandra Camino' and Customers.CustomerID=Orders.CustomerID
select * from Customers order by ContactName asc
-------------------------------------------------
select Orders.OrderID, Customers.ContactName, Orders.OrderDate from Orders inner join Customers on Orders.CustomerID=Customers.CustomerID
select Orders.OrderID,Customers.ContactName,Shippers.CompanyName from Orders inner join Customers on Orders.CustomerID=Customers.CustomerID inner join Shippers on Orders.ShipperID=Shippers.ShipperID
select Customers.ContactName, Orders.OrderID from Customers left join Orders on Customers.CustomerID=orders.CustomerID order by Customers.ContactName
select Orders.OrderID, Employees.LastName, Employees.FirstName from Orders right join Employees on Orders.EmployeeID=Employees.EmployeeID order by Orders.OrderID
select Customers.ContactName, Orders.OrderID from Customers full outer join Orders on Customers.CustomerID=Orders.CustomerID order by Customers.ContactName
---------------------------------------------------
select A.ContactName as ContactName1, B.ContactName as ContactName2, A.City from Customers A, Customers B where A.CustomerID<>B.CustomerID and a.City=b.City order by a.City
--------------
select City from Customers union select city from Suppliers order by city
select city from Customers union all select city from Suppliers order by city
select city,country from Customers where Country='Germany' union ALL select city, country from Suppliers where Country='Germany' order by city
select 'Customer' as Type,ContactName, City,Country from Customers union select 'Supplier', ContactName, City, Country from Suppliers
-----------------------
select count(CustomerID),Country from Customers Group by Country
select Shippers.CompanyName,COUNT(Orders.OrderID) as NumberOfOrders from Orders left join Shippers on Orders.ShipperID=Shippers.ShipperID
-------------------------
select count(CustomerID),country from Customers group by Country having count(CustomerID)>5
select count(CustomerID),country from Customers group by Country having count(CustomerID)>5 order by count(CustomerID) desc
select Employees.LastName, count(orders.OrderID) as Numberoforders from Orders inner join Employees on Orders.EmployeeID=Employees.EmployeeID group by LastName having count(orders.OrderID)>10
select Employees.LastName, count(Orders.OrderID) as Numberoforders from Orders inner join Employees on Orders.EmployeeID=Employees.EmployeeID group by LastName having count(Orders.OrderID)>10
select Employees.LastName,COUNT(Orders.OrderID) as Numberoforders from Orders inner join Employees on Orders.EmployeeID=Employees.EmployeeID where LastName='Davolio' or LastName='Fuller' group by LastName having count(Orders.OrderID)>25
----------------------------
select ContactName from Suppliers where exists (select ProductName from Products where Products.SupplierID=Suppliers.SupplierID and UnitPrice<20)
select ContactName from Suppliers where exists(select ProductName from Products where Products.SupplierID=Suppliers.SupplierID and UnitPrice=22)
--------------------------------
select ProductName from Products where ProductID = Any(select ProductID from [Order Details]where Quantity=10)
select ProductName from Products where ProductID=Any(select ProductID from [Order Details] where Quantity>99)
select ProductName from Products where ProductID=All(select ProductID from [Order Details] where Quantity=10)
---------------------------------
select * into CustomersBackup2017 from Customers
select * into CustomersBackup2017 IN 'Backup.mdb' from Customers
----------------------------------------
select ContactName into CustomersBackup2017 from Customers

------------------------------------------------------
select Products.ProductName as [Ürün adı], sum(Products.UnitPrice*[Order Details].Quantity) as ToplamMiktar from [Order Details] inner join Products on [Order Details].ProductID=Products.ProductID join Orders on Orders.OrderID=[Order Details].OrderID group by Products.ProductName
