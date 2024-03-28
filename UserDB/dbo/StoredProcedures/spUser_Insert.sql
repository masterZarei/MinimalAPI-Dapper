CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	Insert Into dbo.[User](FirstName,LastName)
	Values (@FirstName,@LastName)
end