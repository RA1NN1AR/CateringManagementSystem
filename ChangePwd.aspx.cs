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
public partial class ChangePwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void bt_cpSave_Click(object sender, EventArgs e)
    {

        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        SqlConnection conn = new SqlConnection(consqlserver);
        string Sql = "update tb_User set UserPwd='"+cpText.Text+"' where UserName='"+Session["AdminCheck"]+"'";
       // SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        SqlCommand cmd = new SqlCommand(Sql, conn);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception en) { }
        finally {
            Response.Write("<script>alert('修改密码成功。');</script>");
        }
        conn.Close();
    }
    protected void bt_cpExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("indexF.html");
    }
}
