<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMemoView.aspx.cs" Inherits="DevASPNET.PracASP.NET.Day9.FrmMemoView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>상세보기 패턴</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>상세보기</h3>
            번호 : <asp:Label ID="lblNum" runat="server"></asp:Label><br />
            이름 : <asp:Label ID="lblName" runat="server"></asp:Label><br />
            이메일 : <asp:Label ID="lblEmail" runat="server"></asp:Label><br />
            메모 : <asp:Label ID="lblTitle" runat="server"></asp:Label><br />
            작성일 : <asp:Label ID="lblPostDate" runat="server"></asp:Label><br />
            IP 주소 : <asp:Label ID="lblPostIP" runat="server"></asp:Label><br />
            <hr />
            <asp:HyperLink ID="lnkModify" runat="server">수정</asp:HyperLink>
            <asp:HyperLink ID="lnkDelete" runat="server">삭제</asp:HyperLink>
            <asp:HyperLink ID="lnkList" runat="server" NavigateUrl="~/PracASP.NET/Day9/FrmMemoList.aspx">리스트</asp:HyperLink>
        </div>
    </form>
</body>
</html>
