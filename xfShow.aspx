<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xfShow.aspx.cs" Inherits="xfShow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Button ID="bt_xfShow" runat="server" Text="后退" onclick="bt_xfShow_Click" 
             />
        <asp:GridView ID="grid_xfShow" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
