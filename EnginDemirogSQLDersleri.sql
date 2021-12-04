USE Northwind

-- Stokta olmayýp siparisi olan ürünler.
select * from Products where UnitsInStock =0 and UnitsOnOrder>0;


-- OR ile çalýþmak 
-- stokta olmayan veya sipariþi olmayan ürünleri listeleyin
select * from Products where UnitsInStock=0 or UnitsOnOrder=0;

--  not and
-- ismi PErth PAsties olmayan ve sýfýr stoðu bulunan ürünler
select * from Products where not ProductName ='Perth Pasties' and UnitsInStock =0;

-- Order by
-- Verileri listelediðimizde belli bir sýrada gelmesini istiyorsak kullanýrýz
Select * from Products order by ProductName;

select * from Products order by UnitPrice;

-- asc = ascending
-- desc = descending

-- ürün isimleri ve birim fiyata göre sýralama iþlemi
--Aþaðýdaki kodda önce ürün ismine göre sýralayacak sonra ayný isimde olan ürünleri birim fiyatýna göre sýralayacak
select * from Products order by SupplierID, UnitPrice desc
-- Burada sýralama önemlidir Supplier a göre mi unitPrice a göremi
-- olduðuna bakar


select Products.ProductName,Suppliers.Country,Suppliers.City,Categories.CategoryName from Products
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
inner join Categories on Categories.CategoryID = Products.CategoryID
group by Products.ProductName,Suppliers.Country,Suppliers.City,Categories.CategoryName


-- hangi kategoride kaç ürün var
select COUNT(Products.ProductID),Categories.CategoryName from Products
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
inner join Categories on Categories.CategoryID = Products.CategoryID
group by Categories.CategoryName 

-- Lýke 
-- bir ürünün diyelim ki ismini tam haýtrlamýyoruz o zaman 
-- like kullanabiliriz

-- örnek 1: con ile baþlayan kategoriler
select COUNT(Products.ProductID),Categories.CategoryName from Products
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
inner join Categories on Categories.CategoryID = Products.CategoryID
where CategoryName LIKE 'con%'
group by Categories.CategoryName 

-- için de Con olanlar için %Con% kullanýrýz

-- örnek 1: con ile baþlayan kategoriler
select COUNT(Products.ProductID),Categories.CategoryName from Products
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
inner join Categories on Categories.CategoryID = Products.CategoryID
where CategoryName LIKE '%con%'
group by Categories.CategoryName 

-- Between 
select * from Products where UnitPrice between 10 and 46 order by UnitPrice asc

-- IN (1,2) categorisi 1 veya 2 olanalr
select * from Products where Products.CategoryID in (1,2)

--Count: Bir þeyin sayýsýný bulmak isyitoruz
-- Örneðin bugün yaptýðýmýz satýþlarýn sayýsýný öðrenmek istiyoruz

-- ürün sayýsý
Select Count(*)from  Products
-- müþteri sayýsý 
select Count(Customers.CustomerID) from Customers


-- Min : en düþük  Max en yüksek
-- AVg average
Select Min(UnitPrice) from Products

-- kaç para kazandýk
select Sum(UnitPrice*Quantity) as Kazanc from [Order Details]

-- Rand() bize rastgele sayý üretmeye yarýyor


--  LEFT 
-- soldan 3 karakteri getiriyor
select LEFT('Engin Demirog',3)
-- LEN 
select LEN('Engin Demirog')
--LOWER
-- Trim fonksiyonu, bir metnin baþýndaki ve sonundaki boþlularý atýyor

-- mesela bir ismin baþýnda boþluklar var ie where onu getirmez
-- bu noktada trim fonksiyonunu çalýþtýrabilirzinz

select TRIM(Products.ProductName) from Products where TRIM(ProductName) = 'chai'

-- REVERSE tersine çevirir
-- CHARINDEX: cümlenin içinde bir yerlerde geçiyorsa 1den itibaren arýyoruz yeri önemli deðil
-- sýk kullanýlan foksiyonlardan biridir
select ProductName from Products
where CHARINDEX('anton',ProductName,1)>0

-- REPLACE() deðiþtirme iþlemi

SELECT REPLACE('Engin DEmirog','','_');-- boslugu _ ile degistiriyoruz

-- SUBSTRING metni parçalamaya yarar
SELECT SUBSTRING('Engin Demirog',1,5)
--ASCÝÝ, Char,


-- Distinct: bir sutundaki tekrarlayan kayýtlarý tekrarlamadn bir kerede getirmeye yarar
-- aslýnda gruplama ifadesidir eðer contactName i de yazýp çaðýrýsak hata alýrýz

select distinct(Country) from Customers order by Country

-- Group by ile çalýþmak
-- arka planda her grup için bir list oluþturuyor saymak istersen count kullanabilrisin

-- Hangi ülkede kaç müþreti var

select Country from Customers group by Country

select Country,Count(*) as Adet from Customers group by Country
-- Bu üke ve þehirden kaçar tane müþteri var
select Country,City,Count(*) as Adet from Customers group by Country,City

-- Ülke ve þehri bazýnde birden fazla müþterimiz olan yerler neresidir
select Country,City,Count(*) as Adet from Customers
where City is not NULL
group by Country,City
having Count(*)>1
Order by Count(*) desc

-- having cumulatif þeyler için kullanýlýr Count gibi

--inner join
-- not çýktýyý copy edip excele atabilrisin
select Products.ProductName, o.OrderDate, od.Quantity*od.UnitPrice from Products inner join [Order Details] od
on Products.ProductID = od.ProductID 
inner join ORders o
on o.OrderID = od.OrderID
order by ProductName, o.OrderDate

-- LEFT JOÝN eþleþmeyen verileri de getirir
-- Hem join olanlarý getiriyor hem join olmayanlarý getiriyor

-- hiç satamadýðýmýz ürün var mý
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
where od.ProductID is null

--Bir kategoride bulunan ürünlerden birim olarak en çok satýlan 5 ürünü 
--veya toplam kazancý   en fazla olan 5 ürünü azalacak þekilde sýralayan ve
--son olarak ise bu ürünleri ülkelere göre gruplandýran komutu yazýnýz

select top 5 Products.UnitsOnOrder, Products.ProductName from Products order by Products.UnitsOnOrder desc


select top 5 p.UnitsOnOrder, (od.UnitPrice*od.Quantity) as kazanc from Products p
inner join [Order Details] od on od.ProductID =p.ProductID
group by (od.UnitPrice*od.Quantity),p.UnitsOnOrder
order by p.UnitsOnOrder desc, (od.UnitPrice*od.Quantity) desc


-- Hangi üründen kaç tane satmýþýz?

select Count(*),ProductID from [Order Details] od group by od.ProductID

-- Hangi kategoriden kaç tane satmýþýz
 
 select c.CategoryName,Count(*) as adet from Products p inner join Categories c
 on p.CategoryID = c.CategoryID
 inner join [Order Details] od
 on od.ProductID = p.ProductID
 group by c.CategoryName

-- Bir sütünda çalýþanýn ismi  diðer sütunda ise onun üstü

select Employees.FirstName as [Employee Name], Employees.ReportsTo as Manager  from Employees where ReportsTo is not null

--
select Employees.FirstName as [Employee Name], Employees.ReportsTo as Manager  from Employees
where  Employees.EmployeeID = Employees.ReportsTo


