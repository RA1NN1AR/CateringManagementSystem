<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JZ.aspx.cs" Inherits="JZ" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp; 结账单<br />
        总消费：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="jz_allPrice" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="￥"></asp:Label>
        <br />
        收银：<asp:TextBox ID="jz_mony" runat="server" AutoPostBack="True" 
            ontextchanged="jz_mony_TextChanged">0</asp:TextBox>
        <br />
        找零：<asp:Label ID="jz_money" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="bt_jz" runat="server" Text="结账" onclick="bt_jz_Click"/>
        <asp:Button ID="jz_reset" runat="server" onclick="jz_reset_Click" Text="更正" />
        <asp:Button ID="bt_back" runat="server" Text="后退" onclick="bt_back_Click" />
    
    </div>
    </form>
</body>
</html>
