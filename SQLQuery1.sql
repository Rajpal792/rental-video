USE [master]
GO
/****** Object:  Database [VideoRentalSystem_Rajpal]    Script Date: 12-06-2020 04:30:53 PM ******/
CREATE DATABASE [VideoRentalSystem_Rajpal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoRentalSystem_Rajpal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\VideoRentalSystem_Rajpal.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VideoRentalSystem_Rajpal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\VideoRentalSystem_Rajpal_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoRentalSystem_Rajpal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET  MULTI_USER 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET DELAYED_DURABILITY = DISABLED 
GO
USE [VideoRentalSystem_Rajpal]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12-06-2020 04:30:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Address] [nvarchar](500) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RentedMovie]    Script Date: 12-06-2020 04:30:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovie](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MovieIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMovie] PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Videos]    Script Date: 12-06-2020 04:30:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Points] [nvarchar](50) NULL,
	[Year] [int] NULL,
	[Copies] [int] NULL,
	[ReleasedBy] [nvarchar](50) NULL,
	[RentalCost] [int] NULL,
 CONSTRAINT [PK_Videos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

GO
INSERT [dbo].[Customers] ([ID], [Name], [Mobile], [Address]) VALUES (1, N'Rajpal', N'12345575', N'qwery')
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
USE [master]
GO
ALTER DATABASE [VideoRentalSystem_Rajpal] SET  READ_WRITE 
GO
