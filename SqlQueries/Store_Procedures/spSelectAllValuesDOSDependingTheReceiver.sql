create Procedure spSelectAllValuesDOSDependingTheReceiver
(
@Receiver as nvarchar(50)
)
AS
	Begin
		--Declare @EmailExists  BIT
		--SET @EmailExists = 0 -- False
		select tblEmailMessage.DOS 
        from  tblEmailMessage
        where Receiver = @Receiver
		
	END