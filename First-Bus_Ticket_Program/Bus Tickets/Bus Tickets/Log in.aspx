<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log in.aspx.cs" Inherits="Bus_Tickets.Log_in" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>login</title>

    <link href="Style.css" rel ="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            font-family: "Bahnschrift Light Condensed";
            font-weight: bold;
            font-size: medium;
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <img src ="BusBook/beach-depth-of-field-enjoyment-1024619.jpg" class="panel"/>
        </section>
        <div class="sec2">
           <div class="container">
               <div class="social">
                   <asp:Image ID="Image1" runat="server" ImageUrl="~/Bus Interface/facebook-3000954_960_720.png" />
                   <asp:Image ID="Image2" runat="server" ImageUrl="~/Bus Interface/twitter.png" />
                </div>

                <div class="content">
                    <h2>Log in to Beach Bus Ticket to view your booking</h2>

                    <asp:TextBox ID="TextBox1" placeholder="E-mail address" runat="server"></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid E-Mail" ControlToValidate="TextBox1" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="auto-style1"></asp:RegularExpressionValidator> <br />
                    
                    <asp:TextBox ID="TextBox2" placeholder="Password" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter password!" ControlToValidate="TextBox2" CssClass="auto-style1"></asp:RequiredFieldValidator><br />
                    <asp:Button ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click" /><br /> <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="White" style="color: #000000"></asp:Label><br />
                    <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="White"></asp:Label><br /> <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ViewPage.aspx" >Click here  to view your booking</asp:HyperLink>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
