

select * from CustomersWork

-- customer tbalosunda m��terileri bu dabloya ekleyece�im

insert into CustomersWork (CustomerId,CompanyName,ContactName)
select c.CustomerId,c.CompanyName,c.ContactName from Customers c

-- Join yaparak update yapmak

-- Diyelim ki customers tablomuzda problem oldu�unu d���nd�k
-- onu suctomersWork a ekledik ve d�zenlemeler yapt�k


update Customers set CompanyName = CustomersWork.CompanyName
from 
Customers inner join CustomersWork
on Customers.CustomerId = CustomersWork.CustomerID
where CustomersWork.CompanyName like '%Test%'


-- delete
delete Customers 
from 
Customers inner join CustomersWork
on Customers.CustomerId = CustomersWork.CustomerID
where CustomersWork.CompanyName like '%Test%'


-- union, uygulayabilmen i�in sutun say�lar� e�it olmal�
-- birle�tirirken farkl�l�klar� sadece getiriyor
-- customerWork

-- b�t�n kay�tlar i�in all kullan�l�r
select CustomerID,CompanyName,ContactName from Customers
union
select * from CustomersWork

