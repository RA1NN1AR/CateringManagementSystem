<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeskXx.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Button ID="bt_add" runat="server" onclick="Button1_Click" Text="添加桌台" 
        Height="26px" />
    <br />
    <asp:Label ID="Msg" runat="server" Text="Label"></asp:Label>
   <table width="800px" style="border:solid 1px #666666; font-size:10pt; background-color:#663333">
   <tr>
    <td align="center" width="400px">桌台名称</td>
    <td align="center" width="200px">桌台简称</td>
    <td align="center" width="400px">桌台类型</td>
    <td align="center" width="200px">包间费</td>
    <td align="center" width="400px">桌台位置</td>
    <td align="center" width="200px">桌台状态</td>
    <td align="center" width="400px">备注</td>
    </tr>
    </table>
    <asp:Repeater ID="Repeater1" runat="server" 
        onitemcommand="Repeater1_ItemCommand">
    <ItemTemplate>
    <table width="800px" style="border:solid 1px #666666; font-size:10pt; background-color:#663333">
   
   <tr>
   <td align="center" width="50px"> <%# Eval("RoomName") %></td>
   <td align="center" width="50px"> <%# Eval("RoomJC") %></td>
   <td align="center" width="50px"> <%# Eval("RoomType") %></td>
   <td align="center" width="50px"> <%# Eval("RoomBJF") %></td>
   <td align="center" width="50px"> <%# Eval("RoomWZ") %></td>
   <td align="center" width="50px"> <%# Eval("RoomZT") %></td>
   <td align="center" width="50px"> <%# Eval("RoomBZ") %></td>
   </tr>
    
    
    
    <tr>
    
    <td colspan="7" align="right">
    <hr width="580px" />
    <asp:Button ID="bt_Delete" runat="server" Text="删除" CommandName="Delete" CommandArgument='<%# Eval("RoomName") %>' />&nbsp;
    <asp:Button ID="btn_KaiTai" runat="server" Text="开台" CommandName="KaiTai" CommandArgument='<%# Eval("RoomName") %>' /> 
   <asp:Button ID="bt_qxKaitai" runat="server" Text="取消开台" CommandName="qxKaiTai" CommandArgument='<%# Eval("RoomName") %>' /> 
    <asp:Button ID="bt_diancai" runat="server" Text="点/加菜" CommandName="diancai" CommandArgument='<%# Eval("RoomName") %>' /> 
   
    <asp:Button ID="bt_xfShow" runat="server" Text="消费查询" CommandName="xfShow" CommandArgument='<%# Eval("RoomName") %>' />  
  
    <asp:Button ID="bt_jz" runat="server" Text="结账" CommandName="JZ" CommandArgument='<%# Eval("RoomName") %>' />  
    </tr>
    
    </table>
    
    
    </ItemTemplate>
    </asp:Repeater>
    </form>
</body>
</html>
