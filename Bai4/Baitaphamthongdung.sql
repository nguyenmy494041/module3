SELECT * FROM HAMTHONGDUNG

--Viết câu lệnh hiện thị tất cả các dòng có tên là Huong

SELECT * FROM HAMTHONGDUNG
WHERE TEN = 'HUONG'

--Viết câu lệnh lấy ra tổng số tiền của Huong

SELECT SUM(SOTIEN)
FROM HAMTHONGDUNG
WHERE TEN = 'HUONG'

-- Viết câu lệnh lấy ra tên danh sách của tất cả học viên, không trùng lặp

 SELECT DISTINCT TEN FROM HAMTHONGDUNG

 create view gffg 
 as
 select [OrderDate],[Freight], sum([Freight]) as 'sum' from [dbo].[Orders] group by [OrderDate],[Freight]

