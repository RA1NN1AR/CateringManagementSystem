<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sysZT.aspx.cs" Inherits="sysZT" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 398px; background-color:Aqua" >
    
        当前用户：<asp:TextBox ID="sysUser" runat="server" Width="60px" 
            Enabled="False"></asp:TextBox>
&nbsp;权限：<asp:TextBox ID="sysQx" runat="server" Width="91px" Enabled="False"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
