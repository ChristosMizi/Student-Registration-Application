
create Procedure spStudentSaveCommandCheckIFEmailExists
(
@Email as nvarchar(50)
)
AS
	Begin
		Declare @EmailExists  BIT
		SET @EmailExists = 0 -- False
		IF EXISTS (SELECT * from tblStudentInfo Where Email = @Email)
											 

		BEGIN
		SET @EmailExists =1 -- True
		
		END
		
		SeLECT @EmailExists
		
	END