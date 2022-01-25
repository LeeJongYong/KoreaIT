<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDropDownList.aspx.cs" Inherits="DevASPNET.Day2.FrmDropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>드롭다운리스트 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="listJob" runat="server" AutoPostBack="true" OnSelectedIndexChanged="listJob_SelectedIndexChanged">
                <asp:ListItem>회사원</asp:ListItem>
                <asp:ListItem>공무원</asp:ListItem>
                <asp:ListItem Selected="True">개발자</asp:ListItem>
            </asp:DropDownList>
            <hr /> 
            <asp:Label ID="listDisplay" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
