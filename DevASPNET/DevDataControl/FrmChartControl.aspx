<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmChartControl.aspx.cs" Inherits="DevDataControl.FrmChartControl" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Chart ID="ctlChart1" runat="server">
                <series>
                    <asp:Series Name="Series1" ChartType="Doughnut" YValuesPerPoint="2">
                        <Points>
                            <asp:DataPoint AxisLabel="국어" YValues="30,0" />
                            <asp:DataPoint AxisLabel="영어" YValues="41,0" />
                            <asp:DataPoint AxisLabel="수학" YValues="10,0" />
                        </Points>
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
            <hr />
            <asp:Chart ID="ctlChart2" runat="server">
                <Series>
                    <asp:Series Name="Series1"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            <hr />
            <a href="http://weblogs.asp.net/scottgu/built-in-charting-controls-vs-2010-and-net-4-series">
                http://weblogs.asp.net/scottgu/built-in-charting-controls-vs-2010-and-net-4-series
            </a>
        </div>
    </form>
</body>
</html>
