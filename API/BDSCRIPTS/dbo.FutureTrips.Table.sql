USE [GATGENS]
GO
/****** Object:  Table [dbo].[FutureTrips]    Script Date: 02/07/2019 10:33:48 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FutureTrips](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCountry] [int] NOT NULL,
	[ClientId] [varchar](250) NOT NULL,
	[TripDate] [date] NOT NULL
) ON [PRIMARY]
GO
