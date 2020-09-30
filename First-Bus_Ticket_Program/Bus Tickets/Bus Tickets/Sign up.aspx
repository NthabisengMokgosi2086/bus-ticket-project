<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign up.aspx.cs" Inherits="Bus_Tickets.Sign_up" %>,

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>login</title>

    <link href="Style.css" rel ="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <img src ="Bus Interface/Background.png" class="panel"/>
        </section>
        <div class="sec2">
           <div class="container">
               <div class="social">
                   <asp:Image ID="Image1" runat="server" ImageUrl="~/Bus Interface/facebook-3000954_960_720.png" />
                   <asp:Image ID="Image2" runat="server" ImageUrl="~/Bus Interface/twitter.png" />
                </div>

                <div class="content">
                    <h2>Sign Up for Bus Ticket Purchase</h2>

                    <asp:TextBox ID="TextBox1" placeholder="Name and Surname" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ForeColor="White">Name and Surname Required</asp:RequiredFieldValidator> <br />
                    <asp:TextBox ID="TextBox2" placeholder="E-mail address" runat="server"></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="White">Invalid E-Mail</asp:RegularExpressionValidator> <br />
                    <asp:TextBox ID="TextBox3" placeholder="Password" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ForeColor="White">Enter password!</asp:RequiredFieldValidator><br />
                    <asp:TextBox ID="TextBox5" placeholder="Confirm password" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5" ForeColor="White">Confirm Password</asp:RequiredFieldValidator> <asp:CompareValidator runat="server" ID="CompareValidator1" ControlToCompare="TextBox3" ControlToValidate="TextBox5" ForeColor="Red">Password doesnt match enter again</asp:CompareValidator> <br />
                    <asp:Button ID="Submit" placeholder ="Username" runat="server" Text="Button" OnClick="Submit_Click" />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Log in.aspx" style="color: #FFFFFF; font-size: large; font-weight: 700; font-family: 'Bahnschrift SemiLight Condensed'" >Click here to go to login page</asp:HyperLink>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
