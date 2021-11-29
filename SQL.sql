USE DB_Test;-- Veri tabanýný seçtik
--SELECT * FROM tb_ogrenci;-- Tüm öðrencileri getiriyor
-- SELECT ad,soyad from tb_ogrenci; -- tüm öðrencilerin tum kolanlarý
-- SELECT ad,soyad from tb_ogrenci WHERE ID=1; Id si bir olan elemanýn isim ve soyismini aldýk
-- tablo ismine veritabaný ismini ekleyebilirler örn: DB_Test.dbo.tb_ogrenci
-- Veya from [DB_Test].[dbo].[tb_ogrenci];
-- SELECT ID,ad,soyad FROM tb_ogrenci WHERE ad='Bob';
-- SELECT * from tb_ogrenci WHERE ID>2;
-- SELECT TOP 2 * FROM tb_ogrenci WITH(NOLOCK);-- en üstteki iki elemaný getiriyor
-- Canlý sistemlerde binlerce satýr çekiyorsan veri tabanýnýn kitlenmesini engelliyor.
-- NOLOCK ile veri tabanýnýn kitlenmesini engelleyebiliriz
-- Bizim sorgumuz sunucuyu uzunca meþgul etse diðer kullanýcýlar sorgu yapabilir

-- Ýd ye göre artan sýrada
--SELECT * FROM tb_ogrenci ORDER BY ID ASC; 
-- Ýd ye göre azalansýrada
--SELECT * FROM tb_ogrenci WITH(NOLOCK) ORDER BY ID DESC;

-- Id si 2 ile 5 arasýnda olanlarý sýrala
--SELECT * FROM tb_ogrenci WHERE ID BETWEEN 2 AND 5;
-- 2 ve 5 dahil edilir


-- ID si 3,4 veya 5 olanlarý getir
--SELECT * FROM tb_ogrenci WHERE ID	IN(3,4,5);

-- ID si 3,4 veya 5 olmayanlarý getir
--SELECT * FROM tb_ogrenci WHERE ID	NOT IN(3,4,5);

-- OR
-- SELECT * FROM tb_ogrenci WHERE ID=1 OR ID=4;

 -- AND 
-- SELECT * FROM tb_ogrenci WHERE ID=1 AND ad='Bob';

 -- LÝKE
 SELECT * FROM tb_ogrenci WHERE ad  LIKE '%Obama%'; 

 -- içerisinde bob olan
 SELECT * FROM tb_ogrenci WHERE ad LIKE '%Bob%'

