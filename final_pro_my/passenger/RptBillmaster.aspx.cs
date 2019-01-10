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
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
public partial class passenger_RptBillmaster : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
        MyDB a = new MyDB();
        //MyDB a = new MyDB();
        //CrystalReportSource1.ReportDocument.SetDataSource(a);
        cn.Open ();

        string str = "select * from bill_master";
        SqlDataAdapter adp = new SqlDataAdapter(str,cn);
        adp.Fill(a);
        ReportDocument doc = new ReportDocument();
        doc.Load("C:/final_pro_my/passenger/BillMaster.rpt"); 
        doc.SetDataSource(a);
        CrystalReportViewer1.ReportSource = doc;

        cn .Close();


       
    }
}
