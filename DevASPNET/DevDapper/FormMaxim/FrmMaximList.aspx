<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMaximList.aspx.cs" Inherits="DevDapper.FormMaxim.FrmMaximList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>출력</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="lstMaxim" runat="server">
                <Columns>
                    <asp:HyperLinkField Text="상세보기" DataNavigateUrlFormatString="FrmMaximView.aspx?Id={0}" DataNavigateUrlFields="Id" />
                </Columns>
            </asp:GridView>
            <hr />
            <asp:HyperLink ID="lnkWrite" runat="server" NavigateUrl="~/FormMaxim/FrmMaximView.aspx">입력</asp:HyperLink>
        </div>
    </form>
</body>
</html>
