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
using System.Xml;
using System.Data.SqlClient;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {

            if (Session["AdminCheck"] != null) {

                SetBind();
            
            }
        }

    }
    

    private void SetBind()
    {
        Msg.Text = "登陆成功!";
        string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
        //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
        SqlConnection conn = new SqlConnection(consqlserver);
        string Sql = "select * from tb_Room order by zhangdanDate DESC";
        SqlDataAdapter da = new SqlDataAdapter(Sql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataTable dt = ds.Tables[0];
        Repeater1.DataSource = dt;
        Repeater1.DataBind();

    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "KaiTai") {

            
             string sy="使用";
             string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
             //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
             SqlConnection conn = new SqlConnection(consqlserver);
              string Sql = "select * from tb_Room where RoomName='"+e.CommandArgument+"' and RoomZT='"+sy+"'";
              conn.Open();
           SqlCommand cmd=new SqlCommand(Sql,conn);
           
           SqlDataReader sdr = cmd.ExecuteReader();
         
            if (sdr.Read())
           {
              
              
                Response.Write("<Script Language=JavaScript>alert('桌台使用中！');</Script>");
               return;
                
                
           }
            else
            {
                Response.Write("<Script Language=JavaScript>alert('登陆失败！')</Script>");
                 Application["name"] = e.CommandArgument;
                Response.Redirect("kaiTai.aspx");
            }
           sdr.Close();
           conn.Close();
          
        }

        
        if (e.CommandName == "qxKaiTai") {

            Application["name"] = e.CommandArgument;
            string dy = "待用";
            string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
            //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
            SqlConnection conn = new SqlConnection(consqlserver);
            string Sql = "select * from tb_Room where RoomName='" + e.CommandArgument + "' and RoomZT='" + dy + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {

                
                Response.Write("<Script Language=JavaScript>alert('桌台没人，不能执行取消开台操作！');</Script>");
                return;


            }
            else
            {

                sdr.Close();
                conn.Close();
                string Sql2 = "update tb_Room set RoomZT='" + dy + "',GuestName='" + null + "',num='" + null + " ',WaiterName='" + null + "' where RoomName='" + e.CommandArgument + "'";
                SqlCommand cmd2 = new SqlCommand(Sql2, conn);
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();

                SetBind();
            }
            
           




            
           
            
        }


        if (e.CommandName == "Delete")
        {
            string sy = "使用";
            string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
            //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
            SqlConnection conn = new SqlConnection(consqlserver);
            string Sql = "select * from tb_Room where RoomName='" + e.CommandArgument + "' and RoomZT='" + sy + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {


                Response.Write("<Script Language=JavaScript>alert('桌台使用中，不能删除！');</Script>");
                return;


            }
            else
            {
                sdr.Close();
                conn.Close();
                string Sql2 = "delete from tb_Room where RoomName='" + e.CommandArgument + "'";
                SqlCommand cmd2 = new SqlCommand(Sql2, conn);
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();

                SetBind();
                
            }
            
           





            


        }

        if (e.CommandName == "diancai") {
            Application["name"]=e.CommandArgument;
            Application["name"] = e.CommandArgument;
            string sy = "待用";
            string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
            //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
            SqlConnection conn = new SqlConnection(consqlserver);
            string Sql = "select * from tb_Room where RoomName='" + e.CommandArgument + "' and RoomZT='" + sy + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {


                Response.Write("<Script Language=JavaScript>alert('桌台没人，不能点菜！');</Script>");
                return;


            }
            else
            {

                Application["name"] = e.CommandArgument;
                Response.Redirect("diancai.aspx");
            }
            sdr.Close();
            conn.Close();
           
        
               
        }

        if (e.CommandName == "xfShow")
        {
           
            Application["name"] = e.CommandArgument;
            Response.Redirect("xfShow.aspx");


        }

        if (e.CommandName == "JZ")
        {

            Application["name"] = e.CommandArgument;
            string sy = "待用";
            string consqlserver = ConfigurationManager.ConnectionStrings["db_MrCyConn"].ConnectionString;
            //string consqlserver = "data source=LIUHEAN;Initial catalog=db_MrCy;Integrated Security=SSPI;uid=sa;pwd=an822356";
            SqlConnection conn = new SqlConnection(consqlserver);
            string Sql = "select * from tb_Room where RoomName='" + e.CommandArgument + "' and RoomZT='" + sy + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {


                Response.Write("<Script Language=JavaScript>alert('桌台没人，不能结账！');</Script>");
                return;


            }
            else
            {
                
                Application["name"] = e.CommandArgument;
                Response.Redirect("JZ.aspx");
            }
            sdr.Close();
            conn.Close();
           


        }

    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {

        Response.Redirect("addDesk.aspx");
        
    }
}
