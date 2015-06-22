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
public partial class kaiTai : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Application.Lock();
        ztName.Text = Application["name"].ToString();
        Application.UnLock();
        boxKaitai_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        if (!IsPostBack)
        {
            string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
            //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
            string Sql = "select * from tb_Waiter ";
            SqlConnection conn = new SqlConnection(consqlserver);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                wtSelect.Items.Add(sdr["WaiterName"].ToString().Trim());//显示所有职员信息
            }
            wtSelect.SelectedIndex = 0;									//设置选中第一项
            sdr.Close();
        }
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (txtNum.Text == "" || Convert.ToInt32(txtNum.Text) <= 0)//如果输入的数据为空或者小于等于0时
        {
            Response.Write("<script language=javascript>alert('请输入用餐人数！')</script>");
        }
        else
        {
            string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
            //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
            string Sql = "update tb_Room set GuestName='" + txtName.Text + "',zhangdanDate='" + boxKaitai_date.Text + "',Num='" + Convert.ToInt32(txtNum.Text) + "',WaiterName='" + wtSelect.SelectedItem.ToString() + "',RoomZT='使用' where RoomName='" + ztName.Text + "'";
            SqlConnection conn = new SqlConnection(consqlserver);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        kaitai_Save.Enabled = false;
    }
    protected void brKaitai_Reset_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtNum.Text = "";
        boxKaitai_bz.Text = "";
        kaitai_Save.Enabled = true;
    }
    protected void btKaitai_Exit_Click(object sender, EventArgs e)
    {
       
        Response.Redirect("DeskXx.aspx");
    }
}
