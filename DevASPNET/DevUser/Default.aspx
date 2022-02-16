<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DevUser.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>회원관리 - 메인페이지</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>회원관리</h1>
            <h2>메인 페이지</h2>
            <asp:LoginView ID="loginView1" runat="server">
                <AnonymousTemplate>
                    <asp:LoginStatus ID="loginStatus1" runat="server" LoginText="로그인" /> |
                    <asp:HyperLink ID="hyperLink1" runat="server" NavigateUrl="~/Register.aspx">회원가입</asp:HyperLink>
                </AnonymousTemplate>
                <LoggedInTemplate>
                    <asp:LoginStatus ID="loginStatus2" runat="server" LogoutText="로그아웃" Visible="false" />
                    <a href="Logout.aspx">로그아웃</a> |
                    <asp:HyperLink ID="hyperLink2" runat="server" NavigateUrl="~/UserInfo.aspx">
                        <asp:LoginName ID="loginName1" runat="server" />
                    </asp:HyperLink>
                </LoggedInTemplate>
            </asp:LoginView>
        </div>
    </form>
</body>
</html>
