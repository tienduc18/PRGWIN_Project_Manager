USE [master]
GO
/****** Object:  Database [QuanLyDeTai]    Script Date: 6/26/2020 11:23:16 PM ******/
CREATE DATABASE [QuanLyDeTai]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'QuanLyDeTai', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyDeTai.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'QuanLyDeTai_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyDeTai_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[ChuyenNganh]    Script Date: 6/26/2020 11:23:17 PM ******/
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
/****** Object:  Table [dbo].[DeAn]    Script Date: 6/26/2020 11:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeAn](
	[IDDeAn] [varchar](15) NOT NULL,
	[TenDeAn] [nvarchar](200) NULL,
	[Type] [char](1) NULL,
	[IDNhomSV] [varchar](15) NULL,
	[GVHD] [char](4) NULL,
	[MonHoc] [char](10) NULL,
	[ChuyenNganh] [char](4) NULL,
	[MoTa] [nvarchar](max) NULL,
	[DateStart] [datetime] NULL,
	[DateEnd] [datetime] NULL,
	[TienDo] [float] NULL,
	[TaiLieu] [varchar](200) NULL,
	[Diem] [nchar](10) NULL,
 CONSTRAINT [PK_DeAn] PRIMARY KEY CLUSTERED 
(
	[IDDeAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 6/26/2020 11:23:17 PM ******/
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
	[ChuyenNganh] [char](4) NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[MSGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 6/26/2020 11:23:17 PM ******/
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
/****** Object:  Table [dbo].[NhomSinhVien]    Script Date: 6/26/2020 11:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomSinhVien](
	[IDNhom] [varchar](15) NOT NULL,
	[TenNhom] [nvarchar](200) NULL,
	[ThanhVien] [varchar](200) NULL,
 CONSTRAINT [PK_NhomSinhVien] PRIMARY KEY CLUSTERED 
(
	[IDNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/26/2020 11:23:17 PM ******/
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
	[DaXoa] [bit] NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[Mssv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TienDo]    Script Date: 6/26/2020 11:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TienDo](
	[IDDeAn] [varchar](15) NOT NULL,
	[BaoCao] [nvarchar](max) NULL,
	[HoanThanh] [nvarchar](max) NULL,
	[LinkTaiLieu] [varchar](max) NULL,
	[SoBuoi] [int] NULL,
 CONSTRAINT [PK_TienDo] PRIMARY KEY CLUSTERED 
(
	[IDDeAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 6/26/2020 11:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[IDType] [char](1) NOT NULL,
	[LoaiDeAn] [nvarchar](100) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[IDType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'ANM ', N'An ninh mạng')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'CNPM', N'Công nghệ phần mềm')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'CNTT', N'Công nghệ thông tin')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'DDT ', N'Điện - Điện tử')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'HTTT', N'Hệ thống thông tin')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'KTDL', N'Kỹ thuật dữ liệu')
INSERT [dbo].[ChuyenNganh] ([IDChuyenNganh], [TenChuyenNganh]) VALUES (N'MTT ', N'May - Thời trang')
GO
INSERT [dbo].[DeAn] ([IDDeAn], [TenDeAn], [Type], [IDNhomSV], [GVHD], [MonHoc], [ChuyenNganh], [MoTa], [DateStart], [DateEnd], [TienDo], [TaiLieu], [Diem]) VALUES (N'DAMH-ATTT-001', N'an toàn thông tin', N'1', N'DAMH-ATTT-001', N'GV01', N'ATTT      ', NULL, N'lalala', CAST(N'2020-06-27T23:00:18.000' AS DateTime), CAST(N'2020-07-04T23:00:18.000' AS DateTime), 0.25, NULL, N'          ')
INSERT [dbo].[DeAn] ([IDDeAn], [TenDeAn], [Type], [IDNhomSV], [GVHD], [MonHoc], [ChuyenNganh], [MoTa], [DateStart], [DateEnd], [TienDo], [TaiLieu], [Diem]) VALUES (N'DAMH-PYTH-001', N'lalalalala', N'1', N'DAMH-PYTH-001', N'GV01', N'PYTH      ', NULL, N'lalala', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[DeAn] ([IDDeAn], [TenDeAn], [Type], [IDNhomSV], [GVHD], [MonHoc], [ChuyenNganh], [MoTa], [DateStart], [DateEnd], [TienDo], [TaiLieu], [Diem]) VALUES (N'DATN-CNTT-001', N'lalalala', N'3', N'DATN-CNTT-001', N'GV03', NULL, N'CNTT', N'lalalala', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[DeAn] ([IDDeAn], [TenDeAn], [Type], [IDNhomSV], [GVHD], [MonHoc], [ChuyenNganh], [MoTa], [DateStart], [DateEnd], [TienDo], [TaiLieu], [Diem]) VALUES (N'TLCN-ANM-001', N'lalalala', N'2', N'TLCN-ANM-001', N'GV01', NULL, N'ANM ', N'lalala', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV01', N'Trần Văn Công', CAST(N'1990-02-23' AS Date), N'Long An', N'Nam', N'Công nghệ thông tin', N'ANM ', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV02', N'Nguyễn Trần Văn Minh', CAST(N'1991-04-29' AS Date), N'Kiên Giang', N'Nam', N'Công nghệ thông tin', N'ANM ', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV03', N'Lê Nguyễn Đức', CAST(N'1989-09-05' AS Date), N'Quảng Nam', N'Nam', N'Công nghệ thông tin', N'CNPM', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV04', N'Trương Thị Lê Ly', CAST(N'1992-10-11' AS Date), N'Bình Định', N'Nữ', N'Công nghệ thông tin', N'CNTT', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV05', N'Nguyễn Thị My', CAST(N'1995-02-23' AS Date), N'Tiền Giang', N'Nữ', N'Công nghệ thông tin', N'DDT ', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV06', N'Đỗ Văn Tú', CAST(N'1994-12-25' AS Date), N'Hồ Chí Minh', N'Nam', N'Công nghệ thông tin', N'HTTT', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV07', N'Trương Nguyễn Tân', CAST(N'1990-08-10' AS Date), N'Hà Nội', N'Nam', N'Công nghệ thông tin', N'KTDL', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV08', N'Trần Văn Bình', CAST(N'1993-07-01' AS Date), N'Huế', N'Nam', N'Công nghệ thông tin', N'KTDL', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV09', N'Trương Minh Nhân', CAST(N'1993-04-20' AS Date), N'Long An', N'Nam', N'Công nghệ thông tin', N'KTDL', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV10', N'Lê Chí Nam', CAST(N'1990-02-02' AS Date), N'Đà Nẵng', N'Nam', N'Công nghệ thông tin', N'ANM ', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV11', N'Trần Thị Thy', CAST(N'1993-09-09' AS Date), N'Quảng Nam', N'Nữ', N'Công nghệ thông tin', N'HTTT', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV12', N'Nguyễn Phúc', CAST(N'1990-02-23' AS Date), N'Long An', N'Nam', N'Công nghệ thông tin', N'CNPM', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV13', N'Nguyễn Thị Tuyết Linh', CAST(N'1983-06-26' AS Date), N'Long An', N'Nữ', NULL, N'KTDL', 0)
INSERT [dbo].[GiangVien] ([MSGV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [ChuyenNganh], [DaXoa]) VALUES (N'GV14', N'Trần Tiến Đức', CAST(N'1985-08-26' AS Date), N'Hải Dương', N'Nam', NULL, N'CNTT', 0)
GO
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'ATTT      ', N'An toàn thông tin', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'CNPM      ', N'Công nghệ phần mềm', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'CSDL      ', N'Cơ sở dữ liệu', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'CTDL      ', N'Cấu trúc dữ liệu và giải thuật', 100, 3)
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
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'PYTH      ', N'Nhập môn lập trình python', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'TRR       ', N'Toán rời rạc và lý thuyết đồ thị', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'TTDL      ', N'Tương tác dữ liệu trực quan', 100, 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTiet], [SoTinChi]) VALUES (N'TTNT      ', N'Trí tuệ nhân tạo', 100, 3)
GO
INSERT [dbo].[NhomSinhVien] ([IDNhom], [TenNhom], [ThanhVien]) VALUES (N'DAMH-ATTT-001', N'ps2', N'18110333')
INSERT [dbo].[NhomSinhVien] ([IDNhom], [TenNhom], [ThanhVien]) VALUES (N'DAMH-PYTH-001', N'an toàn vệ sinh thực phẩm', N'18110444')
INSERT [dbo].[NhomSinhVien] ([IDNhom], [TenNhom], [ThanhVien]) VALUES (N'DATN-CNTT-001', N'chuẩn bị thi lại', N'18133001')
INSERT [dbo].[NhomSinhVien] ([IDNhom], [TenNhom], [ThanhVien]) VALUES (N'TLCN-ANM-001', N'obs', N'18110300')
GO
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18110300', N'Phan Thành Đạt', CAST(N'2000-09-23' AS Date), N'Đắk Lắk', N'Nam', NULL, N'CNPM', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18110333', N'Nguyễn Anh Triều', CAST(N'2000-10-12' AS Date), N'Quảng Nam', N'Nam', N'Công nghệ thông tin', N'ANM ', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18110340', N'Lê Chí Hiếu', CAST(N'2000-02-12' AS Date), N'Bình Định', N'Nam', N'Công nghệ thông tin', N'CNPM', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18110400', N'Nguyễn Trung Tín', CAST(N'2000-01-01' AS Date), N'Bình Định', N'Nam', N'Công nghệ thông tin', N'ANM ', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18110440', N'Trần Tiến Đức', CAST(N'2000-11-12' AS Date), N'Bình Định', N'Nam', N'Công nghệ thông tin', N'CNPM', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18110444', N'Huỳnh Thị Thúy Vy', CAST(N'2000-05-20' AS Date), N'Long An', N'Nữ', N'Công nghệ thông tin', N'HTTT', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18133001', N'Trương Hùng Anh', CAST(N'2000-12-12' AS Date), N'Bình Định', N'Nam', N'Công nghệ thông tin', N'KTDL', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18133002', N'Lê Đỗ Trà My', CAST(N'2000-02-23' AS Date), N'Biên Hòa', N'Nữ', N'Công nghệ thông tin', N'KTDL', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18133004', N'Nguyễn Tuấn Phi', CAST(N'2000-05-12' AS Date), N'Biên Hòa', N'Nam', N'Công nghệ thông tin', N'KTDL', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18133007', N'Trần Tiến Đức', CAST(N'2000-06-26' AS Date), N'Thái Bình', N'Nam', NULL, N'KTDL', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18133039', N'Nguyễn Tuấn Phi', CAST(N'2000-09-16' AS Date), N'Đồng Nai', N'Nam', N'CNTT', N'KTDL', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18133042', N'Trần Thị Như Quỳnh', CAST(N'2000-06-26' AS Date), N'Khánh Hoà', N'Nữ', NULL, N'KTDL', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18133043', N'Phan Thị Mỹ Linh', CAST(N'2000-09-03' AS Date), N'Thái Bình', N'Nữ', NULL, N'CNTT', N'2018', 0)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18133044', N'Trần Minh Tú Trung', CAST(N'2000-04-01' AS Date), N'Bình Định', N'Nam', NULL, N'KTDL', N'2018', 1)
INSERT [dbo].[SinhVien] ([Mssv], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [Khoa], [IDChuyenNganh], [NamNhapHoc], [DaXoa]) VALUES (N'18133045', N'Trần Thành Trung', CAST(N'2000-05-26' AS Date), N'Hưng Yên', N'Nam', NULL, N'CNPM', N'2018', 0)
GO
INSERT [dbo].[TienDo] ([IDDeAn], [BaoCao], [HoanThanh], [LinkTaiLieu], [SoBuoi]) VALUES (N'DAMH-ATTT-001', N'báo cáo sơ bộ$', N'true,', N'https://drive.google.com/file/d/1mgNrwScsjnUCzitRa8JfcVyg8qr_yJb9/view?usp=sharing,', 4)
INSERT [dbo].[TienDo] ([IDDeAn], [BaoCao], [HoanThanh], [LinkTaiLieu], [SoBuoi]) VALUES (N'DAMH-PYTH-001', NULL, NULL, NULL, NULL)
INSERT [dbo].[TienDo] ([IDDeAn], [BaoCao], [HoanThanh], [LinkTaiLieu], [SoBuoi]) VALUES (N'DATN-CNTT-001', NULL, NULL, NULL, NULL)
INSERT [dbo].[TienDo] ([IDDeAn], [BaoCao], [HoanThanh], [LinkTaiLieu], [SoBuoi]) VALUES (N'TLCN-ANM-001', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Type] ([IDType], [LoaiDeAn]) VALUES (N'1', N'Đồ án môn học')
INSERT [dbo].[Type] ([IDType], [LoaiDeAn]) VALUES (N'2', N'Tiểu luận chuyên ngành')
INSERT [dbo].[Type] ([IDType], [LoaiDeAn]) VALUES (N'3', N'Đồ án tốt nghiệp')
GO
ALTER TABLE [dbo].[DeAn]  WITH CHECK ADD  CONSTRAINT [FK_DeAn_ChuyenNganh] FOREIGN KEY([ChuyenNganh])
REFERENCES [dbo].[ChuyenNganh] ([IDChuyenNganh])
GO
ALTER TABLE [dbo].[DeAn] CHECK CONSTRAINT [FK_DeAn_ChuyenNganh]
GO
ALTER TABLE [dbo].[DeAn]  WITH CHECK ADD  CONSTRAINT [FK_DeAn_GiangVien] FOREIGN KEY([GVHD])
REFERENCES [dbo].[GiangVien] ([MSGV])
GO
ALTER TABLE [dbo].[DeAn] CHECK CONSTRAINT [FK_DeAn_GiangVien]
GO
ALTER TABLE [dbo].[DeAn]  WITH CHECK ADD  CONSTRAINT [FK_DeAn_MonHoc] FOREIGN KEY([MonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[DeAn] CHECK CONSTRAINT [FK_DeAn_MonHoc]
GO
ALTER TABLE [dbo].[DeAn]  WITH CHECK ADD  CONSTRAINT [FK_DeAn_NhomSinhVien] FOREIGN KEY([IDNhomSV])
REFERENCES [dbo].[NhomSinhVien] ([IDNhom])
GO
ALTER TABLE [dbo].[DeAn] CHECK CONSTRAINT [FK_DeAn_NhomSinhVien]
GO
ALTER TABLE [dbo].[DeAn]  WITH CHECK ADD  CONSTRAINT [FK_DeAn_Type] FOREIGN KEY([Type])
REFERENCES [dbo].[Type] ([IDType])
GO
ALTER TABLE [dbo].[DeAn] CHECK CONSTRAINT [FK_DeAn_Type]
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD  CONSTRAINT [FK_GiangVien_ChuyenNganh] FOREIGN KEY([ChuyenNganh])
REFERENCES [dbo].[ChuyenNganh] ([IDChuyenNganh])
GO
ALTER TABLE [dbo].[GiangVien] CHECK CONSTRAINT [FK_GiangVien_ChuyenNganh]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_ChuyenNganh] FOREIGN KEY([IDChuyenNganh])
REFERENCES [dbo].[ChuyenNganh] ([IDChuyenNganh])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_ChuyenNganh]
GO
ALTER TABLE [dbo].[TienDo]  WITH CHECK ADD  CONSTRAINT [FK_TienDo_DeAn] FOREIGN KEY([IDDeAn])
REFERENCES [dbo].[DeAn] ([IDDeAn])
GO
ALTER TABLE [dbo].[TienDo] CHECK CONSTRAINT [FK_TienDo_DeAn]
GO
USE [master]
GO
ALTER DATABASE [QuanLyDeTai] SET  READ_WRITE 
GO
