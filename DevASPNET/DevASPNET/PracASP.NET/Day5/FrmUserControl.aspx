  <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmUserControl.aspx.cs" Inherits="DevASPNET.Day5.FrmUserControl" %>

<%@ Register Src="~/Day5/Navigator.ascx" TagPrefix="uc1" TagName="Navigator" %>
<%@ Register Src="~/Day5/Copyright.ascx" TagPrefix="uc1" TagName="Copyright" %>
<%@ Register Src="~/Day5/Category.ascx" TagPrefix="uc1" TagName="Category" %>
<%@ Register Src="~/Day5/Catalog.ascx" TagPrefix="uc1" TagName="Catalog" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>웹 사이트 뼈대 구축</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style>
        div{
            border: 1px solid red;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <uc1:Navigator runat="server" id="Navigator" />
                </div>
            </div>
            <div class="row" style="height:200px;">
                <div class="col-md-3">
                    <uc1:Category runat="server" id="Category" />
                </div>
                <div class="col-md-8">
                    <uc1:Catalog runat="server" id="Catalog" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <uc1:Copyright runat="server" id="Copyright" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
