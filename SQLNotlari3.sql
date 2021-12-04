USE [OKUL_VT]
GO

INSERT INTO [dbo].[tb_Ogrenci]
           ([ad]
           ,[soyad]
           ,[dogumYili]
           ,[sinifID]
           ,[ogretmenID])
     VALUES
           ('Barýþ','Tutakli',1997,2,4
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

INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('adým','soyadým','5555555',1)
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('adým2','soyadým2','5555555',2)
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('adým3','soyadým3','5555555',3)
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('adým4','soyadým4','5555555',4)
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('adým5','soyadým5','5555555',2)
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES ('adým6','soyadým6','55555545',3)

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
INSERT INTO tb_alan (ad) VALUES('Raylý sistemler müdürlüðü');
SELECT * FROM tb_alan;
select * from tb_Ogretmen
select * from tb_Ogrenci
select * from tb_Sinif


select tb_Ogrenci.ad as OgrenciAd,tb_Ogrenci.soyad as OgrenciSoyad,tb_Ogretmen.ad as Öðretmen
from tb_Ogrenci
INNER JOIN tb_Ogretmen on tb_Ogretmen.ID = tb_Ogrenci.ogretmenID


-- öðrenci ad soyad sýnýf adý bilgilerini ekrana yazdýran sorgu
select tb_Ogrenci.ad, tb_Sinif.ad as sýnýf,tb_Sinif.kat as kat
from tb_Ogrenci
inner join tb_Sinif on tb_Sinif.ID = tb_Ogrenci.sinifID

-- Her öðrencinin ad soyad sýnýf adý ve öðretmen ad soyadý ile birlikte listeleyin
select tb_Ogrenci.ad, tb_Ogrenci.soyad, tb_Ogretmen.ad, tb_Ogretmen.soyad, tb_Sinif.ad as sýnýf
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

-- A ve B iki küme olsun
-- inner join iki tabloda da on ile belirtilen kolanlarda veri varsa listeler
-- left join   (A-B)U(AVB): V kesiþim kümesi


--***** MÜLAKATTA ÇIKABÝLÝR ******
--***** ÝÞ HAYATINDA KESÝN ÇIKAR ******

SELECT * FROM tb_Alan;
SELECT * FROM tb_Sinif;
SELECT * FROM tb_Ogrenci;
SELECT * FROM tb_Ogretmen;

--INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID) 
--VALUES ('Seyhan','KARACA',1995,2);

INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES('Aþýk','Veysel','03463211232',3);

-- INNER JOIN/JOIN iki tabloda ON ile belirtilen kolonlar dolu ise 
-- listeler.
-- Öðretmeni olan tüm öðrencileri listele (öðretmeni olmazsa listelemez veya öðretmenin öðrencisi yoksa listelemez). 
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
FROM tb_Ogrenci INNER JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;

SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
FROM tb_Ogrenci JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- LEFT JOIN (FROM'dan sonra ve ON'dan sonra yazdýðýmýz tablo adý SOLDAKÝ'dir.)
-- Tüm öðrencileri listele (öðretmeni olmasa da öðrencilerin tamamýný,öðretmenlerin sadece öðrencisi olanlarý
-- listeler). 
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
FROM tb_Ogrenci LEFT JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- RIGHT JOIN: soldaki:öðrenci tablosundan öðretmeni olanlarý alýrken 
-- saðdaki tablo:öðretmenlerin tamamýný listeler.
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
FROM tb_Ogrenci RIGHT JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;

SELECT 
CONCAT(tb_Ogrenci.ad,' ',tb_Ogrenci.soyad) as Öðrenci,
CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
FROM tb_Ogrenci
FULL OUTER JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


INSERT INTO tb_Alan (ad) VALUES('Bilgisayar');
INSERT INTO tb_Alan (ad) VALUES('Kimya');
INSERT INTO tb_Alan (ad) VALUES('Biyoloji');
INSERT INTO tb_Alan (ad) VALUES('Fizik');
INSERT INTO tb_Alan (ad) VALUES('Elektronik');
INSERT INTO tb_Alan (ad) VALUES('Metalurji');
INSERT INTO tb_Alan (ad) VALUES('Raylý Sistemler Mühendisliði');

INSERT INTO tb_Sinif (ad,kat) VALUES('d203',2);
INSERT INTO tb_Sinif (ad,kat) VALUES('d201',2);
INSERT INTO tb_Sinif (ad,kat) VALUES('d103',1);
INSERT INTO tb_Sinif (ad,kat) VALUES('d101',1);


INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES('Selim','GÜR',1990,1,1); 
INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES('Hercai','KILIÇ',1980,1,2); 
INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES('Mürsel','TORBA',1997,2,3); 

-- Aþaðýdaki þekilde view oluþturmak için sayfada baþka kod olmamalý veya yorum þeklinde olmalýlar
-- Ayný sorguyu sürekli tekrar yazmak yerine View kullanýyoruz
-- Bu iþlemi yaparken yeni bir View sql oluþturduk
-- Kullaným þekli ise  veri tabanýnýn altýndaki Views klasörünün içinde yeni bir sanal tablo oluþturuyor
--  Kullaným þekli:
--  Select * from OGRENCÝOGRETMEN

-- CREATE VIEW OgrenciOgretmen AS 
--SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as Öðretmen
--FROM tb_Ogrenci JOIN tb_Ogretmen
--ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- istediðmizde öðrenci ve oðretmen þeklinde kodlarý ayrý ayrý da alabiliyoruz

DECLARE @durum nvarchar(5)
SET @durum ='evet'
SELECT CASE @durum WHEN 'evet' THEN 'DURUM EVET' END Durum;-- þart saðlýyorsa
-- DURUM sutun ismi

DECLARE @sayi2 int;
SET @sayi2=9;
IF(@sayi2>100)
BEGIN
	PRINT 'sayi 100" küçüktür'
END
ELSE 
BEGIN
	PRINT 'sayi 100 veya büyüktür'
END

-- T-sql ise yukarýdaki ifadelerle bunlarýn kullanýlmasý oluyor

	
