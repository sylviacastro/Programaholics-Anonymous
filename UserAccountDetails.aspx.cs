using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserAccountDetails : System.Web.UI.Page
{
    clsBusinessLayer myBusinessLayer; 

    public Label UserName
    {
        get
        {
            return lblUserName;
        }
    }

    public TextBox FindUser
    {
        get
        {
            return txtFindUser;
        }
    }
    public TextBox City
    {
        get
        {
            return txtCity;
        }
    }
    public TextBox State
    {
        get
        {
            return txtState;
        }
    }
    public TextBox FavLanguage
    {
        get
        {
            return txtLanguage;
        }
    }
    public TextBox LeastFavProgLanguage
    {
        get
        {
            return txtLeastLanguage;
        }
    }
    public TextBox LastProgramCompletionDate
    {
        get
        {
            return txtDateLastProgram;
        }
    }

    public GridView Applications
    {
        get
        {
            return grdApplications;
        }
    }


    protected void Page_Load(object sender, EventArgs e)    
    {

        myBusinessLayer = new clsBusinessLayer(Server.MapPath("~/App_Data/"));
       
        if (PreviousPage!=null && PreviousPage.IsCrossPagePostBack)
        {
            lblUserName.Text = PreviousPage.UserName.Text;
            
        }
        BindApplicationsGrid();
    }


    private void BindApplicationsGrid() {

        grdApplications.DataSource = myBusinessLayer.getApplications().Application;
        grdApplications.DataBind();
    }

    private void FindUserDetails(){

        //Declare the dataset
        dsUsers dsUserName;

        //create the clsDatalayer object and pass the database path.
        string tempPath = Server.MapPath("~/App_Data/Users.mdb");
        clsDataLayer dataLayerObj = new clsDataLayer(tempPath);

        try
        {
            //Find  the customer based on the last name
            dsUserName = dataLayerObj.FindUser(txtFindUser.Text);

            //If dataset has rows 
            if (dsUserName.tblUsers.Rows.Count > 0)
            {
                //populate the fields from the resultset
                txtCity.Text = dsUserName.tblUsers[0].City;
                txtState.Text = dsUserName.tblUsers[0].State;
                txtLanguage.Text = dsUserName.tblUsers[0].FavLanguage;
                txtLeastLanguage.Text = dsUserName.tblUsers[0].LeastFavProgLanguage;
                txtDateLastProgram.Text = dsUserName.tblUsers[0].LastProgramCompletionDate.ToString();
                lblUserName.Text = dsUserName.tblUsers[0].UserName.ToString();
                Master.UserFeedBack.Text = "Record Found";
            }
            else
            {
                //Update the feedback label with the no results found
                Master.UserFeedBack.Text = "No records were found!";
            }
        }
        catch (Exception error)
        {
            //display the error in userfeedback label
            string message = "Something went wrong - ";
            Master.UserFeedBack.Text = message + error.Message;
        }

    }



    protected void btnFindUser_Click(object sender, EventArgs e)
    {
        FindUserDetails();
    }
   
    public void ClearInputs(ControlCollection ctrls)
    {
        foreach (Control ctrl in ctrls)
        {

            if (ctrl is TextBox)
            {
                ((TextBox)ctrl).Text = string.Empty;
            }
            else if (ctrl is DropDownList)
            {
                ((DropDownList)ctrl).ClearSelection();
            }
            else if (ctrl is RadioButton)
            {
                ((RadioButton)ctrl).Checked = false;
            }
            else if (ctrl is RadioButtonList)
            {
                ((RadioButtonList)ctrl).ClearSelection();
            }
            else
            {
                ClearInputs(ctrl.Controls);
            }
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
       //create the clsDatalayer object and pass the database path.
        string tempPath = Server.MapPath("~/App_Data/Users.mdb");
        clsDataLayer dataLayerObj = new clsDataLayer(tempPath);

        try
        {
            //Find  the customer based on the last name
           bool isDeleted = dataLayerObj.DeleteAccountInfo(lblUserName.Text);

            //If deletion is successful then print the message and clear the inputs.
           if (isDeleted)
            {
               Master.UserFeedBack.Text = "Record Deleted successfully.";
               ClearInputs(Page.Controls);
            }
            else
            {
                //Update the feedback label with the no results found
                Master.UserFeedBack.Text = "There was a proble trying to delete the record.!";
            }
        }
        catch (Exception error)
        {
            //display the error in userfeedback label
            string message = "Something went wrong - ";
            Master.UserFeedBack.Text = message + error.Message;
        }

    }
    protected void btnExport_Click(object sender, EventArgs e)
    {
        if (myBusinessLayer.WriteApplicationsToXML())
            Master.UserFeedBack.Text = "Successfully generated username.xml file";
        else
            Master.UserFeedBack.Text = "Something went wrong";
    }
}