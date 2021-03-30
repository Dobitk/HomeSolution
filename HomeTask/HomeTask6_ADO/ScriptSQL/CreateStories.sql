USE [CSharpAdvanced]
GO

/****** Object:  Table [dbo].[Stories]    Script Date: 14.02.2021 0:00:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Stories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameStory] [nchar](20) NULL,
	[Discription] [nvarchar](50) NULL,
	[DateStory] [datetime] NULL
) ON [PRIMARY]
GO


