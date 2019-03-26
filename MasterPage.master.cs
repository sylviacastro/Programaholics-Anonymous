﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public Label UserFeedBack
    {
        get { return lblUserFeedBack; }
        set { lblUserFeedBack = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            lblGUID.Text = System.Guid.NewGuid().ToString();
        }
    }
}
