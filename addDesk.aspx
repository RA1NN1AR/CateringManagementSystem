<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addDesk.aspx.cs" Inherits="addDesk" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:Gray">
    
        桌台名称：<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
&nbsp; 桌台简称：<asp:TextBox ID="txtjc" runat="server"></asp:TextBox>
        <br />
        包间费：<asp:TextBox ID="txtbjf" runat="server"></asp:TextBox>
&nbsp; 桌台位置：<asp:TextBox ID="txtwz" runat="server"></asp:TextBox>
        <br />
        桌台类型：<asp:TextBox ID="txtlx" runat="server"></asp:TextBox>
&nbsp;备注：<asp:TextBox ID="txtbz" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;
        <asp:Button ID="bt_add" runat="server" onclick="bt_add_Click" Text="添加" />
        <asp:Button ID="bt_reset" runat="server" onclick="bt_reset_Click" Text="重置" />
        <asp:Button ID="bt_back" runat="server" onclick="bt_back_Click" Text="后退" />
    
    </div>
    </form>
</body>
</html>
