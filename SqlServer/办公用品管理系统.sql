USE [master]
GO
/****** Object:  Database [OfficeSuppliesManagementSystemDatabase]    Script Date: 07/01/2016 12:29:54 ******/
CREATE DATABASE [OfficeSuppliesManagementSystemDatabase] ON  PRIMARY 
( NAME = N'OfficeSuppliesManagementSystemDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\OfficeSuppliesManagementSystemDatabase.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OfficeSuppliesManagementSystemDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\OfficeSuppliesManagementSystemDatabase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OfficeSuppliesManagementSystemDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET ANSI_NULLS OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET ANSI_PADDING OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET ARITHABORT OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET  DISABLE_BROKER
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET  READ_WRITE
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET RECOVERY FULL
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET  MULTI_USER
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [OfficeSuppliesManagementSystemDatabase] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'OfficeSuppliesManagementSystemDatabase', N'ON'
GO
USE [OfficeSuppliesManagementSystemDatabase]
GO
/****** Object:  Table [dbo].[RuKuXin]    Script Date: 07/01/2016 12:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RuKuXin](
	[Date] [date] NOT NULL,
	[Supplier] [varchar](50) NOT NULL,
	[InvoiceNumber] [int] NOT NULL,
	[Remark] [varchar](50) NULL,
	[LingquR] [varchar](50) NULL,
	[Shuling] [int] NULL,
	[Leibie] [varchar](50) NULL,
	[Danjia] [int] NULL,
	[Zongjine]  AS ([Shuling]*[Danjia]) PERSISTED,
 CONSTRAINT [PK_RuKuXin] PRIMARY KEY CLUSTERED 
(
	[InvoiceNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LinQu]    Script Date: 07/01/2016 12:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LinQu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ShangPinId] [int] NOT NULL,
	[BuMenId] [varchar](50) NOT NULL,
	[ChuKuShu] [varchar](50) NOT NULL,
	[LingQuRen] [varchar](50) NULL,
	[ShangMin] [varchar](50) NULL,
	[BuMin] [varchar](50) NULL,
	[DanJIa] [int] NULL,
	[JinE]  AS ([DanJIa]*[ChuKuShu]),
	[ShiJian] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BumenXin]    Script Date: 07/01/2016 12:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BumenXin](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[Shangpin] [varchar](50) NULL,
	[Shuliang] [int] NULL,
	[FuZeRen] [varchar](50) NULL,
 CONSTRAINT [PK_BumenXin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 07/01/2016 12:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Administrator](
	[Id] [varchar](50) NOT NULL,
	[Psw] [varchar](50) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
