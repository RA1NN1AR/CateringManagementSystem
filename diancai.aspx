<%@ Page Language="C#" AutoEventWireup="true" CodeFile="diancai.aspx.cs" Inherits="diancai" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

    void Select_Change(Object sender, EventArgs e)
    {

     dcFoodname.Text =LinksTreeView.SelectedNode.Text;

    }

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    
<link href="F_left.css" rel="stylesheet" type="text/css" />
<link href="F_out.css" rel="stylesheet" type="text/css" />
<link href="F_rightTop.css" rel="stylesheet" type="text/css" />
<link href="F_rightC.css" rel="stylesheet" type="text/css" />
<link href="F_rightB.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #Form2
        {
            width: 810px;
            height: 445px;
        }
    </style>
</head>
<body>
   
  
  
     <form id="Form2" runat="server">
       <div class="F_out" id="F_out">
        <div class="F_left" id="F_left"> 
         <br />   &nbsp; &nbsp;<h3>&nbsp; &nbsp;菜单</h3>

            <asp:TreeView ForeColor="Brown" id="LinksTreeView" OnSelectedNodeChanged="Select_Change" runat="server" >
            
              <Nodes>
                    
                    <asp:TreeNode Text="锅底"
                        SelectAction="None">
                   
                     <asp:TreeNode Text="清汤锅"/>
                     <asp:TreeNode Text="鸳鸯锅"/>
                    
                     </asp:TreeNode>
                    
                    <asp:TreeNode Text="配菜" SelectAction="None">
                    <asp:TreeNode Text="火腿"/>
                    <asp:TreeNode Text="鸡肉"/>
                    <asp:TreeNode Text="牛肉"/>
                    <asp:TreeNode Text="油条"/>
                      </asp:TreeNode>
                    
                    <asp:TreeNode Text="烟酒" SelectAction="None" >
                     <asp:TreeNode Text="中华"/>
                    <asp:TreeNode Text="五粮液"/>
                    <asp:TreeNode Text="黄鹤楼"/>
                    </asp:TreeNode>
                    <asp:TreeNode Text="主食" SelectAction="None" >
                     <asp:TreeNode Text="米饭"/>
                    <asp:TreeNode Text="稀饭"/>
                    </asp:TreeNode>
                
                </Nodes>
             </asp:TreeView>
           
           </div>
 
    <div class="F_rightTop" id="F_rightTop">
            <p>&nbsp;</p>
                   <p>&nbsp;</p>
            <p>桌台编号：<asp:TextBox ID="dcRoom" runat="server" Enabled="False"></asp:TextBox>
                菜品名称：&nbsp;<asp:TextBox ID="dcFoodname" runat="server" Enabled="False"></asp:TextBox>
                   </p>
              <p>单价：<asp:TextBox ID="dcPrice" runat="server" Width="66px" Height="18px" 
                      AutoPostBack="True" ontextchanged="dcPrice_TextChanged">0</asp:TextBox>
        &nbsp; X数量：<asp:TextBox ID="dcNum" runat="server" Width="75px" Height="21px" 
                      AutoPostBack="True" ontextchanged="dcNum_TextChanged">1</asp:TextBox>
        &nbsp;总价：<asp:TextBox ID="dcHowmuch" runat="server" Width="83px" Enabled="False"></asp:TextBox>
              </p>
            <p>服务员：<asp:DropDownList ID="dcWaiter" runat="server" Height="29px" Width="172px" 
                    AutoPostBack="True">
                </asp:DropDownList>
        &nbsp;备注：<asp:TextBox ID="dcBeizhu" runat="server" Height="23px"></asp:TextBox>
                      </p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
  </div>
       
       <div class="F_rightC" id="F_rightC">
       
                  <p>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="dc_save" runat="server" onclick="dc_save_Click" Text="保存" />
                     &nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="dc_reset" runat="server" Text="重置" onclick="dc_reset_Click" />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="dc_exit" runat="server" Text="退出" onclick="dc_exit_Click" />
                  </p>
       </div>
  
     <div class="F_rightB" id="F_rightB">
              <p style="margin-left: 45px">&nbsp;<asp:GridView ID="dgvFoods" runat="server">
                  </asp:GridView>
              </p>
              <p>&nbsp;</p>
              <p>&nbsp;</p>
              <p>
                  &nbsp;</p>
              <p>
                  &nbsp;</p>
       </div>
           
        </div>
        </form>
</body>
</html>
