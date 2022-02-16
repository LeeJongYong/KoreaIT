CREATE TABLE [dbo].[Users]
(
	UID INT identity(1,1) NOT NULL PRIMARY KEY,
	UserID nvarchar(25) not null,
	Password nvarchar(20) not null
)
