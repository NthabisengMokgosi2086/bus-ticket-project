using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bus_Tickets
{
    public partial class Sign_up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequiredFieldValidator1.Validate();
            CompareValidator1.Validate();
            RegularExpressionValidator1.Validate();
            RequiredFieldValidator2.Validate();
            RequiredFieldValidator3.Validate();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            HttpCookie infor = new HttpCookie("BusInfor");
            infor["Name"] = TextBox1.Text;
            infor["Email"] = TextBox2.Text;
            infor["Pass"] = TextBox3.Text;
            infor["ConPass"] = TextBox5.Text;

            infor.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(infor);
            Response.Redirect("BusBookings.aspx");
        }
    }
}