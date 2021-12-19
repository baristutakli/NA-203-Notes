-- TRIGGER: �a��r�lmaks�z�n �artlar sa�land���nda otomatik �al��an SQL
--          sorgular� yazmam�z� sa�lar. �artlar sa�land���nda �al��an sorgu bloklar�.
--          AFTER TRIGGER: Belirli bir sorgu �al��rsa arkas�nda �al��s�n �eklinde tan�mlad���m�z
--                        TRIGGER yap�s�d�r. �RN: Categories tablosuna her INSERT yap�ld���nda
--						  sorgusu otomatik �al��s�n.
--			INSTEAD OF TRIGGER: Belirli bir tabloda �al��an bir sorgu �a��r�ld���nda o sorgu 
--								�al��mas�n bizim TRIGGER ile tan�mlad���m�z sorgu �al��s�n.

--CREATE TRIGGER TR_BlockDeleteCategory -- Trigger ad�n� belirttik.
--ON Northwind.dbo.Categories  -- Hangi tabloda �al��aca��n� belirttik.
--INSTEAD OF DELETE  -- Trigger tipini ve hangi sorguda �al��aca��n� belirttik.
--AS
--BEGIN
--	PRINT 'Bu tabloda silme i�lemi engellendi !!'
--END


ALTER TRIGGER TR_BlockDeleteCategory -- Trigger ad�n� belirttik.
ON Northwind.dbo.Categories  -- Hangi tabloda �al��aca��n� belirttik.
INSTEAD OF DELETE  -- Trigger tipini ve hangi sorguda �al��aca��n� belirttik.
AS
BEGIN
	DECLARE @catAdi NVARCHAR(50);	
	SELECT @catAdi = CategoryName FROM DELETED;  -- DELETED tablosu ge�ici(temp) olarak silinmeye �al��an
	PRINT @catAdi+ ' silinmeye �al���ld�.'
END

USE Northwind;
--SELECT * FROM Categories;
DELETE FROM Categories WHERE CategoryID=8; -- Seafood silinmeye �al���ld�.
ENABLE TRIGGER TR_BlockDeleteCategory ON Northwind.dbo.Categories;
DISABLE TRIGGER TR_BlockDeleteCategory ON Northwind.dbo.Categories;
DELETE FROM Categories WHERE CategoryID=12;

SELECT * FROM Categories;
--

-- CategoriesBackup isimli bir tablo olu�turun. 
-- Categories tablosundan veri silinmeye �al���ld���nda �nce silinmeye �al���lan veriyi bu yeni tabloya 
-- insert edin.
-- Daha sonra silinmeye �al���lan sat�r� silin.
