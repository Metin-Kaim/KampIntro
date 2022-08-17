--select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers
--
--select * from Customers where City='Berlin'
--
--select * from products where categoryId=1 or CategoryID=3

--select * from products where categoryId=1 and UnitPrice>10

--select * from products where CategoryID=1 order by UnitPrice desc

--select count(*) Adet from products where CategoryID = 2

--select CategoryID from products group by CategoryID

--select CategoryID,count(*) Adet from products group by CategoryID

--select CategoryID,count(*) Adet from products where UnitPrice>20
--group by CategoryID having count(*)<10

--select Products.ProductID,products.ProductName,Products.UnitPrice,Categories.CategoryName
--from products inner join Categories 
--on products.CategoryID = Categories.CategoryID where UnitPrice>10

select * from products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join orders o on o.OrderID=od.OrderID

select * from Customers c left join orders o 
on c.CustomerID=o.CustomerID 
where o.CustomerID is null



















