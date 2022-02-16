create proc dbo.SearchMeMo
(
	@SearchField	nvarchar(10),
	@searchQuery	nvarchar(50)
)
as
	declare @strSql nvarchar(150)	-- 변수선언
	set
		@strSql =
		'select Num, Name, Email, Title, PostDate, PostIP
		from Memos
		where ' + @SearchField + ' Like N''%' + @SearchQuery + '%''order by Num desc'
	--print strSql
	Exec (@strSql)	--완성된 sql 실행