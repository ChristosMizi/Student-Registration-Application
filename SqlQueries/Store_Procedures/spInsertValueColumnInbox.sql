create Procedure spInsertValueColumnInbox
(
@counter as int,
@Sender as varchar(50)
)
AS
	Begin
		Insert into tblEmailMessage(CountInbox,Sender)
		Values(@counter,@Sender)
	END