CREATE DATABASE [Test_Invoice]
GO
USE [Test_Invoice]
GO
CREATE TABLE [dbo].[CustomerTypes](
[Id] [int] IDENTITY(1,1) primary key,
[Description] [nvarchar](70) NOT NULL
)
go
CREATE TABLE [dbo].[Customers](
[Id] [int] IDENTITY(1,1)primary key,
[CustName] [nvarchar](70) NOT NULL,
[Adress] [nvarchar](120) NOT NULL,
[Status] [bit] default(1),
[CustomerTypeId] [int] References CustomerTypes(Id)
)
GO

CREATE TABLE [dbo].[Invoices](
[Id] [int] IDENTITY(1,1) primary key,
[CustomerId] [int] References Customers(Id),
[TotalItbis] decimal(12,4) NOT NULL,
[SubTotal] decimal(12,4) NOT NULL,
[Total] decimal(12,4) NOT NULL,
 )
GO
Create table dbo.Products(
       Id int IDENTITY(1,1) primary key,
	   Name nvarchar(100),
	   Description nVarchar(350),
	   Expiration DateTime,
	   CostUnit float,
	   PriceUnit float,
	   ItbisPt float,
	   PackageCount float,
	   [Count] int,
	   Status bit default(0)
)
go
CREATE TABLE [dbo].[InvoiceDetails](
[Id] [int] IDENTITY(1,1) primary key,
ProductId [int] References Products(Id),
[Qty] [int] NOT NULL,
[Price] float NOT NULL,
[Itbis] float NOT NULL,
[SubTotal] decimal(12,4) NOT NULL
) 
GO
