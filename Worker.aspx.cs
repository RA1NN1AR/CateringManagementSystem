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
public partial class Worker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetBind();
        }
    }
    
    private void SetBind()
    {

        string consqlserver = "data source=.;Initial catalog=db_MrCy;Integrated Security=True;uid=sa;pwd=7246";
        SqlConnection conn = new SqlConnection(consqlserver);
        string Sql = "select * from tb_Waiter order by ID DESC";
        SqlDataAdapter da = new SqlDataAdapter(Sql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataTable dt = ds.Tables[0];
        Repeater1.DataSource = dt;
        Repeater1.DataBind();

    }



    protected void bt_addWaiter_Click1(object sender, EventArgs e)
    {
        Response.Redirect("addWaiter.aspx");
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delWaiter") {
            string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
            //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
            string Sql = "delete from tb_Waiter where WaiterName='" + e.CommandArgument + "'";
            SqlConnection conn = new SqlConnection(consqlserver);
            SqlCommand cmd = new SqlCommand(Sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            SetBind();
        }

        if (e.CommandName == "xgWaiter")
        {
            Application["name"] = e.CommandArgument;
            Response.Redirect("xgWaiter.aspx");
        }


    }
}
