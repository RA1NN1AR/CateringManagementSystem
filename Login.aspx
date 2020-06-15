<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    
<link href="out.css" rel="stylesheet" type="text/css" />
<link href="inner.css" rel="stylesheet" type="text/css" />
<link href="inner_Login.css" rel="stylesheet" type="text/css" />
<link href="out_title.css" rel="stylesheet" type="text/css" />
</head>
<body>
  
    <form id="form1" runat="server">
    <div class="out">
     <div id="out_title">
    <p class="out_title">&nbsp;&nbsp;&nbsp;</p>
         <p class="out_title">&nbsp; 餐饮管理系统</p>
         <div class="inner">
         <div>    
             <br />
             </div>
             <div class="inner_Login" style="text-transform: capitalize; color:#000000">
                 <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
                        <p style="font-family: Gulim; font-variant: small-caps; font-style: italic; color: #000080; background-color: #339933;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;请登录. </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        用户名：<asp:TextBox ID="Login_name" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        密&nbsp;码：&nbsp;&nbsp;<asp:TextBox ID="Login_password" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Login" runat="server" onclick="Login_Click" Text="登录" />
        &nbsp;
        <asp:Button ID="Reset" runat="server" onclick="Close_Click" Text="重置" />
    </p>
   </div>
    </div>
  </div>
    </div>
    </form>
</body>
</html>
