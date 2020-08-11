
SELECT OrderID, OrderDate FROM Orders WHERE MONTH(OrderDate) = 7 AND YEAR(OrderDate)=1997;

SELECT OrderID, OrderDate FROM Orders WHERE MONTH(OrderDate) IN (1,2,3) AND YEAR(OrderDate)=1997
AND MONTH(ShippedDate) IN (1,2,3) AND YEAR(ShippedDate)=1997;

-- Nua đầu tháng 7/1997
SELECT OrderID, OrderDate,[ShippedDate] FROM Orders WHERE MONTH(OrderDate)=7 AND YEAR(OrderDate)=1997 AND DAY(OrderDate)<=15 AND
MONTH(ShippedDate)=7 AND YEAR(ShippedDate)=1997 AND DAY(ShippedDate)<=15;

--Liệt kê thông tin STT, Tên, Ngày sinh của nhân viên.
SELECT [EmployeeID], CONCAT([LastName],' ',[FirstName]) as 'Name', [BirthDate] FROM Employees

--Liệt kê các khách hàng đã mua hàng trong năm 1997

SELECT Customers.CompanyName, Customers.ContactName, YEAR(Orders.OrderDate) FROM Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID
WHERE YEAR(Orders.OrderDate) = 1997;

-- Liệt kê các sản phẩm do công ty Exotic Liquids cung cấp trong năm 1997 và 1998.
SELECT distinct Products.ProductName FROM Products 
INNER JOIN  Suppliers ON Products.SupplierID = Suppliers.SupplierID
INNER join [dbo].[Order Details] a ON a.ProductID = Products.ProductID
INNER join Orders ON Orders.OrderID = a.OrderID
WHERE Suppliers.CompanyName = 'Exotic Liquids' AND YEAR(Orders.OrderDate) IN(1998,1997)
SELect * FROM [dbo].[Suppliers]

-- Liet ke chi tiet ID, ten san pham, so luong, don gia, thanh tien cua cac don hang
SELECT O.OrderID ,P.ProductName,OD.Quantity,OD.Discount,
  OD.Quantity * OD.UnitPrice AS 'Amount' FROM Orders O
INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
INNER JOIN [dbo].[Products] P ON  P.ProductID = OD.ProductID
GROUP BY P.ProductID,P.ProductName,OD.Quantity,OD.Discount

--Liệt kê các thông tin chi tiết trên của các đơn đặt hàng trong tháng 1/1998 
SELECT * FROM Orders 
WHERE YEAR([RequiredDate]) = 1998 AND MONTH([RequiredDate]) = 1
		AND YEAR([OrderDate]) = 1998 AND MONTH([OrderDate])= 1;

-- Tính thêm số tiền thanh toán trên mỗi hóa đơn
SELECT O.OrderID, ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) as 'Total' FROM Orders O
INNER JOIN [Order Details] OD ON OD.OrderID = O.OrderID
GROUP BY  O.OrderID

--Tính tổng doanh thu bán hàng Theo từng năm
SELECT YEAR(O.OrderDate) AS 'Year', 
ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) AS 'Amount'
FROM Orders O
INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
GROUP BY YEAR(O.OrderDate)
ORDER BY YEAR(O.OrderDate)

--Tính tổng doanh thu bán hàng Theo từng quý năm 1997:
SELECT YEAR(O.OrderDate) AS 'Year', DATEPART(QUARTER, O.OrderDate) AS  'Quarter',
ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3)  AS 'Amount'
FROM Orders O
INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY YEAR(O.OrderDate), DATEPART(QUARTER, O.OrderDate)
ORDER BY DATEPART(QUARTER, O.OrderDate)

-- Đếm số hóa đơn bán được trong mỗi năm
SELECT YEAR(O.OrderDate) AS 'YEAR' ,COUNT(O.OrderID) AS 'Number of' FROM Orders O
GROUP BY YEAR(O.OrderDate)
ORDER BY YEAR(O.OrderDate)

--Tính tổng doanh số bán hàng của mỗi nhân viên trong năm 1997.
SELECT O.EmployeeID,CONCAT(E.FirstName,' ',E.LastName), ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3)  AS 'Amount'
FROM Orders O
INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O. OrderID
INNER JOIN [dbo].[Employees] E ON  E.EmployeeID = O.EmployeeID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY O.EmployeeID,CONCAT(E.FirstName,' ',E.LastName)
ORDER BY ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) DESC

--Tìm nhân viên có doanh số bán hàng cao nhất.
SELECT TOP(1)
O.EmployeeID,CONCAT(E.FirstName,' ',E.LastName), ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3)  AS 'Amount'
FROM Orders O
INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O. OrderID
INNER JOIN [dbo].[Employees] E ON  E.EmployeeID = O.EmployeeID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY O.EmployeeID,CONCAT(E.FirstName,' ',E.LastName)
ORDER BY ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) DESC

