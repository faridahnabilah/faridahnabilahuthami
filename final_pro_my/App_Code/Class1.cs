using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient; 

/// <summary>
/// Summary description for Class1
/// </summary>
public class MyDB : DataSet
{
    DataTable dt1;
    DataTable dt2;
    DataTable dt3;
    DataTable dt4;
    DataTable dt5;


    public MyDB()
    {
        dt1 = getTable("select * from bill_master");
        dt1.TableName = "bill_master";
        Tables.Add(dt1);

        dt2 = getTable("select * from bus_master");
        dt2.TableName = "bus_master";
        Tables.Add(dt2);

        dt3 = getTable("select * from fare_master");
        dt3.TableName = "fare_master";
        Tables.Add(dt3);

        dt4 = getTable("select * from passenger_master");
        dt4.TableName = "passenger_master";
        Tables.Add(dt4);

        dt5 = getTable("select * from route_master");
        dt5.TableName = "route_master";
        Tables.Add(dt5);

    }


    DataTable getTable(string q)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
        SqlDataAdapter adp = new SqlDataAdapter(q, cn);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
}
