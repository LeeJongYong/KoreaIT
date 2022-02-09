<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmBulletedList.aspx.cs" Inherits="DevASPNET.Day2.FrmBulletedLis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>리스트 형식 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="listFavorite" runat="server" BulletStyle="LowerRoman" DisplayMode="LinkButton" OnClick="listFavorite_Click">
                <asp:ListItem>1. Windows Server</asp:ListItem>
                <asp:ListItem>2. SQL Server</asp:ListItem>
                <asp:ListItem>3. Visual Studio</asp:ListItem>
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
