using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Bus_Tickets
{
    public partial class Log_in : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Documents\Bus.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand cmd;
        public SqlDataAdapter adp;
        public SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Email"] = TextBox1.Text;
            try
            {

                if (Session["Email"] != null)
                {
                    con.Open();
                    string search = $"Select Name From BookingTable Where Email_Address  Like  '%" + Session["Email"] + "%' ";
                    cmd = new SqlCommand(search, con);

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Label1.Text = " Welcome back " + dr.GetValue(0);
                            
                    }
                    
                    con.Close();
                }
            }
            catch (SqlException error)
            {
                Label2.Text = error.Message;
                Label2.Visible = true;
            }
            
            HyperLink1.Visible = true;
           
            Label1.Visible = true;
            

            
        }
    }
}