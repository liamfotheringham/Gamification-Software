USE [sql1601596]
GO

/****** Object:  Table [dbo].[GAMEQUESTIONS]    Script Date: 14/01/2019 10:42:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GAMEQUESTIONS](
	[QuestionID] [int] NOT NULL,
	[QuestionText] [varchar](1000) NOT NULL,
	[Choice1] [varchar](15) NOT NULL,
	[Choice2] [varchar](15) NOT NULL,
	[Choice1Virus] [int] NOT NULL,
	[Choice1Rep] [int] NOT NULL,
	[Choice2Virus] [int] NOT NULL,
	[Choice2Rep] [int] NOT NULL,
	[Message] [varchar](1000) NULL,
 CONSTRAINT [PK_GAMEQUESTIONS] PRIMARY KEY CLUSTERED 
(
	[QuestionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

