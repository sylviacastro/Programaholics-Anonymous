using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogIn : System.Web.UI.Page
{
    public TextBox UserName
    {
        get
        {
            return txtUserName;
        }
    }

    public TextBox Password
    {
        get
        {
            return txtPassword;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        Response.Redirect("~/UserAccountDetails.aspx");
    }
   
}