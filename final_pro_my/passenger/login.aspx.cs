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

public partial class passenger_login : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);  
    protected void Page_Load(object sender, EventArgs e)
    {
        txtUserName.Focus();
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            //  string pass = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "MD5");
            cn.Open();
            SqlCommand cmd = new SqlCommand("StoredProcedure1", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pusername", txtUserName.Text);
            cmd.Parameters.AddWithValue("@ppassword", txtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                Session["Uname"] = dr["log_id"].ToString();
                Response.Redirect("~/admin/1_route.aspx");
            }
            else
            {
               // lblMsg.Text = "Invalid Input,Please Try again !";
            }
        }
        catch (Exception ex)
        {
            //lblMsg.Text = "Invalid Username or Password,Please try Again !";
           // lblMsg.Text = ex.ToString();
        }
    }
}
