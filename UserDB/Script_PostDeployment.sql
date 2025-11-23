if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName,LastName)
	values	('Jason','Wayne'),
			('Will','Smith'),
			('Sarah','Sobhani'),
			('Shahin','Shahsafi'),
			('Cyrus','Miles'),
			('Rafael','Jackson'),
			('Karim','Alkhalid');
end