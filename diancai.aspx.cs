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
public partial class diancai : System.Web.UI.Page
{
        

    protected void Page_Load(object sender, EventArgs e)
    {
        
        Application.Lock();
       string name = Application["name"].ToString();
        Application.UnLock();
       dcRoom.Text = name;
       if (!IsPostBack)
       {
           dcSelect();
       }
    }

    public void dcSelect() {

        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        SqlConnection conn = new SqlConnection(consqlserver);
        string Sql = "select * from tb_Waiter ";
     
        conn.Open();
        SqlCommand cmd = new SqlCommand(Sql, conn);
        SqlDataReader sdr = cmd.ExecuteReader();
        while (sdr.Read())
        {

            dcWaiter.Items.Add(sdr["WaiterName"].ToString().Trim());//显示所有职员信息

        }
      //  dcWaiter.SelectedIndex = 0;									//设置选中第一项
        sdr.Close();
    
    
    }

    protected void dc_save_Click(object sender, EventArgs e)
    {
        Application.Lock();
        string name = Application["name"].ToString();
        Application.UnLock();
        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        SqlConnection conn = new SqlConnection(consqlserver);
        string Sql = "insert into tb_GuestFood values('" + null + "','" + dcFoodname.Text + "','" + dcNum.Text + "','" + dcHowmuch.Text + "','" + dcWaiter.SelectedItem.ToString() + "','" + dcBeizhu.Text + "','"+name+"',null)";
        SqlCommand cmd = new SqlCommand(Sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        GetData();
        dc_save.Enabled = false;
    }

    private void GetData()
    {
        string name;
        Application.Lock();
        name = Application["name"].ToString();
        Application.UnLock();
        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        SqlConnection conn = new SqlConnection(consqlserver);
        SqlDataAdapter sda = new SqlDataAdapter("select foodname as '菜名',foodsum as '数量',foodallprice as '总价',waitername as '服务员',beizhu as '备注' from tb_GuestFood where zhuotai='" + name + "' order by ID desc", conn);
        DataSet ds = new DataSet();
        
        sda.Fill(ds);
        dgvFoods.DataSource = ds.Tables[0];//对控件进行数据绑定
        dgvFoods.DataBind();
        
    }

   
    protected void dcNum_TextChanged(object sender, EventArgs e)
    {
        if (dcNum.Text == "")
        {
            Response.Write("<script language=javascript>alert('数量不能为空。');</script>");
            return;
        }
        else
        {
            if (int.Parse(dcNum.Text.Trim()) < 1)
            {
                Response.Write("<script language=javascript>alert('不能为小于1的数字。');</script>");
                return;
            }
            else
            {
                int i = int.Parse(dcPrice.Text.Trim());
                int j = int.Parse(dcNum.Text.Trim());
                int sum=i*j;
                dcHowmuch.Text = sum.ToString();
            }
        }
        dc_save.Enabled = true;
        
    }
    protected void dcPrice_TextChanged(object sender, EventArgs e)
    {
        if (dcPrice.Text == "")
        {
            Response.Write("<script language=javascript>alert('单价不能为空。');</script>");
            return;
        }
        else
        {
            if (int.Parse(dcPrice.Text.Trim()) < 1)
            {
                Response.Write("<script language=javascript>alert('不能为小于1的数字。');</script>");
                return;
            }
            else
            {
                int i = int.Parse(dcPrice.Text.Trim());
                int j = int.Parse(dcNum.Text.Trim());
                int sum = i * j;
                dcHowmuch.Text = sum.ToString();
            }
        }
        dc_save.Enabled = true;
    }

   
    protected void dc_exit_Click(object sender, EventArgs e)
    {
        qingKong();
        dc_save.Enabled = true;
        Response.Redirect("DeskXx.aspx");
    }
    protected void dc_reset_Click(object sender, EventArgs e)
    {
        qingKong();
        dc_save.Enabled = true;

    }

    public void qingKong() {

        dcFoodname.Text = "";
        dcPrice.Text = "0";
        dcNum.Text = "1";
        dcHowmuch.Text = "";
  
    }
  
}
