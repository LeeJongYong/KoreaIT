create proc dbo.DeleteMemo
(
	@Num int
)
as
	delete Memos
	where Num = @Num