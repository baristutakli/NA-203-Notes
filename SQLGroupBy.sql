
USE Northwind

--select * from Products


-- Ayný kategorideki ürünleri saydýk
-- select COUNT(SupplierID), CategoryID from  Products group by CategoryID

-- Employees =>Orders=>Customers=> Suppliers => Products


select * from [Order Details]
select sum([Order Details].Quantity),[Order Details].ProductID from [Order Details]
group by [Order Details].ProductID order by sum([Order Details].Quantity) desc;










select COUNT(*) FROM Customers;


-- stoktaki ürünlerin toplam tutarý
SELECT SUM(Products.UnitsInStock*Products.UnitPrice) as ToplamTutar from Products;

SELECT AVG(Products.UnitPrice) from Products; --Ortalama



-- Group by
-- Hangi ülkeden akç müþterin var
SELECT Customers.CompanyName,Customers.Country from Customers ORDER by Customers.Country 

SELECT COUNT(*)as MusteriSayisi,Country from Customers group by Country
having COUNT(CustomerID)>5

-- PRoducts : Hangi kategoriden kaç ürün var


-- Group by içindeki her þey select içinde olmalý
select COUNT(Products.ProductID), Categories.CategoryName from Products
inner join Categories on Products.ProductID= Categories.CategoryID 
group by Categories.CategoryName



-- Her kategorideki ürünlerin toplamý nedir

select SUM(Products.UnitPrice*Products.UnitsInStock) as Total from Products group by Products.CategoryID

select SUM(Products.UnitPrice*Products.UnitsInStock) as Total, Categories.CategoryName from Products
inner join Categories on Products.CategoryID=Categories.CategoryID
group by Categories.CategoryName




----CREATE VIEW  AnalizTablosu as
----Select Employees.FirstName as EmployeeName,Employees.Title as EmployeeTitle,Orders.OrderDate as OrderDate,
----Customers.ContactName, Customers.ContactTitle, [Order Details].Quantity as Quantity, [Order Details].UnitPrice,
----Products.ProductName as ProductName from Employees
----inner join Orders on Orders.EmployeeID = Employees.EmployeeID
----inner join Customers on Orders.CustomerID = Customers.CustomerID 
----inner join [Order Details] on Orders.OrderID = [Order Details].OrderID
----inner join Products on [Order Details].ProductID = Products.ProductID

----group by  AOrderDate  
----select EmployeeName, OrderDate, Quantity from AnalizTablosu group by OrderDate

--select * from AnalizTablosu 
--select SUM(UnitPrice*Quantity) from AnalizTablosu  where EmployeeName ='Steven' and ContactName LIKE '%Paul%'
--select SUM(UnitPrice*Quantity) from AnalizTablosu  where EmployeeName ='Steven'



-- London'daki hangi müsteri ne kadar siparis verdi?
-- Hangi müþteri kaç adet siparis verdi?(Her müsteri için siparis adedi.)  
-- Bu sorguya CompanyName ve City bilgileri eklensin.
-- Hangi sehirden kaç siparis gelmis.
-- Müsteri baþýna 10 dan fazla siparisi olan müsteriler(CompanyName) ve siparis adetleri;


--select count(Orders.OrderID),Customers.CustomerID  from Customers
--inner join Orders on Customers.CustomerID = Orders.CustomerID
--where Customers.City ='London'
--group by Customers.CustomerID



--select count(Customers.CustomerID),Customers.CustomerID  from Customers
--inner join Orders on Customers.CustomerID = Orders.CustomerID
--group by Customers.CustomerID


--select count(Orders.OrderID),Customers.City  from Customers
--inner join Orders on Customers.CustomerID = Orders.CustomerID
--group by Customers.City


select COUNT(Orders.OrderID),Customers.CompanyName from Customers
inner join Orders on Orders.CustomerID = Customers.CustomerID
group by Customers.CustomerID,Customers.CompanyName
having COUNT(Orders.OrderID)>10





