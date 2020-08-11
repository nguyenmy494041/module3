--Có bao nhiêu khách hàng?
SELECT COUNT(CustomerID) FROM Customers

SELECT * FROM [dbo].[Suppliers]

-- Có bao nhiêu loại hàng (category), mỗi loại hàng có bao nhiêu sản phẩm (product)
/* SELECT * FROM [dbo].[Categories]
 SELECT * FROM [dbo].[Products]*/ 

SELECT a.CategoryID,b.CategoryName, COUNT(a.CategoryID) 'So luong' FROM[dbo].[Products] a
INNER JOIN [dbo].[Categories] b
ON a.CategoryID = b.CategoryID
GROUP BY a.CategoryID,b.CategoryName

--Có bao nhiêu nhân viên (Employee)? Nâng cao: bạn có thể truy vấn được tên người quản lý (là người được nhân viên báo cáo) không?
SELECT COUNT(EmployeeID) FROM Employees

--Nâng cao: bạn có thể truy vấn được tên người quản lý (là người được nhân viên báo cáo) không?
SELECT CONCAT (LastName,' ',FirstName) as 'manager' FROM Employees WHERE ReportsTo IS NULL

-- Có bao nhiêu nhà cung cấp?
SELECT COUNT(SupplierID) FROM [dbo].[Suppliers]

--Đơn hàng (order) được lưu trữ gồm những năm nào?
SELECT * FROM [dbo].[Customers]
SELECT DATENAME(year, c.OrderDate) as nam FROM [dbo].[Orders] as c GROUP BY DATENAME(year, c.OrderDate);

--Khách hàng thường sống ở những quốc gia nào? 
SELECT Country FROM [dbo].[Customers] c GROUP BY Country

--Những quốc gia nào có nhà cung cấp?
SELECT Country FROM Suppliers GROUP BY Country

 -- Liệt kê các khách hàng không có số Fax?
 SELECT CompanyName as 'custumer' FROM Customers WHERE Fax IS NULL

 --Liệt kê các khách hàng sống ở Pháp.
  SELECT CompanyName as 'custumer' FROM Customers WHERE Country = 'France'
-- Liệt kê các khách hang sống ở Pháp và Tây Ban Nha
  SELECT CompanyName as 'custumer' FROM Customers WHERE Country = 'France' or Country = 'Spain'
--  Liệt kê các khách hàng không sống ở Châu Mỹ
SELECT CompanyName, Country FROM Customers WHERE Region IS  NULL
-- Liệt kê các hóa đơn của năm 1997
SELECT OrderID, CustomerID, DATENAME(year, [OrderDate]) as 'year'  FROM Orders WHERE DATENAME(year, [OrderDate])=1997

--  Liệt kê 3 hóa đơn mới nhất
SELECT TOP(3) * FROM Orders ORDER BY [OrderDate] DESC

-- Liệt kê các hóa đơn có cước phí >100$.
SELECT * FROM Orders WHERE  [Freight] >= 100;

-- Tìm hóa đơn có cước phí cao nhất, thấp nhất.
SELECT TOP(1) * FROM Orders ORDER BY [Freight];
SELECT TOP(1) * FROM Orders ORDER BY [Freight] DESC;
SELECT * FROM Orders WHERE Freight = (SELECT MAX([Freight]) FROM Orders);
SELECT * FROM Orders WHERE Freight = (SELECT MIN([Freight]) FROM Orders);
--Đếm số hóa đơn bán được của năm 1996, 1997 và cả 2 năm 1996, 1997
SELECT COUNT ([OrderID]) as 'So luong' FROM Orders WHERE DATENAME(year, [OrderDate])=1997
SELECT COUNT ([OrderID]) as 'So luong' FROM Orders WHERE DATENAME(year, [OrderDate])=1996
SELECT COUNT ([OrderID]) as 'So luong' FROM Orders WHERE DATENAME(year, [OrderDate]) IN (1996,1997);

--  Tính đơn giá bình quân của tất cả sản phẩm, của sản phẩm thuộc loại hải sản (mã loại là 8)
 SELECT AVG([UnitPrice]) FROM [dbo].[Products] WHERE [ProductID] = 8
 select * from Products
 -- Liệt kê 3 sản phẩm có đơn giá mắc nhất.
 SELECT TOP(3) * FROM [dbo].[Products] ORDER BY [UnitPrice] DESC

 -- Liệt kê các sản phẩm có tên bắt đầu bằng ký tự N? Bắt đầu bằng ký tự N
-- hoặc A? Liệt kê các sản phẩm có tên không bắt đầu bằng N? Không bắt đầu bằng N và A?
 SELECT * FROM [dbo].[Products] WHERE [ProductName] LIKE 'N%';
 SELECT * FROM Products WHere Products.ProductName NOT in (SELECT Products.ProductName FROM [dbo].[Products] WHERE [ProductName] LIKE 'N%' OR [ProductName] LIKE 'A%');
 
 --Liệt kê các sản phẩm có đơn giá từ 100 đến 200
 SELECT * FROM Products WHERE [UnitPrice] BETWEEN 100 AND 200

 -- Liệt kê các sản phẩm có số lượng tồn kho (units in stock) thấp hơn định mức tồn kho tối thiểu (reorder level)  
  SELECT * FROM Products WHERE [UnitsInStock] < [ReorderLevel];

  -- Tính số sản phẩm được cung cấp bởi nhà cung cấp Tokyo Traders (có mã là 4)
  SELECT COUNT([SupplierID]) FROM [dbo].[Products] WHERE [SupplierID] = 4
