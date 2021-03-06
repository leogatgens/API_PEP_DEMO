USE [GATGENS]
GO
/****** Object:  Table [dbo].[Traveler]    Script Date: 02/07/2019 10:33:48 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traveler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[LastName] [varchar](250) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Genre] [char](1) NOT NULL,
	[ClientId] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
