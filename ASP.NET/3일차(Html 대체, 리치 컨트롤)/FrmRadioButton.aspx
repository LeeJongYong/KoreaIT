<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRadioButton.aspx.cs" Inherits="DevASPNET.Day3.FrmRadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>라디오버튼 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="radioMan" runat="server" GroupName="Gender" />
            <asp:RadioButton ID="optWomen" runat="server" GroupName="Gender" />
            <asp:Button ID="btnOk" runat="server" Text="확인" OnClick="btnOk_Click" />
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
