create Procedure spInsertCommand
(
@Email as nvarchar(50),
@Password as nvarchar(50),
@Roles as nvarchar(50),
@Description as nvarchar(max)
)
AS
	Begin
		Insert into tblUsers(Email, [Password], Roles,[Description])
		Values(@Email,@Password,@Roles,@Description)
	END