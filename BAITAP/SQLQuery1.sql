--2. 1 Cho biết danh sách các đối tác cung cấp hàng cho công ty
SELECT Macongty, TenCongTy FROM [dbo].[NhaCungCap]

--2. 2 Mã hàng, tên hàng và số lượng của các mặt hàng hiện có trong công ty
SELECT Mahang,TenHang,SoLuong
FROM [dbo].[MatHang]

--2. 3 Họ tên và địa chỉ và năm bắt đầu làm việc của các nhân viên trong công ty
 SELECT CONCAT(Ho,' ',Ten) as 'Họ tên', DiaChi, Year(NgayLamViec) as 'Năm làm việc'
 FROM [dbo].[NhanVien]

 --2. 4 Địa chỉ và điện thoại của nhà cung cấp có tên giao dịch VINAMILK là gì
 SELECT MaCongTy,TenCongTy,DiaChi,DienThoai
 FROM [dbo].[NhaCungCap]
 WHERE TenGiaoDich = 'VINAMILK'

 --2. 5 Cho biết mã và tên của các mặt hàng có giá lớn hơn 100000 và số lượng hiện có ít hơn 50.
 SELECT MaHang,TenHang,SoLuong,GiaHang
 FROM [dbo].[MatHang]
 WHERE GiaHang > 100000 AND SoLuong < 50

-- 2. 6 Cho biết mỗi mặt hàng trong công ty do ai cung cấp.
SELECT MaHang,TenHang,TenCongTy
FROM [dbo].[MatHang] M
INNER JOIN [dbo].[NhaCungCap] N ON M.MaCongTy = N.MaCongTy 

--2. 7 Công ty Làng Vũ Đại đã cung cấp những mặt hàng nào?
SELECT M.MaHang,M.TenHang,M.SoLuong
FROM [dbo].[NhaCungCap] N
INNER JOIN [dbo].[MatHang] M ON N.MaCongTy = M.MaCongTy
WHERE N.TenCongTy = N'Làng Vũ Đại'

--2. 8 Loại hàng thực phẩm do những công ty nào cung cấp và địa chỉ của các công ty đó là gì?
SELECT M.MaHang, M.TenHang,L.TenLoaiHang
FROM [dbo].[LoaiHang] L
INNER JOIN [dbo].[MatHang] M ON L.MaLoaiHang = M.MaLoaiHang
INNER JOIN [dbo].[NhaCungCap] N ON M.MaCongTy = N.MaCongTy
WHERE L.TenLoaiHang = N'Thực phẩm'

--2. 9 Những khách hàng nào (tên giao dịch) đã đặt mua mặt hàng Sữa Ông Thọ của công ty?
SELECT N.MaCongTy,N.TenCongTy,N.TenGiaoDich
FROM [dbo].[MatHang] M
INNER JOIN [dbo].[NhaCungCap] N ON M.MaCongTy = N.MaCongTy
WHERE M.TenHang = N'Sữa Ông Thọ'

--2. 10 Đơn đặt hàng số 1 do ai đặt và do nhân viên nào lập, thời gian và địa điểm giao hàng là ở đâu?
SELECT K.MaKhachHang,K.TenCongTy,CONCAT(N.Ho, ' ',N.Ten) as 'Họ tên'
FROM [dbo].[DonDatHang] D 
INNER JOIN [dbo].[NhanVien] N ON D.MaNhanVien = N.MaNhanVien
INNER JOIN [dbo].[KhachHang] K ON K.MaKhachHang = D.MaKhachHang
WHERE D.SoHoaDon = 1

--2. 11 Hãy cho biết số tiền lương mà công ty phải trả cho mỗi nhân viên là bao nhiêu (lương = lương cơ bản + phụ cấp).
SELECT MaNhanVien,LuongCoBan + PhuCap as 'Lương'
FROM [dbo].[NhanVien] 

--2. 12 Trong đơn đặt hàng số 3 đặt mua những mặt hàng nào và số tiền mà khách hàng phải trả cho mỗi mặt hàng là bao nhiêu (số tiền phải trả được tính theo công thức
--SOLUONG×GIABAN – SOLUONG×GIABAN×MUCGIAMGIA/100)
SELECT c.MaHang,m.TenHang, (1-c.MucGiamGia /100)*c.SoLuong*c.GiaBan AS 'Tiền'
FROM [dbo].[DonDatHang] d
INNER JOIN [dbo].[ChiTietDatHang] c ON d.SoHoaDon = c.SoHoaDon
INNER JOIN [dbo].[MatHang] m ON m.MaHang = c.MaHang
WHERE c.SoHoaDon = 3

--2. 13 Hãy cho biết có những khách hàng nào lại chính là đối tác cung cấp hàng của công ty (tức là có cùng tên giao dịch).
SELECT N.MaCongTy,N.TenCongTy,N.DiaChi,N.DienThoai
FROM [dbo].[NhaCungCap] N
INNER JOIN [dbo].[KhachHang] K ON K.TenGiaoDich = N.TenGiaoDich

--2. 14 Trong công ty có những nhân viên nào có cùng ngày sinh?
Select v1.MaNhanVien, CONCAT(v1.Ho,' ',v1.Ten),v1.NgaySinh
FROM [dbo].[NhanVien] v1 
INNER JOIN [dbo].[NhanVien] v2 ON v2.NgaySinh = v1.NgaySinh 
WHERE v2.MaNhanVien != v1.MaNhanVien

--2. 15 Những đơn đặt hàng nào yêu cầu giao hàng ngay tại công ty đặt hàng và những đơn đó là của công ty nào?
SELECT d.SoHoaDon, k.TenCongTy,d.NoiGiaoHang
FROM [dbo].[DonDatHang] d
INNER JOIN [dbo].[KhachHang] K ON K.MaKhachHang = d.MaKhachHang
WHERE d.NoiGiaoHang = K.TenCongTy

--2. 16 Cho biết tên công ty, tên giao dịch, địa chỉ và điện thoại của các khách hàng và các nhà cung cấp hàng cho công ty.
SELECT TenCongTy, TenGiaoDich,DiaChi,DienThoai
FROM [dbo].[KhachHang] 
UNION 
SELECT TenCongTy, TenGiaoDich,DiaChi,DienThoai
FROM [dbo].[NhaCungCap]

--2. 17 Những mặt hàng nào chưa từng được khách hàng đặt mua?
SELECT MaHang, TenHang
FROM [dbo].[MatHang]
WHERE MaHang NOT IN 
(
SELECT MaHang
FROM [dbo].[ChiTietDatHang]
)
--2. 18 Những nhân viên nào của công ty chưa từng lập bất kỳ một hoá đơn đặt hàng nào?
SELECT MaNhanVien,CONCAT(Ho,' ', Ten)AS 'Họ tên'
FROM [dbo].[NhanVien]
WHERE MaNhanVien NOT IN 
(
SELECT MaNhanVien
FROM [dbo].[DonDatHang]
)

--2. 19 Những nhân viên nào của công ty có lương cơ bản cao nhất?
SELECT MaNhanVien,CONCAT(Ho,' ', Ten)AS 'Họ tên', LuongCoBan+PhuCap AS 'Lương'
FROM NhanVien
WHERE LuongCoBan+PhuCap = (SELECT MAX(LuongCoBan+PhuCap) FROM NhanVien)

--2. 20 Tổng số tiền mà khách hàng phải trả cho mỗi đơn đặt hàng là bao nhiêu?
SELECT DonDatHang.SoHoaDon,KhachHang.TenCongTy, KhachHang.TenGiaoDich,
SUM((1-c.MucGiamGia/100)*c.SoLuong*c.GiaBan) as 'Tổng tiền'
FROM DonDatHang 
INNER JOIN [dbo].[ChiTietDatHang] c ON c.SoHoaDon = DonDatHang.SoHoaDon
INNER JOIN KhachHang ON KhachHang.MaKhachHang = DonDatHang.MaKhachHang
GROUP BY DonDatHang.SoHoaDon,KhachHang.TenCongTy,KhachHang.TenGiaoDich

--2. 21 Trong năm 2020, những mặt hàng nào chỉ được đặt mua đúng một lần.
SELECT m.MaHang,m.TenHang
FROM DonDatHang d
INNER JOIN ChiTietDatHang c ON d.SoHoaDon = c.SoHoaDon
INNER JOIN MatHang m ON m.MaHang = c.MaHang
WHERE YEAR(d.NgayDatHang)=2020
GROUP BY m.MaHang,m.TenHang
HAVING COUNT(c.MaHang) = 1

--2. 22 Hãy cho biết mỗi một khách hàng đã phải bỏ ra bao nhiêu tiền để đặt mua hàng của công ty?
SELECT k.MaKhachHang,k.TenCongTy,k.TenGiaoDich,SUM((1-c.MucGiamGia/100)*c.SoLuong*c.GiaBan) as 'Tổng tiền'
FROM DonDatHang d
INNER JOIN ChiTietDatHang c ON d.SoHoaDon = c.SoHoaDon
INNER JOIN KhachHang k ON k.MaKhachHang = d.MaKhachHang
GROUP BY  k.MaKhachHang,k.TenCongTy,k.TenGiaoDich

--2. 23 Mỗi một nhân viên của công ty đã lập bao nhiêu đơn đặt hàng (nếu nhân viên chưa hề lập một hoá đơn nào thì cho kết quả là 0)
SELECT n.MaNhanVien, COUNT(d.MaNhanVien) as 'Number of Order'
FROM NhanVien n
LEFT JOIN DonDatHang d ON n.MaNhanVien = d.MaNhanVien
GROUP BY n.MaNhanVien

--2. 24 Cho biết tổng số tiền hàng mà cửa hàng thu được trong mỗi tháng của năm 2020 (thời được gian tính theo ngày đặt hàng).
SELECT YEAR(d.NgayDatHang) AS 'Year',MONTH(d.NgayDatHang) AS 'Month',SUM((1-c.MucGiamGia/100)*c.SoLuong*c.GiaBan) as 'Tổng tiền'
FROM DonDatHang d
INNER JOIN ChiTietDatHang c ON d.SoHoaDon = c.SoHoaDon
GROUP BY YEAR(d.NgayDatHang),MONTH(d.NgayDatHang)
HAVING YEAR(d.NgayDatHang)=2020


--2. 25 Hãy cho biết tổng số tiền lời mà công ty thu được từ mỗi mặt hàng trong năm 2020.
SELECT c.MaHang,m.TenHang,SUM((1-c.MucGiamGia/100)*c.SoLuong*c.GiaBan - c.SoLuong*m.GiaHang) as 'Tổng tiền'
FROM DonDatHang d
INNER JOIN ChiTietDatHang c ON d.SoHoaDon = c.SoHoaDon
INNER JOIN MatHang m ON m.MaHang = c.MaHang
WHERE YEAR(d.NgayDatHang)=2020
GROUP BY c.MaHang,m.TenHang

--2. 26 Hãy cho biết tổng số lượng hàng của mỗi mặt hàng mà công ty đã có (tổng số lượng hàng hiện có và đã bán).
SELECT a.MaHang,a.TenHang,
CASE WHEN a.[Tổng sô lượng]+MatHang.SoLuong IS NULL THEN MatHang.SoLuong ELSE a.[Tổng sô lượng]+MatHang.SoLuong END AS 'Tổng số lựơng'
FROM (
SELECT m.MaHang,m.TenHang,Sum(c.SoLuong) AS 'Tổng sô lượng'
FROM MatHang m
LEFT JOIN ChiTietDatHang c ON m.MaHang = c.MaHang
GROUP BY m.MaHang,m.TenHang) as a inner join MatHang on MatHang.MaHang = a.MaHang

--2. 27 Nhân viên nào của công ty bán được số lượng hàng nhiều nhất và số lượng hàng bán được của những nhân viên này là bao nhiêu?

SELECT n.MaNhanVien, CONCAT(n.Ho,' ', n.Ten) AS 'Họ tên',SUM(c.SoLuong)as'Số lượng đã bán'
FROM NhanVien n
INNER JOIN DonDatHang d ON d.MaNhanVien = n.MaNhanVien
INNER JOIN ChiTietDatHang c ON c.SoHoaDon = d.SoHoaDon
GROUP BY  n.MaNhanVien, CONCAT(n.Ho,' ', n.Ten)
HAVING SUM(c.SoLuong) >= ALL (
SELECT SUM(c.SoLuong)
FROM NhanVien n
INNER JOIN DonDatHang d ON d.MaNhanVien = n.MaNhanVien
INNER JOIN ChiTietDatHang c ON c.SoHoaDon = d.SoHoaDon
GROUP BY  n.MaNhanVien
)

--2. 28 Đơn đặt hàng nào có số lượng hàng được đặt mua ít nhất?
SELECT d.SoHoaDon, SUM(c.SoLuong) AS 'Số lượng sản phẩm'
FROM [dbo].[DonDatHang] d
INNER JOIN ChiTietDatHang c ON c.SoHoaDon = d.SoHoaDon
group by d.SoHoaDon
HAVING SUM(c.SoLuong) >= ALL (SELECT SUM(c.SoLuong)
FROM [dbo].[DonDatHang] d
INNER JOIN ChiTietDatHang c ON c.SoHoaDon = d.SoHoaDon
group by d.SoHoaDon)

--2. 29 Số tiền nhiều nhất mà mỗi khách hàng đã từng bỏ ra để đặt hàng trong các đơn đặt hàng là bao nhiêu?
SELECT k.MaKhachHang,k.TenCongTy,SUM((1-c.MucGiamGia/100)*c.SoLuong*c.GiaBan) as 'Tổng tiền'
FROM DonDatHang d
INNER JOIN ChiTietDatHang c ON c.SoHoaDon = d.SoHoaDon
INNER JOIN KhachHang k ON K.MaKhachHang = d.MaKhachHang
GROUP BY k.MaKhachHang,k.TenCongTy
HAVING SUM((1-c.MucGiamGia/100)*c.SoLuong*c.GiaBan) >= ALL (
SELECT SUM((1-c.MucGiamGia/100)*c.SoLuong*c.GiaBan)
FROM DonDatHang d
INNER JOIN ChiTietDatHang c ON c.SoHoaDon = d.SoHoaDon
INNER JOIN KhachHang k ON K.MaKhachHang = d.MaKhachHang
GROUP BY k.MaKhachHang
)

--2. 30 Mỗi một đơn đặt hàng đặt mua những mặt hàng nào và tổng số tiền mà mỗi đơn đặt hàng phải trả là bao nhiêu?
SELECT kq.SoHoaDon, STRING_AGG(CONCAT(kq.TenHang,': ',kq.SoLuong),'; ')
AS 'Loại hàng: Số lượng',sum(kq.[Tổng tiền])AS'Tổng tiền'
FROM(
SELECT d.SoHoaDon,m.TenHang,c.SoLuong,SUM((1-c.MucGiamGia/100)*c.SoLuong*c.GiaBan) as 'Tổng tiền'
FROM DonDatHang d
INNER JOIN ChiTietDatHang c ON  d.SoHoaDon =c.SoHoaDon
INNER JOIN MatHang m ON m.MaHang = c.MaHang
GROUP BY d.SoHoaDon,m.TenHang,c.SoLuong) AS kq
GROUP BY kq.SoHoaDon

--2. 31 Hãy cho biết mỗi một loại hàng bao gồm những mặt hàng nào, tổng số lượng 
--hàng của mỗi loại và tổng số lượng của tất cả các mặt hàng hiện có trong công ty là bao nhiêu?
SELECT kq.MaLoaiHang,STRING_AGG(Concat(kq.TenHang,': ',kq.SoLuong,' ',kq.DonViTinh),'; ') 
AS 'Loại hàng: Số lượng',sum(kq.SoLuong)AS'Tổng số lượng'
FROM (
SELECT l.MaLoaiHang,m.MaHang,m.TenHang,m.SoLuong,m.DonViTinh
FROM LoaiHang l 
INNER JOIN MatHang m ON m.MaLoaiHang = l.MaLoaiHang
) AS kq
GROUP BY  kq.MaLoaiHang


--2. 32 Thống kê xem trong năm 2020, mỗi một mặt hàng trong mỗi tháng và trong cả năm bán được với số lượng bao nhiêu
--Yêu cầu: Kết quả được hiển thị dưới dạng bảng, hai cột cột đầu là mã hàng và
--tên hàng, các cột còn lại tương ứng với các tháng từ 1 đến 12 và cả năm. Như
--vậy mỗi dòng trong kết quả cho biết số lượng hàng bán được mỗi tháng và trong
--cả năm của mỗi mặt hàng.
SELECT m.MaHang,m.TenHang, 
SUM(CASE MONTH(d.NgayDatHang)WHEN 1 THEN c.SoLuong ELSE 0 END) AS thang1,
SUM(CASE MONTH(d.NgayDatHang)WHEN 2 THEN c.SoLuong ELSE 0 END) AS thang2
FROM MatHang m
INNER JOIN ChiTietDatHang c ON m.MaHang = c.MaHang
INNER JOIN DonDatHang d ON c.SoHoaDon = d.SoHoaDon
WHERE YEAR(d.NgayDatHang)=2020
group by m.MaHang,m.TenHang 



--Sử dụng câu lệnh UPDATE để thực hiện các yêu cầu sau:
--2. 33 Cập nhật lại giá trị trường NGAYCHUYENHANG của những bản ghi có
--NGAYCHUYENHANG chưa xác định (NULL) trong bảng DONDATHANG
--bằng với giá trị của trường NGAYDATHANG.2. 34 Tăng số lượng hàng của những mặt hàng do công ty VINAMILK cung cấp lên gấp
--đôi.
--2. 35 Cập nhật giá trị của trường NOIGIAOHANG trong bảng DONDATHANG bằng địa
--chỉ của khách hàng đối với những đơn đặt hàng chưa xác định được nơi giao hàng
--(giá trị trường NOIGIAOHANG bằng NULL).
--2. 36 Cập nhật lại dữ liệu trong bảng KHACHHANG sao cho nếu tên công ty và tên giao
--dịch của khách hàng trùng với tên công ty và tên giao dịch của một nhà cung cấp
--nào đó thì địa chỉ, điện thoại, fax và e-mail phải giống nhau.
--2. 37 Tăng lương lên gấp rưỡi cho những nhân viên bán được số lượng hàng nhiều hơn
--100 trong năm 2003

