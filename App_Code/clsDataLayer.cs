using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Net;
using System.Data;

/// <summary>
/// Summary description for clsDataLayer
/// </summary>
public class clsDataLayer
{
    // This function gets the user activity from the tblUserActivity
    public static dsUserActivity GetUserActivity(string Database)
    {
        // declaring variables
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        // assigning OleDbConnection to sqlConn
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        // assigning DB query to sqlDA
        sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);
        // instantiate dsUserActivity object
        DS = new dsUserActivity();
        // gets the information from the DB
        sqlDA.Fill(DS.tblUserActivity);
        // returns the info from dsUserActivity
        return DS;
    }
    // This function saves the user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        // assign connection to DB, open the connection, save information to DB
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;
        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" + GetIP4Address() + "', '" + FormAccessed + "')";
        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }
    // This function gets the IP Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;
        foreach (IPAddress IPA in
        Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }
        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        return IP4Address;
    }

    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName,
    string PayRate, string StartDate, string EndDate)
    {
        bool recordSaved;

        // set up OleDBTransaction
        OleDbTransaction myTransaction = null;

        try
        {
            // set up DB connection
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            //Begin transaction
            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            // create query statement
            strSQL = "Insert into tblPersonnel " + "(FirstName, LastName) values ('" +
            FirstName + "', '" + LastName + "')";
            // set up commandtype
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // execute querey
            command.ExecuteNonQuery();
            // set up update to tblPersonnel
            strSQL = "Update tblPersonnel " + "Set PayRate=" + PayRate + ", " +"StartDate='" + StartDate + "', " +
            "EndDate='" + EndDate + "' " + "Where ID=(Select Max(ID) From tblPersonnel)";
            // set update to command type
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // execute update
            command.ExecuteNonQuery();

            //commit Transaction
            myTransaction.Commit();
            conn.Close();

            recordSaved = true;
        }
        catch (Exception ex)
        {
            //rollback transaction
            myTransaction.Rollback();

            recordSaved = false;
        }

        return recordSaved;
    }

    public static bool SaveUser(string Database, string UserName, string Password, string SecurityLevel)
    {
        //Create Variables
        bool recordSaved;

        try
        {
            //establish connection to DB
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
           "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            //set up query
            strSQL = "Insert into tblUserLogin " + "(UserName, UserPassword, SecurityLevel) values ('" +
            UserName + "', '" + Password + "' , '" + SecurityLevel + "')";

            //set up query
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            //execute query
            command.ExecuteNonQuery();

            //Close connection
            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {
            recordSaved = false;
        }

        return recordSaved;
    }
    
    public static dsPersonnel GetPersonnel(string Database, string strSearch)
    {
        dsPersonnel DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        // assigning OleDbConnection to sqlConn
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        // assigning DB query to sqlDA
        if (strSearch == null || strSearch.Trim() == "")
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
        }
        else
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearch + "'", sqlConn);
        }
        // instantiate dsUserActivity object
        DS = new dsPersonnel();
        // gets the information from the DB
        sqlDA.Fill(DS.tblPersonnel);
        // returns the info from dsUserActivity
        return DS;

    }

    // This function verifies a user in the tblUser table
    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
    {
        // Add your comments here
        dsUser DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        // Add your comments here
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);
        // Add your comments here
        sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
        "where UserName like '" + UserName + "' " +
        "and UserPassword like '" + UserPassword + "'", sqlConn);
        // Add your comments here
        DS = new dsUser();
        // Add your comments here
        sqlDA.Fill(DS.tblUserLogin);
        // Add your comments here
        return DS;
    }

    //Default constructor
    public clsDataLayer()
    {
       
    }

}// end clsDataLayer class