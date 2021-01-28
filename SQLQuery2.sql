--Select
Select ContactName Adi,CompanyName Şirketadi,City Sehir from Customers

Select * from Products where categoryId=1 or categoryId=3

select * from Products where categoryId=1 and UnitPrice>=10

select * from Products order by UnitPrice desc ---ascendig ---descending

select count(*) from Products  ---bütün product kolonunda kaç data var

select count (*) Adet from Products where CategoryID=2

select categoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

select *
from Products inner join Categories on Products.CategoryID = Categories.CategoryID



