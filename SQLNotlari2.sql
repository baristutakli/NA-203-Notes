--Create DATABASE OKUL_VT;-- OKUL_VT isminde bir veritaban� olu�turduk.

-- DROP DATABASE OKUL_VT; --veri taban�n� siler

USE OKUL_VT;-- OKUL_VT veri taban�n� kullan
 --iki parantez aras�na alan ad� + veri tibi yazaca��z
--CREATE TABLE tb_Ogrenci
--(
--numara int IDENTITY(1,1) PRIMARY KEY,
--ad nvarchar(50),
--soyad nvarchar(50),
--dogumYili smallint,
--sinif nvarchar(5)
--);



ALTER TABLE tb_Ogrenci
ALTER COLUMN ad nvarchar(50) NOT NULL;
ALTER TABLE tb_Ogrenci
ALTER COLUMN soyad nvarchar(50) NOT NULL;
ALTER TABLE tb_Ogrenci
ALTER COLUMN dogumYili smallint NOT NULL;
ALTER TABLE tb_Ogrenci
ALTER COLUMN sinif nvarchar(5) NOT NULL;


--ALTER TABLE tb_Ogrenci ALTER COLUMN numara int NULL;

--ALTER TABLE tb_Ogrenci DROP CONSTRAINT PK1;
--ALTER TABLE tb_ogrenci DROP numara;

--ALTER TABLE tb_Ogrenci ADD numara int NOT NULL IDENTITY(1,1) PRIMARY KEY;

