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

public partial class xfShow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GetData();
       

    }
   
    private void GetData()
    {
        string name;
        Application.Lock();
        name = Application["name"].ToString();
        Application.UnLock();
        string consqlserver = "data source=.;Initial catalog=db_MrCy;Integrated Security=True;uid=sa;pwd=7246";
        SqlConnection conn = new SqlConnection(consqlserver);
        SqlDataAdapter sda = new SqlDataAdapter("select foodname as '菜名',foodsum as '数量',foodallprice as '总价',waitername as '服务员',beizhu as '备注' from tb_GuestFood where zhuotai='" + name + "' order by ID desc", conn);
        DataSet ds = new DataSet();

        sda.Fill(ds);
        grid_xfShow.DataSource = ds.Tables[0];//对控件进行数据绑定
        grid_xfShow.DataBind();

    }


    protected void bt_xfShow_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeskXx.aspx");
    }
}
