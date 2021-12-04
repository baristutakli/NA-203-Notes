USE [OKUL_VT]
GO

INSERT INTO [dbo].[tb_Ogrenci]
           ([ad]
           ,[soyad]
           ,[dogumYili]
           ,[sinifID]
           ,[ogretmenID])
     VALUES
           ('Bar��','Tutakli',1997,2,4
           )
GO

INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES ('ogrenci1','ogr',1999,2,4)
INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES ('ogrenci2','ogr',1999,3,2)
INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES ('ogrenci3','ogr3',1999,2,4)
INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES ('ogrenci4','ogr4',1998,3,2)
INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES ('ogrenci5','ogr5',1997,2,3)
INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES ('ogrenci6','ogr6',19996,3,2)

insert into tb_Sinif (ad, kat) VALUES ('ad1',4)
insert into  tb_Sinif (ad, kat) VALUES ('ad2',2)
insert into  tb_Sinif (ad ,kat) VALUES ('ad2',2)

USE [OKUL_VT]
GO

INSERT INTO [dbo].[tb_Ogretmen]
           ([ad]
           ,[soyad]
           ,[telefon]
           ,[alanID])
     VALUES
           ('Mehmet','Demir','0001233556',1)
GO

INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('ad�m','soyad�m','5555555',1)
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('ad�m2','soyad�m2','5555555',2)
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('ad�m3','soyad�m3','5555555',3)
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('ad�m4','soyad�m4','5555555',4)
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('ad�m5','soyad�m5','5555555',2)
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('ad�m6','soyad�m6','55555545',3)

SELECT * FROM tb_alan;

TRUNCATE TABLE tb_Ogrenci;
TRUNCATE TABLE tb_Ogretmen;
TRUNCATE TABLE tb_alan;
TRUNCATE TABLE tb_Sinif;

Use OKUL_VT;
--INSERT INTO tb_alan (ad) VALUES('Bilgisayar');
INSERT INTO tb_alan (ad) VALUES('Kimya');
INSERT INTO tb_alan (ad) VALUES('Biyoloji');
INSERT INTO tb_alan (ad) VALUES('Elektronik');
INSERT INTO tb_alan (ad) VALUES('Meteoroloji');
INSERT INTO tb_alan (ad) VALUES('Rayl� sistemler m�d�rl���');
SELECT * FROM tb_alan;
select * from tb_Ogretmen
select * from tb_Ogrenci
select * from tb_Sinif


select tb_Ogrenci.ad as OgrenciAd,tb_Ogrenci.soyad as OgrenciSoyad,tb_Ogretmen.ad as ��retmen
from tb_Ogrenci
INNER JOIN tb_Ogretmen on tb_Ogretmen.ID = tb_Ogrenci.ogretmenID


-- ��renci ad soyad s�n�f ad� bilgilerini ekrana yazd�ran sorgu
select tb_Ogrenci.ad, tb_Sinif.ad as s�n�f,tb_Sinif.kat as kat
from tb_Ogrenci
inner join tb_Sinif on tb_Sinif.ID = tb_Ogrenci.sinifID

-- Her ��rencinin ad soyad s�n�f ad� ve ��retmen ad soyad� ile birlikte listeleyin
select tb_Ogrenci.ad, tb_Ogrenci.soyad, tb_Ogretmen.ad, tb_Ogretmen.soyad, tb_Sinif.ad as s�n�f
from tb_Ogrenci
inner join tb_Ogretmen on tb_Ogretmen.ID = tb_Ogrenci.ogretmenID
inner join tb_Sinif on tb_Ogrenci.sinifID = tb_Sinif.ID

----- Update ----

--select * from tb_alan;
-- update tb_alan SET ad='Elektronik & Elektrik' where ID =5

select * from tb_Ogretmen;
update tb_Ogretmen SET telefon ='2164441444', alanID=4 where ID =3

-- delete

DELETE FROM tb_alan WHERE ID =2;

Select tb_Ogrenci.ad, tb_Ogrenci.soyad,Concat(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Ogretmen
FROM tb_Ogrenci Inner join tb_Ogretmen
on tb_Ogrenci.ogretmenID = tb_Ogretmen.ID;

-- A ve B iki k�me olsun
-- inner join iki tabloda da on ile belirtilen kolanlarda veri varsa listeler
-- left join   (A-B)U(AVB): V kesi�im k�mesi


--***** M�LAKATTA �IKAB�L�R ******
--***** �� HAYATINDA KES�N �IKAR ******

SELECT * FROM tb_Alan;
SELECT * FROM tb_Sinif;
SELECT * FROM tb_Ogrenci;
SELECT * FROM tb_Ogretmen;

--INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID) 
--VALUES ('Seyhan','KARACA',1995,2);

INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES('A��k','Veysel','03463211232',3);

-- INNER JOIN/JOIN iki tabloda ON ile belirtilen kolonlar dolu ise 
-- listeler.
-- ��retmeni olan t�m ��rencileri listele (��retmeni olmazsa listelemez veya ��retmenin ��rencisi yoksa listelemez). 
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
FROM tb_Ogrenci INNER JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;

SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
FROM tb_Ogrenci JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- LEFT JOIN (FROM'dan sonra ve ON'dan sonra yazd���m�z tablo ad� SOLDAK�'dir.)
-- T�m ��rencileri listele (��retmeni olmasa da ��rencilerin tamam�n�,��retmenlerin sadece ��rencisi olanlar�
-- listeler). 
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
FROM tb_Ogrenci LEFT JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- RIGHT JOIN: soldaki:��renci tablosundan ��retmeni olanlar� al�rken 
-- sa�daki tablo:��retmenlerin tamam�n� listeler.
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
FROM tb_Ogrenci RIGHT JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;

SELECT 
CONCAT(tb_Ogrenci.ad,' ',tb_Ogrenci.soyad) as ��renci,
CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
FROM tb_Ogrenci
FULL OUTER JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


INSERT INTO tb_Alan (ad) VALUES('Bilgisayar');
INSERT INTO tb_Alan (ad) VALUES('Kimya');
INSERT INTO tb_Alan (ad) VALUES('Biyoloji');
INSERT INTO tb_Alan (ad) VALUES('Fizik');
INSERT INTO tb_Alan (ad) VALUES('Elektronik');
INSERT INTO tb_Alan (ad) VALUES('Metalurji');
INSERT INTO tb_Alan (ad) VALUES('Rayl� Sistemler M�hendisli�i');

INSERT INTO tb_Sinif (ad,kat) VALUES('d203',2);
INSERT INTO tb_Sinif (ad,kat) VALUES('d201',2);
INSERT INTO tb_Sinif (ad,kat) VALUES('d103',1);
INSERT INTO tb_Sinif (ad,kat) VALUES('d101',1);


INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES('Selim','G�R',1990,1,1); 
INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES('Hercai','KILI�',1980,1,2); 
INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES('M�rsel','TORBA',1997,2,3); 

-- A�a��daki �ekilde view olu�turmak i�in sayfada ba�ka kod olmamal� veya yorum �eklinde olmal�lar
-- Ayn� sorguyu s�rekli tekrar yazmak yerine View kullan�yoruz
-- Bu i�lemi yaparken yeni bir View sql olu�turduk
-- Kullan�m �ekli ise  veri taban�n�n alt�ndaki Views klas�r�n�n i�inde yeni bir sanal tablo olu�turuyor
--  Kullan�m �ekli:
--  Select * from OGRENC�OGRETMEN

-- CREATE VIEW OgrenciOgretmen AS 
--SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
--FROM tb_Ogrenci JOIN tb_Ogretmen
--ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- istedi�mizde ��renci ve o�retmen �eklinde kodlar� ayr� ayr� da alabiliyoruz

DECLARE @durum nvarchar(5)
SET @durum ='evet'
SELECT CASE @durum WHEN 'evet' THEN 'DURUM EVET' END Durum;-- �art sa�l�yorsa
-- DURUM sutun ismi

DECLARE @sayi2 int;
SET @sayi2=9;
IF(@sayi2>100)
BEGIN
	PRINT 'sayi 100" k���kt�r'
END
ELSE 
BEGIN
	PRINT 'sayi 100 veya b�y�kt�r'
END

-- T-sql ise yukar�daki ifadelerle bunlar�n kullan�lmas� oluyor

	
