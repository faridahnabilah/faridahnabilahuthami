using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;


public partial class passenger_cancle : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //protected void btncanclet_Click(object sender, EventArgs e)
    //{
    //    cn.Open();
    //    string sql = "delete from bill_master where bill_no=" + Texticketno.Text + "";
    //    SqlCommand cmd = new SqlCommand(sql, cn);
    //    cmd.ExecuteNonQuery();
    //    cn.Close();
    //    Response.Write("Successfully done..");  

    //}
    protected void btncanclet_Click1(object sender, EventArgs e)
    {

        cn.Open();
        string sql = "delete from bill_master where bill_no=" + Texticketno.Text + " and email='" + Txtemail.Text + "' ";

        SqlCommand cmd = new SqlCommand(sql, cn);
        //cmd.ExecuteNonQuery();
        int j;
        j = cmd.ExecuteNonQuery();
        if (j > 0)
        {
            Response.Write("Record Deleted\n");
            Response.Write(sql);
        }
        else { 
            Response.Write("Record not Deleted\n"); 
        }
        cn.Close();
        //Response.Write("Successfully done..");
    }
}
