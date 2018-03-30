USE PHARMASTORE
GO

IF DB_NAME() <> N'PHARMASTORE' SET NOEXEC ON
GO

--
-- Create table [dbo].[Admin]
--
PRINT (N'Create table [dbo].[Admin]')
GO
CREATE TABLE dbo.Admin (
  aid int IDENTITY,
  aname varchar(30) NOT NULL,
  email varchar(30) NOT NULL,
  pwd varchar(30) NULL,
  PRIMARY KEY CLUSTERED (aid)
)
ON [PRIMARY]
GO
INSERT PHARMASTORE.dbo.Admin(aid, aname, email, pwd) VALUES (1, N'admin1', N'root', N'toor')
GO