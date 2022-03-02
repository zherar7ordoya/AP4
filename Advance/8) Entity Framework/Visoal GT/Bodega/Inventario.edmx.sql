
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/02/2022 19:43:13
-- Generated from EDMX file: C:\Documents\AP4\Advance\8) Entity Framework\Visoal GT\Bodega\Inventario.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Bodega];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ProveedorSet'
CREATE TABLE [dbo].[ProveedorSet] (
    [ProveedorID] int  NOT NULL,
    [ProveedorNombre] nvarchar(50)  NOT NULL,
    [ProveedorDireccion] nvarchar(100)  NOT NULL,
    [ProveedorTelefono] nvarchar(20)  NOT NULL,
    [ProveedorEmail] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'ProductoSet'
CREATE TABLE [dbo].[ProductoSet] (
    [ProductoID] int  NOT NULL,
    [ProductoNombre] nvarchar(100)  NOT NULL,
    [ProductoPrecio] decimal(5,0)  NOT NULL,
    [ProductoDescripcion] nvarchar(150)  NOT NULL,
    [ProductoProveedor] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ProveedorID] in table 'ProveedorSet'
ALTER TABLE [dbo].[ProveedorSet]
ADD CONSTRAINT [PK_ProveedorSet]
    PRIMARY KEY CLUSTERED ([ProveedorID] ASC);
GO

-- Creating primary key on [ProductoID] in table 'ProductoSet'
ALTER TABLE [dbo].[ProductoSet]
ADD CONSTRAINT [PK_ProductoSet]
    PRIMARY KEY CLUSTERED ([ProductoID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProductoProveedor] in table 'ProductoSet'
ALTER TABLE [dbo].[ProductoSet]
ADD CONSTRAINT [FK_ProveedorProducto]
    FOREIGN KEY ([ProductoProveedor])
    REFERENCES [dbo].[ProveedorSet]
        ([ProveedorID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProveedorProducto'
CREATE INDEX [IX_FK_ProveedorProducto]
ON [dbo].[ProductoSet]
    ([ProductoProveedor]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------