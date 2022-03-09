USE [RJCodeAdvance]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 22/2/2022 11:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Legajo] [varchar](10) NOT NULL,
	[Nombre] [nvarchar](80) NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
	[Nacimiento] [date] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 
GO
INSERT [dbo].[Empleados] ([id], [Legajo], [Nombre], [Email], [Nacimiento]) VALUES (1, N'6587542361', N'Juan Gabriel', N'juan@gmail.com', CAST(N'2007-03-11' AS Date))
GO
INSERT [dbo].[Empleados] ([id], [Legajo], [Nombre], [Email], [Nacimiento]) VALUES (2, N'6587542362', N'Gonzalo', N'gonzalo@gmail.com', CAST(N'1983-06-17' AS Date))
GO
INSERT [dbo].[Empleados] ([id], [Legajo], [Nombre], [Email], [Nacimiento]) VALUES (3, N'6587542363', N'Marta', N'marta@gmail.com', CAST(N'1986-11-19' AS Date))
GO
INSERT [dbo].[Empleados] ([id], [Legajo], [Nombre], [Email], [Nacimiento]) VALUES (4, N'6587542364', N'Lisandro', N'lisandro@gmail.com', CAST(N'2008-05-25' AS Date))
GO
INSERT [dbo].[Empleados] ([id], [Legajo], [Nombre], [Email], [Nacimiento]) VALUES (5, N'6587542365', N'Anna Maria', N'anna@gmail.com', CAST(N'1983-01-07' AS Date))
GO
INSERT [dbo].[Empleados] ([id], [Legajo], [Nombre], [Email], [Nacimiento]) VALUES (6, N'6587542366', N'Jack Reacher', N'jack@mail.net', CAST(N'1965-04-23' AS Date))
GO
INSERT [dbo].[Empleados] ([id], [Legajo], [Nombre], [Email], [Nacimiento]) VALUES (7, N'6587542367', N'Gerardo Tordoya', N'zherar7ordoya@outlook.com', CAST(N'1972-08-26' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
