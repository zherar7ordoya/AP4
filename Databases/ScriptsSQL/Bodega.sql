USE [Development]
GO
/****** Object:  Table [dbo].[ProductoSet]    Script Date: 12/3/2022 10:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoSet](
	[ProductoID] [int] NOT NULL,
	[ProductoNombre] [nvarchar](100) NOT NULL,
	[ProductoPrecio] [decimal](5, 0) NOT NULL,
	[ProductoDescripcion] [nvarchar](150) NOT NULL,
	[ProductoProveedor] [int] NOT NULL,
 CONSTRAINT [PK_ProductoSet] PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProveedorSet]    Script Date: 12/3/2022 10:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProveedorSet](
	[ProveedorID] [int] NOT NULL,
	[ProveedorNombre] [nvarchar](50) NOT NULL,
	[ProveedorDireccion] [nvarchar](100) NOT NULL,
	[ProveedorTelefono] [nvarchar](20) NOT NULL,
	[ProveedorEmail] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_ProveedorSet] PRIMARY KEY CLUSTERED 
(
	[ProveedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ProveedorSet] ([ProveedorID], [ProveedorNombre], [ProveedorDireccion], [ProveedorTelefono], [ProveedorEmail]) VALUES (1, N'Victor Hugo', N'Ciudad de Guatemala', N'1010-1010', N'vhcardenas@test.com')
GO
INSERT [dbo].[ProveedorSet] ([ProveedorID], [ProveedorNombre], [ProveedorDireccion], [ProveedorTelefono], [ProveedorEmail]) VALUES (2, N'Claudia Hernandez', N'Sanarate Este', N'555-9090', N'chernandez@test.com')
GO
INSERT [dbo].[ProveedorSet] ([ProveedorID], [ProveedorNombre], [ProveedorDireccion], [ProveedorTelefono], [ProveedorEmail]) VALUES (3, N'SQL Server', N'Local', N'555-1234', N'server@mail.net')
GO
ALTER TABLE [dbo].[ProductoSet]  WITH CHECK ADD  CONSTRAINT [FK_ProveedorProducto] FOREIGN KEY([ProductoProveedor])
REFERENCES [dbo].[ProveedorSet] ([ProveedorID])
GO
ALTER TABLE [dbo].[ProductoSet] CHECK CONSTRAINT [FK_ProveedorProducto]
GO
