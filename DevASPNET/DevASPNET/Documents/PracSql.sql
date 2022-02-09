Create Table dbo.Memos(
	Num			Int Identity(1,1) primary key,			--번호
	Name		NVarChar(25) not null,					--이름
	Email		NVarChar(100) null,						--이메일
	Title		NVarChar(150) not null,					--메모
	PostDate	datetime default(getdate()),			--작성일
	PostIP		NVarChar(15) null						--IP주소
)

-- insert문
insert Memos
values(
	N'레드플러스4', N'redplus@devlec.com', N'레드플러스입니다', getdate(), '127.0.0.1'
)

-- select문
select *
from Memos order by num desc

-- update문
update Memos
set
	Name=N'백두산',
	Email=N'admin@devlec.com',
	Title=N'백두산입니다.',
	PostIP='127.0.0.10'
where Num = 1

delete Memos
where Num = 4

select *
from Memos
where Email like '%ad%'

-- 프로시저

-- 메모 입력용 저장 프로시저
create procedure dbo.WriteMemo(
	@Name NVarChar(25),
	@Email NVarChar(100),
	@Title NVarChar(150),
	@PostIP NVarChar(15)
)
as
	insert Memos(Name, Email, Title, PostIP)
	values (@Name, @Email, @Title, @PostIP)

-- 메모 출력용 저장 프로시저
create proc dbo.ListMemo
as
	select Num, Name, Email, Title, PostDate, PostIP
	from Memos order by Num desc

-- 메모 상세보기용 저장 프로시저
create proc dbo.ViewMemo
(
	@Num int
)
as
	select Num, Name, Email, Title, PostDate, PostIP
	from Memos
	where Num=@Num

-- 메모 데이터 수정용 저장 프로시저
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

-- 메모 데이터 삭제용 저장 프로시저
create proc dbo.DeleteMemo
(
	@Num int
)
as
	delete Memos
	where Num = @Num

-- 메모 데이터 검색용 저장 프로시저(동적SQL 사용)
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

