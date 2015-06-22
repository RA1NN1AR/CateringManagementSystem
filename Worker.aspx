<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Worker.aspx.cs" Inherits="Worker" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        服务员信息<br />
        <br />
        <asp:Button ID="bt_addWaiter" runat="server" onclick="bt_addWaiter_Click1" 
            Text="添加" />
        <br />
        
        <asp:Repeater ID="Repeater1" runat="server" 
            onitemcommand="Repeater1_ItemCommand">
        <ItemTemplate>
    <table width="800px" style="border:solid 1px #666666; font-size:10pt; background-color:Gray">
   
   <tr>
   <td align="center" width="50px"> <%# Eval("WaiterName") %></td>
   <td align="center" width="50px"> <%# Eval("CardNum") %></td>
   <td align="center" width="50px"> <%# Eval("WaiterNum") %></td>
   <td align="center" width="50px"> <%# Eval("Sex") %></td>
   <td align="center" width="50px"> <%# Eval("Age") %></td>
   <td align="center" width="50px"> <%# Eval("Tel") %></td>
   <td align="center" width="50px"> <asp:Button ID="bt_xgWaiter" runat="server" Text="修改" CommandName="xgWaiter" CommandArgument='<%# Eval("WaiterName") %>' /></td>
   <td align="center" width="50px">  <asp:Button ID="bt_delWaiter" runat="server" Text="删除" CommandName="delWaiter" CommandArgument='<%# Eval("WaiterName") %>' /></td>
   </tr>
  </table>
    
    
    </ItemTemplate>
        </asp:Repeater>
    
        <br />
    
    </div>
    </form>
</body>
</html>
