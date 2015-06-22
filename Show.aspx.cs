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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetBind();
        }
    }

    protected void btn_SendMessage_Click(object sender, EventArgs e)
    {
        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        string Sql = "insert into tbGuestBook(UserName,PostTime,Message,IsReplied,Reply) values ('"+tb_UserName.Text+"','"+DateTime.Now+"','"+tb_Message.Text+"',0,'')";
        SqlConnection conn = new SqlConnection(consqlserver);
        SqlCommand cmd = new SqlCommand(Sql,conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        SetBind();
    }

    private void SetBind() {

        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        string Sql = "select * from tbGuestBook order by PostTime DESC";
        SqlConnection conn = new SqlConnection(consqlserver);
        SqlDataAdapter da = new SqlDataAdapter(Sql,conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataTable dt = ds.Tables[0];
        rpt_Message.DataSource = dt;
        rpt_Message.DataBind();

    }
    protected void SD_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }
}
