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
public partial class LockSys : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lockZT();
        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        SqlConnection conn = new SqlConnection(consqlserver);
        string sql = "select power from tb_User where UserName='" + Session["AdminCheck"] + "' ";
        conn.Open();
        SqlDataAdapter sdr = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        sdr.Fill(ds);
        string i = ds.Tables[0].Rows[0][0].ToString().Trim();
        if (i != "0")
        {
            Response.Write("<script>alert('抱歉，您未取得 系统设置 权限，请联系管理员！');window.location.href='indexF.html'</script>");
        }
       
        conn.Close();

        
        
    }

    public void lockZT() {

        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        SqlConnection conn = new SqlConnection(consqlserver);
        string sql2 = "select yesORno from lock  ";
        conn.Open();
        SqlDataAdapter sdr2 = new SqlDataAdapter(sql2, conn);
        DataSet ds2 = new DataSet();
        sdr2.Fill(ds2);
        string i2 = ds2.Tables[0].Rows[0][0].ToString().Trim();
        if (i2 == "0")
        {
            mm.Text = "  已锁定";
        }
        else
        {
            mm.Text = "  未锁定";
        }

        conn.Close();
    
    
    }

    protected void bt_lockYes_Click(object sender, EventArgs e)
    {
        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        SqlConnection conn = new SqlConnection(consqlserver);
        string sql = "select UserPwd from tb_User where UserName='" + Session["AdminCheck"] + "' ";
        conn.Open();
        SqlDataAdapter sdr = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        sdr.Fill(ds);
        string i = ds.Tables[0].Rows[0][0].ToString().Trim();
       
        if (txtLock.Text.Trim() == i)
        {
            conn.Close();
            string noo = "0";
          
            string sql2 = "update lock set yesORno ='"+noo+"'";
            conn.Open();
            SqlCommand cmd2 = new SqlCommand(sql2,conn);
            int i2=cmd2.ExecuteNonQuery();
            if (i2 > 0)
            {
                Response.Write("<script>alert('系统已锁定，其他用户将不能登陆。');window.location.href='LockSys.aspx'</script>");
       
            }
            else {
                Response.Write("<script>alert('锁定失败！');</script>");
            
            }
            conn.Close();

        }
        else {
            Response.Write("<script>alert('口令不正确，请重新输入！');</script>");
        }
    }
    protected void bt_unlock_Click(object sender, EventArgs e)
    {
        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        SqlConnection conn = new SqlConnection(consqlserver);
        string sql = "select UserPwd from tb_User where UserName='" + Session["AdminCheck"] + "' ";
        conn.Open();
        SqlDataAdapter sdr = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        sdr.Fill(ds);
        string i = ds.Tables[0].Rows[0][0].ToString().Trim();

        if (txtLock.Text.Trim() == i)
        {
            conn.Close();
            string yes = "1";
         
            string sql2 = "update lock set yesORno ='"+yes+"'";
            conn.Open();
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            int i2 = cmd2.ExecuteNonQuery();
            if (i2 > 0)
            {
                Response.Write("<script>alert('系统锁定解除，其他用户允许登陆。');window.location.href='LockSys.aspx'</script>");

            }
            else
            {
                Response.Write("<script>alert('解锁失败！');</script>");

            }
            conn.Close();

        }
        else
        {
            Response.Write("<script>alert('口令不正确，请重新输入！');</script>");
        }
    }
    protected void bt_lockExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("indexF.html");
    }
}
