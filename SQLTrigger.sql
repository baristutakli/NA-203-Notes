

-- Trigger
CREATE TRIGGER TR_AfterDeleteShippers
on Shippers
AFTER DELETE -- Tip ve hangi komuttan sonra çalýþacaðý. Önce delete çalýþacak sonra bizim istediðimiz
as 
BEGIN
	DECLARE @id INT;
	DECLARE @name NVARCHAR(40);
	DECLARE @phone NVARCHAR(24);
	SELECT @id = ShipperID from DELETED;
	Select @name = CompanyName from DELETED;
	Select @phone = Phone from DELETED;
	INSERT INTO ShippersBackup (ShipperID,CompanyName,Phone)
	VALUES (@id,@name,@phone)
	
END


go

Insert INTO Shippers (CompanyName,Phone)
Values ('NEtwork Akademi Taþýmacýlýk','02164556165')
go

-- go 10 yapoarsak 10 adet kayýt yapar
select * from Shippers



-- Tablomuza 10 adet kayýt ekledik.
GO
DECLARE @sayac INT;
SET @sayac = 0;
DECLARE @tel NVARCHAR(20);
SET @tel = CONCAT('0216 123 123 ',STR(@sayac));
INSERT INTO Shippers (CompanyName,Phone)
VALUES ('Network Akademi Taþýmacýlýk',@tel);
set @sayac =@sayac+1
GO 10

DELETE FROM Shippers where CompanyName LIKE '%NEtwork%'

select * from ShippersBackup;

-- Shippers tablosuna bir kayýt eklendiðinde bu kayda ait bilgileri ekrana 
-- CompanyName eklendi þeklinde ekrana print yazdýran trigger ý yazýnýz


ALTER TRIGGER TR_Inserted
on Shippers
after INSERT
as
BEGIN
	DECLARE @id INT;
	DECLARE @name NVARCHAR(40);
	DECLARE @phone NVARCHAR(24);
	SELECT @id = ShipperID from INSERTED;
	Select @name = CompanyName from INSERTED;
	Select @phone = Phone from INSERTED;
	PRINT CONCAT(@id,' ',@name ,' ',@phone)
END


INSERT INTO Shippers  values ('Tesla','4440444')


-- UNION: Dikey birleþtirm. Ayný kolanlarý tekrardan yazmaz
SELECT 'Müþteri' AS Tip, City AS Sehir,Country, CONCAT('Þirket Adý: ',Customers.CompanyName) AS [Þirket/Yetkili Ad] FROM Customers 
WHERE Country='France'
UNION
SELECT 'Tedarikçi' AS Tip, City,Country,CONCAT('Yetkili Adý: ',Suppliers.ContactName) AS [Þirket/Yetkili Ad] FROM Suppliers 
WHERE Country='France';

SELECT 'Müþteri' AS Tip, City AS Sehir,Country FROM Customers WHERE Country='France'
UNION
SELECT 'Tedarikçi' AS Tip, City,Country FROM Suppliers WHERE Country='France';


--UNION ALL: Dikey birleþtirme. Ayný kolonlarý tekrar eder.
SELECT 'Müþteri' AS Tip, City AS Sehir,Country FROM Customers WHERE Country='France'
UNION ALL
SELECT 'Tedarikçi' AS Tip, City,Country FROM Suppliers WHERE Country='France';


-- Hangi ülkelerden müþterim var?
SELECT DISTINCT(Country) FROM Customers ORDER BY Country;

-- JSON verileri JSON formatýnda çýkarmamýzý saðlýyor
select * from Categories for JSON AUTO;

-- Doðrudan xml veri çekme
-- SELECT * from Categories for XML AUTO
-- SELECT * from Categories for XML PATH('<Dosya konumu>')

--WITH ile sanal bir tablo oluþturabiliriz
WITH AzKalanlar as(
select * from Orders where Orders.ShipCountry ='France')
select * from Orders WITH (NOLOCK)-- senin sorgun sýrasýnda baþkalarý kilitlenmiyor


-- Hangi sipariþin toplam kaç para olduðunu siparis, tutar isimli gecici bir tabloda tutunuz.
-- Daha sonra bunlarý artan sýralama ile gecici tablodan cekiniz



-- With 
-- 
ilk once istediðimiz tabloyu parantez içinde oluþtururuz sonra
-- filtreleme iþlemini istediðimiz gibi yaparýz
WITH SiparisTutar  as
(select od.OrderID as [Order ID], sum(p.UnitPrice) as total   from [Order Details] od inner join
Products p on p.ProductID = od.ProductID group by od.OrderID) 
select * from SiparisTutar order by total asc for xml auto;


-- TRANSACTION NEDÝR NE ISE YARAR VE NASIL KULLANILIR ARASTIR

