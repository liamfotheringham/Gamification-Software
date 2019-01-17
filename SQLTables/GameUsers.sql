USE [sql1601596]
GO

/****** Object:  Table [dbo].[GAMEUSERS]    Script Date: 14/01/2019 10:43:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GAMEUSERS](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[isAdmin] [int] NOT NULL
) ON [PRIMARY]
GO

