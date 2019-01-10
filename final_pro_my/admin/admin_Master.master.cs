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

public partial class admin_admin_Master : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] == null)
        {
            Response.Redirect("~/passenger/login.aspx");
        }
        else
        {
            lblUser.Text = Session["uname"].ToString();
        }
    }






    protected void Button4_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["Uname"] = null;
        Response.Redirect("~/login.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void btnpaydetailsa_Click(object sender, EventArgs e)
    {

    }
    protected void btnfare_Click(object sender, EventArgs e)
    {

    }
}
