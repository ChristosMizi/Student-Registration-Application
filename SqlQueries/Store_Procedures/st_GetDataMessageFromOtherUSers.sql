create  Procedure st_GetDataMessageFromOtherUSers
(
@Sender varchar(50),
@Receiver varchar (50),
@MSDOS varchar(50)
)
as
Begin
select DataMessage from tblEmailMessage where Sender=@Sender and Receiver=@Receiver and MSDOS =@MSDOS

End