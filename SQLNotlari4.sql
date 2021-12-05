

select * from CustomersWork

-- customer tbalosunda müþterileri bu dabloya ekleyeceðim

insert into CustomersWork (CustomerId,CompanyName,ContactName)
select c.CustomerId,c.CompanyName,c.ContactName from Customers c

-- Join yaparak update yapmak

-- Diyelim ki customers tablomuzda problem olduðunu düþündük
-- onu suctomersWork a ekledik ve düzenlemeler yaptýk


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


-- union, uygulayabilmen için sutun sayýlarý eþit olmalý
-- birleþtirirken farklýlýklarý sadece getiriyor
-- customerWork

-- bütün kayýtlar için all kullanýlýr
select CustomerID,CompanyName,ContactName from Customers
union
select * from CustomersWork

