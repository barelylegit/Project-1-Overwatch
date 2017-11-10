/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2016
    Target Database Engine Edition : Microsoft SQL Server Express Edition
    Target Database Engine Type : Standalone SQL Server
*/

USE [OverwatchGuides]
GO

/****** Object:  Table [dbo].[Heroes]    Script Date: 11/9/2017 7:56:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Heroes](
	[HeroName] [varchar](30) NOT NULL,
	[Category] [varchar](30) NOT NULL,
	[Image] [varchar](50) NULL,
	[Strengths] [varchar](50) NULL,
	[Weaknesses] [varchar](50) NULL,
	[Counters] [varchar](50) NULL,
	[Counteredby] [varchar](50) NULL,
	[Synergy] [varchar](50) NULL,
	[Discord] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[HeroName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

