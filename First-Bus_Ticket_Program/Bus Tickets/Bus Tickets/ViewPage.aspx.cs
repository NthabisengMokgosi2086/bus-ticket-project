using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Bus_Tickets
{
    public partial class ViewPage : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Documents\Bus.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand cmd;
        public SqlDataAdapter adp;
        public DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {

            
            try
            {

                if (Session["Email"] != null)
                {
                    con.Open();
                    string search = @"Select * From BookingTable Where Email_Address Like  '%" +Session["Email"] +"%' ";
                    cmd = new SqlCommand(search, con);
                    adp = new SqlDataAdapter();
                    ds = new DataSet();

                    adp.SelectCommand = cmd;
                    adp.Fill(ds);

                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                    con.Close();
                }
            }
            catch (SqlException error)
            {
                Label1.Text = error.Message;
                Label1.Visible = true;
            }

            HyperLink1.Visible = true;
            
            Label1.Visible = true;



        }
        
    }
    
}