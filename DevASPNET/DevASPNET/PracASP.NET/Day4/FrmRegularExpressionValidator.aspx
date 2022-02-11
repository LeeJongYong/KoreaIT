<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRegularExpressionValidator.aspx.cs" Inherits="DevASPNET.Day4.FrmRegularExpressionValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>정규식 확인 유효성 검사 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>정규식 확인 유효성 검사 컨트롤</h3>
            이메일 : <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="valEmail" runat="server" ErrorMessage="이메일을 다시 확인해주세요." ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            
            <asp:LinkButton ID="btnOk" runat="server">확인</asp:LinkButton>
        </div>
    </form>
</body>
</html>
