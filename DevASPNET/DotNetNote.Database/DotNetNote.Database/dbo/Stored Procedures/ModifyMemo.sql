create proc dbo.ModifyMemo
(
	@Name	nvarchar(25),
	@Email	nvarchar(100),
	@Title	nvarchar(150),
	@Num	int
)
as
	update Memos
	set
		Name = @Name,
		Email = @Email,
		Title = @Title
	where Num = @Num