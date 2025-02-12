﻿/*
DotNetNote의 배포 스크립트

이 코드는 도구를 사용하여 생성되었습니다.
파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
변경 내용이 손실됩니다.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DotNetNote"
:setvar DefaultFilePrefix "DotNetNote"
:setvar DefaultDataPath "C:\Users\dev\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\dev\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
SQLCMD 모드가 지원되지 않으면 SQLCMD 모드를 검색하고 스크립트를 실행하지 않습니다.
SQLCMD 모드를 설정한 후에 이 스크립트를 다시 사용하려면 다음을 실행합니다.
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'이 스크립트를 실행하려면 SQLCMD 모드를 사용하도록 설정해야 합니다.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'테이블 [dbo].[Users]을(를) 만드는 중...';


GO
CREATE TABLE [dbo].[Users] (
    [UID]      INT           IDENTITY (1, 1) NOT NULL,
    [UserID]   NVARCHAR (25) NOT NULL,
    [Password] NVARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([UID] ASC)
);


GO
PRINT N'프로시저 [dbo].[DeleteUsers]을(를) 만드는 중...';


GO

create proc dbo.DeleteUsers
	@UID int
as
	delete Users where UID = @UID
GO
PRINT N'프로시저 [dbo].[ListUsers]을(를) 만드는 중...';


GO

create proc dbo.ListUsers
as
	select UID, UserID, Password from Users order by UID desc
GO
PRINT N'프로시저 [dbo].[ModifyUsers]을(를) 만드는 중...';


GO

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
GO
PRINT N'프로시저 [dbo].[SearchUsers]을(를) 만드는 중...';


GO

create proc dbo.SearchUsers
	@SearchField nvarchar(25),
	@SearchQuery nvarchar(25)
as
	declare @strSql nvarchar(255)
	set
		@strSql = 'select UID, UserID, Password from Users
					where ' + @SearchField + ' likes ''%' + @SearchQuery + '%'''
	exec(@strSql)
GO
PRINT N'프로시저 [dbo].[WriteUsers]을(를) 만드는 중...';


GO
create proc dbo.WriteUsers
	@UserID nvarchar(25),
	@Password nvarchar(20)
as
	insert into Users values(@UserID, @Password)
GO
PRINT N'업데이트가 완료되었습니다.';


GO
