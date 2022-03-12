USE [Development]
GO
/****** Object:  Table [dbo].[People]    Script Date: 12/3/2022 10:23:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[idSexo] [int] NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 12/3/2022 10:23:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[People] ON 
GO
INSERT [dbo].[People] ([id], [Nombre], [Edad], [idSexo]) VALUES (2, N'Spider-Man', 20, 1)
GO
INSERT [dbo].[People] ([id], [Nombre], [Edad], [idSexo]) VALUES (15, N'Wolverine', 25, 1)
GO
INSERT [dbo].[People] ([id], [Nombre], [Edad], [idSexo]) VALUES (17, N'Norse Thor', 30, 1)
GO
SET IDENTITY_INSERT [dbo].[People] OFF
GO
SET IDENTITY_INSERT [dbo].[Sexo] ON 
GO
INSERT [dbo].[Sexo] ([id], [Nombre]) VALUES (1, N'Masculino ')
GO
INSERT [dbo].[Sexo] ([id], [Nombre]) VALUES (2, N'Femenino  ')
GO
SET IDENTITY_INSERT [dbo].[Sexo] OFF
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Sexo] FOREIGN KEY([idSexo])
REFERENCES [dbo].[Sexo] ([id])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Sexo]
GO
