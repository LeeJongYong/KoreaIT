<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCalendar.aspx.cs" Inherits="DevASPNET.Day3.FrmCalendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>캘린더 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="calendar1" runat="server" OnSelectionChanged="calendar1_SelectionChanged"></asp:Calendar>
            <hr />
            <asp:Calendar ID="calendar2" runat="server" BackColor="#ffffcc" BorderColor="#ffcc66" BorderWidth="1px" DayNameFormat="Shortest"
                Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="true" Width="220px">
                <DayHeaderStyle BackColor="#ffcc66" Font-Bold="true" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#ffffcc" />
                <OtherMonthDayStyle ForeColor="#cc9966" />
                <SelectedDayStyle BackColor="#ccccff" Font-Bold="true" />
                <SelectorStyle BackColor="#ffcc66" />
                <TitleStyle BackColor="#990000" Font-Bold="true" Font-Size="9pt" ForeColor="#ffffcc" />
                <TodayDayStyle BackColor="#ffcc66" ForeColor="White" />
            </asp:Calendar>
        </div>
    </form>
</body>
</html>
