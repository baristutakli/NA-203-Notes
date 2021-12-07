

-- Trigger
CREATE TRIGGER TR_AfterDeleteShippers
on Shippers
AFTER DELETE -- Tip ve hangi komuttan sonra �al��aca��. �nce delete �al��acak sonra bizim istedi�imiz
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
Values ('NEtwork Akademi Ta��mac�l�k','02164556165')
go

-- go 10 yapoarsak 10 adet kay�t yapar
select * from Shippers



-- Tablomuza 10 adet kay�t ekledik.
GO
DECLARE @sayac INT;
SET @sayac = 0;
DECLARE @tel NVARCHAR(20);
SET @tel = CONCAT('0216 123 123 ',STR(@sayac));
INSERT INTO Shippers (CompanyName,Phone)
VALUES ('Network Akademi Ta��mac�l�k',@tel);
set @sayac =@sayac+1
GO 10

DELETE FROM Shippers where CompanyName LIKE '%NEtwork%'

select * from ShippersBackup;

-- Shippers tablosuna bir kay�t eklendi�inde bu kayda ait bilgileri ekrana 
-- CompanyName eklendi �eklinde ekrana print yazd�ran trigger � yaz�n�z


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


-- UNION: Dikey birle�tirm. Ayn� kolanlar� tekrardan yazmaz
SELECT 'M��teri' AS Tip, City AS Sehir,Country, CONCAT('�irket Ad�: ',Customers.CompanyName) AS [�irket/Yetkili Ad] FROM Customers 
WHERE Country='France'
UNION
SELECT 'Tedarik�i' AS Tip, City,Country,CONCAT('Yetkili Ad�: ',Suppliers.ContactName) AS [�irket/Yetkili Ad] FROM Suppliers 
WHERE Country='France';

SELECT 'M��teri' AS Tip, City AS Sehir,Country FROM Customers WHERE Country='France'
UNION
SELECT 'Tedarik�i' AS Tip, City,Country FROM Suppliers WHERE Country='France';


--UNION ALL: Dikey birle�tirme. Ayn� kolonlar� tekrar eder.
SELECT 'M��teri' AS Tip, City AS Sehir,Country FROM Customers WHERE Country='France'
UNION ALL
SELECT 'Tedarik�i' AS Tip, City,Country FROM Suppliers WHERE Country='France';


-- Hangi �lkelerden m��terim var?
SELECT DISTINCT(Country) FROM Customers ORDER BY Country;

-- JSON verileri JSON format�nda ��karmam�z� sa�l�yor
select * from Categories for JSON AUTO;

-- Do�rudan xml veri �ekme
-- SELECT * from Categories for XML AUTO
-- SELECT * from Categories for XML PATH('<Dosya konumu>')

--WITH ile sanal bir tablo olu�turabiliriz
WITH AzKalanlar as(
select * from Orders where Orders.ShipCountry ='France')
select * from Orders WITH (NOLOCK)-- senin sorgun s�ras�nda ba�kalar� kilitlenmiyor


-- Hangi sipari�in toplam ka� para oldu�unu siparis, tutar isimli gecici bir tabloda tutunuz.
-- Daha sonra bunlar� artan s�ralama ile gecici tablodan cekiniz



-- With 
-- 
ilk once istedi�imiz tabloyu parantez i�inde olu�tururuz sonra
-- filtreleme i�lemini istedi�imiz gibi yapar�z
WITH SiparisTutar  as
(select od.OrderID as [Order ID], sum(p.UnitPrice) as total   from [Order Details] od inner join
Products p on p.ProductID = od.ProductID group by od.OrderID) 
select * from SiparisTutar order by total asc for xml auto;


-- TRANSACTION NED�R NE ISE YARAR VE NASIL KULLANILIR ARASTIR

