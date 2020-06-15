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

        string consqlserver = "data source=.;Initial catalog=db_MrCy;Integrated Security=True;uid=sa;pwd=7246";
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
            Response.Write("<script>alert('已成功修改密码。');</script>");
        }
        conn.Close();
    }
    protected void bt_cpExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("indexF.html");
    }
}
