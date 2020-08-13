-- Liệt kê thông tin ID, Họ tên, Tuổi của nhân viên.
          -- SELECT CURRENT_TIMESTAMP   DATEDIFF(year, '2019/04/28', '2021/04/28');
SELECT [EmployeeID], 
CONCAT([FirstName],' ',[LastName]) AS 'Name',
DATEDIFF(year,[BirthDate],CURRENT_TIMESTAMP) AS 'Age'
FROM [dbo].[Employees]

/* Bổ sung thêm thông tin về quốc gia. Lọc lấy các khách hàng thuộc nước Pháp và Tây Ban Nha
cùng mã số hóa đơn khách đã mua trong quý 3 và 4 của năm 1997.*/

SELECT C.CustomerID, C.CompanyName,C.Country, O.OrderID,O.OrderDate
FROM [dbo].[Customers] C
INNER JOIN [dbo].[Orders] O ON O.CustomerID = C.CustomerID
WHERE C.Country IN ('France','Spain') AND 
DATEPART(year,O.OrderDate) = 1997 AND 
DATEPART(Quarter,O.OrderDate) IN (3,4)

--Tính tổng cước phí mỗi khách hàng đã trả cho mỗi nhà chuyên chở. Cước phí: Freight, Nhà chuyên chở: ShipVia/Shipper.
SELECT O.CustomerID, S.CompanyName, SUM(O.Freight) AS 'Total Freight'
FROM [dbo].[Orders] O
INNER JOIN [dbo].[Shippers] S ON S.ShipperID = O.ShipVia
GROUP BY  O.CustomerID, S.CompanyName
ORDER BY O.CustomerID

--Tính tổng số tiền mỗi khách đã mua trong năm 1997.

SELECT O.CustomerID, ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) AS 'Amount'
FROM [dbo].[Orders] O
INNER JOIN [dbo].[Customers] C ON O.CustomerID = C.CustomerID
INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY O.CustomerID

--Tính tổng doanh số mỗi nhân viên đã bán được trong năm 1997
SELECT O.EmployeeID,ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) AS 'Amount'
FROM [dbo].[Orders] O
INNER JOIN [dbo].[Order Details] OD ON O.OrderID = OD.OrderID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY O.EmployeeID
ORDER BY O.EmployeeID

 --Tính tổng tiền bán được của mỗi loại sản phẩm trong năm 1997? 
 SELECT OD.ProductID, ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) AS 'Amount'
 FROM [dbo].[Order Details] OD
 INNER JOIN [dbo].[Orders] O ON O.OrderID = OD.OrderID
 WHERE YEAR(O.OrderDate) = 1997
GROUP BY OD.ProductID
ORDER BY OD.ProductID

--Tính tổng tiền bán được của mỗi loại sản phẩm Từng quý năm 1997?

 SELECT OD.ProductID,DATEPART(Quarter,O.OrderDate) AS 'Quarter', ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) AS 'Amount'
 FROM [dbo].[Order Details] OD
 INNER JOIN [dbo].[Orders] O ON O.OrderID = OD.OrderID
 WHERE YEAR(O.OrderDate) = 1997 
GROUP BY OD.ProductID,DATEPART(Quarter,O.OrderDate)
ORDER BY OD.ProductID

--Liệt kê các quốc gia có trên 3 khách hàng
SELECT Country, COUNT(Country) AS 'Number Custumer'
FROM [dbo].[Customers]
GROUP BY Country
HAVING COUNT(Country) >3

--Liệt kê loại sản phẩm có nhiều sản phẩm nhất

SELECT *
FROM [dbo].[Products]
WHERE UnitsInStock = (SELECT  MAX(UnitsInStock) FROM [dbo].[Products])

-- Liệt kê tên khách hàng mua hàng nhiều nhất trong năm 1997? Trong mỗi năm?
SELECT YEAR(O.OrderDate),o.CustomerID, ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) AS 'Amount'
FROM [dbo].[Customers] C
INNER JOIN [dbo].[Orders] O ON O.CustomerID = C.CustomerID
INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
WHERE YEAR(O.OrderDate) IN(1996,1997,1998)
GROUP BY YEAR(O.OrderDate),o.CustomerID
ORDER BY ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) DESC


-- Liệt kê tên khách hàng mua hàng nhiều nhất trong năm 1997? Trong mỗi năm?
/*ALTER PROCEDURE procedure_BestSales 
AS
BEGIN

declare @tbYear TABLE([year] int)
declare @year int
declare @BestSalesOfYear TABLE([year] int,Customer varchar(5),Amount float) 


insert into @tbYear select distinct year(OrderDate) [Year] from Orders

--dùng vòng lặp
while (exists (select * from @tbYear))
	begin
	
		set @year = (select top(1) [Year] from @tbYear)
		insert into @BestSalesOfYear
		SELECT TOP(1) YEAR(O.OrderDate)as 'year',o.CustomerID as 'custumer', ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) 
		FROM [dbo].[Customers] C
		INNER JOIN [dbo].[Orders] O ON O.CustomerID = C.CustomerID
		INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
		GROUP BY YEAR(O.OrderDate),o.CustomerID
		having YEAR(O.OrderDate) = @year 
		ORDER BY YEAR(O.OrderDate),ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) DESC

		delete from @tbYear where [Year] = @year
		
	end
select * from @BestSalesOfYear
end

procedure_BestSales */

ALTER FUNCTION BestSales()
RETURNS @BestSalesOfYear TABLE (
				[year] INT,
				Customer VARCHAR(50),
				Amount FLOAT
				)
AS
BEGIN
DECLARE @tbYear TABLE([year] INT)
DECLARE @year INT
INSERT INTO @tbYear SELECT DISTINCT YEAR(OrderDate) [Year] FROM Orders
WHILE (EXISTS (SELECT * FROM @tbYear))
	BEGIN
	
		SET @year = (SELECT TOP(1) [Year] FROM @tbYear)
		INSERT INTO @BestSalesOfYear
		SELECT TOP(1) YEAR(O.OrderDate)as 'YEAR',o.CustomerID as 'CUSTOMER', ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) 
		FROM [dbo].[Customers] C
		INNER JOIN [dbo].[Orders] O ON O.CustomerID = C.CustomerID
		INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
		GROUP BY YEAR(O.OrderDate),o.CustomerID
		having YEAR(O.OrderDate) = @year 
		ORDER BY YEAR(O.OrderDate),ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) DESC
		DELETE FROM @tbYear WHERE [Year] = @year		
	END
RETURN 
END
 SELECT * FROM bestsales() ORDER BY [YEAR] DESC

-- Cách ông Tung Lam
-- select * from (
--select h.*,rank() over (partition by Years order by [Total Money Buy] desc) as BXH
--from (
--SELECT TOP(15)
--		C.CustomerID,
--		C.CompanyName,
--		C.ContactName,
--		YEAR(O.OrderDate) AS 'Years',
--		ROUND(SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)),2) AS 'Total Money Buy'
--FROM Orders AS O	INNER JOIN Customers AS C ON O.CustomerID = C.CustomerID
--					INNER JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
--GROUP BY C.CustomerID, C.CompanyName, C.ContactName,YEAR(O.OrderDate)
--ORDER BY ROUND(SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)),2) DESC) as h ) as b where b.BXH=1

SELECT  OrderYear ,oCustomerID, MAX(Amount) as maxSalary, Amount
FROM (SELECT  YEAR(O.OrderDate) as OrderYear,o.CustomerID as oCustomerID, ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) AS Amount
FROM [dbo].[Customers] C
INNER JOIN [dbo].[Orders] O ON O.CustomerID = C.CustomerID
INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
WHERE YEAR(O.OrderDate) IN( 1996, 1997, 1998)
GROUP BY YEAR(O.OrderDate),o.CustomerID) as afterTable HAVING Amount = MAX(Amount)