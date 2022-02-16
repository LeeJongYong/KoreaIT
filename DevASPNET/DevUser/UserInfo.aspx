﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="DevUser.UserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>회원관리 - 회원 정보 보기</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>회원관리</h1>
            <h2>회원 정보 보기</h2>

            UID : <asp:Label ID="lblUID" runat="server"></asp:Label><br />
            ID : <asp:TextBox ID="txtId" runat="server"></asp:TextBox><br />
            PW : <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="btnModify" runat="server" Text="정보수정" OnClick="btnModify_Click" />
        </div>
    </form>
</body>
</html>
