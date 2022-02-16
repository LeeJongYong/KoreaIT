create proc dbo.ViewMemo
(
	@Num int
)
as
	select Num, Name, Email, Title, PostDate, PostIP
	from Memos
	where Num=@Num