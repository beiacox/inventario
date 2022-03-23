
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/23/2022 17:17:25
-- Generated from EDMX file: C:\Users\Emmanuel\source\repos\inventario\capa_datos\tod.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [today];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Almacen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Almacen];
GO
IF OBJECT_ID(N'[dbo].[articulos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[articulos];
GO
IF OBJECT_ID(N'[dbo].[TPinventario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TPinventario];
GO
IF OBJECT_ID(N'[dbo].[transacciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[transacciones];
GO
IF OBJECT_ID(N'[todayModelStoreContainer].[existenciasXalmacen]', 'U') IS NOT NULL
    DROP TABLE [todayModelStoreContainer].[existenciasXalmacen];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Almacen'
CREATE TABLE [dbo].[Almacen] (
    [ID] int  NOT NULL,
    [descripcion] varchar(255)  NOT NULL,
    [estado] varchar(25)  NULL
);
GO

-- Creating table 'articulos'
CREATE TABLE [dbo].[articulos] (
    [ID] int  NOT NULL,
    [descripcion] varchar(255)  NOT NULL,
    [existencia] varchar(255)  NULL,
    [IDTPinventario] int  NOT NULL,
    [costo] int  NOT NULL,
    [estado] varchar(25)  NULL
);
GO

-- Creating table 'TPinventario'
CREATE TABLE [dbo].[TPinventario] (
    [ID] int  NOT NULL,
    [descripcion] varchar(255)  NOT NULL,
    [cuenta_contable] varchar(255)  NULL,
    [estado] varchar(25)  NULL
);
GO

-- Creating table 'transacciones'
CREATE TABLE [dbo].[transacciones] (
    [ID] int  NOT NULL,
    [Tipo] varchar(15)  NOT NULL,
    [IDarticulo] int  NOT NULL,
    [fecha] datetime  NULL
);
GO

-- Creating table 'existenciasXalmacen'
CREATE TABLE [dbo].[existenciasXalmacen] (
    [IDalmacen] int  NOT NULL,
    [IDarticulo] int  NOT NULL,
    [cantidad] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Almacen'
ALTER TABLE [dbo].[Almacen]
ADD CONSTRAINT [PK_Almacen]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'articulos'
ALTER TABLE [dbo].[articulos]
ADD CONSTRAINT [PK_articulos]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TPinventario'
ALTER TABLE [dbo].[TPinventario]
ADD CONSTRAINT [PK_TPinventario]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'transacciones'
ALTER TABLE [dbo].[transacciones]
ADD CONSTRAINT [PK_transacciones]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [IDalmacen], [IDarticulo] in table 'existenciasXalmacen'
ALTER TABLE [dbo].[existenciasXalmacen]
ADD CONSTRAINT [PK_existenciasXalmacen]
    PRIMARY KEY CLUSTERED ([IDalmacen], [IDarticulo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------