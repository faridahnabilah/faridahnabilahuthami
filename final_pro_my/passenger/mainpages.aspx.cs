using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class passenger_mainpages : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString); 
    protected void Page_Load(object sender, EventArgs e)
    {
       
        Button2.Visible = false;
        if (MultiView1.ActiveViewIndex < 0)
            btnsearch.Visible = false;
           else
            btnsearch.Visible = true;

        if (IsPostBack == true) return;

        MultiView1.ActiveViewIndex = 0;
        Calendar1.Visible = false;


    }
    protected void ddlfrom_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
       
        btnseragain.Visible = true;

        
        MultiView1.ActiveViewIndex -= 1;
        if (MultiView1.ActiveViewIndex ==0)
            btnsearch.Visible = false;
        else
            btnsearch.Visible = true;
        
        

    }
   



    protected void btnseragain_Click(object sender, EventArgs e)
    {
       
       
        MultiView1.ActiveViewIndex += 1;
        if (MultiView1.ActiveViewIndex == MultiView1.Views.Count - 1)
            btnseragain.Visible = false;
        else
            btnseragain.Visible = true;
        if (MultiView1.ActiveViewIndex == 3)
        {
         
            Button2.Visible = true;
            
        }

       

}

    protected void Button2_Click(object sender, EventArgs e)
    {
        //cn.Open();
        //string sql = "select source,destination form route_master ('" + ddlfrom.Text.Trim() + "','" + ddlto.Text + "')";
        //SqlCommand cmd = new SqlCommand(sql, cn);
        //SqlDataReader dr = cmd.ExecuteReader();
        //cn.Close();


        //try
        //{
        //    string s = " ";
        //    string s2 = "";
        //    string s3 = "";
        //    string s4 = "";
        //    string s5 = "";
        //    string Stotal;
        //    for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        //    {
        //        if (CheckBoxList1.Items[i].Selected == true)
        //        {
        //            s = s + CheckBoxList1.Items[i].Text + ",";

        //        }

        //    }
        //    s = s.Remove(s.Length - 1);
        //    for (int i = 0; i < CheckBoxList2.Items.Count; i++)
        //    {
        //        if (CheckBoxList2.Items[i].Selected == true)
        //        {
        //            s2 = s2 + CheckBoxList2.Items[i].Text + ",";

        //        }

        //    }
        //    s2 = s2.Remove(s2.Length - 1);
        //    for (int i = 0; i < CheckBoxList3.Items.Count; i++)
        //    {
        //        if (CheckBoxList3.Items[i].Selected == true)
        //        {
        //            s3 = s3 + CheckBoxList3.Items[i].Text + ",";

        //        }

        //    }
        //    s3 = s3.Remove(s3.Length - 1);
        //    for (int i = 0; i < CheckBoxList4.Items.Count; i++)
        //    {
        //        if (CheckBoxList4.Items[i].Selected == true)
        //        {
        //            s4 = s4 + CheckBoxList4.Items[i].Text + ",";

        //        }

        //    }
        //    s4 = s4.Remove(s4.Length - 1);
        //    for (int i = 0; i < CheckBoxList5.Items.Count; i++)
        //    {
        //        if (CheckBoxList5.Items[i].Selected == true)
        //        {
        //            s5 = s5 + CheckBoxList5.Items[i].Text + ",";

        //        }
        //        s5 = s5.Remove(s5.Length - 1);
        //    }
        //    Stotal = s + "," + s2 + "," + s3 + "," + s4 + "," + s5;



        //    cn.Open();
        //    string sql = "insert into bill_master( [jdate], [jtime], [source],[destination],[bus_type],[seat_nos])values('" + txtdate1.Text + "','" + ddltime.SelectedValue + "','" + ddlfrom1.SelectedValue + "','" + ddlto1.SelectedValue + "','" + ddlbustype.SelectedValue + "','" + Stotal + "')";
        //    SqlCommand cmd = new SqlCommand(sql, cn);
        //    cmd.ExecuteNonQuery();
        //    cn.Close();
     
    try{        cn.Open();
            string sql1 = "insert into Passenger_master([cname],[age],[address],[phone_no],[email])values('" + txtname.Text + "'," + txtage.Text + ",'" + txtaddress.Text + "','" + txtphone.Text + "','" + txtmailid.Text + "')";
            SqlCommand cmd1 = new SqlCommand(sql1, cn);
            cmd1.ExecuteNonQuery();
            cn.Close();
            Response.Write("Successfully Done");

        }
        catch (Exception ex)
        {
            //lblError.Visible = true;

            Response.Write(ex.ToString());
        }


    }
    
    
    
    
    protected void ddltime_SelectedIndexChanged(object sender, EventArgs e)
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

        txtdate1.Text = Calendar1.SelectedDate.ToString("d");
        Calendar1.Visible = false; 

    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void CheckBoxList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void ddlbustype_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (ddlbustype.SelectedIndex == 0 || ddlbustype.SelectedIndex == 1)
        //{
        //    MultiView1.ActiveViewIndex = 1;
        //}
        //else 
        //{
        //    MultiView1.ActiveViewIndex = 2;
        //}
        if (ddlbustype.SelectedIndex == 0)
        {
            MultiView1.ActiveViewIndex = 1;
        }
        else if (ddlbustype.SelectedIndex == 1)
        {
            MultiView1.ActiveViewIndex = 1;
        }
        else if (ddlbustype.SelectedIndex == 2)
        {
            MultiView1.ActiveViewIndex = 2;
        }
        else if (ddlbustype.SelectedIndex == 3)
        {
            MultiView1.ActiveViewIndex = 2;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            string s = "";
            //string s2 = "";
          //  string s3 = "";
           // string s4 = "";
            //string s5 = "";
            string Stotal;
            int cnt = 0;
            for (int i = 0; i < CheckBoxList1.Items.Count-1; i++)
            {
                if (CheckBoxList1.Items[i].Selected == true)
                {
                    s = s + CheckBoxList1.Items[i].Text + ",";
                    cnt++;
                }

            }
           // s = s.Remove(s.Length - 1);
            for (int i = 0; i < CheckBoxList2.Items.Count-1; i++)
            {
                if (CheckBoxList2.Items[i].Selected == true)
                {
                    s = s + CheckBoxList2.Items[i].Text + ",";
                    cnt++;
                }

            }
            //s2 = s2.Remove(s2.Length - 1);
            for (int i = 0; i < CheckBoxList3.Items.Count-1; i++)
            {
                if (CheckBoxList3.Items[i].Selected == true)
                {
                    s = s + CheckBoxList3.Items[i].Text + ",";
                    cnt++;
                }

            }
            //s = s.Remove(s3.Length - 1);
            for (int i = 0; i < CheckBoxList4.Items.Count-1; i++)
            {
                if (CheckBoxList4.Items[i].Selected == true)
                {
                    s = s + CheckBoxList4.Items[i].Text + ",";
                    cnt++;
                }

            }
            //s4 = s4.Remove(s4.Length - 1);
            for (int i = 0; i < CheckBoxList5.Items.Count-1; i++)
            {
                if (CheckBoxList5.Items[i].Selected == true)
                {
                    s = s + CheckBoxList5.Items[i].Text + ",";
                    cnt++;
                }
                
            }
            s = s.Remove(s.Length - 1);
            Stotal = s; //+ "," + s2 + "," + s3 + "," + s4 + "," + s5;
            int ans = cnt * 100;
            lblmsg.Text = ans.ToString();
            //Stotal = "1,2";

            cn.Open();
            string sql = "insert into bill_master( [jdate], [jtime], [source],[destination],[bus_type],[seat_nos])values('" + txtdate1.Text + "','" + ddltime.SelectedValue + "','" + ddlfrom1.SelectedValue + "','" + ddlto1.SelectedValue + "','" + ddlbustype.SelectedValue + "','" + Stotal + "')";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
            cn.Close();


            cn.Open();
            string sql1 = "insert into Passenger_master([cname],[age],[address],[phone_no],[email])values('" + txtname.Text + "'," + txtage.Text + ",'" + txtaddress.Text + "','" + txtphone.Text + "','" + txtmailid.Text + "')";
            SqlCommand cmd1 = new SqlCommand(sql1, cn);
            cmd1.ExecuteNonQuery();
            cn.Close();
            Response.Write("Successfully Done");

        }
        catch (Exception ex)
        {
            //lblError.Visible = true;

            Response.Write(ex.ToString());
        }
    }
}