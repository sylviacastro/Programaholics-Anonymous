using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserAccountConfirmationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //if it is a cross page posting then set the labels from the previous page
            if (!IsPostBack &&  PreviousPage.IsCrossPagePostBack)
            {
                lblUserName.Text = PreviousPage.UserName.Text;
                lblCity.Text = PreviousPage.City.Text;
                lblLanguage.Text = PreviousPage.FavLanguage.Text;
                lblLeastLanguage.Text = PreviousPage.LeastFavProgLanguage.Text;
                lblProgDate.Text = PreviousPage.LastProgramCompletionDate.Text;
                lblState.Text = PreviousPage.State.Text;
            }
        }
        catch (Exception error)
        {
            //Displays the error in the status label
            Master.UserFeedBack.Text = "Sorry there was an error processing your request.";
        }

        lblConfirmation.Text = "Are you sure you want to update this user account?";
    }
    protected void btnUpdateInformation_Click(object sender, EventArgs e)
    {
        //initialize the error flag to false
        bool userUpdateError = false;

        string tempPath = Server.MapPath("~/App_Data/Users.mdb");
        clsDataLayer myDataLayer = new clsDataLayer(tempPath);

        try
        {
            myDataLayer.UpdateAccountInfo(lblCity.Text, lblState.Text, lblLanguage.Text,lblLeastLanguage.Text, DateTime.Parse(lblProgDate.Text), lblUserName.Text);

        }
        catch (Exception error)
        {
            //set the update error to true
            userUpdateError = true;
            string message = "Error updating user, please check form data";
            Master.UserFeedBack.Text = message + error.Message;
        }

        if (!userUpdateError)
        {
            
            Master.UserFeedBack.Text = "Customer Updated Successfully";

        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/UserAccountDetails.aspx");
    }
}