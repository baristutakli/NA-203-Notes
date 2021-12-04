USE Northwind

-- Stokta olmay�p siparisi olan �r�nler.
select * from Products where UnitsInStock =0 and UnitsOnOrder>0;


-- OR ile �al��mak 
-- stokta olmayan veya sipari�i olmayan �r�nleri listeleyin
select * from Products where UnitsInStock=0 or UnitsOnOrder=0;

--  not and
-- ismi PErth PAsties olmayan ve s�f�r sto�u bulunan �r�nler
select * from Products where not ProductName ='Perth Pasties' and UnitsInStock =0;

-- Order by
-- Verileri listeledi�imizde belli bir s�rada gelmesini istiyorsak kullan�r�z
Select * from Products order by ProductName;

select * from Products order by UnitPrice;

-- asc = ascending
-- desc = descending

-- �r�n isimleri ve birim fiyata g�re s�ralama i�lemi
--A�a��daki kodda �nce �r�n ismine g�re s�ralayacak sonra ayn� isimde olan �r�nleri birim fiyat�na g�re s�ralayacak
select * from Products order by SupplierID, UnitPrice desc
-- Burada s�ralama �nemlidir Supplier a g�re mi unitPrice a g�remi
-- oldu�una bakar


select Products.ProductName,Suppliers.Country,Suppliers.City,Categories.CategoryName from Products
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
inner join Categories on Categories.CategoryID = Products.CategoryID
group by Products.ProductName,Suppliers.Country,Suppliers.City,Categories.CategoryName


-- hangi kategoride ka� �r�n var
select COUNT(Products.ProductID),Categories.CategoryName from Products
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
inner join Categories on Categories.CategoryID = Products.CategoryID
group by Categories.CategoryName 

-- L�ke 
-- bir �r�n�n diyelim ki ismini tam ha�trlam�yoruz o zaman 
-- like kullanabiliriz

-- �rnek 1: con ile ba�layan kategoriler
select COUNT(Products.ProductID),Categories.CategoryName from Products
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
inner join Categories on Categories.CategoryID = Products.CategoryID
where CategoryName LIKE 'con%'
group by Categories.CategoryName 

-- i�in de Con olanlar i�in %Con% kullan�r�z

-- �rnek 1: con ile ba�layan kategoriler
select COUNT(Products.ProductID),Categories.CategoryName from Products
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
inner join Categories on Categories.CategoryID = Products.CategoryID
where CategoryName LIKE '%con%'
group by Categories.CategoryName 

-- Between 
select * from Products where UnitPrice between 10 and 46 order by UnitPrice asc

-- IN (1,2) categorisi 1 veya 2 olanalr
select * from Products where Products.CategoryID in (1,2)

--Count: Bir �eyin say�s�n� bulmak isyitoruz
-- �rne�in bug�n yapt���m�z sat��lar�n say�s�n� ��renmek istiyoruz

-- �r�n say�s�
Select Count(*)from  Products
-- m��teri say�s� 
select Count(Customers.CustomerID) from Customers


-- Min : en d���k  Max en y�ksek
-- AVg average
Select Min(UnitPrice) from Products

-- ka� para kazand�k
select Sum(UnitPrice*Quantity) as Kazanc from [Order Details]

-- Rand() bize rastgele say� �retmeye yar�yor


--  LEFT 
-- soldan 3 karakteri getiriyor
select LEFT('Engin Demirog',3)
-- LEN 
select LEN('Engin Demirog')
--LOWER
-- Trim fonksiyonu, bir metnin ba��ndaki ve sonundaki bo�lular� at�yor

-- mesela bir ismin ba��nda bo�luklar var ie where onu getirmez
-- bu noktada trim fonksiyonunu �al��t�rabilirzinz

select TRIM(Products.ProductName) from Products where TRIM(ProductName) = 'chai'

-- REVERSE tersine �evirir
-- CHARINDEX: c�mlenin i�inde bir yerlerde ge�iyorsa 1den itibaren ar�yoruz yeri �nemli de�il
-- s�k kullan�lan foksiyonlardan biridir
select ProductName from Products
where CHARINDEX('anton',ProductName,1)>0

-- REPLACE() de�i�tirme i�lemi

SELECT REPLACE('Engin DEmirog','','_');-- boslugu _ ile degistiriyoruz

-- SUBSTRING metni par�alamaya yarar
SELECT SUBSTRING('Engin Demirog',1,5)
--ASC��, Char,


-- Distinct: bir sutundaki tekrarlayan kay�tlar� tekrarlamadn bir kerede getirmeye yarar
-- asl�nda gruplama ifadesidir e�er contactName i de yaz�p �a��r�sak hata al�r�z

select distinct(Country) from Customers order by Country

-- Group by ile �al��mak
-- arka planda her grup i�in bir list olu�turuyor saymak istersen count kullanabilrisin

-- Hangi �lkede ka� m��reti var

select Country from Customers group by Country

select Country,Count(*) as Adet from Customers group by Country
-- Bu �ke ve �ehirden ka�ar tane m��teri var
select Country,City,Count(*) as Adet from Customers group by Country,City

-- �lke ve �ehri baz�nde birden fazla m��terimiz olan yerler neresidir
select Country,City,Count(*) as Adet from Customers
where City is not NULL
group by Country,City
having Count(*)>1
Order by Count(*) desc

-- having cumulatif �eyler i�in kullan�l�r Count gibi

--inner join
-- not ��kt�y� copy edip excele atabilrisin
select Products.ProductName, o.OrderDate, od.Quantity*od.UnitPrice from Products inner join [Order Details] od
on Products.ProductID = od.ProductID 
inner join ORders o
on o.OrderID = od.OrderID
order by ProductName, o.OrderDate

-- LEFT JO�N e�le�meyen verileri de getirir
-- Hem join olanlar� getiriyor hem join olmayanlar� getiriyor

-- hi� satamad���m�z �r�n var m�
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
where od.ProductID is null

--Bir kategoride bulunan �r�nlerden birim olarak en �ok sat�lan 5 �r�n� 
--veya toplam kazanc�   en fazla olan 5 �r�n� azalacak �ekilde s�ralayan ve
--son olarak ise bu �r�nleri �lkelere g�re grupland�ran komutu yaz�n�z

select top 5 Products.UnitsOnOrder, Products.ProductName from Products order by Products.UnitsOnOrder desc


select top 5 p.UnitsOnOrder, (od.UnitPrice*od.Quantity) as kazanc from Products p
inner join [Order Details] od on od.ProductID =p.ProductID
group by (od.UnitPrice*od.Quantity),p.UnitsOnOrder
order by p.UnitsOnOrder desc, (od.UnitPrice*od.Quantity) desc


-- Hangi �r�nden ka� tane satm���z?

select Count(*),ProductID from [Order Details] od group by od.ProductID

-- Hangi kategoriden ka� tane satm���z
 
 select c.CategoryName,Count(*) as adet from Products p inner join Categories c
 on p.CategoryID = c.CategoryID
 inner join [Order Details] od
 on od.ProductID = p.ProductID
 group by c.CategoryName

-- Bir s�t�nda �al��an�n ismi  di�er s�tunda ise onun �st�

select Employees.FirstName as [Employee Name], Employees.ReportsTo as Manager  from Employees where ReportsTo is not null

--
select Employees.FirstName as [Employee Name], Employees.ReportsTo as Manager  from Employees
where  Employees.EmployeeID = Employees.ReportsTo


