USE Northwind;-- Kullanýlan veri tabanýný seç
-- Northwind veri tabanýndan ürünler ve ürün kategorilerini getiren inner join li sorguyu yazýnýz
-- Daha sonra ProductWithCategory isminde bir View ile
-- ProductID, ProductName, SupplierID, UnitPrice, UnitsInStock ve
-- Categories tablosunun CategoryName, Description kolonlarýný listeleyiniz
 
--CREATE VIEW 

--Select *,Categories.CategoryName from Products
--inner join Categories on Products.CategoryID = Categories.CategoryID
-- ProductWithCategory adlý bir view oluþturduk
--Create View ProductWithCategory AS
--SELECT Products.ProductID, Products.ProductName, Products.SupplierID, Products.UnitPrice, Products.UnitsInStock,
--Categories.CategoryName, Categories.Description 
--from Products inner join Categories on Products.CategoryID = Categories.CategoryID

--ALTER VIEW ProductWithCategory AS
--SELECT Products.ProductID, Products.ProductName, Products.SupplierID, Products.UnitPrice, Products.UnitsInStock,
--Categories.CategoryName, Categories.Description 
--from Products inner join Categories on Products.CategoryID = Categories.CategoryID

-- VIEW SORGULAMA
-- Tüm kolonlarý getir.
--SELECT * FROM ProductWithCategory;

-- Yukarýdaki sorguya ek olarak suppliers tablosundan CompanyName(supplier) ve phone(suplier phone) bilgisini getirecek þekilde 
-- p_categorySupplier isminde bir View tanýmlayýnýz


--CREATE VIEW P_CategorySupplier as 
--SELECT Products.ProductID, Products.ProductName, Products.SupplierID, Products.UnitPrice, Products.UnitsInStock,
--Categories.CategoryName, Categories.Description, Suppliers.CompanyName, Suppliers.Phone 
--from Products 
--inner join Categories on Products.CategoryID = Categories.CategoryID
--inner join Suppliers on Products.SupplierID = Suppliers.SupplierID


-- P_CategorySupplier view a güncelleme iþlemi yaptýk

--ALTER VIEW P_CategorySupplier AS
--SELECT Products.ProductID, Products.ProductName, Products.SupplierID, Products.UnitPrice, Products.UnitsInStock,
--Categories.CategoryName, Categories.Description, Suppliers.CompanyName as supplier, Suppliers.Phone as 'Supplier Phone'
--from Products 
--inner join Categories on Products.CategoryID = Categories.CategoryID
--inner join Suppliers on Products.SupplierID = Suppliers.SupplierID

-- VIEW SORGULAMA
-- Tüm kolonlarý getir.
--SELECT * FROM P_CategorySupplier;

-- ORders tablosunda OrderDAte i 1998 olanlarý döndüren view Yazýnýz

--CREATE VIEW P_TariheGoreGoner as
--select * from Orders where Orders.OrderDate ='1998'
--select * from Orders where Orders.OrderDate LIKE '%1998%'


--select * from Orders where Orders.ShipCountry ='USA'
--CREATE VIEW USA_Orders as
--select Orders.OrderID, Orders.CustomerID, Employees.FirstName
--from Orders inner join Employees on Orders.EmployeeID = Employees.EmployeeID where Orders.ShipCountry ='USA'

-- select  (UnitPrice*Quantity) as TotalPrice from [Order Details] where OrderID = 10248

-- Almanya'ya yapýlan satýþlardan 200 dolardan fazla olanlarýn TotalPrice, CustomerID, ShipCity
-- Bilgilerini yazdýran View



Select Customers.CompanyName as CustomerName ,(UnitPrice*Quantity) as TotalPrice, Orders.OrderID,Orders.ShipCountry from [Order Details]
inner join Orders on [Order Details].OrderID = Orders.OrderID
inner join Customers on Customers.CustomerID = Orders.CustomerID
where Orders.ShipCountry = 'Germany' and (UnitPrice*Quantity) > 200 Order by (UnitPrice*Quantity) ASC;




Go -- program bloklar gibi bloklar
DECLARE @sayi int;-- deðiþken tanýmladýk sadece bu go bloklarý içinde geçerli
SET @sayi =15;
-- PRINT @sayi; normal yazý olarak yazdýrdýk
-- SELECT @sayi; -- tablo olarak ekrana yazdýrdýk
Go

Go
DECLARE @kategoriSayi int;
select  @kategoriSayi =  COUNT(Categories.CategoryID) FROM Categories;
PRINT @kategoriSayisi;
GO

PRINT GETDATE();--Tarih yazar

DECLARE @sayi int;
SET @sayi =10;
PRINT CONVERT(NVARCHAR(5),@sayi)
PRINT CONVERT(NVARCHAR(3),123)
PRINT TRY_CONVERT(NVARCHAR(3),1233) -- 1233 sayýsýný nvarchar a çevir ekrana yaz


PRINT RIGHT('MEHMET',3);


DECLARE @HECE NVARCHAR(20);
PRINT @HECE
SELECT @HECE = SUBSTRING('KADIKOY',0,5)
SELECT @HECE

-- cast ile tip dönüþümü
SELECT @sayi = CAST('34' AS INT)

PRINT REPLICATE('*',5)-- I 5 defa

PRINT GETDATE(); -- Tarih yazar.

DECLARE @sayi int;
SET @sayi= 10; -- tipi int.
PRINT CONVERT(NVARCHAR(5),@sayi)
PRINT CONVERT(NVARCHAR(3),123) -- 123 sayýsýný NVARCHAR'a çevir ekrana yaz.

PRINT TRY_CONVERT(NVARCHAR(3),1493) -- 1493 sayýsýný NVARCHAR'a çevirebilirse çevirir. Çeviremezse hata vermez.

SELECT @sayi = CAST('34' AS INT) -- Castin ile tip dönüþümü
DECLARE @HECE NVARCHAR(20);
SELECT @HECE =RIGHT('mehmet',3) -- SAÐDAKÝ 3 KARAKTERÝ AL.
PRINT @HECE; -- et

SELECT @HECE = LEFT('mehmet',3)  -- SOLDAKÝ 3 karakteri alsýn.
PRINT @HECE;

SELECT @HECE = SUBSTRING('KADIKÖY',0,5);
PRINT @HECE;

PRINT REPLICATE('*',5) -- *'I 5 DEFA TEKRAR ET.


-- DATE FONKSÝYONLARI
PRINT DATEDIFF(DD,'05.24.1993',GETDATE()) -- GÜN OLARAK  -- GÜN OLARAK FARK. MM YY DD
PRINT DATEDIFF(YY,'05.24.1993',GETDATE()) -- YIL OLARAK  -- GÜN OLARAK FARK. MM YY DD
PRINT DATEDIFF(MM,'05.24.1993',GETDATE()) -- AY OLARAK  -- GÜN OLARAK FARK. MM YY DD

PRINT CAST(DATEPART(DD,'09.09.1990') AS NVARCHAR(MAX)) + '.'+CONVERT(NVARCHAR(MAX),DATEPART(MM,'09.09.1990'))+'.'+ TRY_CONVERT(NVARCHAR(MAX),DATEPART(YYYY,'09.09.1990'))
-- TARIHIN PARÇALARINI ALDIK.
PRINT DATENAME(MM,GETDATE()) -- AYIN ADI

PRINT DAY(GETDATE())
PRINT MONTH(GETDATE())
PRINT YEAR(GETDATE())
PRINT @@DATEFIRST --HAFTANIN ILK GÜNÜ KAÇINCI GÜNÜ
PRINT EOMONTH(GETDATE()) -- BU AYIN SON GÜNÜ
PRINT CURRENT_TIMESTAMP --Jan  4 2020  9:18AM

