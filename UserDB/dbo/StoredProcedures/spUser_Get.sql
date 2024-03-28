CREATE PROCEDURE [dbo].[spUser_Get]
@Id int
As
begin
	select Id,FirstName,LastName
	from dbo.[User]
	where Id = @Id
end