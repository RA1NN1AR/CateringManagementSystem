using System;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Configuration;


public partial class _Default : System.Web.UI.Page 
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login_Click(object sender, EventArgs e)
    {
       // string noo = "1";
        string consqlserver = "data source=.;Initial catalog=db_MrCy;Integrated Security=True;uid=sa;pwd=7246";
        SqlConnection conn = new SqlConnection(consqlserver);
        string sql = "select yesORno from lock";
        conn.Open();
        
        SqlDataAdapter sdr = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        sdr.Fill(ds);
        string i = ds.Tables[0].Rows[0][0].ToString().Trim();
        if (i == "1")
        {
            conn.Close();
            conn.Open();
            DataSet ds2 = new DataSet();
            //string password = FormsAuthentication.HashPasswordForStoringInConfigFile(Login_password.Text, "md5");
            string sql2 = "select * from tb_User where UserName='" + Login_name.Text + "'and UserPwd='" + Login_password.Text + "' ";
           
            SqlDataAdapter da = new SqlDataAdapter(sql2, conn);
            da.Fill(ds2);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["AdminCheck"] = Login_name.Text.Trim();
                Response.Write("<Script Language=JavaScript>alert('登录成功。')</Script>");
                Response.Redirect("zhuye.html");
            }
            else
            {

                Response.Write("<Script Language=JavaScript>alert('登录失败，请重新登录。')</Script>");
                return;
            }
            conn.Close();
        }
        else {
            
            conn.Close();
           
            string aa = "aa";
            string sql3 = "select UserPwd from tb_User where UserName='" + aa + "'";
           
            conn.Open();
             SqlDataAdapter sdrr = new SqlDataAdapter(sql3,conn);
          DataSet dsr = new DataSet();
          sdrr.Fill(dsr);
           string ir =dsr.Tables[0].Rows[0][0].ToString().Trim();
            if(ir == Login_password.Text.Trim()){
                Session["AdminCheck"] = Login_name.Text;
                Response.Write("<Script Language=JavaScript>alert('登录成功。');window.location.href='zhuye.html'</Script>");
               
            }
            else
            {
                Response.Write("<script>alert('系统已锁定，暂时无法登录,必要时请联系管理员.');</script>");
            }
            conn.Close();
        }
    }
    protected void Close_Click(object sender, EventArgs e)
    {
        Login_name.Text = "";
        Login_password.Text = "";
    }
}
