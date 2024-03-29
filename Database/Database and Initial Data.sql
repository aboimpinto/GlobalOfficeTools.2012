USE [master]
GO
/****** Object:  Database [dbGlobalOfficeTools]    Script Date: 06/08/2012 20:31:24 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'dbGlobalOfficeTools')
BEGIN
CREATE DATABASE [dbGlobalOfficeTools] ON  PRIMARY 
( NAME = N'dbGlobalOfficeTools', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\dbGlobalOfficeTools.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbGlobalOfficeTools_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\dbGlobalOfficeTools_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END
GO
ALTER DATABASE [dbGlobalOfficeTools] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbGlobalOfficeTools].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbGlobalOfficeTools] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET ANSI_NULLS OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET ANSI_PADDING OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET ARITHABORT OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET AUTO_CLOSE ON
GO
ALTER DATABASE [dbGlobalOfficeTools] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [dbGlobalOfficeTools] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [dbGlobalOfficeTools] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [dbGlobalOfficeTools] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET  DISABLE_BROKER
GO
ALTER DATABASE [dbGlobalOfficeTools] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [dbGlobalOfficeTools] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [dbGlobalOfficeTools] SET  READ_WRITE
GO
ALTER DATABASE [dbGlobalOfficeTools] SET RECOVERY SIMPLE
GO
ALTER DATABASE [dbGlobalOfficeTools] SET  MULTI_USER
GO
ALTER DATABASE [dbGlobalOfficeTools] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [dbGlobalOfficeTools] SET DB_CHAINING OFF
GO
USE [dbGlobalOfficeTools]
GO
/****** Object:  ForeignKey [FK_ENTtblAddressBook_ENTtblEntity]    Script Date: 06/08/2012 20:31:27 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ENTtblAddressBook_ENTtblEntity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ENTtblAddressBook]'))
ALTER TABLE [dbo].[ENTtblAddressBook] DROP CONSTRAINT [FK_ENTtblAddressBook_ENTtblEntity]
GO
/****** Object:  ForeignKey [FK_CLItblFederationDetail_CLItblUser]    Script Date: 06/08/2012 20:31:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblFederationDetail_CLItblUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblFederationDetails]'))
ALTER TABLE [dbo].[CLItblFederationDetails] DROP CONSTRAINT [FK_CLItblFederationDetail_CLItblUser]
GO
/****** Object:  ForeignKey [FK_CLItblCompanyUser_CLItblCompany]    Script Date: 06/08/2012 20:31:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblCompanyUser_CLItblCompany]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblCompanyUser]'))
ALTER TABLE [dbo].[CLItblCompanyUser] DROP CONSTRAINT [FK_CLItblCompanyUser_CLItblCompany]
GO
/****** Object:  ForeignKey [FK_CLItblCompanyUser_CLItblUser]    Script Date: 06/08/2012 20:31:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblCompanyUser_CLItblUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblCompanyUser]'))
ALTER TABLE [dbo].[CLItblCompanyUser] DROP CONSTRAINT [FK_CLItblCompanyUser_CLItblUser]
GO
/****** Object:  Table [dbo].[CLItblCompanyUser]    Script Date: 06/08/2012 20:31:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblCompanyUser_CLItblCompany]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblCompanyUser]'))
ALTER TABLE [dbo].[CLItblCompanyUser] DROP CONSTRAINT [FK_CLItblCompanyUser_CLItblCompany]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblCompanyUser_CLItblUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblCompanyUser]'))
ALTER TABLE [dbo].[CLItblCompanyUser] DROP CONSTRAINT [FK_CLItblCompanyUser_CLItblUser]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblCompanyUser]') AND type in (N'U'))
DROP TABLE [dbo].[CLItblCompanyUser]
GO
/****** Object:  Table [dbo].[CLItblFederationDetails]    Script Date: 06/08/2012 20:31:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblFederationDetail_CLItblUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblFederationDetails]'))
ALTER TABLE [dbo].[CLItblFederationDetails] DROP CONSTRAINT [FK_CLItblFederationDetail_CLItblUser]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblFederationDetails]') AND type in (N'U'))
DROP TABLE [dbo].[CLItblFederationDetails]
GO
/****** Object:  View [dbo].[CLIvwEmployeeType]    Script Date: 06/08/2012 20:31:28 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[CLIvwEmployeeType]'))
DROP VIEW [dbo].[CLIvwEmployeeType]
GO
/****** Object:  Table [dbo].[ENTtblAddressBook]    Script Date: 06/08/2012 20:31:27 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ENTtblAddressBook_ENTtblEntity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ENTtblAddressBook]'))
ALTER TABLE [dbo].[ENTtblAddressBook] DROP CONSTRAINT [FK_ENTtblAddressBook_ENTtblEntity]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ENTtblAddressBook_ContactReferenceId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ENTtblAddressBook] DROP CONSTRAINT [DF_ENTtblAddressBook_ContactReferenceId]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ENTtblAddressBook_IsDefault]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ENTtblAddressBook] DROP CONSTRAINT [DF_ENTtblAddressBook_IsDefault]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ENTtblAddressBook_HierarchyId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ENTtblAddressBook] DROP CONSTRAINT [DF_ENTtblAddressBook_HierarchyId]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTtblAddressBook]') AND type in (N'U'))
DROP TABLE [dbo].[ENTtblAddressBook]
GO
/****** Object:  Table [dbo].[ENTtblContact]    Script Date: 06/08/2012 20:31:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTtblContact]') AND type in (N'U'))
DROP TABLE [dbo].[ENTtblContact]
GO
/****** Object:  Table [dbo].[ENTtblEntity]    Script Date: 06/08/2012 20:31:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTtblEntity]') AND type in (N'U'))
DROP TABLE [dbo].[ENTtblEntity]
GO
/****** Object:  Table [dbo].[ENTtblPerson]    Script Date: 06/08/2012 20:31:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTtblPerson]') AND type in (N'U'))
DROP TABLE [dbo].[ENTtblPerson]
GO
/****** Object:  Table [dbo].[SYStblMenu]    Script Date: 06/08/2012 20:31:27 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SYStblMenu_ParentMenuId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SYStblMenu] DROP CONSTRAINT [DF_SYStblMenu_ParentMenuId]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SYStblMenu]') AND type in (N'U'))
DROP TABLE [dbo].[SYStblMenu]
GO
/****** Object:  Table [dbo].[SYStblNewsMessages]    Script Date: 06/08/2012 20:31:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SYStblNewsMessages]') AND type in (N'U'))
DROP TABLE [dbo].[SYStblNewsMessages]
GO
/****** Object:  Table [dbo].[SYStblOption]    Script Date: 06/08/2012 20:31:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SYStblOption]') AND type in (N'U'))
DROP TABLE [dbo].[SYStblOption]
GO
/****** Object:  Table [dbo].[ENTtblAddress]    Script Date: 06/08/2012 20:31:27 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ENTtblAddress_IsBillingAddress]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ENTtblAddress] DROP CONSTRAINT [DF_ENTtblAddress_IsBillingAddress]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ENTtblAddress_IsShippingAddress]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ENTtblAddress] DROP CONSTRAINT [DF_ENTtblAddress_IsShippingAddress]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTtblAddress]') AND type in (N'U'))
DROP TABLE [dbo].[ENTtblAddress]
GO
/****** Object:  Table [dbo].[CLItblAcl]    Script Date: 06/08/2012 20:31:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblAcl]') AND type in (N'U'))
DROP TABLE [dbo].[CLItblAcl]
GO
/****** Object:  Table [dbo].[CLItblCompany]    Script Date: 06/08/2012 20:31:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblCompany]') AND type in (N'U'))
DROP TABLE [dbo].[CLItblCompany]
GO
/****** Object:  Table [dbo].[CLItblReference]    Script Date: 06/08/2012 20:31:26 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_CLItblReference_IsActive]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[CLItblReference] DROP CONSTRAINT [DF_CLItblReference_IsActive]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_CLItblReference_IsSystem]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[CLItblReference] DROP CONSTRAINT [DF_CLItblReference_IsSystem]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblReference]') AND type in (N'U'))
DROP TABLE [dbo].[CLItblReference]
GO
/****** Object:  Table [dbo].[CLItblUser]    Script Date: 06/08/2012 20:31:26 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_CLItblUser_IsActive]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[CLItblUser] DROP CONSTRAINT [DF_CLItblUser_IsActive]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblUser]') AND type in (N'U'))
DROP TABLE [dbo].[CLItblUser]
GO
/****** Object:  User [GOT_User]    Script Date: 06/08/2012 20:31:24 ******/
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'GOT_User')
DROP USER [GOT_User]
GO
/****** Object:  User [GOT_User]    Script Date: 06/08/2012 20:31:24 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'GOT_User')
CREATE USER [GOT_User] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[CLItblUser]    Script Date: 06/08/2012 20:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CLItblUser](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](255) NOT NULL,
	[IsActive] [bit] NOT NULL CONSTRAINT [DF_CLItblUser_IsActive]  DEFAULT ((1)),
 CONSTRAINT [PK_CLItblUser] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CLItblUser] ON
INSERT [dbo].[CLItblUser] ([UserId], [FullName], [IsActive]) VALUES (1, N'Paulo Aboim Pinto', 1)
INSERT [dbo].[CLItblUser] ([UserId], [FullName], [IsActive]) VALUES (2, N'Lara Fernandes', 1)
SET IDENTITY_INSERT [dbo].[CLItblUser] OFF
/****** Object:  Table [dbo].[CLItblReference]    Script Date: 06/08/2012 20:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblReference]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CLItblReference](
	[ReferenceId] [int] IDENTITY(1,1) NOT NULL,
	[ReferenceTable] [varchar](100) NOT NULL,
	[Id] [int] NOT NULL,
	[Code] [varchar](50) NULL,
	[Value] [varchar](100) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL CONSTRAINT [DF_CLItblReference_IsActive]  DEFAULT ((0)),
	[IsSystem] [bit] NOT NULL CONSTRAINT [DF_CLItblReference_IsSystem]  DEFAULT ((0)),
 CONSTRAINT [PK_CLItblReference] PRIMARY KEY CLUSTERED 
(
	[ReferenceId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CLItblReference] ON
INSERT [dbo].[CLItblReference] ([ReferenceId], [ReferenceTable], [Id], [Code], [Value], [CompanyId], [IsActive], [IsSystem]) VALUES (1, N'EmployeeType', 1, NULL, N'Owner', 1, 1, 1)
INSERT [dbo].[CLItblReference] ([ReferenceId], [ReferenceTable], [Id], [Code], [Value], [CompanyId], [IsActive], [IsSystem]) VALUES (2, N'EmployeeType', 2, NULL, N'Seller', 1, 1, 0)
INSERT [dbo].[CLItblReference] ([ReferenceId], [ReferenceTable], [Id], [Code], [Value], [CompanyId], [IsActive], [IsSystem]) VALUES (3, N'EmployeeType', 3, NULL, N'Office Manager', 1, 1, 0)
INSERT [dbo].[CLItblReference] ([ReferenceId], [ReferenceTable], [Id], [Code], [Value], [CompanyId], [IsActive], [IsSystem]) VALUES (4, N'ClientType', 1, N'P', N'Private', 1, 1, 0)
INSERT [dbo].[CLItblReference] ([ReferenceId], [ReferenceTable], [Id], [Code], [Value], [CompanyId], [IsActive], [IsSystem]) VALUES (5, N'ClientType', 2, N'E', N'Company', 1, 1, 0)
INSERT [dbo].[CLItblReference] ([ReferenceId], [ReferenceTable], [Id], [Code], [Value], [CompanyId], [IsActive], [IsSystem]) VALUES (6, N'ClientType', 1, N'P', N'Private', 2, 1, 0)
INSERT [dbo].[CLItblReference] ([ReferenceId], [ReferenceTable], [Id], [Code], [Value], [CompanyId], [IsActive], [IsSystem]) VALUES (7, N'ClientType', 2, N'E', N'Company', 2, 1, 0)
SET IDENTITY_INSERT [dbo].[CLItblReference] OFF
/****** Object:  Table [dbo].[CLItblCompany]    Script Date: 06/08/2012 20:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblCompany]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CLItblCompany](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](255) NOT NULL,
	[ShortName] [varchar](50) NULL,
 CONSTRAINT [PK_CLItblCompany] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CLItblCompany] ON
INSERT [dbo].[CLItblCompany] ([CompanyId], [FullName], [ShortName]) VALUES (1, N'IMAGO Software', N'IMAGO')
INSERT [dbo].[CLItblCompany] ([CompanyId], [FullName], [ShortName]) VALUES (2, N'TLS - Advogados', N'TLS')
SET IDENTITY_INSERT [dbo].[CLItblCompany] OFF
/****** Object:  Table [dbo].[CLItblAcl]    Script Date: 06/08/2012 20:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblAcl]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CLItblAcl](
	[AclId] [int] IDENTITY(1,1) NOT NULL,
	[Entity] [varchar](50) NULL,
	[EntityId] [int] NULL,
	[Resource] [varchar](100) NOT NULL,
	[ResourceId] [int] NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_CLItblAclId] PRIMARY KEY CLUSTERED 
(
	[AclId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CLItblAcl] ON
INSERT [dbo].[CLItblAcl] ([AclId], [Entity], [EntityId], [Resource], [ResourceId], [CompanyId]) VALUES (1, N'USER', 1, N'MENU', 1, 1)
INSERT [dbo].[CLItblAcl] ([AclId], [Entity], [EntityId], [Resource], [ResourceId], [CompanyId]) VALUES (2, N'USER', 1, N'MENU', 2, 1)
INSERT [dbo].[CLItblAcl] ([AclId], [Entity], [EntityId], [Resource], [ResourceId], [CompanyId]) VALUES (3, N'USER', 1, N'MENU', 3, 1)
INSERT [dbo].[CLItblAcl] ([AclId], [Entity], [EntityId], [Resource], [ResourceId], [CompanyId]) VALUES (4, N'USER', 1, N'MENU', 4, 1)
INSERT [dbo].[CLItblAcl] ([AclId], [Entity], [EntityId], [Resource], [ResourceId], [CompanyId]) VALUES (5, N'USER', 1, N'MENU', 5, 1)
INSERT [dbo].[CLItblAcl] ([AclId], [Entity], [EntityId], [Resource], [ResourceId], [CompanyId]) VALUES (6, N'USER', 1, N'MENU', 6, 1)
INSERT [dbo].[CLItblAcl] ([AclId], [Entity], [EntityId], [Resource], [ResourceId], [CompanyId]) VALUES (7, N'USER', 1, N'MENU', 7, 1)
SET IDENTITY_INSERT [dbo].[CLItblAcl] OFF
/****** Object:  Table [dbo].[ENTtblAddress]    Script Date: 06/08/2012 20:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTtblAddress]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ENTtblAddress](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[AddressLineOne] [varchar](1000) NULL,
	[AddressLineTwo] [varchar](1000) NULL,
	[PostalCode] [varchar](1000) NULL,
	[Country] [varchar](1000) NULL,
	[IsBillingAddress] [bit] NOT NULL CONSTRAINT [DF_ENTtblAddress_IsBillingAddress]  DEFAULT ((0)),
	[IsShippingAddress] [bit] NOT NULL CONSTRAINT [DF_ENTtblAddress_IsShippingAddress]  DEFAULT ((0)),
 CONSTRAINT [PK_ENTtblAddress] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYStblOption]    Script Date: 06/08/2012 20:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SYStblOption]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SYStblOption](
	[OptionId] [int] IDENTITY(1,1) NOT NULL,
	[OptionType] [varchar](100) NOT NULL,
	[ObjectId] [int] NOT NULL,
	[OptionKey] [varchar](255) NOT NULL,
	[OptionValue] [varchar](255) NOT NULL,
 CONSTRAINT [PK_SYStblOption] PRIMARY KEY CLUSTERED 
(
	[OptionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[SYStblOption] ON
INSERT [dbo].[SYStblOption] ([OptionId], [OptionType], [ObjectId], [OptionKey], [OptionValue]) VALUES (1, N'COMPANY', 1, N'CountryId', N'1')
INSERT [dbo].[SYStblOption] ([OptionId], [OptionType], [ObjectId], [OptionKey], [OptionValue]) VALUES (2, N'COMPANY', 1, N'CurrencyId', N'1')
INSERT [dbo].[SYStblOption] ([OptionId], [OptionType], [ObjectId], [OptionKey], [OptionValue]) VALUES (3, N'COMPANY', 1, N'TimeZoneId', N'1')
INSERT [dbo].[SYStblOption] ([OptionId], [OptionType], [ObjectId], [OptionKey], [OptionValue]) VALUES (4, N'USER', 1, N'DefaultCompanyId', N'1')
INSERT [dbo].[SYStblOption] ([OptionId], [OptionType], [ObjectId], [OptionKey], [OptionValue]) VALUES (5, N'USER', 1, N'NbrRecordsPage', N'20')
INSERT [dbo].[SYStblOption] ([OptionId], [OptionType], [ObjectId], [OptionKey], [OptionValue]) VALUES (6, N'COMPANY', 2, N'CountryId', N'1')
INSERT [dbo].[SYStblOption] ([OptionId], [OptionType], [ObjectId], [OptionKey], [OptionValue]) VALUES (7, N'COMPANY', 2, N'CurrencyId', N'1')
INSERT [dbo].[SYStblOption] ([OptionId], [OptionType], [ObjectId], [OptionKey], [OptionValue]) VALUES (8, N'COMPANY', 2, N'TimeZoneId', N'1')
INSERT [dbo].[SYStblOption] ([OptionId], [OptionType], [ObjectId], [OptionKey], [OptionValue]) VALUES (9, N'USER', 2, N'DefaultCompanyId', N'2')
INSERT [dbo].[SYStblOption] ([OptionId], [OptionType], [ObjectId], [OptionKey], [OptionValue]) VALUES (10, N'USER', 2, N'NbrRecordsPage', N'20')
SET IDENTITY_INSERT [dbo].[SYStblOption] OFF
/****** Object:  Table [dbo].[SYStblNewsMessages]    Script Date: 06/08/2012 20:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SYStblNewsMessages]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SYStblNewsMessages](
	[NewMessageId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[MessageDate] [date] NOT NULL,
	[Message] [varchar](1000) NOT NULL,
	[Writer] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SYStblNews] PRIMARY KEY CLUSTERED 
(
	[NewMessageId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[SYStblNewsMessages] ON
INSERT [dbo].[SYStblNewsMessages] ([NewMessageId], [Title], [MessageDate], [Message], [Writer]) VALUES (1, N'Início do desenvolvimento em ASP.NET MVC4', CAST(0xF3340B00 AS Date), N'Devido à possibilidade de criar páginas para cada equipamento móvel, o desenvolvimento Global Office Tools em Silverlight temporariamente abandonado.', N'Paulo Aboim Pinto')
INSERT [dbo].[SYStblNewsMessages] ([NewMessageId], [Title], [MessageDate], [Message], [Writer]) VALUES (2, N'Criação da primeira página para equipamentos móveis', CAST(0xF3340B00 AS Date), N'É possivel visitar a página de entrada no Global Office Tools num equipamento móvel mantendo uma estrutura coerente e de acordo com as dimensões do equipamento', N'Paulo Aboim Pinto')
SET IDENTITY_INSERT [dbo].[SYStblNewsMessages] OFF
/****** Object:  Table [dbo].[SYStblMenu]    Script Date: 06/08/2012 20:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SYStblMenu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SYStblMenu](
	[MenuId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Text] [varchar](50) NOT NULL,
	[Image] [varchar](1000) NULL,
	[Action] [varchar](255) NULL,
	[ActionObject] [varchar](50) NULL,
	[ActionParameters] [varchar](255) NULL,
	[ParentMenuId] [int] NOT NULL CONSTRAINT [DF_SYStblMenu_ParentMenuId]  DEFAULT ((-1)),
	[MenuOrder] [int] NOT NULL,
 CONSTRAINT [PK_SYStblMenu] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[SYStblMenu] ON
INSERT [dbo].[SYStblMenu] ([MenuId], [Name], [Text], [Image], [Action], [ActionObject], [ActionParameters], [ParentMenuId], [MenuOrder]) VALUES (1, N'Dossiers', N'Dossiers', N'/GlobalOfficeTools.VS2012;component/Images/Menu/dossier.png', NULL, NULL, NULL, -1, 2)
INSERT [dbo].[SYStblMenu] ([MenuId], [Name], [Text], [Image], [Action], [ActionObject], [ActionParameters], [ParentMenuId], [MenuOrder]) VALUES (2, N'Entities', N'Entities', N'/GlobalOfficeTools.VS2012;component/Images/Menu/group.png', N'VIEW', N'EntitiesList', NULL, -1, 3)
INSERT [dbo].[SYStblMenu] ([MenuId], [Name], [Text], [Image], [Action], [ActionObject], [ActionParameters], [ParentMenuId], [MenuOrder]) VALUES (3, N'Settings', N'Settings', N'/GlobalOfficeTools.VS2012;component/Images/Menu/settings.png', NULL, NULL, NULL, -1, 4)
INSERT [dbo].[SYStblMenu] ([MenuId], [Name], [Text], [Image], [Action], [ActionObject], [ActionParameters], [ParentMenuId], [MenuOrder]) VALUES (7, N'Dashboard', N'Dashboard', N'/GlobalOfficeTools.VS2012;component/Images/Menu/dashboard.png', N'VIEW', N'DashboardPage', NULL, -1, 1)
INSERT [dbo].[SYStblMenu] ([MenuId], [Name], [Text], [Image], [Action], [ActionObject], [ActionParameters], [ParentMenuId], [MenuOrder]) VALUES (9, N'Help', N'Help', N'/GlobalOfficeTools.VS2012;component/Images/Menu/help.png', N'VIEW', NULL, NULL, -1, 5)
SET IDENTITY_INSERT [dbo].[SYStblMenu] OFF
/****** Object:  Table [dbo].[ENTtblPerson]    Script Date: 06/08/2012 20:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTtblPerson]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ENTtblPerson](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Note] [varchar](1000) NULL,
 CONSTRAINT [PK_ENTtblPerson] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ENTtblEntity]    Script Date: 06/08/2012 20:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTtblEntity]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ENTtblEntity](
	[EntityId] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[ShortName] [varchar](50) NULL,
	[VatNumber] [varchar](50) NULL,
 CONSTRAINT [PK_ENTtblEntity] PRIMARY KEY CLUSTERED 
(
	[EntityId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ENTtblContact]    Script Date: 06/08/2012 20:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTtblContact]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ENTtblContact](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](100) NOT NULL,
	[Value] [varchar](255) NOT NULL,
 CONSTRAINT [PK_ENTtblContact] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ENTtblAddressBook]    Script Date: 06/08/2012 20:31:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTtblAddressBook]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ENTtblAddressBook](
	[EntityAddressBookId] [int] IDENTITY(1,1) NOT NULL,
	[EntityId] [int] NOT NULL,
	[Reference] [varchar](50) NOT NULL,
	[ReferenceId] [int] NOT NULL CONSTRAINT [DF_ENTtblAddressBook_ContactReferenceId]  DEFAULT ((-1)),
	[IsDefault] [bit] NOT NULL CONSTRAINT [DF_ENTtblAddressBook_IsDefault]  DEFAULT ((0)),
	[HierarchyId] [int] NOT NULL CONSTRAINT [DF_ENTtblAddressBook_HierarchyId]  DEFAULT ((-1)),
 CONSTRAINT [PK_ENTtblAddressBook] PRIMARY KEY CLUSTERED 
(
	[EntityAddressBookId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[CLIvwEmployeeType]    Script Date: 06/08/2012 20:31:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[CLIvwEmployeeType]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[CLIvwEmployeeType]
AS
SELECT     TOP (100) PERCENT Id AS EmployeeTypeId, Value AS EmployeeType
FROM         dbo.CLItblReference
WHERE     (IsActive = 1) AND (ReferenceTable = ''EmployeeType'')
ORDER BY EmployeeTypeId
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'CLIvwEmployeeType', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CLItblReference"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 170
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1725
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CLIvwEmployeeType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'CLIvwEmployeeType', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CLIvwEmployeeType'
GO
/****** Object:  Table [dbo].[CLItblFederationDetails]    Script Date: 06/08/2012 20:31:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblFederationDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CLItblFederationDetails](
	[FederationDetailId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[FederationType] [varchar](50) NOT NULL,
	[FederationId] [varchar](100) NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_CLItblFederationDetail] PRIMARY KEY CLUSTERED 
(
	[FederationDetailId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[CLItblFederationDetails]') AND name = N'IX_CLItblFederationDetail')
CREATE NONCLUSTERED INDEX [IX_CLItblFederationDetail] ON [dbo].[CLItblFederationDetails] 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CLItblFederationDetails] ON
INSERT [dbo].[CLItblFederationDetails] ([FederationDetailId], [UserId], [FederationType], [FederationId], [UserName], [Password]) VALUES (1, 1, N'LOCAL', NULL, N'esqueleto', N'paulo97')
INSERT [dbo].[CLItblFederationDetails] ([FederationDetailId], [UserId], [FederationType], [FederationId], [UserName], [Password]) VALUES (2, 2, N'LOCAL', NULL, N'lara', N'lisboa')
SET IDENTITY_INSERT [dbo].[CLItblFederationDetails] OFF
/****** Object:  Table [dbo].[CLItblCompanyUser]    Script Date: 06/08/2012 20:31:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLItblCompanyUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CLItblCompanyUser](
	[CompanyUserId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[EmployeeTypeId] [int] NOT NULL,
 CONSTRAINT [PK_CLItblCompanyUser] PRIMARY KEY CLUSTERED 
(
	[CompanyUserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[CLItblCompanyUser] ON
INSERT [dbo].[CLItblCompanyUser] ([CompanyUserId], [CompanyId], [UserId], [EmployeeTypeId]) VALUES (1, 1, 1, 1)
INSERT [dbo].[CLItblCompanyUser] ([CompanyUserId], [CompanyId], [UserId], [EmployeeTypeId]) VALUES (2, 2, 2, 1)
SET IDENTITY_INSERT [dbo].[CLItblCompanyUser] OFF
/****** Object:  ForeignKey [FK_ENTtblAddressBook_ENTtblEntity]    Script Date: 06/08/2012 20:31:27 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ENTtblAddressBook_ENTtblEntity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ENTtblAddressBook]'))
ALTER TABLE [dbo].[ENTtblAddressBook]  WITH CHECK ADD  CONSTRAINT [FK_ENTtblAddressBook_ENTtblEntity] FOREIGN KEY([EntityId])
REFERENCES [dbo].[ENTtblEntity] ([EntityId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ENTtblAddressBook_ENTtblEntity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ENTtblAddressBook]'))
ALTER TABLE [dbo].[ENTtblAddressBook] CHECK CONSTRAINT [FK_ENTtblAddressBook_ENTtblEntity]
GO
/****** Object:  ForeignKey [FK_CLItblFederationDetail_CLItblUser]    Script Date: 06/08/2012 20:31:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblFederationDetail_CLItblUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblFederationDetails]'))
ALTER TABLE [dbo].[CLItblFederationDetails]  WITH CHECK ADD  CONSTRAINT [FK_CLItblFederationDetail_CLItblUser] FOREIGN KEY([UserId])
REFERENCES [dbo].[CLItblUser] ([UserId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblFederationDetail_CLItblUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblFederationDetails]'))
ALTER TABLE [dbo].[CLItblFederationDetails] CHECK CONSTRAINT [FK_CLItblFederationDetail_CLItblUser]
GO
/****** Object:  ForeignKey [FK_CLItblCompanyUser_CLItblCompany]    Script Date: 06/08/2012 20:31:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblCompanyUser_CLItblCompany]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblCompanyUser]'))
ALTER TABLE [dbo].[CLItblCompanyUser]  WITH CHECK ADD  CONSTRAINT [FK_CLItblCompanyUser_CLItblCompany] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[CLItblCompany] ([CompanyId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblCompanyUser_CLItblCompany]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblCompanyUser]'))
ALTER TABLE [dbo].[CLItblCompanyUser] CHECK CONSTRAINT [FK_CLItblCompanyUser_CLItblCompany]
GO
/****** Object:  ForeignKey [FK_CLItblCompanyUser_CLItblUser]    Script Date: 06/08/2012 20:31:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblCompanyUser_CLItblUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblCompanyUser]'))
ALTER TABLE [dbo].[CLItblCompanyUser]  WITH CHECK ADD  CONSTRAINT [FK_CLItblCompanyUser_CLItblUser] FOREIGN KEY([UserId])
REFERENCES [dbo].[CLItblUser] ([UserId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLItblCompanyUser_CLItblUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLItblCompanyUser]'))
ALTER TABLE [dbo].[CLItblCompanyUser] CHECK CONSTRAINT [FK_CLItblCompanyUser_CLItblUser]
GO
