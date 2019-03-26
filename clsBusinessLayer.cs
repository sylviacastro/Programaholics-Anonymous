using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsBusinessLayer
/// </summary>
public class clsBusinessLayer
{ 
    //path to the xml file
    string dataPath;

    //data layer instance
    clsDataLayer myDataLayer;

    public clsBusinessLayer(string serverMappedPath)
    {
        dataPath = serverMappedPath;
        myDataLayer = new clsDataLayer(dataPath + "Users.mdb");

    }

    public dsUsers getApplications() {

        return myDataLayer.GetApplications();
    }

    public bool WriteApplicationsToXML() {

        try
        {
            dsUsers applications = myDataLayer.GetApplications();
            applications.WriteXml(dataPath + "username.xml");
            return true;
        }
        catch (Exception ex) {

            return false;
        }
    }
}