using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsDataLayer
/// </summary>
public class clsDataLayer
{
    OleDbConnection dbConnection;
    public clsDataLayer(string Path)
    {
        dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path);
    }

    //this method find the customer based on last name parameter from the database
    public dsUsers FindUser(string username)
    {
        //Create a query and pass it to the adapter
        string sqlStmt = "Select * from tblUsers where username like '" + username + "'";
        OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter(sqlStmt, dbConnection);

        //Fill the dataset with the results from the query.
        dsUsers myStoreDataset = new dsUsers();
        sqlDataAdapter.Fill(myStoreDataset.tblUsers);

        //return the dataset
        return myStoreDataset;

    }

    //this method find the customer based on last name parameter from the database
    public dsUsers GetApplications()
    {
        //Create a query and pass it to the adapter
        string sqlStmt = "SELECT * FROM Application where CompletionDate <= Date()";
        OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter(sqlStmt, dbConnection);

        //Fill the dataset with the results from the query.
        dsUsers myStoreDataset = new dsUsers();
        sqlDataAdapter.Fill(myStoreDataset.Application);

        //return the dataset
        return myStoreDataset;

    }

    

    //Update the customer information in the database
    public void UpdateAccountInfo(string city, string state, string favLanguage, string LeastFavLanguage,DateTime lastProgCompletionDate, string username)
    {
        //Open the database connection
        dbConnection.Open();

        //prepare the query
        string sqlStmt = "update tblUsers set city = @city, " +
                          "state = @state, " +
                          "FavLanguage = @FavLanguage, " +
                          "LeastFavProgLanguage = @LeastFavProgLanguage, " +
                          "LastProgramCompletionDate = @LastProgramCompletionDate " +
                          "Where (tblUsers.Username = @username)";

        //Create the command using the connection and query
        OleDbCommand dbCommand = new OleDbCommand(sqlStmt, dbConnection);

        //Add all the parameters to the query
        OleDbParameter param = new OleDbParameter("@city", city);
        
        dbCommand.Parameters.Add(param);
        dbCommand.Parameters.Add(new OleDbParameter("@state", state));
        dbCommand.Parameters.Add(new OleDbParameter("@FavLanguage", favLanguage));
        dbCommand.Parameters.Add(new OleDbParameter("@LeastFavProgLanguage", LeastFavLanguage));
        dbCommand.Parameters.Add(new OleDbParameter("@LastProgramCompletionDate", lastProgCompletionDate));
        dbCommand.Parameters.Add(new OleDbParameter("@username", username));
        
        //Run the query
        dbCommand.ExecuteNonQuery();

        //close the connection
        dbConnection.Close();

    }

    //Update the customer information in the database
    public bool DeleteAccountInfo(string username)
    {
           //Open the database connection
            dbConnection.Open();

            //prepare the query
            string sqlStmt = "delete from tblUsers " +
                              "Where (tblUsers.Username = @username)";

            //Create the command using the connection and query
            OleDbCommand dbCommand = new OleDbCommand(sqlStmt, dbConnection);

            //Add all the parameters to the query
            dbCommand.Parameters.Add(new OleDbParameter("@username", username));

            //Run the query
            int results = dbCommand.ExecuteNonQuery();

            //close the connection
            dbConnection.Close();
            return results >0;
       
    }
}