create  Procedure sp_SendMessage(
@Sender as nvarchar(50),
@Receiver as nvarchar(50),
@DOS as nvarchar(50),
@DataMessage as nvarchar(max),
@AllInboxRows as int
)
AS
	Begin
		--Declare @EmailExists  BIT
		--SET @EmailExists = 0 -- False
		Insert into tblEmailMessage(Sender,Receiver, DataMessage,DOS,CountInbox,StatusID)
		Values(@Sender,@Receiver,@DataMessage,@DOS,@AllInboxRows,2)
	END