<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kaiTai.aspx.cs" Inherits="kaiTai" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        #Select1
        {
            width: 134px;
        }
        #kaiTai_select
        {
            width: 126px;
        }
        #select
        {
            width: 126px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:Gray">
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        开&nbsp; 台&nbsp;&nbsp;&nbsp;&nbsp; 单<br />
&nbsp;&nbsp; 桌台编号：<asp:Label ID="ztName" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
        账单日期：<asp:TextBox ID="boxKaitai_date" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp; 顾客名称：<asp:TextBox ID="txtName" runat="server" Height="19px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 用餐人数：<asp:TextBox ID="txtNum" 
            runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp; 服 务&nbsp;员：&nbsp;<asp:DropDownList ID="wtSelect" 
            runat="server" Height="18px" Width="146px" AutoPostBack="True">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 备 &nbsp;&nbsp; 
        注：<asp:TextBox ID="boxKaitai_bz" runat="server"></asp:TextBox>
&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="kaitai_Save" runat="server" onclick="Button1_Click" Text="保存" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="brKaitai_Reset" runat="server" Text="重置" 
            onclick="brKaitai_Reset_Click" />
&nbsp;&nbsp;
        <asp:Button ID="btKaitai_back" runat="server" Text="后退" 
            onclick="btKaitai_Exit_Click" />
    
    </div>
    </form>
</body>
</html>
