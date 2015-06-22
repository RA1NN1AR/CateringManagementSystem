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
public partial class sysZT : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        sysUser.Text=Session["AdminCheck"].ToString();
        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        string sql = "select power from tb_User where UserName='"+Session["AdminCheck"]+"' ";
        SqlConnection conn = new SqlConnection(consqlserver);
        conn.Open();
        SqlDataAdapter sdr = new SqlDataAdapter(sql,conn);
        DataSet ds = new DataSet();
        sdr.Fill(ds);
        string i =ds.Tables[0].Rows[0][0].ToString().Trim();
        switch (i)
        {
            case "0": sysQx.Text = "超级管理员"; break;   //权限为0时，说明用户是超级管理员
            case "1": sysQx.Text = "经理"; break;         //权限为1时，说明用户是经理
            case "2": sysQx.Text = "一般用户"; break;     //权限为2时，说明用户是一般用户
        }
        conn.Close();
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
