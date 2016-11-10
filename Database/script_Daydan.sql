USE [master]
GO
/****** Object:  Database [daydan]    Script Date: 10/11/2016 8:57:08 SA ******/
CREATE DATABASE [daydan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'daydan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\daydan.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'daydan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\daydan_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [daydan] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [daydan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [daydan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [daydan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [daydan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [daydan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [daydan] SET ARITHABORT OFF 
GO
ALTER DATABASE [daydan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [daydan] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [daydan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [daydan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [daydan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [daydan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [daydan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [daydan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [daydan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [daydan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [daydan] SET  ENABLE_BROKER 
GO
ALTER DATABASE [daydan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [daydan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [daydan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [daydan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [daydan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [daydan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [daydan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [daydan] SET RECOVERY FULL 
GO
ALTER DATABASE [daydan] SET  MULTI_USER 
GO
ALTER DATABASE [daydan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [daydan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [daydan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [daydan] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'daydan', N'ON'
GO
USE [daydan]
GO
USE [daydan]
GO
/****** Object:  Sequence [dbo].[seq_person]    Script Date: 10/11/2016 8:57:09 SA ******/
CREATE SEQUENCE [dbo].[seq_person] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 CACHE  10 
GO
/****** Object:  StoredProcedure [dbo].[ThanhVienLogin]    Script Date: 10/11/2016 8:57:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThanhVienLogin]
@UserName char(10),
@Password char(12)
as
begin
declare @count int 
declare @res bit
select @count = count(*) from ThanhVien where Username = @UserName and Pass = @Password
if @count >0
set @res = 1
else set @res = 0
select @res
end
GO
/****** Object:  Table [dbo].[BaiGiang]    Script Date: 10/11/2016 8:57:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiGiang](
	[MaBaiGiang] [int] IDENTITY(1,1) NOT NULL,
	[TenBaiGiang] [nvarchar](30) NULL,
	[MaLoaiBG] [int] NULL,
	[NgayDang] [datetime] NULL,
	[MaThanhVien] [int] NULL,
	[NoiDung] [nvarchar](255) NULL,
	[MaCD] [int] NULL,
	[MaGD] [int] NULL,
 CONSTRAINT [PK_BaiGiang] PRIMARY KEY CLUSTERED 
(
	[MaBaiGiang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Blog]    Script Date: 10/11/2016 8:57:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blog](
	[MaBlog] [int] IDENTITY(1,1) NOT NULL,
	[TenBlog] [nvarchar](50) NULL,
	[NgayDang] [datetime] NULL,
	[MaLoaiBlog] [int] NULL,
	[Noidung] [nvarchar](255) NULL,
 CONSTRAINT [PK_Blog] PRIMARY KEY CLUSTERED 
(
	[MaBlog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChuDe]    Script Date: 10/11/2016 8:57:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuDe](
	[MaChuDe] [int] IDENTITY(1,1) NOT NULL,
	[TenChuDe] [nvarchar](20) NULL,
	[MoTaCD] [nvarchar](30) NULL,
 CONSTRAINT [PK_ChuDe] PRIMARY KEY CLUSTERED 
(
	[MaChuDe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaiDieu]    Script Date: 10/11/2016 8:57:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaiDieu](
	[MaGiaiDieu] [int] IDENTITY(1,1) NOT NULL,
	[TenGiaiDieu] [nvarchar](20) NULL,
	[MoTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_GiaiDieu] PRIMARY KEY CLUSTERED 
(
	[MaGiaiDieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiBaiGiang]    Script Date: 10/11/2016 8:57:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBaiGiang](
	[MaLoaiBG] [int] NOT NULL,
	[TenLoaiBG] [nvarchar](20) NULL,
	[MoTaLoaiBG] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiBaiGiang] PRIMARY KEY CLUSTERED 
(
	[MaLoaiBG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiBlog]    Script Date: 10/11/2016 8:57:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBlog](
	[MaLoaiBlog] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiBlog] [nvarchar](50) NULL,
	[MotaBlog] [nvarchar](80) NULL,
 CONSTRAINT [PK_LoaiBlog] PRIMARY KEY CLUSTERED 
(
	[MaLoaiBlog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiThanhVien]    Script Date: 10/11/2016 8:57:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThanhVien](
	[MaLoaiTVien] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](20) NULL,
	[MoTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiThanhVien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 10/11/2016 8:57:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[MaThanhVien] [int] IDENTITY(1,1) NOT NULL,
	[TenThanhVien] [nvarchar](50) NULL,
	[Ngaydangky] [datetime] NULL,
	[Diem] [float] NULL,
	[Mota] [nvarchar](50) NULL,
	[LoaiThanhVien] [int] NULL,
	[Username] [char](10) NOT NULL,
	[Pass] [char](12) NOT NULL,
	[Email] [varchar](30) NULL,
	[Hinhanh] [varchar](255) NULL,
 CONSTRAINT [PK_ThanhVien] PRIMARY KEY CLUSTERED 
(
	[MaThanhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Video]    Script Date: 10/11/2016 8:57:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Video](
	[Mavideo] [int] IDENTITY(1,1) NOT NULL,
	[Tenvideo] [nvarchar](50) NULL,
	[Ngaydang] [datetime] NULL,
	[MaThanhVien] [int] NULL,
	[Luotthich] [int] NULL,
	[Luotxem] [int] NULL,
	[Trangthai] [char](10) NULL,
	[Mablog] [int] NULL,
	[MaBG] [int] NULL,
	[MaGD] [int] NULL,
 CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED 
(
	[Mavideo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[BaiGiang]  WITH CHECK ADD  CONSTRAINT [fk_baigiang_chude] FOREIGN KEY([MaCD])
REFERENCES [dbo].[ChuDe] ([MaChuDe])
GO
ALTER TABLE [dbo].[BaiGiang] CHECK CONSTRAINT [fk_baigiang_chude]
GO
ALTER TABLE [dbo].[BaiGiang]  WITH CHECK ADD  CONSTRAINT [fk_baigiang_giaidieu] FOREIGN KEY([MaGD])
REFERENCES [dbo].[GiaiDieu] ([MaGiaiDieu])
GO
ALTER TABLE [dbo].[BaiGiang] CHECK CONSTRAINT [fk_baigiang_giaidieu]
GO
ALTER TABLE [dbo].[BaiGiang]  WITH CHECK ADD  CONSTRAINT [FK_BaiGiang_LoaiBaiGiang] FOREIGN KEY([MaLoaiBG])
REFERENCES [dbo].[LoaiBaiGiang] ([MaLoaiBG])
GO
ALTER TABLE [dbo].[BaiGiang] CHECK CONSTRAINT [FK_BaiGiang_LoaiBaiGiang]
GO
ALTER TABLE [dbo].[BaiGiang]  WITH CHECK ADD  CONSTRAINT [fk_bg_thanhvien] FOREIGN KEY([MaThanhVien])
REFERENCES [dbo].[ThanhVien] ([MaThanhVien])
GO
ALTER TABLE [dbo].[BaiGiang] CHECK CONSTRAINT [fk_bg_thanhvien]
GO
ALTER TABLE [dbo].[Blog]  WITH CHECK ADD  CONSTRAINT [fk_blog_loaiblog] FOREIGN KEY([MaLoaiBlog])
REFERENCES [dbo].[LoaiBlog] ([MaLoaiBlog])
GO
ALTER TABLE [dbo].[Blog] CHECK CONSTRAINT [fk_blog_loaiblog]
GO
ALTER TABLE [dbo].[ThanhVien]  WITH CHECK ADD  CONSTRAINT [fk_thanhvien_loaitv] FOREIGN KEY([LoaiThanhVien])
REFERENCES [dbo].[LoaiThanhVien] ([MaLoaiTVien])
GO
ALTER TABLE [dbo].[ThanhVien] CHECK CONSTRAINT [fk_thanhvien_loaitv]
GO
ALTER TABLE [dbo].[Video]  WITH CHECK ADD  CONSTRAINT [fk_video_bg] FOREIGN KEY([MaBG])
REFERENCES [dbo].[BaiGiang] ([MaBaiGiang])
GO
ALTER TABLE [dbo].[Video] CHECK CONSTRAINT [fk_video_bg]
GO
ALTER TABLE [dbo].[Video]  WITH CHECK ADD  CONSTRAINT [fk_video_blog] FOREIGN KEY([Mablog])
REFERENCES [dbo].[Blog] ([MaBlog])
GO
ALTER TABLE [dbo].[Video] CHECK CONSTRAINT [fk_video_blog]
GO
ALTER TABLE [dbo].[Video]  WITH CHECK ADD  CONSTRAINT [fk_video_thanhvien] FOREIGN KEY([MaThanhVien])
REFERENCES [dbo].[ThanhVien] ([MaThanhVien])
GO
ALTER TABLE [dbo].[Video] CHECK CONSTRAINT [fk_video_thanhvien]
GO
ALTER TABLE [dbo].[Video]  WITH CHECK ADD  CONSTRAINT [fk_videogd] FOREIGN KEY([MaGD])
REFERENCES [dbo].[GiaiDieu] ([MaGiaiDieu])
GO
ALTER TABLE [dbo].[Video] CHECK CONSTRAINT [fk_videogd]
GO
USE [master]
GO
ALTER DATABASE [daydan] SET  READ_WRITE 
GO
