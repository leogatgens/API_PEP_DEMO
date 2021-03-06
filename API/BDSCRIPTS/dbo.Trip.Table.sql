USE [GATGENS]
GO
/****** Object:  Table [dbo].[Trip]    Script Date: 02/07/2019 10:33:48 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trip](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCountry] [int] NOT NULL,
	[DateVisited] [date] NOT NULL,
	[TravelerId] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Trip]  WITH CHECK ADD  CONSTRAINT [FK_Trip_Country] FOREIGN KEY([IdCountry])
REFERENCES [dbo].[Country] ([IdCountry])
GO
ALTER TABLE [dbo].[Trip] CHECK CONSTRAINT [FK_Trip_Country]
GO
