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

public partial class admin_3_fareentry : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ddlbusid_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        cn.Open();
        string sql = "update fare_master set route_id=" + ddlrouteid.SelectedItem + ",bus_type='" + ddlbustype.SelectedItem + "',jdate='" + txtdate.Text + "',jtime='"+txttime.Text+"',fere='"+txtfare.Text+"' where fare_id=" + ddlfareid.SelectedValue + "";
        SqlCommand cmd = new SqlCommand(sql, cn);
        int j;
        j = cmd.ExecuteNonQuery();
        if (j > 0)
        {
            Response.Write("Record updated\n");
            Response.Write(sql);
        }
        else { Response.Write("Record not updated\n"); }
        cn.Close();
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar1.Visible == true)
        {
            Calendar1.Visible = false;
        }

        {
            Calendar1.Visible = true;
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtdate.Text = Calendar1.SelectedDate.ToString("d");
        Calendar1.Visible = false; 
    }
    protected void btnaddfare_Click(object sender, EventArgs e)
    {
        txtdate.Text = "";
        txtfare.Text = "";
        txttime.Text = "";
        txtfareid.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cn.Open();
        string sql = "insert into fare_master values(" + txtfareid.Text + "," + ddlrouteid.SelectedItem + ",'" + ddlbustype.SelectedItem + "','" + txtdate.Text + "','" + txttime.Text + "','" + txtfare.Text + "')";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.ExecuteNonQuery();
        cn.Close();
        txtfareid.Visible = false;
    }
    protected void ddlrouteid_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void btndelfare_Click(object sender, EventArgs e)
    {
        cn.Open();
        string sql = "delete from fare_master where fare_id=" + ddlfareid.SelectedValue + "";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.ExecuteNonQuery();
        cn.Close();
    }
    protected void ddlfareid_SelectedIndexChanged(object sender, EventArgs e)
    {
        cn.Open();
        string sql = "Select * from fare_master where fare_id=" + ddlfareid.SelectedValue + "";
        SqlCommand cmd = new SqlCommand(sql, cn);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            //ddlbustype.SelectedItem = dr["bus_type"].ToString();
            txtdate.Text = dr["jdate"].ToString();
            txttime.Text = dr["jtime"].ToString();
            txtfare.Text = dr["fare"].ToString();
        }
        cn.Close();

    }
}
