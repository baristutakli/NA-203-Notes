

-- Trigger: �a��r�lmaks�z�n �artlar sa�land���nda otomatik �al��an sql 
--  sorgular� yazmam�z� sa�lar veya �artlar sa�land���nda �al��an sorgu bloklar�

-- AFTER TRIGGER: Belirli bir sorgu �al���rsa arkas�nda �al��ans�n �eklinde tan�mlad���m�z TRIGGER yap�s�d�r.
-- �RN: Categories tablosuna her insert yap�ld���nda sorgusu otomatik �al��ss�n.

-- Instead OF TRIGGER: Belirli bir tabloda �al��an bir sorgu �a��r�ld���nda o sorgu 
-- �al��mas�n bizim trigger ile tan�mlad���m�z sorgu �al��s�n.

-- sql server da e posta g�nderebiliyorsunuz

-- Tables=> CAtegories => Trigger=> TR_BlockDeleteCategory

-- Trigger lar� tablolar �zerinde tan�ml�yoruz
-- �rne�in biri delete i�lemi yapt�k onu engelledik
CREATE TRIGGER TR_BlockDeleteCategory --trigger ad�n� belirttik
on Categories -- hangi tabloda �al��aca��n� belirttik
INSTEAD OF DELETE  -- trigger tipini ve hangi sorguda �al��aca��n�belirttik
as
BEGIN
	PRINT 'Bu tabloda silme i�lemi engellendi'
END

DELETE FROM Categories where CategoryID = 12;


ALTER TRIGGER TR_BlockDeleteCategory --trigger ad�n� belirttik
on Categories -- hangi tabloda �al��aca��n� belirttik
INSTEAD OF DELETE  -- trigger tipini ve hangi sorguda �al��aca��n�belirttik
as
BEGIN
	DECLARE @categoryAdi NVARCHAR(50);
	SELECT @categoryAdi = CategoryName from DELETED;-- DELETED asl�nda gizli bir tabloya kaydettik istedi�imizde �a��dabiliriz
	PRINT 'Bu tabloda silme i�lemi engellendi'
END


DELETE FROM Categories where CategoryID = 12;
-- trigger � aktif veya pasif hale getirebiliyoruz
ENABLE TRIGGER TR_BlockDeleteCategory on Northwind.dbo.Categories;
DISABLE TRIGGER TR_BlockDeleteCategory on Northwind.dbo.Categories;

-- categori tablosundan bir kay�t silinecek silinmeye izin verilsin

-- 

CREATE trigger TR_Yedekleme2
on Northwind.dbo.Categories
instead of delete
as
begin
	DECLARE @id int;
	DECLARE @name nvarchar(15);
	DECLARE @desc nvarchar(max);
	SELECT @id = CategoryID FROM DELETED;
	SELECT @name = CategoryName FROM DELETED;
	SELECT @desc = Description FROM DELETED;
	SELECT @id,@name,@desc;
	INSERT INTO CategoriesBackup (CategoryID,CategoryName,Description)
	VALUES(@id,@name,@desc);
	DELETE FROM Categories WHERE CategoryID=@id;
end

DELETE FROM Categories WHERE CategoryID=10;

SELECT * FROM Categories;
SELECT * FROM CategoriesBackup;


---2. Y�ntem