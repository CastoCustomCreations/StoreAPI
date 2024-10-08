USE [master]
GO
/****** Object:  Database [StoreDB]    Script Date: 7/29/2024 5:59:47 PM ******/
CREATE DATABASE [StoreDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StoreDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\StoreDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StoreDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\StoreDB_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [StoreDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StoreDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StoreDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StoreDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StoreDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StoreDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StoreDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StoreDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StoreDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StoreDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StoreDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StoreDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StoreDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StoreDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StoreDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StoreDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StoreDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StoreDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StoreDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StoreDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StoreDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StoreDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StoreDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StoreDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StoreDB] SET RECOVERY FULL 
GO
ALTER DATABASE [StoreDB] SET  MULTI_USER 
GO
ALTER DATABASE [StoreDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StoreDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StoreDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StoreDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StoreDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StoreDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StoreDB', N'ON'
GO
ALTER DATABASE [StoreDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [StoreDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [StoreDB]
GO
/****** Object:  User [NT AUTHORITY\SYSTEM]    Script Date: 7/29/2024 5:59:47 PM ******/
CREATE USER [NT AUTHORITY\SYSTEM] FOR LOGIN [NT AUTHORITY\SYSTEM] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [SQLArcExtensionUserRole]    Script Date: 7/29/2024 5:59:47 PM ******/
CREATE ROLE [SQLArcExtensionUserRole]
GO
ALTER ROLE [SQLArcExtensionUserRole] ADD MEMBER [NT AUTHORITY\SYSTEM]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 7/29/2024 5:59:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [nvarchar](450) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Address1] [nvarchar](max) NULL,
	[Address2] [nvarchar](max) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](5) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[CreatedDate] [date] NULL,
	[LastSignIn] [date] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 7/29/2024 5:59:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderPlaced] [datetime2](7) NOT NULL,
	[OrderFulfilled] [datetime2](7) NULL,
	[CustomerId] [int] NOT NULL,
	[CustomerId1] [nvarchar](450) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductOrders]    Script Date: 7/29/2024 5:59:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductOrders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[OrderId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/29/2024 5:59:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Catergory_Id] [int] NULL,
	[Description] [varchar](255) NULL,
	[Image_One] [varbinary](max) NULL,
	[Image_Two] [varbinary](max) NULL,
	[Image_Three] [varbinary](max) NULL,
	[Image_Four] [varbinary](max) NULL,
	[Image_Five] [varbinary](max) NULL,
	[Units_In_Stock] [int] NULL,
	[Units_On_Order] [int] NULL,
	[Units_Reorder_Level] [int] NULL,
	[SupplierId] [int] NULL,
	[Units_Sold] [int] NULL,
	[Unit_Weight] [numeric](3, 2) NULL,
	[Unit_Dimensions] [nvarchar](50) NULL,
	[Unit_Cost] [decimal](18, 2) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [StoreDB] SET  READ_WRITE 
GO
