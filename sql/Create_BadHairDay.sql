USE [WebGoat]
GO

/****** Object:  Table [dbo].[HairStatus]    Script Date: 4/20/2022 12:13:56 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairStatus]') AND type in (N'U'))
DROP TABLE [dbo].[HairStatus]
GO

/****** Object:  Table [dbo].[HairStatus]    Script Date: 4/20/2022 12:13:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HairStatus](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_timestamp] [datetime] NOT NULL,
	[modified_timestamp] [datetime] NULL,
	[username] [varchar](50) NOT NULL,
	[hair_status_timestamp] [datetime] NOT NULL,
	[hair_status] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


