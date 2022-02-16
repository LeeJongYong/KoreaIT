create procedure dbo.WriteMemo(
	@Name NVarChar(25),
	@Email NVarChar(100),
	@Title NVarChar(150),
	@PostIP NVarChar(15)
)
as
	insert Memos(Name, Email, Title, PostIP)
	values (@Name, @Email, @Title, @PostIP)