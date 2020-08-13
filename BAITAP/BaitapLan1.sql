-- Them du lieu cho bang MAT HANG
CREATE PROC proc_LendanhsahMathang
(
	@tenmathang varchar(50),
	@loaiquycach varchar(50),
	@giaban money,
	@soluonghienco int
)
AS
BEGIN
INSERT INTO MATHANG
		VALUES(
		@tenmathang,
		@loaiquycach,
		@giaban,
		@soluonghienco
		)
END

EXEC proc_LendanhsahMathang Sachgiaokhoa, Vanphongpham,45000,97;

---- Them du lieu cho bang CHUNG TU
ALTER PROC proc_LendanhsachcacChungTu
(
	@ngaylapchungtu date,
	@tenkhachhang varchar(50),
	@diachi varchar(50),
	@mamathang int,
	@soluong int,
	@dongia money
)
AS
BEGIN
	INSERT INTO CHUNGTU
	VALUES(
	@ngaylapchungtu,
	@tenkhachhang,
	@diachi,
	@mamathang,
	@soluong,
	@dongia
	)
END
EXEC proc_LendanhsachcacChungTu '2020-03-06',[Anh Long],[Tp Hue],1,15,25000;


---- Them du lieu cho bang CHUNG TU
CREATE PROC proc_LendanhsachPhieuThu
(
@sochungtu int,
@ngaythutien date,
@sotienthu money
)
AS
BEGIN
INSERT INTO PHIEUTHU
VALUES
(
@sochungtu,
@ngaythutien,
@sotienthu
)
END

EXEC proc_LendanhsachPhieuThu 1,'2020-03-06',25000;


-- Update bang MATHANG
CREATE PROC proc_UpdateBangMatHang
(	@mamathang int,
	@tenmathang varchar(50),
	@loaiquycach varchar(50),
	@giaban money,
	@soluonghienco int
)
AS
UPDATE MATHANG

   SET TenMatHang =@tenmathang,
      LoaiQuyCach = @loaiquycach,
      GiaBan = @giaban,
      SoluongHienCo =@soluonghienco
 WHERE MaMatHang = @mamathang

 --Update bang CHUNHTU
 ALTER PROC proc_UpdateBangChungTu
(	@sochungtu int,
	@ngaylapchungtu date,
	@tenkhachhang varchar(50),
	@diachi varchar(50),
	@mamathang int,
	@soluong int,
	@dongia money	
)
AS
UPDATE CHUNGTU
 SET  
	  NgayLapChungTu = @ngaylapchungtu,
      TenKhachHang = @tenkhachhang,
      DiaChi = @diachi,
      MaMatHang = @mamathang,
      SoLuongBan = @soluong,
      DonGia = @dongia
 WHERE SoChungTu = @sochungtu

  --Update bang PHIEU THU

 CREATE PROC proc_UpdateBangPhieuTHu
(
	@sophieuthu int,	
	@sochungtu int,
	@ngaythutien date,
	@sotienthu money
)
AS
UPDATE PHIEUTHU
	SET		
		SoChungTu= @sochungtu,
		NgayThuTien= @ngaythutien,
		SoTienThu = @sophieuthu
	WHERE SoChungTu = @sophieuthu

-- Thiết kế một View bao gồm thông tin chi tiết của tất cả các Chứng Từ trong CSDL trên.
CREATE VIEW VW_ThongtincacChungTu
AS
SELECT SoChungTu,NgayLapChungTu,TenKhachHang,MaMatHang,SoLuongBan,DonGia
FROM ChungTu


--Viết thủ tục hiển thị thông tin chi tiết của tất cả các Mặt Hàng có trong CSDL.

CREATE PROC proc_ThongtincacMatHang
AS
SELECT * FROM Mathang

EXEC proc_ThongtincacMatHang;

--Viết thủ tục trả về thông tin chi tiết của một Chứng Từ có trong CSDL
CREATE PROC proc_LayveThongTinCuaChungTu
(
	@sochungtu int
)
AS
BEGIN
DECLARE @bangketqua TABLE 
(
	SoChungTu int,
	NgayLapChungTu date,
	TenKhachHang varchar(50),
	DiaChi varchar(50),
	MaMatHang int,
	SoLuongBan int,
	DonGia money
)
INSERT INTO @bangketqua
		SELECT * FROM ChungTu
		WHERE SoChungTu = @sochungtu
SELECT * FROM @bangketqua
END

EXEC proc_LayveThongTinCuaChungTu 1
EXEC proc_ThongtincacMatHang