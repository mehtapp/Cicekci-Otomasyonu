USE [master]
GO
/****** Object:  Database [cicekci]    Script Date: 5.06.2022 22:38:24 ******/
CREATE DATABASE [cicekci]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cicekci', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cicekci.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cicekci_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cicekci_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cicekci] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cicekci].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cicekci] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cicekci] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cicekci] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cicekci] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cicekci] SET ARITHABORT OFF 
GO
ALTER DATABASE [cicekci] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cicekci] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cicekci] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cicekci] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cicekci] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cicekci] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cicekci] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cicekci] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cicekci] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cicekci] SET  ENABLE_BROKER 
GO
ALTER DATABASE [cicekci] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cicekci] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cicekci] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cicekci] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cicekci] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cicekci] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cicekci] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cicekci] SET RECOVERY FULL 
GO
ALTER DATABASE [cicekci] SET  MULTI_USER 
GO
ALTER DATABASE [cicekci] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cicekci] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cicekci] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cicekci] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cicekci] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cicekci] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cicekci', N'ON'
GO
ALTER DATABASE [cicekci] SET QUERY_STORE = OFF
GO
USE [cicekci]
GO
/****** Object:  Table [dbo].[kullaniciSet]    Script Date: 5.06.2022 22:38:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullaniciSet](
	[Kul_id] [int] IDENTITY(1,1) NOT NULL,
	[kulAd] [nvarchar](max) NOT NULL,
	[kulSifre] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_kullaniciSet] PRIMARY KEY CLUSTERED 
(
	[Kul_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteriSet]    Script Date: 5.06.2022 22:38:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteriSet](
	[Mus_id] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAd] [nvarchar](max) NOT NULL,
	[MusAdres] [nvarchar](max) NOT NULL,
	[MusTel] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_musteriSet] PRIMARY KEY CLUSTERED 
(
	[Mus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiparisSet]    Script Date: 5.06.2022 22:38:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiparisSet](
	[Sip_id] [int] IDENTITY(1,1) NOT NULL,
	[SipAdres] [nvarchar](max) NOT NULL,
	[Adet] [int] NOT NULL,
	[Tutar] [int] NOT NULL,
	[mus_id] [int] NOT NULL,
	[Urun_id] [int] NOT NULL,
 CONSTRAINT [PK_SiparisSet] PRIMARY KEY CLUSTERED 
(
	[Sip_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunSet]    Script Date: 5.06.2022 22:38:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunSet](
	[Urun_id] [int] IDENTITY(1,1) NOT NULL,
	[UrunAd] [nvarchar](max) NOT NULL,
	[UrunFiyat] [int] NOT NULL,
 CONSTRAINT [PK_UrunSet] PRIMARY KEY CLUSTERED 
(
	[Urun_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[kullaniciSet] ON 

INSERT [dbo].[kullaniciSet] ([Kul_id], [kulAd], [kulSifre]) VALUES (1, N'm', N'm')
INSERT [dbo].[kullaniciSet] ([Kul_id], [kulAd], [kulSifre]) VALUES (2, N'Senem', N'sen123')
INSERT [dbo].[kullaniciSet] ([Kul_id], [kulAd], [kulSifre]) VALUES (3, N'Akif', N'akkif011')
SET IDENTITY_INSERT [dbo].[kullaniciSet] OFF
GO
SET IDENTITY_INSERT [dbo].[musteriSet] ON 

INSERT [dbo].[musteriSet] ([Mus_id], [MusteriAd], [MusAdres], [MusTel]) VALUES (2, N'Sibel Eren', N'Güneşli', N'022121211212')
INSERT [dbo].[musteriSet] ([Mus_id], [MusteriAd], [MusAdres], [MusTel]) VALUES (3, N'İsmail Serbest', N'Yenibosna', N'021549494964')
INSERT [dbo].[musteriSet] ([Mus_id], [MusteriAd], [MusAdres], [MusTel]) VALUES (5, N'Zehra Alabaş', N'Ümraniye', N'053594949494')
INSERT [dbo].[musteriSet] ([Mus_id], [MusteriAd], [MusAdres], [MusTel]) VALUES (6, N'Ayşe Erkuş', N'Bağcılar', N'0215656959')
INSERT [dbo].[musteriSet] ([Mus_id], [MusteriAd], [MusAdres], [MusTel]) VALUES (7, N'Rükna Kavraş', N'Sancaktepe', N'05465895614')
INSERT [dbo].[musteriSet] ([Mus_id], [MusteriAd], [MusAdres], [MusTel]) VALUES (8, N'Sibel İsmail', N'Beykoz', N'02121111111')
SET IDENTITY_INSERT [dbo].[musteriSet] OFF
GO
SET IDENTITY_INSERT [dbo].[SiparisSet] ON 

INSERT [dbo].[SiparisSet] ([Sip_id], [SipAdres], [Adet], [Tutar], [mus_id], [Urun_id]) VALUES (1, N'İstanbul Şişli', 2, 40, 3, 1)
INSERT [dbo].[SiparisSet] ([Sip_id], [SipAdres], [Adet], [Tutar], [mus_id], [Urun_id]) VALUES (2, N'Ümraniye', 1, 200, 5, 5)
INSERT [dbo].[SiparisSet] ([Sip_id], [SipAdres], [Adet], [Tutar], [mus_id], [Urun_id]) VALUES (3, N'Ümraniye', 2, 50, 2, 2)
INSERT [dbo].[SiparisSet] ([Sip_id], [SipAdres], [Adet], [Tutar], [mus_id], [Urun_id]) VALUES (4, N'Kirazlı', 5, 250, 5, 4)
INSERT [dbo].[SiparisSet] ([Sip_id], [SipAdres], [Adet], [Tutar], [mus_id], [Urun_id]) VALUES (7, N'Bahçelievler', 2, 2000, 6, 1)
SET IDENTITY_INSERT [dbo].[SiparisSet] OFF
GO
SET IDENTITY_INSERT [dbo].[UrunSet] ON 

INSERT [dbo].[UrunSet] ([Urun_id], [UrunAd], [UrunFiyat]) VALUES (1, N'Papatya', 20)
INSERT [dbo].[UrunSet] ([Urun_id], [UrunAd], [UrunFiyat]) VALUES (2, N'Begonya', 25)
INSERT [dbo].[UrunSet] ([Urun_id], [UrunAd], [UrunFiyat]) VALUES (3, N'Çilek', 12)
INSERT [dbo].[UrunSet] ([Urun_id], [UrunAd], [UrunFiyat]) VALUES (4, N'Zambak', 50)
INSERT [dbo].[UrunSet] ([Urun_id], [UrunAd], [UrunFiyat]) VALUES (5, N'Aleo Vera', 200)
SET IDENTITY_INSERT [dbo].[UrunSet] OFF
GO
/****** Object:  Index [IX_FK_musteriSiparis]    Script Date: 5.06.2022 22:38:24 ******/
CREATE NONCLUSTERED INDEX [IX_FK_musteriSiparis] ON [dbo].[SiparisSet]
(
	[mus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_UrunSiparis]    Script Date: 5.06.2022 22:38:24 ******/
CREATE NONCLUSTERED INDEX [IX_FK_UrunSiparis] ON [dbo].[SiparisSet]
(
	[Urun_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SiparisSet]  WITH CHECK ADD  CONSTRAINT [FK_musteriSiparis] FOREIGN KEY([mus_id])
REFERENCES [dbo].[musteriSet] ([Mus_id])
GO
ALTER TABLE [dbo].[SiparisSet] CHECK CONSTRAINT [FK_musteriSiparis]
GO
ALTER TABLE [dbo].[SiparisSet]  WITH CHECK ADD  CONSTRAINT [FK_UrunSiparis] FOREIGN KEY([Urun_id])
REFERENCES [dbo].[UrunSet] ([Urun_id])
GO
ALTER TABLE [dbo].[SiparisSet] CHECK CONSTRAINT [FK_UrunSiparis]
GO
USE [master]
GO
ALTER DATABASE [cicekci] SET  READ_WRITE 
GO
