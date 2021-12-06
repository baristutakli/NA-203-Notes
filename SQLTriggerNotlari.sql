

-- Trigger: Çaðýrýlmaksýzýn þartlar saðlandýðýnda otomatik çalýþan sql 
--  sorgularý yazmamýzý saðlar veya þartlar saðlandýðýnda çalýþan sorgu bloklarý

-- AFTER TRIGGER: Belirli bir sorgu çalýþýrsa arkasýnda çalýþansýn þeklinde tanýmladýðýmýz TRIGGER yapýsýdýr.
-- ÖRN: Categories tablosuna her insert yapýldýðýnda sorgusu otomatik çalýþssýn.

-- Instead OF TRIGGER: Belirli bir tabloda çalýþan bir sorgu çaðýrýldýðýnda o sorgu 
-- çalýþmasýn bizim trigger ile tanýmladýðýmýz sorgu çalýþsýn.

-- sql server da e posta gönderebiliyorsunuz

-- Tables=> CAtegories => Trigger=> TR_BlockDeleteCategory

-- Trigger larý tablolar üzerinde tanýmlýyoruz
-- örneðin biri delete iþlemi yaptýk onu engelledik
CREATE TRIGGER TR_BlockDeleteCategory --trigger adýný belirttik
on Categories -- hangi tabloda çalýþacaðýný belirttik
INSTEAD OF DELETE  -- trigger tipini ve hangi sorguda çalýþacaðýnýbelirttik
as
BEGIN
	PRINT 'Bu tabloda silme iþlemi engellendi'
END

DELETE FROM Categories where CategoryID = 12;


ALTER TRIGGER TR_BlockDeleteCategory --trigger adýný belirttik
on Categories -- hangi tabloda çalýþacaðýný belirttik
INSTEAD OF DELETE  -- trigger tipini ve hangi sorguda çalýþacaðýnýbelirttik
as
BEGIN
	DECLARE @categoryAdi NVARCHAR(50);
	SELECT @categoryAdi = CategoryName from DELETED;-- DELETED aslýnda gizli bir tabloya kaydettik istediðimizde çaðýdabiliriz
	PRINT 'Bu tabloda silme iþlemi engellendi'
END


DELETE FROM Categories where CategoryID = 12;
-- trigger ý aktif veya pasif hale getirebiliyoruz
ENABLE TRIGGER TR_BlockDeleteCategory on Northwind.dbo.Categories;
DISABLE TRIGGER TR_BlockDeleteCategory on Northwind.dbo.Categories;

-- categori tablosundan bir kayýt silinecek silinmeye izin verilsin

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


---2. Yöntem