USE PHARMASTORE
GO

IF DB_NAME() <> N'PHARMASTORE' SET NOEXEC ON
GO

--
-- Create table [dbo].[Product]
--
PRINT (N'Create table [dbo].[Product]')
GO
CREATE TABLE dbo.Product (
  pid int IDENTITY,
  pname varchar(30) NOT NULL,
  price decimal(10, 2) NOT NULL,
  quantity int NULL,
  img varbinary(max) NULL,
  category varchar(30) NULL,
  provider varchar(30) NULL,
  PRIMARY KEY CLUSTERED (pid)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO