create Procedure stDeleteMessage
(
@BodyMessage as nvarchar(max),
@Sender as nvarchar (50),
@MSDOS as nvarchar(50)
)
AS
	Begin
	update  tblEmailMessage set DataMessage = ''
where Id =(select tblEmailMessage.Id from [tblEmailMessage] where DataMessage =  @BodyMessage and Sender =  @Sender and MSDOS= @MSDOS)
		
		
	END