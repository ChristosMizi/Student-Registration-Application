create  Procedure spIsUserDetailsValid
(
@Email as nvarchar(50),
@Password as nvarchar(50),
@Roles as nvarchar(50)
)
AS
	Begin
		Declare @IsUserValid BIT
		SET @IsUserValid = 0
		IF EXISTS (SELECT * from tblUsers Where Email = @Email
											AND  [Password] = @Password
											AND Roles= @Roles )

		BEGIN
		SET @IsUserValid =1
		END
		
		SeLECT @IsUserValid
	END