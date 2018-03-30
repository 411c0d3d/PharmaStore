USE [PHARMASTORE]
GO

/****** Object:  Table [dbo].[BuyHistory]    Script Date: 3/27/2018 2:21:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BuyHistory](
	[bid] [int] IDENTITY(1,1) NOT NULL,
	[cid] [int] NULL,
	[pid] [int] NULL,
	[buyDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[BuyHistory]  WITH CHECK ADD FOREIGN KEY([cid])
REFERENCES [dbo].[Client] ([cid])
GO

ALTER TABLE [dbo].[BuyHistory]  WITH CHECK ADD FOREIGN KEY([pid])
REFERENCES [dbo].[Product] ([pid])
GO
