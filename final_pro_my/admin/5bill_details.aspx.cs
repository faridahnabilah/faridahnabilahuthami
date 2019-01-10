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

public partial class admin_5bill_details : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString); 
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnnext_Click(object sender, EventArgs e)
    {

    }
    protected void btnpvs_Click(object sender, EventArgs e)
    {

    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {

    }
    protected void btndelfare_Click(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        cn.Open();
        string sql = "Select * from bill_master where bill_no='" + DropDownList1.SelectedValue  + "'";
        SqlCommand cmd = new SqlCommand(sql, cn);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {

            //string gen = dr["Gender"].ToString();
            //if (gen == "Male")
            //{
            //    rdbMale.Checked = true;
            //    rdbFemale.Checked = false;
            //}
            //if (gen == "Female")
            //{
            //    rdbFemale.Checked = true;
            //    rdbMale.Checked = false;
            //}
            txtsource.Text = dr["source"].ToString();
            txtdate.Text = dr["jdate"].ToString();
            txttime.Text = dr["jtime"].ToString();
            txtdesti.Text = dr["destination"].ToString();
            txtbustype.Text = dr["bus_type"].ToString();
            Txtseatnos.Text = dr["seat_nos"].ToString();
            Txttotalbill.Text = dr["total_bill"].ToString();
            Response.Write("SuccessFully got the Info..");
        }
        cn.Close();
    }
}
