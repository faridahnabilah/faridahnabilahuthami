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

public partial class passenger_chack_fare : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Calendar1.Visible = false;
        GridView1.Visible = false;

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
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
        txtdatechk.Text = Calendar1.SelectedDate.ToString("d");
        Calendar1.Visible = false; 
    }
    protected void btnchkfare_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
    }
}
