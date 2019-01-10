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

public partial class admin_1_route : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString); 
    protected void Page_Load(object sender, EventArgs e)
    {

    }




    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //cn.Open();
        //string sql = "insert into route_master values(" + ddlrouteid.Text + ",'" + ddlfrom.Text + "','" + ddlto.Text + "')";
        //SqlCommand cmd = new SqlCommand(sql, cn);
        //cmd.ExecuteNonQuery();
        //cn.Close();
        txtrouteid.Visible = true;
       txtfrom.Text = "";
        txtto.Text = "";
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        cn.Open();
        string sql = "update route_master set source='" + txtfrom.Text + "',destination='" + txtto.Text + "' where route_id=" + ddlrouteid.SelectedValue + "";
        SqlCommand cmd = new SqlCommand(sql, cn);
        int j;
        j = cmd.ExecuteNonQuery();
        if (j > 0)
        {
            Response.Write("Record updated\n");
            Response.Write(sql);
        }
        else {
            //Response.Write("Record not updated\n"); 
        }
        cn.Close();
    }
    protected void btndelroute_Click(object sender, EventArgs e)
    {
      //  cn.Open();
      //  string sql = "delete from route_master where route_id=" + ddlrouteid.Text + "";
      //  SqlCommand cmd = new SqlCommand(sql, cn);
      //cmd.ExecuteNonQuery();
      //  cn.Close();

        cn.Open();
        string sql = "delete from route_master where route_id=" + ddlrouteid.SelectedValue + "";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.ExecuteNonQuery();
        cn.Close();
    }
   
    protected void btnsave_Click(object sender, EventArgs e)
    {
        cn.Open();
        string sql = "insert into route_master values(" + txtrouteid.Text + ",'" + txtfrom.Text + "','" + txtto.Text + "')";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.ExecuteNonQuery();
        cn.Close();
        txtrouteid.Visible = false;

    }
    protected void ddlrouteid_SelectedIndexChanged(object sender, EventArgs e)
    {
        cn.Open();
        string sql = "Select * from route_master where route_id=" + ddlrouteid.SelectedValue + "";
        SqlCommand cmd = new SqlCommand(sql, cn);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            txtfrom.Text = dr["source"].ToString();
            txtto.Text = dr["destination"].ToString();
        }
        cn.Close();
    }
    protected void txtrouteid_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
