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
public partial class xgWaiter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Application.Lock();
            string name = Application["name"].ToString();
            Application.UnLock();
            xg_waiter.Text = name;
        }
    }
    protected void bt_xgSave_Click(object sender, EventArgs e)
    {
        Application.Lock();
        string name = Application["name"].ToString();
        Application.UnLock();
        string consqlserver = "data source=.;Initial catalog=db_MrCy;Integrated Security=True;uid=sa;pwd=7246";
        string sql = "update tb_Waiter set CardNum='" + xg_idcard.Text.Trim()+ "',WaiterNum='"+xg_num.Text.Trim()+"',Sex='"+xg_sex.Text.Trim()+"',Age='"+xg_age.Text.Trim()+"',Tel='"+xg_tel.Text.Trim()+"' where WaiterName='" + name + "' ";
        SqlConnection conn = new SqlConnection(consqlserver);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
       
        try {
            int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {

            Response.Write("<Script Language=JavaScript>alert('修改成功。')</Script>");
        }
        else
        {
            Response.Write("<Script Language=JavaScript>alert('修改失败。')</Script>");
        }
        }
        catch (Exception en) {  }

        
        conn.Close();
        bt_xgSave.Enabled = false;
    }
    protected void bt_xgReset_Click(object sender, EventArgs e)
    {
        bt_xgSave.Enabled = true;
        xg_idcard.Text = "";
        xg_idcard.Text = "";
        xg_num.Text = "";
        xg_sex.Text = "";
        xg_tel.Text = "";

    }
    protected void bt_xgBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Worker.aspx");
    }
}
