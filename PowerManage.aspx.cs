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
public partial class PowerManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string consqlserver = "data source=.;Initial catalog=db_MrCy;Integrated Security=True;uid=sa;pwd=7246";
       
        string sql = "select power from tb_User where UserName='" + Session["AdminCheck"] + "' ";
        SqlConnection conn = new SqlConnection(consqlserver);
        conn.Open();
        SqlDataAdapter sdr = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        sdr.Fill(ds);
        string i = ds.Tables[0].Rows[0][0].ToString().Trim();
        if (i != "0")
        {
            Response.Write("<script>alert('由于权限不足,操作失败.必要时请联系管理员.');window.location.href='indexF.html'</script>");
        }
        else {
            if (!IsPostBack)
            {
                pmSelect();
            }
        }
        conn.Close();
        
        
    }
    protected void bt_pmSave_Click(object sender, EventArgs e)
    {
        string userpower = "";
        switch (pmQx.SelectedItem.ToString())
        {
            case "超级管理员": userpower = "0"; break;
            case "经理": userpower = "1"; break;
            case "一般用户": userpower = "2"; break;
        }
        string consqlserver = "data source=.;Initial catalog=db_MrCy;Integrated Security=True;uid=sa;pwd=7246";
        SqlConnection conn = new SqlConnection(consqlserver);
        conn.Open();
        SqlCommand cmd = new SqlCommand("update tb_User set power='" + userpower + "' where UserName='"+pmUser.SelectedItem.ToString()+"'",conn);
        try
        {
            cmd.ExecuteNonQuery();
        }catch(Exception en){}finally{
        Response.Write("<script>alert('权限修改成功。');</script>");
        }
        conn.Close();
        
    }

    public void pmSelect()   //数据绑定
    {

        string consqlserver = "data source=.;Initial catalog=db_MrCy;Integrated Security=True;uid=sa;pwd=7246";
        string Sql = "select * from tb_User ";
        SqlConnection conn = new SqlConnection(consqlserver);
        conn.Open();
        SqlCommand cmd = new SqlCommand(Sql, conn);
        SqlDataReader sdr = cmd.ExecuteReader();
        while (sdr.Read())
        {

            pmUser.Items.Add(sdr["UserName"].ToString().Trim());//显示所有职员信息

        }
        pmUser.SelectedIndex = 0;									//设置选中第一项
        sdr.Close();


    }
    protected void bt_pmExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("indexF.html");
    }
}
