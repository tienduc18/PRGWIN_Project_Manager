USE [master]
GO
/****** Object:  Database [QuanLyDeTai]    Script Date: 6/6/2020 8:55:46 AM ******/
CREATE DATABASE [QuanLyDeTai]
 --CONTAINMENT = NONE
 --ON  PRIMARY 
--( NAME = N'QuanLyDeTai', FILENAME = N'G:\sqlserver2019_root\MSSQL15.HNNT_NTP\MSSQL\DATA\QuanLyDeTai.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'QuanLyDeTai_log', FILENAME = N'G:\sqlserver2019_root\MSSQL15.HNNT_NTP\MSSQL\DATA\QuanLyDeTai_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
-- WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyDeTai] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyDeTai].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyDeTai] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyDeTai] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyDeTai] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyDeTai] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyDeTai] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyDeTai] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyDeTai] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyDeTai] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyDeTai] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyDeTai] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyDeTai] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyDeTai] SET QUERY_STORE = OFF
GO
USE [QuanLyDeTai]
GO
/****** Object:  Table [dbo].[ChuyenNganh]    Script Date: 6/6/2020 8:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenNganh](
	[IDChuyenNganh] [char](4) NOT NULL,
	[TenChuyenNganh] [nvarchar](70) NULL,
 CONSTRAINT [PK_ChuyenNganh] PRIMARY KEY CLUSTERED 
(
	[IDChuyenNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoAnMonHoc]    Script Date: 6/6/2020 8:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoAnMonHoc](
	[ID] [char](4) NOT NULL,
	[MaMonHoc] [char](10) NULL,
	[TenDeTai] [nvarchar](70) NULL,
	[TienDo] [nvarchar](max) NULL,
	[Deadline] [date] NULL,
	[Check] [nvarchar](max) NULL,
	[Diem] [float] NULL,
	[MSSV] [char](8) NULL,
 CONSTRAINT [PK_DoAnMonHoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoAnTotNghiep]    Script Date: 6/6/2020 8:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoAnTotNghiep](
	[MaDATN] [char](4) NOT NULL,
	[Mssv] [char](8) NOT NULL,
	[TenDeTai] [nvarchar](50) NULL,
	[IDChuyenNganh] [char](4) NULL,
	[GVHD] [char](4) NULL,
	[TienDo] [nvarchar](max) NULL,
	[Deadline] [date] NULL,
	[Check] [bit] NULL,
	[Diem] [float] NULL,
 CONSTRAINT [PK_DoAnTotNghiep] PRIMARY KEY CLUSTERED 
(
	[Mssv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 6/6/2020 8:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MSGV] [char](4) NOT NULL,
	[HoTen] [nvarchar](60) NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[Khoa] [nvarchar](50) NULL,
	[ChuyenNganh] [nvarchar](50) NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[MSGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 6/6/2020 8:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [char](10) NOT NULL,
	[TenMonHoc] [nvarchar](50) NULL,
	[SoTiet] [int] NULL,
	[SoTinChi] [int] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhom]    Script Date: 6/6/2020 8:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhom](
	[MaNhom] [char](2) NOT NULL,
	[Mssv] [char](8) NULL,
	[MaMonHoc] [char](10) NULL,
 CONSTRAINT [PK_Nhom] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/6/2020 8:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[Mssv] [char](8) NOT NULL,
	[HoTen] [nvarchar](60) NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](max) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[Khoa] [nvarchar](30) NULL,
	[IDChuyenNganh] [char](4) NULL,
	[NamNhapHoc] [char](4) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[Mssv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TieuLuanChuyenNganh]    Script Date: 6/6/2020 8:55:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TieuLuanChuyenNganh](
	[MaTLCN] [char](4) NOT NULL,
	[Mssv] [char](8) NOT NULL,
	[TenDeTai] [nvarchar](60) NULL,
	[IDChuyenNganh] [char](4) NULL,
	[TienDo] [nvarchar](max) NULL,
	[Deadline] [date] NULL,
	[Check] [bit] NULL,
	[Diem] [float] NULL,
 CONSTRAINT [PK_TieuLuanChuyenNganh_1] PRIMARY KEY CLUSTERED 
(
	[Mssv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'ANM ', N'An ninh mạng')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'CNPM', N'Công nghệ phần mềm')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'CNTT', N'Công nghệ thông tin')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'DDT ', N'Điện - Điện tử')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'HTTT', N'Hệ thống thông tin')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'KTDL', N'Kỹ thuật dữ liệu')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'MTT ', N'May - Thời trang')
INSERT [dbo].[DoAnMonHoc] ([ID], [MaMonHoc], [TenDeTai], [TienDo], [Deadline], [Check], [Diem], [MSSV]) VALUES (N'MH01', N'LTTW      ', N'Chương trình tạo sơ đồ tư duy', N'50%', CAST(N'2020-06-30' AS Date), N'0', NULL, N'18133001')
INSERT [dbo].[DoAnMonHoc] ([ID], [MaMonHoc], [TenDeTai], [TienDo], [Deadline], [Check], [Diem], [MSSV]) VALUES (N'MH02', N'CNPM      ', N'Chương trình quản lý các file trên máy tính', N'30%', CAST(N'2020-06-20' AS Date), N'0', NULL, N'18110300')
INSERT [dbo].[DoAnMonHoc] ([ID], [MaMonHoc], [TenDeTai], [TienDo], [Deadline], [Check], [Diem], [MSSV]) VALUES (N'MH03', N'ATTT      ', N'Chương trình quản lý thông tin sinh viên', N'40%', CAST(N'2020-06-30' AS Date), N'0', NULL, N'18110333')
INSERT [dbo].[DoAnMonHoc] ([ID], [MaMonHoc], [TenDeTai], [TienDo], [Deadline], [Check], [Diem], [MSSV]) VALUES (N'MH04', N'LTHDT     ', N'Game cờ caro', N'50%', CAST(N'2020-06-25' AS Date), N'0', NULL, N'18110444')
INSERT [dbo].[DoAnTotNghiep] ([MaDATN], [Mssv], [TenDeTai], [IDChuyenNganh], [GVHD], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'DA05', N'18110300', N'Chương trình tạo sơ đồ tư duy', N'CNPM', N'GV01', N'30%', CAST(N'2022-04-30' AS Date), 0, NULL)
INSERT [dbo].[DoAnTotNghiep] ([MaDATN], [Mssv], [TenDeTai], [IDChuyenNganh], [GVHD], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'DA06', N'18110333', N'Chương trình quản lý, in mã barcode cho sản phẩm', N'ANM ', N'GV10', N'30%', CAST(N'2022-04-30' AS Date), 0, NULL)
INSERT [dbo].[DoAnTotNghiep] ([MaDATN], [Mssv], [TenDeTai], [IDChuyenNganh], [GVHD], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'DA07', N'18110340', N'Chương trình quản lý đề tài sinh viên', N'CNPM', N'GV02', N'50%', CAST(N'2022-04-30' AS Date), 0, NULL)
INSERT [dbo].[DoAnTotNghiep] ([MaDATN], [Mssv], [TenDeTai], [IDChuyenNganh], [GVHD], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'DA10', N'18110444', N'Chương trình quản lý điểm của sinh viên', N'HTTT', N'GV05', N'40%', CAST(N'2022-04-30' AS Date), 0, NULL)
INSERT [dbo].[DoAnTotNghiep] ([MaDATN], [Mssv], [TenDeTai], [IDChuyenNganh], [GVHD], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'DA01', N'18133001', N'Chương trình quản lý dự án sử dụng Grantt chart', N'KTDL', N'GV07', N'30%', CAST(N'2022-04-30' AS Date), 0, NULL)
INSERT [dbo].[DoAnTotNghiep] ([MaDATN], [Mssv], [TenDeTai], [IDChuyenNganh], [GVHD], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'DA02', N'18133002', N'Chương trình quản lý các file trên máy tính', N'KTDL', N'GV08', N'40%', CAST(N'2022-04-30' AS Date), 0, NULL)
INSERT [dbo].[DoAnTotNghiep] ([MaDATN], [Mssv], [TenDeTai], [IDChuyenNganh], [GVHD], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'DA04', N'18133004', N'Chương trình tạo, lưu ghi chú', N'KTDL', N'GV07', N'50%', CAST(N'2022-04-30' AS Date), 0, NULL)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV01', N'Trần Văn Công', CAST(N'1990-02-23' AS Date), N'Long An', N'Nam', N'Công nghệ thông tin', N'Công nghệ phần mềm')
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV02', N'Nguyễn Trần Văn Minh', CAST(N'1991-04-29' AS Date), N'Kiên Giang', N'Nam', N'Công nghệ thông tin', N'Công nghệ phần mềm')
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV03', N'Lê Nguyễn Đức', CAST(N'1989-09-05' AS Date), N'Quảng Nam', N'Nam', N'Công nghệ thông tin', N'Công nghệ phần mềm')
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV04', N'Trương Thị Lê Ly', CAST(N'1992-10-11' AS Date), N'Bình Định', N'Nữ', N'Công nghệ thông tin', N'Hệ thống thông tin')
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV05', N'Nguyễn Thị My', CAST(N'1995-02-23' AS Date), N'Tiền Giang', N'Nữ', N'Công nghệ thông tin', N'Hệ thống thông tin')
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV06', N'Đỗ Văn Tú', CAST(N'1994-12-25' AS Date), N'Hồ Chí Minh', N'Nam', N'Công nghệ thông tin', N'Hệ thống thông tin')
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV07', N'Trương Nguyễn Tân', CAST(N'1990-08-10' AS Date), N'Hà Nội', N'Nam', N'Công nghệ thông tin', N'Kỹ thuật dữ liệu')
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV08', N'Trần Văn Bình', CAST(N'1993-07-01' AS Date), N'Huế', N'Nam', N'Công nghệ thông tin', N'Kỹ thuật dữ liệu')
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV09', N'Trương Minh Nhân', CAST(N'1993-04-20' AS Date), N'Long An', N'Nam', N'Công nghệ thông tin', N'Kỹ thuật dữ liệu')
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV10', N'Lê Chí Nam', CAST(N'1990-02-02' AS Date), N'Đà Nẵng', N'Nam', N'Công nghệ thông tin', N'An ninh mạng')
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV11', N'Trần Thị Thy', CAST(N'1993-09-09' AS Date), N'Quảng Nam', N'Nữ', N'Công nghệ thông tin', N'An ninh mạng')
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh]) VALUES (N'GV12', N'Nguyễn Phúc', CAST(N'1990-02-23' AS Date), N'Long An', N'Nam', N'Công nghệ thông tin', N'An ninh mạng')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'ATTT      ', N'An toàn thông tin', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'CNPM      ', N'Công nghệ phần mềm', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'CSDL      ', N'Cơ sở dữ liệu', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'CTDLVGT   ', N'Cấu trúc dữ liệu và giải thuật', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'DTDM      ', N'Điện toán đám may', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'HDH       ', N'Hệ điều hành', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'HPB       ', N'Hệ phân bố', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'KDL       ', N'Kho dữ liệu', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'KPDL      ', N'Khai phá dữ liệu', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'LTHDT     ', N'Lập trình hướng đối tượng', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'LTRCPT    ', N'Lập trình R cho phân tích', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'LTTW      ', N'Lập trình trên Windows', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'LTW       ', N'Lập trình web', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'MMTCB     ', N'Mạng máy tính căn bản', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'PYTHON    ', N'Nhập môn lập trình python', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'TRRVLTDT  ', N'Toán rời rạc và lý thuyết đồ thị', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'TTDLTQ    ', N'Tương tác dữ liệu trực quan', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'TTNT      ', N'Trí tuệ nhân tạo', 100, 3)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18110300', N'Phan Thành Đạt', CAST(N'2000-09-23' AS Date), N'Đắc Lắc', N'Nam', N'Công nghệ thông tin', N'CNPM', N'2018')
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18110333', N'Nguyễn Anh Triều', CAST(N'2000-10-12' AS Date), N'Quảng Nam', N'Nam', N'Công nghệ thông tin', N'ANM ', N'2018')
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18110340', N'Lê Chí Hiếu', CAST(N'2000-02-12' AS Date), N'Bình Định', N'Nam', N'Công nghệ thông tin', N'CNPM', N'2018')
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18110400', N'Nguyễn Trung Tín', CAST(N'2000-01-01' AS Date), N'Bình Định', N'Nam', N'Công nghệ thông tin', N'ANM ', N'2018')
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18110440', N'Trần Tiến Đức', CAST(N'2000-11-12' AS Date), N'Bình Định', N'Nam', N'Công nghệ thông tin', N'CNPM', N'2018')
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18110444', N'Huỳnh Thị Thúy Vy', CAST(N'2000-05-20' AS Date), N'Long An', N'Nữ', N'Công nghệ thông tin', N'HTTT', N'2018')
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18133001', N'Trương Hùng Anh', CAST(N'2000-12-12' AS Date), N'Bình Định', N'Nam', N'Công nghệ thông tin', N'KTDL', N'2018')
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18133002', N'Lê Đỗ Trà My', CAST(N'2000-02-23' AS Date), N'Biên Hòa', N'Nữ', N'Công nghệ thông tin', N'KTDL', N'2018')
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18133004', N'Nguyễn Tuấn Phi', CAST(N'2000-05-12' AS Date), N'Biên Hòa', N'Nam', N'Công nghệ thông tin', N'KTDL', N'2018')
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18133007', N'Trần Tiến Đức', NULL, NULL, N'Nam', N'CNTT', N'KTDL', N'2018')
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18133039', N'Nguyễn Tuấn Phi', CAST(N'2000-09-16' AS Date), N'Đồng Nai', N'Nam', N'CNTT', N'KTDL', N'2018')
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc]) VALUES (N'18133042', N'Trần Thị Như Quỳnh', NULL, NULL, N'0', N'CNTT', N'KTDL', N'2018')
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'TL07', N'18110300', N'Quản lý phòng lab', N'CNPM', N'40%', CAST(N'2021-03-30' AS Date), 0, NULL)
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'TL05', N'18110333', N'Quản lý thông tin của sinh viên', N'ANM ', N'30%', CAST(N'2021-03-30' AS Date), 0, NULL)
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'TL08', N'18110340', N'Quản lý phòng lab', N'CNPM', N'20%', CAST(N'2021-03-30' AS Date), 0, NULL)
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'TL04', N'18110400', N'Quản lý thông tin của sinh viên', N'ANM ', N'30%', CAST(N'2021-03-30' AS Date), 0, NULL)
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'TL09', N'18110440', N'Quản lý tiểu luận chuyên ngành', N'CNPM', N'20%', CAST(N'2021-03-30' AS Date), 0, NULL)
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'TL06', N'18110444', N'Quản lý thông tin của giảng viên', N'HTTT', N'40%', CAST(N'2021-03-30' AS Date), 0, NULL)
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'TL02', N'18133001', N'Quản lý điểm của sinh viên', N'KTDL', N'20%', CAST(N'2021-03-30' AS Date), 0, NULL)
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'TL01', N'18133002', N'Quản lý điểm của sinh viên', N'KTDL', N'20%', CAST(N'2021-03-30' AS Date), 0, NULL)
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'TL03', N'18133004', N'Quản lý điểm của sinh viên', N'KTDL', N'20%', CAST(N'2021-03-30' AS Date), 0, NULL)
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'KTDL', N'18133007', N'TTD', N'KTDL', NULL, NULL, 0, NULL)
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'KTDL', N'18133039', N'NTP', N'KTDL', NULL, NULL, 1, NULL)
INSERT [dbo].[TieuLuanChuyenNganh] ([MaTLCN], [Mssv], [TenDeTai], [IDChuyenNganh], [TienDo], [Deadline], [Check], [Diem]) VALUES (N'KTDL', N'18133042', N'NTNQ', N'KTDL', NULL, NULL, 1, NULL)
ALTER TABLE [dbo].[DoAnMonHoc]  WITH CHECK ADD  CONSTRAINT [FK_DoAnMonHoc_MonHoc] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[DoAnMonHoc] CHECK CONSTRAINT [FK_DoAnMonHoc_MonHoc]
GO
ALTER TABLE [dbo].[DoAnMonHoc]  WITH CHECK ADD  CONSTRAINT [FK_DoAnMonHoc_SinhVien] FOREIGN KEY([MSSV])
REFERENCES [dbo].[SinhVien] ([Mssv])
GO
ALTER TABLE [dbo].[DoAnMonHoc] CHECK CONSTRAINT [FK_DoAnMonHoc_SinhVien]
GO
ALTER TABLE [dbo].[DoAnTotNghiep]  WITH CHECK ADD  CONSTRAINT [FK_DoAnTotNghiep_GiangVien] FOREIGN KEY([GVHD])
REFERENCES [dbo].[GiangVien] ([MSGV])
GO
ALTER TABLE [dbo].[DoAnTotNghiep] CHECK CONSTRAINT [FK_DoAnTotNghiep_GiangVien]
GO
ALTER TABLE [dbo].[DoAnTotNghiep]  WITH CHECK ADD  CONSTRAINT [FK_DoAnTotNghiep_SinhVien] FOREIGN KEY([Mssv])
REFERENCES [dbo].[SinhVien] ([Mssv])
GO
ALTER TABLE [dbo].[DoAnTotNghiep] CHECK CONSTRAINT [FK_DoAnTotNghiep_SinhVien]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_ChuyenNganh] FOREIGN KEY([IDChuyenNganh])
REFERENCES [dbo].[ChuyenNganh] ([IDChuyenNganh])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_ChuyenNganh]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_TieuLuanChuyenNganh] FOREIGN KEY([Mssv])
REFERENCES [dbo].[TieuLuanChuyenNganh] ([Mssv])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_TieuLuanChuyenNganh]
GO
USE [master]
GO
ALTER DATABASE [QuanLyDeTai] SET  READ_WRITE 
GO
