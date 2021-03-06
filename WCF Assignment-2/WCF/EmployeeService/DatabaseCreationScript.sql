USE [master]
GO

/****** Object:  Database [Organization]    Script Date: 16-08-2018 19:33:40 ******/
CREATE DATABASE [Organization]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Organization', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Organization.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Organization_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Organization_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Organization] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Organization].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Organization] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Organization] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Organization] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Organization] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Organization] SET ARITHABORT OFF 
GO

ALTER DATABASE [Organization] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Organization] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [Organization] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Organization] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Organization] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Organization] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Organization] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Organization] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Organization] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Organization] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Organization] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Organization] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Organization] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Organization] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Organization] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Organization] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Organization] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Organization] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Organization] SET RECOVERY FULL 
GO

ALTER DATABASE [Organization] SET  MULTI_USER 
GO

ALTER DATABASE [Organization] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Organization] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Organization] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Organization] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Organization] SET  READ_WRITE 
GO


