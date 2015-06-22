<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xgWaiter.aspx.cs" Inherits="xgWaiter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:Gray">
    
        修改服务员信息：<br />
        名字：<asp:TextBox ID="xg_waiter" runat="server" Enabled="False"></asp:TextBox>
        身份证号：<asp:TextBox ID="xg_idcard" runat="server"></asp:TextBox>
        <br />
        编号：<asp:TextBox ID="xg_num" runat="server"></asp:TextBox>
        性别：<asp:TextBox ID="xg_sex" runat="server"></asp:TextBox>
        <br />
        年龄：<asp:TextBox ID="xg_age" runat="server"></asp:TextBox>
        电话：<asp:TextBox ID="xg_tel" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="bt_xgSave" runat="server" onclick="bt_xgSave_Click" Text="确认" />
        <asp:Button ID="bt_xgReset" runat="server" onclick="bt_xgReset_Click" 
            Text="清空" />
        <asp:Button ID="bt_xgBack" runat="server" onclick="bt_xgBack_Click" Text="返回" />
    
    </div>
    </form>
</body>
</html>
