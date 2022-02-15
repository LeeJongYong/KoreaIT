<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmObjectDataSource.aspx.cs" Inherits="DevDataControl.FrmObjectDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="ctlMemoList" DataSourceID="odsMemoList" runat="server"></asp:GridView>
            <asp:ObjectDataSource ID="odsMemoList" runat="server" SelectMethod="getMemos" TypeName="DevDataControl.DAO.FrmObjectDataSourceClass"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
