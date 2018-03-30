USE PHARMASTORE
GO

IF DB_NAME() <> N'PHARMASTORE' SET NOEXEC ON
GO

SET QUOTED_IDENTIFIER, ANSI_NULLS ON

GO
PRINT (N'Create procedure [dbo].[buyProc]')
GO

CREATE proc dbo.buyProc @oid int
as begin
DECLARE @cid int,@pid INT,@blnc int

   if(exists(select oid from BuyOrder where oid=@oid))
   BEGIN
		set @cid = (SELECT c.cid from Client c  join BuyOrder o on c.cid = o.cid WHERE o.oid=@oid )
		set @pid = (SELECT o.pid from Product p  join BuyOrder o on p.pid = o.pid WHERE o.oid=@oid )
		set @blnc = (SELECT balance from Client c join BuyOrder o on c.cid = o.cid WHERE o.oid=@oid)
		if(@blnc>@pid)
		begin
			update c set balance -= price from Client c  join BuyOrder o on c.cid = o.cid join Product p on o.pid=p.pid where o.oid=@oid
			update p set quantity-=1 from Product p  join BuyOrder o on o.pid=p.pid
			where oid=@oid
			DELETE from BuyOrder where oid=@oid
			INSERT into BuyHistory(cid,pid,buyDate) VALUES (@cid,@pid,CURRENT_TIMESTAMP)
			
		end
    end
end

GO