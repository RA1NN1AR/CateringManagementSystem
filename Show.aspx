<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Show.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>留言簿</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        姓名：<asp:TextBox ID="tb_UserName" runat="server"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="SD" runat="server" Text="管理员入口" onclick="SD_Click" />
        <br />
        留言：<asp:TextBox ID="tb_Message" runat="server" Height="48px" 
            style="margin-top: 38px" TextMode="MultiLine" Width="329px"></asp:TextBox>
        <br />
        <asp:Button ID="btn_SendMessage" runat="server" Text="发表留言" 
            onclick="btn_SendMessage_Click" />
    
        <br />
        <asp:Repeater ID="rpt_Message" runat="server">
        <ItemTemplate>
        <table width="900px" style="border:solid 1px #6666666; font-size:10pt; background-color:#f0f0f0">
        <tr>
        <td align="left" width="400px">
        <%# Eval("Message") %>
        </td>
        <td align="left" width="300px">
        <%# Eval("PostTime") %> - <%# Eval("UserName") %>
        </td>
        
        </tr>
        
        <tr>
        <td colspan="2" align="right">
        <hr width="300px" />
       管理员回复:   <%# Eval("IsReplied").ToString() == "False"?"未回复":Eval("Reply")%>
        </td>
        </tr>
        
        </table>
        </ItemTemplate>
        
        </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
