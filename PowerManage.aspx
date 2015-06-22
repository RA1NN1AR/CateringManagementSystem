<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PowerManage.aspx.cs" Inherits="PowerManage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:Gray">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        权限管理<br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        用&nbsp;&nbsp;&nbsp; 户：<asp:DropDownList ID="pmUser" runat="server" 
            Height="22px" Width="129px" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        权&nbsp;&nbsp;&nbsp; 限：<asp:DropDownList ID="pmQx" runat="server" Height="21px" 
            Width="127px" AutoPostBack="True">
            <asp:ListItem>超级管理员</asp:ListItem>
            <asp:ListItem>经理</asp:ListItem>
            <asp:ListItem>一般用户</asp:ListItem>
        </asp:DropDownList>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="bt_pmSave" runat="server" onclick="bt_pmSave_Click" Text="确认" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="bt_pmExit" runat="server" Text="退出" onclick="bt_pmExit_Click" />
    
    </div>
    </form>
</body>
</html>
