create proc dbo.WriteUsers
	@UserID nvarchar(25),
	@Password nvarchar(20)
as
	insert into Users values(@UserID, @Password)
go

create proc dbo.ListUsers
as
	select UID, UserID, Password from Users order by UID desc
go

create proc dbo.ModifyUsers
	@UserId nvarchar(25),
	@Password nvarchar(20),
	@UID int
as
	update Users
	set
		UserID = @UserId,
		Password = @Password
	where
		UID = @UID
go

create proc dbo.DeleteUsers
	@UID int
as
	delete Users where UID = @UID
go

create proc dbo.SearchUsers
	@SearchField nvarchar(25),
	@SearchQuery nvarchar(25)
as
	declare @strSql nvarchar(255)
	set
		@strSql = 'select UID, UserID, Password from Users
					where ' + @SearchField + ' likes ''%' + @SearchQuery + '%'''
	exec(@strSql)
go