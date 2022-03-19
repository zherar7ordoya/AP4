USE [WebCrawler]
GO
/****** Object:  Table [dbo].[tblMainUrls]    Script Date: 19/3/2022 10:18:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMainUrls](
	[UrlHash] [char](64) NOT NULL,
	[Url] [nvarchar](200) NOT NULL,
	[DiscoverDate] [datetime] NOT NULL,
	[LinkDepthLevel] [smallint] NOT NULL,
	[ParentUrlHash] [char](64) NOT NULL,
	[LastCrawlingDate] [datetime] NOT NULL,
	[SourceCode] [varchar](max) NULL,
	[FetchTimeMS] [int] NOT NULL,
	[PageTile] [nvarchar](max) NULL,
	[CompressionPercent] [tinyint] NOT NULL,
	[IsCrawled] [bit] NOT NULL,
	[HostUrl] [nvarchar](200) NOT NULL,
	[CrawlTryCounter] [tinyint] NOT NULL,
 CONSTRAINT [PK_tblMainUrls] PRIMARY KEY CLUSTERED 
(
	[UrlHash] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblMainUrls] ADD  CONSTRAINT [DF_tblMainUrls_LinkDepthLevel]  DEFAULT ((0)) FOR [LinkDepthLevel]
GO
ALTER TABLE [dbo].[tblMainUrls] ADD  CONSTRAINT [DF_tblMainUrls_FetchTimeMS]  DEFAULT ((0)) FOR [FetchTimeMS]
GO
ALTER TABLE [dbo].[tblMainUrls] ADD  CONSTRAINT [DF_tblMainUrls_CompressionPercent]  DEFAULT ((100)) FOR [CompressionPercent]
GO
ALTER TABLE [dbo].[tblMainUrls] ADD  CONSTRAINT [DF_tblMainUrls_Unprocessed]  DEFAULT ((0)) FOR [IsCrawled]
GO
