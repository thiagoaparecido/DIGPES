-- =========================================
-- Create tables DIGPES
-- =========================================
USE [DIGPES]
GO

IF OBJECT_ID('Avaliacao', 'U') IS NOT NULL
  DROP TABLE Avaliacao
GO

CREATE TABLE [dbo].[Avaliacao]
(
	[AvaliacaID] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[OrdemServico] [int] NOT NULL, 
	[Produto] [varchar](20) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Data] [date] NOT NULL,
	[QuestaoA] [bit] NOT NULL,
	[QuestaoB] [varchar](30) NULL,
	[QuestaoC] [varchar](30) NULL,
	[QuestaoD] [varchar](30) NULL,
	[MotivoQuestaoD] [varchar](255) NULL,
	[QuestaoE] [bit] NOT NULL
) ON [PRIMARY]
GO

