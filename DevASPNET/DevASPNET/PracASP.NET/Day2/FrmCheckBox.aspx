<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCheckBox.aspx.cs" Inherits="DevASPNET.Day2.FrmCheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>체크박스 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="chkCSharp" runat="server" Text="C#" />
            <br />
            <asp:CheckBox ID="chkDotNet" runat="server" Text="ASP.NET" />
            <br />
            <asp:Button ID="btnCheck" runat="server" Text="확인" OnClick="btnCheck_Click" />
            <hr />
            <asp:Label ID="printBox" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
