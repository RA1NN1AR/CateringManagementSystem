<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calendar.aspx.cs" Inherits="Calendar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;
    
    <br />&nbsp;&nbsp;    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
            BorderColor="Black" Font-Names="Times New Roman" Font-Size="10pt" 
            ForeColor="Black" Height="220px" Width="400px" DayNameFormat="Shortest" 
            NextPrevFormat="FullMonth" TitleFormat="Month">
            <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" 
                Font-Size="8pt" ForeColor="#333333" Width="1%" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <DayStyle Width="14%" />
            <NextPrevStyle Font-Size="8pt" ForeColor="White" />
            <DayHeaderStyle Font-Bold="True" BackColor="#CCCCCC" Height="10pt" 
                Font-Size="7pt" ForeColor="#333333" />
            <TitleStyle BackColor="Black" 
                Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
        </asp:Calendar>
    
    </div>
    </form>
</body>
</html>
