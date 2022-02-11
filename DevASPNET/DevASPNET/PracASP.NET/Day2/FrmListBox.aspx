<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmListBox.aspx.cs" Inherits="DevASPNET.Day2.FrmListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>리스트박스 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListHobby" runat="server" SelectionMode="Multiple">
                <asp:ListItem>축구</asp:ListItem>
                <asp:ListItem>야구</asp:ListItem>
                <asp:ListItem>농구</asp:ListItem>
            </asp:ListBox>
            <hr />
            <asp:Button ID="btnPrint" OnClick="btnPrint_Click" Text="출력하기" runat="server"/>
            <hr />
            <asp:Label id="printLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
