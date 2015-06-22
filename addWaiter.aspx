<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addWaiter.aspx.cs" Inherits="addWaiter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:Gray">
    
        添加服务员：<br />
        名字：<asp:TextBox ID="aw_name" runat="server"></asp:TextBox>
&nbsp;身份证号：<asp:TextBox ID="aw_idcard" runat="server"></asp:TextBox>
        <br />
        编号：<asp:TextBox ID="aw_num" runat="server"></asp:TextBox>
        性别：<asp:TextBox ID="aw_sex" runat="server"></asp:TextBox>
        <br />
        年龄：<asp:TextBox ID="aw_age" runat="server"></asp:TextBox>
        电话：<asp:TextBox ID="aw_tel" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="addWaiter_save" runat="server" onclick="addWaiter_save_Click" 
            Text="保存" />
        <asp:Button ID="addWaiter_reset" runat="server" onclick="addWaiter_reset_Click" 
            Text="清空" />
        <asp:Button ID="addWaiter_exit" runat="server" Text="退出" 
            onclick="addWaiter_exit_Click" />
    
    </div>
    </form>
</body>
</html>
