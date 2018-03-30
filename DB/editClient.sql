USE PHARMASTORE
GO

IF DB_NAME() <> N'TECHNOSHOP' SET NOEXEC ON
GO

SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO

--
-- Create procedure [dbo].[editClient]
--
GO
PRINT (N'Create procedure [dbo].[editClient]')
GO

Create proc dbo.editClient @cid int,@name varchar(30),@email varchar(30),@balance DECIMAL
as BEGIN
    if(exists(select * from Client where cid = @cid))
    BEGIN
        update Client set balance = @balance,cname=@name,email=@email where cid = @cid 
    END
END
GO