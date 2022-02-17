CREATE TABLE [dbo].[Tasks]
(
	[Id] INT identity(1,1) NOT NULL PRIMARY KEY,
	Title	nvarchar(140) not null,
	IsCompleted	bit,
	CreationDate	datetime	default(getdate())
)
