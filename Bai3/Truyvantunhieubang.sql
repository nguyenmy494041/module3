SELECT ProductID,
  COUNT(OrderID) 'Orders Count',
 ROUND ( SUM((1 - Discount) * UnitPrice * Quantity),3,0) 'Sales'
FROM [Order Details]
GROUP BY ProductID
ORDER BY Sales DESC


SELECT * FROM [Order Details]


SELECT od.ProductID, P.ProductName,
  COUNT(od.ProductID) 'Orders Count',
  ROUND (SUM((1 - od.Discount) * od.UnitPrice * od.Quantity),3) 'Sales'
FROM [Order Details] od
  LEFT JOIN Products P ON od.ProductID = P.ProductID
GROUP BY od.ProductID, P.ProductName
ORDER BY Sales DESC



SELECT Suplier, SUM(Sales)
FROM (
  SELECT [O D].ProductID,
    P.ProductName,
    S.CompanyName Suplier,
    COUNT([O D].ProductID) 'Orders Count',
    SUM((1 - [O D].Discount) * [O D].UnitPrice * [O D].Quantity) 'Sales'
  FROM [Order Details] [O D]
         LEFT JOIN Products P ON [O D].ProductID = P.ProductID
         LEFT JOIN Suppliers S ON P.SupplierID = S.SupplierID
  GROUP BY [O D].ProductID, P.ProductName, S.CompanyName) AS Sales
GROUP BY Suplier
ORDER BY SUM(Sales) DESC 
