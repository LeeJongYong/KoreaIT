﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDetailsView.aspx.cs" Inherits="DevDataControl.FrmDetailsView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>디테일뷰 컨트롤 : 상세보기 패턴</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DetailsView ID="ctlMemoView" runat="server" Height="50px" Width="125px" DataSourceID="sdsMemoView" AutoGenerateRows="true" DataKeyNames="Num">
                <Fields>
                    <asp:BoundField DataField="Num" HeaderText="번호" />
                    <asp:TemplateField HeaderText="이름">
                        <ItemTemplate>
                            <a href="FrmDetailsView.aspx?Num<%# Eval("Num") %>">
                                <%# Eval("Title") %>
                            </a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Fields>
            </asp:DetailsView>
            <asp:SqlDataSource ID="sdsMemoView" runat="server" ConnectionString='<%$ ConnectionStrings:DevADONETConnectionString %>' SelectCommand="SELECT * FROM [Memos] WHERE ([Num] = @Num)">
                <SelectParameters>
                    <asp:QueryStringParameter QueryStringField="Num" Name="Num" Type="Int32"></asp:QueryStringParameter>
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
