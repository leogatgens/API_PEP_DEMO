USE [GATGENS]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 02/07/2019 10:33:48 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[IdCountry] [int] IDENTITY(1,1) NOT NULL,
	[CountryCode] [char](3) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Code] [char](2) NOT NULL,
	[FlagUrl] [varchar](1500) NOT NULL,
	[Capital] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[IdCountry] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
