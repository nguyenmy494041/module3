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
INNER JOIN [dbo].[Customers] C ON C.CustomerID = O.CustomerID
GROUP BY  O.CustomerID, S.CompanyName
ORDER BY O.CustomerID

