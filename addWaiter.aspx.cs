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
public partial class addWaiter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

  

    protected void addWaiter_save_Click(object sender, EventArgs e)
    {
        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        SqlConnection conn = new SqlConnection(consqlserver);
        string Sql = "insert into tb_Waiter values('" + aw_name.Text + "','" + aw_idcard.Text + "','" + aw_num.Text + "','" + aw_sex.Text + "','" + aw_age.Text + "','" + aw_tel.Text + "')";
        SqlCommand cmd = new SqlCommand(Sql, conn);
        conn.Open();
        int i=cmd.ExecuteNonQuery();
        if (i > 0)
        {

            Response.Write("<Script Language=JavaScript>alert('添加成功。')</Script>");
        }
        else
        {
            Response.Write("<Script Language=JavaScript>alert('添加失败。')</Script>");
        }

        conn.Close();
        addWaiter_save.Enabled = false;
        
    }
    protected void addWaiter_reset_Click(object sender, EventArgs e)
    {
        aw_name.Text = "";
        aw_idcard.Text = "";
        aw_num.Text = "";
        aw_sex.Text = "";
        aw_tel.Text = "";
        aw_age.Text = "";
        addWaiter_save.Enabled = true;
    }
    protected void addWaiter_exit_Click(object sender, EventArgs e)
    {
        addWaiter_save.Enabled = true;
        Response.Redirect("Worker.aspx");
    }

    
}
