USE [master]
GO
/****** Object:  Database [Csv_main]    Script Date: 2022/01/31 22:20:35 ******/
CREATE DATABASE [Csv_main]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Csv_main', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Csv_main.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Csv_main_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Csv_main_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Csv_main] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Csv_main].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Csv_main] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Csv_main] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Csv_main] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Csv_main] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Csv_main] SET ARITHABORT OFF 
GO
ALTER DATABASE [Csv_main] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Csv_main] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Csv_main] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Csv_main] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Csv_main] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Csv_main] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Csv_main] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Csv_main] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Csv_main] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Csv_main] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Csv_main] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Csv_main] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Csv_main] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Csv_main] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Csv_main] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Csv_main] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Csv_main] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Csv_main] SET RECOVERY FULL 
GO
ALTER DATABASE [Csv_main] SET  MULTI_USER 
GO
ALTER DATABASE [Csv_main] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Csv_main] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Csv_main] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Csv_main] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Csv_main] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Csv_main', N'ON'
GO
ALTER DATABASE [Csv_main] SET QUERY_STORE = OFF
GO
USE [Csv_main]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2022/01/31 22:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CsvFile]    Script Date: 2022/01/31 22:20:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CsvFile](
	[Id] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[DeletedDate] [datetime2](7) NOT NULL,
	[StudentNumber] [int] NOT NULL,
	[Surname] [nvarchar](max) NULL,
	[CourseCode] [nvarchar](max) NULL,
	[CourseDescription] [nvarchar](max) NULL,
	[FirstName] [nvarchar](max) NULL,
	[Grade] [nvarchar](max) NULL,
 CONSTRAINT [PK_CsvFile] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220126061619_firstmigration', N'5.0.0-preview.6.20312.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220126150818_AdditionalFields', N'5.0.0-preview.6.20312.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220128135354_ChangeDataTypeCouseCode', N'5.0.0-preview.6.20312.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220128140351_ChangeDataTypeStudentNumberyoint', N'5.0.0-preview.6.20312.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220128143206_migrationAddDate', N'5.0.0-preview.6.20312.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220129063842_migrationUpdateTable', N'5.0.0-preview.6.20312.4')
GO
USE [master]
GO
ALTER DATABASE [Csv_main] SET  READ_WRITE 
GO
