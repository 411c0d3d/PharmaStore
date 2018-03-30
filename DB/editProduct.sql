USE PHARMASTORE
GO

IF DB_NAME() <> N'TECHNOSHOP' SET NOEXEC ON
GO

SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO

--
-- Create procedure [dbo].[editProduct]
--
GO
PRINT (N'Create procedure [dbo].[editProduct]')
GO
CREATE proc dbo.editProduct @pid int,@price FLOAT,@quantity int
as BEGIN
    if(exists(select * from Product where pid = @pid))
    BEGIN
        update Product set quantity = @quantity,price = @price  where pid = @pid 
    END
END
GO