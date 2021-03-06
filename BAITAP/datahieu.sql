

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDatHang](
	[SoHoaDon] [int] NOT NULL,
	[MaHang] [int] NOT NULL,
	[GiaBan] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MucGiamGia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 8/12/2020 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[SoHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[NgayDatHang] [date] NOT NULL,
	[NgayGiaoHang] [date] NULL,
	[NgayChuyenHang] [date] NULL,
	[NoiGiaoHang] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 8/12/2020 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenCongTy] [nvarchar](100) NOT NULL,
	[TenGiaoDich] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[Email] [char](50) NULL,
	[DienThoai] [char](20) NOT NULL,
	[FAX] [char](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 8/12/2020 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[MaLoaiHang] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiHang] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 8/12/2020 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[MaHang] [int] IDENTITY(1,1) NOT NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[MaCongTy] [int] NOT NULL,
	[MaLoaiHang] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonViTinh] [nvarchar](20) NOT NULL,
	[GiaHang] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 8/12/2020 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaCongTy] [int] IDENTITY(1,1) NOT NULL,
	[TenCongTy] [nvarchar](100) NOT NULL,
	[TenGiaoDich] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[DienThoai] [char](20) NOT NULL,
	[Fax] [char](20) NOT NULL,
	[Email] [char](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCongTy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 8/12/2020 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[Ho] [nvarchar](10) NOT NULL,
	[Ten] [nvarchar](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[NgayLamViec] [date] NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[DienThoai] [char](20) NOT NULL,
	[LuongCoBan] [int] NOT NULL,
	[PhuCap] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDatHang] ([SoHoaDon], [MaHang], [GiaBan], [SoLuong], [MucGiamGia]) VALUES (1, 2, 10000, 1000, 10)
INSERT [dbo].[ChiTietDatHang] ([SoHoaDon], [MaHang], [GiaBan], [SoLuong], [MucGiamGia]) VALUES (2, 3, 100000, 100, 5)
INSERT [dbo].[ChiTietDatHang] ([SoHoaDon], [MaHang], [GiaBan], [SoLuong], [MucGiamGia]) VALUES (3, 2, 10000, 10, 10)
INSERT [dbo].[ChiTietDatHang] ([SoHoaDon], [MaHang], [GiaBan], [SoLuong], [MucGiamGia]) VALUES (3, 4, 100000, 10, 5)
INSERT [dbo].[ChiTietDatHang] ([SoHoaDon], [MaHang], [GiaBan], [SoLuong], [MucGiamGia]) VALUES (4, 4, 100000, 10, 10)
INSERT [dbo].[ChiTietDatHang] ([SoHoaDon], [MaHang], [GiaBan], [SoLuong], [MucGiamGia]) VALUES (5, 2, 5000, 10, 10)
INSERT [dbo].[ChiTietDatHang] ([SoHoaDon], [MaHang], [GiaBan], [SoLuong], [MucGiamGia]) VALUES (6, 5, 20000, 12, 5)
INSERT [dbo].[ChiTietDatHang] ([SoHoaDon], [MaHang], [GiaBan], [SoLuong], [MucGiamGia]) VALUES (7, 5, 200000, 10, 5)
GO
SET IDENTITY_INSERT [dbo].[DonDatHang] ON 

INSERT [dbo].[DonDatHang] ([SoHoaDon], [MaKhachHang], [MaNhanVien], [NgayDatHang], [NgayGiaoHang], [NgayChuyenHang], [NoiGiaoHang]) VALUES (1, 1, 1, CAST(N'2020-05-05' AS Date), CAST(N'2020-05-30' AS Date), CAST(N'2020-05-05' AS Date), N'Đà Nẵng')
INSERT [dbo].[DonDatHang] ([SoHoaDon], [MaKhachHang], [MaNhanVien], [NgayDatHang], [NgayGiaoHang], [NgayChuyenHang], [NoiGiaoHang]) VALUES (2, 2, 2, CAST(N'2020-05-20' AS Date), CAST(N'2020-05-30' AS Date), CAST(N'2020-05-20' AS Date), N'Quảng Trị')
INSERT [dbo].[DonDatHang] ([SoHoaDon], [MaKhachHang], [MaNhanVien], [NgayDatHang], [NgayGiaoHang], [NgayChuyenHang], [NoiGiaoHang]) VALUES (3, 3, 3, CAST(N'2020-06-20' AS Date), CAST(N'2020-04-30' AS Date), CAST(N'2020-06-20' AS Date), N'Thanh Hóa')
INSERT [dbo].[DonDatHang] ([SoHoaDon], [MaKhachHang], [MaNhanVien], [NgayDatHang], [NgayGiaoHang], [NgayChuyenHang], [NoiGiaoHang]) VALUES (4, 1, 2, CAST(N'2020-03-20' AS Date), CAST(N'2020-05-30' AS Date), CAST(N'2020-03-20' AS Date), N'Huế')
INSERT [dbo].[DonDatHang] ([SoHoaDon], [MaKhachHang], [MaNhanVien], [NgayDatHang], [NgayGiaoHang], [NgayChuyenHang], [NoiGiaoHang]) VALUES (5, 3, 2, CAST(N'2020-02-20' AS Date), CAST(N'2020-05-30' AS Date), CAST(N'2020-02-20' AS Date), N'Thanh Hóa')
INSERT [dbo].[DonDatHang] ([SoHoaDon], [MaKhachHang], [MaNhanVien], [NgayDatHang], [NgayGiaoHang], [NgayChuyenHang], [NoiGiaoHang]) VALUES (6, 3, 2, CAST(N'2020-02-20' AS Date), CAST(N'2020-05-30' AS Date), CAST(N'2020-02-20' AS Date), N'Thanh Hóa')
INSERT [dbo].[DonDatHang] ([SoHoaDon], [MaKhachHang], [MaNhanVien], [NgayDatHang], [NgayGiaoHang], [NgayChuyenHang], [NoiGiaoHang]) VALUES (7, 3, 2, CAST(N'2019-01-01' AS Date), CAST(N'2020-05-30' AS Date), CAST(N'2019-01-01' AS Date), N'Thanh Hóa')
SET IDENTITY_INSERT [dbo].[DonDatHang] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [TenCongTy], [TenGiaoDich], [DiaChi], [Email], [DienThoai], [FAX]) VALUES (1, N'TPH', N'tph', N'Đà Nẵng', N'skfhsdk@email.com                                 ', N'545546              ', N'98374               ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenCongTy], [TenGiaoDich], [DiaChi], [Email], [DienThoai], [FAX]) VALUES (2, N'NB', N'nb', N'Huế', N'sfkfksdhfkds@email.com                            ', N'1398647             ', N'16372               ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenCongTy], [TenGiaoDich], [DiaChi], [Email], [DienThoai], [FAX]) VALUES (3, N'VL', N'vl', N'Thanh Hóa', N'fsdfsk@email.com                                  ', N'93277439            ', N'3242496             ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenCongTy], [TenGiaoDich], [DiaChi], [Email], [DienThoai], [FAX]) VALUES (4, N'HPT', N'hpt', N'Huế', N'skufskfd@gmail.cm                                 ', N'248323432           ', N'129343              ')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiHang] ON 

INSERT [dbo].[LoaiHang] ([MaLoaiHang], [TenLoaiHang]) VALUES (1, N'Bánh')
INSERT [dbo].[LoaiHang] ([MaLoaiHang], [TenLoaiHang]) VALUES (2, N'Kẹo')
INSERT [dbo].[LoaiHang] ([MaLoaiHang], [TenLoaiHang]) VALUES (3, N'Sữa')
INSERT [dbo].[LoaiHang] ([MaLoaiHang], [TenLoaiHang]) VALUES (4, N'CF')
INSERT [dbo].[LoaiHang] ([MaLoaiHang], [TenLoaiHang]) VALUES (5, N'Thực phẩm')
INSERT [dbo].[LoaiHang] ([MaLoaiHang], [TenLoaiHang]) VALUES (6, N'Nước ngọt')
INSERT [dbo].[LoaiHang] ([MaLoaiHang], [TenLoaiHang]) VALUES (7, N'Bia')
SET IDENTITY_INSERT [dbo].[LoaiHang] OFF
GO
SET IDENTITY_INSERT [dbo].[MatHang] ON 

INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaCongTy], [MaLoaiHang], [SoLuong], [DonViTinh], [GiaHang]) VALUES (2, N'Bánh Pía', 1, 1, 3200, N'Hộp', 1000)
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaCongTy], [MaLoaiHang], [SoLuong], [DonViTinh], [GiaHang]) VALUES (3, N'Bánh Canh', 2, 1, 50, N'Gói', 1000)
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaCongTy], [MaLoaiHang], [SoLuong], [DonViTinh], [GiaHang]) VALUES (4, N'Kẹo Kéo', 2, 2, 50, N'Thùng', 1000)
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaCongTy], [MaLoaiHang], [SoLuong], [DonViTinh], [GiaHang]) VALUES (5, N'Bia HuDa', 3, 7, 1000, N'Thùng', 170)
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaCongTy], [MaLoaiHang], [SoLuong], [DonViTinh], [GiaHang]) VALUES (6, N'Sữa VINAMILK', 2, 3, 100, N'Thùng', 1000)
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaCongTy], [MaLoaiHang], [SoLuong], [DonViTinh], [GiaHang]) VALUES (7, N'Sữa Ông Thọ', 2, 3, 1000, N'Thùng', 1200)
INSERT [dbo].[MatHang] ([MaHang], [TenHang], [MaCongTy], [MaLoaiHang], [SoLuong], [DonViTinh], [GiaHang]) VALUES (8, N'Kẹo Dẻo', 2, 2, 50, N'Thùng', 500)
SET IDENTITY_INSERT [dbo].[MatHang] OFF
GO
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([MaCongTy], [TenCongTy], [TenGiaoDich], [DiaChi], [DienThoai], [Fax], [Email]) VALUES (1, N'HPT', N'hpt', N'Huế', N'248323432           ', N'129343              ', N'hadsfd@email.com                                  ')
INSERT [dbo].[NhaCungCap] ([MaCongTy], [TenCongTy], [TenGiaoDich], [DiaChi], [DienThoai], [Fax], [Email]) VALUES (2, N'NB', N'nb', N'Huế', N'1398647             ', N'16372               ', N'jhgfsd@email.com                                  ')
INSERT [dbo].[NhaCungCap] ([MaCongTy], [TenCongTy], [TenGiaoDich], [DiaChi], [DienThoai], [Fax], [Email]) VALUES (3, N'LV', N'lv', N'Quảng Trị', N'230740              ', N'232347              ', N'hskhf@email.com                                   ')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNhanVien], [Ho], [Ten], [NgaySinh], [NgayLamViec], [DiaChi], [DienThoai], [LuongCoBan], [PhuCap]) VALUES (1, N'Ha', N'Thuong', CAST(N'1998-05-01' AS Date), CAST(N'2020-02-25' AS Date), N'Huế', N'0123456             ', 15000000, 500000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [Ho], [Ten], [NgaySinh], [NgayLamViec], [DiaChi], [DienThoai], [LuongCoBan], [PhuCap]) VALUES (2, N'Bui', N'Ngan', CAST(N'1993-10-03' AS Date), CAST(N'2020-03-11' AS Date), N'Bùi Thị Xuân', N'1234567             ', 1500000, 50000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [Ho], [Ten], [NgaySinh], [NgayLamViec], [DiaChi], [DienThoai], [LuongCoBan], [PhuCap]) VALUES (3, N'Le', N'Vu', CAST(N'1994-04-22' AS Date), CAST(N'2020-04-04' AS Date), N'TP Huế', N'43556778            ', 7500000, 20000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [Ho], [Ten], [NgaySinh], [NgayLamViec], [DiaChi], [DienThoai], [LuongCoBan], [PhuCap]) VALUES (4, N'Phan', N'Phap', CAST(N'1994-04-22' AS Date), CAST(N'2020-01-01' AS Date), N'Thuận An', N'1232180             ', 15000000, 29000)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
ALTER TABLE [dbo].[ChiTietDatHang]  WITH CHECK ADD FOREIGN KEY([MaHang])
REFERENCES [dbo].[MatHang] ([MaHang])
GO
ALTER TABLE [dbo].[ChiTietDatHang]  WITH CHECK ADD FOREIGN KEY([SoHoaDon])
REFERENCES [dbo].[DonDatHang] ([SoHoaDon])
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD FOREIGN KEY([MaCongTy])
REFERENCES [dbo].[NhaCungCap] ([MaCongTy])
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD FOREIGN KEY([MaLoaiHang])
REFERENCES [dbo].[LoaiHang] ([MaLoaiHang])
GO
