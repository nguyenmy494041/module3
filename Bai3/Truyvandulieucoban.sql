SELECT * FROM Customers;

SELECT TOP 10 CustomerID, ContactName, City, Country, Phone
FROM Customers ORDER BY CustomerID DESC

SELECT * FROM Orders WHERE CustomerID IN ('VINET','RICSU','FRANK');

SELECT TOP 1 * FROM [Order Details] 