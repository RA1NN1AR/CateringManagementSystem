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
public partial class addDesk : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void bt_add_Click(object sender, EventArgs e)
    {
        string dy="待用";
        string consqlserver = "data source=.;Initial catalog=db_MrCy;Integrated Security=True;uid=sa;pwd=7246";
        SqlConnection conn = new SqlConnection(consqlserver);
        string Sql = "insert into tb_Room values('" +txtname.Text +"','" +txtjc.Text + "','" + txtbjf.Text+"','" + txtwz.Text + "','"+dy+"','" + txtlx.Text + "','" + txtbz.Text + "',null,null,null,null,null)";
        SqlCommand cmd = new SqlCommand(Sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        bt_add.Enabled = false;
        
    }
    protected void bt_reset_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtjc.Text = "";
        txtbjf.Text = "";
        txtwz.Text = "";
        txtlx.Text = "";
        txtbz.Text = "";
        
        bt_add.Enabled = true;
    }
    protected void bt_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeskXx.aspx");
    }
}
