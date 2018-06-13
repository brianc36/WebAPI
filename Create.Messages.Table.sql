USE [Hello]
GO

/****** Object:  Table [dbo].[Messages]    Script Date: 6/13/2018 6:34:30 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Messages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](50) NULL
) ON [PRIMARY]

GO


