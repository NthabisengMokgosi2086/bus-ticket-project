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
    public partial class BusBookings : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Documents\Bus.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand cmd;
        public SqlDataAdapter adp;
        public SqlDataReader dr;
        public DataSet ds;


        protected void Page_Load(object sender, EventArgs e)
        {
            dropbox1();
            dropbox2();
        }

        public void loadAgain()
        {
            con.Open();
            string sql = @"Select * From BookingTable";
            cmd = new SqlCommand(sql, con);

        }

        public void dropbox1()
        {
            try
            {

                con.Open();
                string depature = @"Select Distinct(Departure) From BookingTable ";
                cmd = new SqlCommand(depature, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DropDownList1.Items.Add(dr.GetValue(0).ToString());
                }
                con.Close();
            }
            catch (SqlException error)
            {
                Label2.Text = error.Message;
            }
        }

        public void dropbox2()
        {
            try
            {

                con.Open();
                string destination = @"Select Distinct(Destination) From BookingTable  ";
                cmd = new SqlCommand(destination, con);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DropDownList2.Items.Add(dr.GetValue(0).ToString());
                }
                con.Close();
            }
            catch (SqlException error)
            {
                Label2.Text = error.Message;
            }
        }



        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            double price = 0.0;

            if (DropDownList1.SelectedItem.ToString() == "Western Cape" && DropDownList2.ToString() == "Kwa Zulu Natal")
            {
                price = 3000.00;
            }
            else if (DropDownList1.SelectedItem.ToString() == "Eastern Cape" && DropDownList2.ToString() == "Northen Cape")
            {
                price = 4500.00;
            }
            else if (DropDownList1.SelectedItem.ToString() == "Kwa Zulu Natal" && DropDownList2.ToString() == "Eastern Cape")
            {
                price = 5000.00;
            }
            else if (DropDownList1.SelectedItem.ToString() == "Northern Cape " && DropDownList2.ToString() == "Western Cape")
            {
                price = 4800.00;
            }
            else if (DropDownList1.SelectedItem.ToString() == "Eastern Cape" && DropDownList2.ToString() == "Kwa Zulu Natal")
            {
                price = 6000.00;
            }
            else if (DropDownList1.SelectedItem.ToString() == "Northen Cape" && DropDownList2.ToString() == "Western Cape")
            {
                price = 5500.00;
            }
            else
            {
                price = 7000.00;
            }

            HttpCookie infor = Request.Cookies["BusDetails"];
            if (infor != null)
            {
                con.Open();
                string insert = $"INSERT INTO BookingTable VALUES('{infor["Ticket No"]} ','{infor["Name"]}','{infor["Email_Address"]}','{DropDownList1.SelectedItem}','{DropDownList2.SelectedItem}',{price},{Calendar1.SelectedDate.ToShortDateString()})";
                cmd = new SqlCommand(insert, con);
                adp = new SqlDataAdapter();
                adp.InsertCommand = cmd;
                cmd.ExecuteNonQuery();

                con.Close();

                all();

            }
            Label2.Text = "Your booking was successful and your trip will be on " + Calendar1.SelectedDate.ToLongDateString() + " the amount due is R" + price;

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


           
           






        }
        public void all()
        {
            try
            {

                
                {
                    con.Open();
                    string all= @"Select Name , Email_Address From BookingTable";
                    cmd = new SqlCommand(all, con);
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
                Label2.Text = error.Message;
                Label2.Visible = true;
            }

        }
    }
}
    
