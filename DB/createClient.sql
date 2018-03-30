USE PHARMASTORE
GO

IF DB_NAME() <> N'PHARMASTORE' SET NOEXEC ON
GO

--
-- Create table [dbo].[Client]
--
PRINT (N'Create table [dbo].[Client]')
GO
CREATE TABLE dbo.Client (
  cid int IDENTITY,
  cname varchar(30) NOT NULL,
  email varchar(30) NOT NULL,
  pwd varchar(30) NOT NULL,
  balance decimal(10, 2) NULL DEFAULT (0),
  PRIMARY KEY CLUSTERED (cid)
)
ON [PRIMARY]
GO