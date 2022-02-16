create proc dbo.ListMemo
as
	select Num, Name, Email, Title, PostDate, PostIP
	from Memos order by Num desc