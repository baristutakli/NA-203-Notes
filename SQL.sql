USE DB_Test;-- Veri taban�n� se�tik
--SELECT * FROM tb_ogrenci;-- T�m ��rencileri getiriyor
-- SELECT ad,soyad from tb_ogrenci; -- t�m ��rencilerin tum kolanlar�
-- SELECT ad,soyad from tb_ogrenci WHERE ID=1; Id si bir olan eleman�n isim ve soyismini ald�k
-- tablo ismine veritaban� ismini ekleyebilirler �rn: DB_Test.dbo.tb_ogrenci
-- Veya from [DB_Test].[dbo].[tb_ogrenci];
-- SELECT ID,ad,soyad FROM tb_ogrenci WHERE ad='Bob';
-- SELECT * from tb_ogrenci WHERE ID>2;
-- SELECT TOP 2 * FROM tb_ogrenci WITH(NOLOCK);-- en �stteki iki eleman� getiriyor
-- Canl� sistemlerde binlerce sat�r �ekiyorsan veri taban�n�n kitlenmesini engelliyor.
-- NOLOCK ile veri taban�n�n kitlenmesini engelleyebiliriz
-- Bizim sorgumuz sunucuyu uzunca me�gul etse di�er kullan�c�lar sorgu yapabilir

-- �d ye g�re artan s�rada
--SELECT * FROM tb_ogrenci ORDER BY ID ASC; 
-- �d ye g�re azalans�rada
--SELECT * FROM tb_ogrenci WITH(NOLOCK) ORDER BY ID DESC;

-- Id si 2 ile 5 aras�nda olanlar� s�rala
--SELECT * FROM tb_ogrenci WHERE ID BETWEEN 2 AND 5;
-- 2 ve 5 dahil edilir


-- ID si 3,4 veya 5 olanlar� getir
--SELECT * FROM tb_ogrenci WHERE ID	IN(3,4,5);

-- ID si 3,4 veya 5 olmayanlar� getir
--SELECT * FROM tb_ogrenci WHERE ID	NOT IN(3,4,5);

-- OR
-- SELECT * FROM tb_ogrenci WHERE ID=1 OR ID=4;

 -- AND 
-- SELECT * FROM tb_ogrenci WHERE ID=1 AND ad='Bob';

 -- L�KE
 SELECT * FROM tb_ogrenci WHERE ad  LIKE '%Obama%'; 

 -- i�erisinde bob olan
 SELECT * FROM tb_ogrenci WHERE ad LIKE '%Bob%'

