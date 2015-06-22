using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
public partial class JZ : System.Web.UI.Page
{
    public string price;
    public string bjf;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        Application.Lock();
        string name=Application["name"].ToString();
        Application.UnLock();
        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        SqlConnection conn = new SqlConnection(consqlserver);
        conn.Open();
        SqlCommand cmd = new SqlCommand("select sum(foodallprice) from tb_GuestFood where zhuotai='" + name + "'", conn);
        price = (cmd.ExecuteScalar()).ToString();//得到顾客消费的总金额
        Label2.Text = price + "=";
        try
        {
            jz_allPrice.Text = (double.Parse(price)).ToString();
        }
        catch (Exception en) { 
        
        }
        conn.Close();//关闭连接
        
    }


    protected void bt_jz_Click(object sender, EventArgs e)
    {
        Application.Lock();
        string name=Application["name"].ToString();
        Application.UnLock();
       
            if (jz_money.Text.Substring(0, 1) == "-")//判断支付的金额是否大于消费金额
            {
                Response.Write("<script language=javascript>alert('金额不足！');</script>");

                return;
            }
            else
            {
                string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
                //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
                SqlConnection conn = new SqlConnection(consqlserver);
                conn.Open();//打开数据库
                SqlCommand cmd = new SqlCommand("delete from tb_GuestFood where zhuotai='" + name + "'", conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update tb_Room set RoomZT='待用',Num=0,WaiterName='' where RoomName='" + name + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();//断开连接
                
            }
            bt_jz.Enabled = false;
            jz_reset.Enabled = false;
    }
    protected void jz_mony_TextChanged(object sender, EventArgs e)
    {

     
            if (jz_mony.Text == "0")//判断输入了顾客支付的金额
            {
                jz_mony.Text = "0";//如果没有输入则自动变成0
                jz_money.Text = "0";
            }
            else
            {
                //计算出应该支付给顾客的余额
                jz_money.Text = (double.Parse(jz_mony.Text.Trim())-double.Parse(price)).ToString()+"元";
            }
        
    }
    protected void bt_back_Click(object sender, EventArgs e)
    {
        bt_jz.Enabled = true;
        Response.Redirect("DeskXx.aspx");

    }
    protected void jz_reset_Click(object sender, EventArgs e)
    {
        bt_jz.Enabled = true;
        jz_mony.Text = "";
        jz_money.Text = "";
    }
}
