using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DatabaseGuiApp
{
    internal class ContactS
    {
        private const int NO_OF_CONTACTS = 10;

        private Contact[] myContacts = new Contact[NO_OF_CONTACTS];

        public int ReadContacts(ref string error)
        {
            string sConnection;
            string sql;
            OleDbDataReader dbReader;

            int index = 0;

            try
            {
                sConnection = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Contacts.accdb";

                OleDbConnection dbConn = new OleDbConnection(sConnection);  //Create an object dbConn of type OleDbConnection
                dbConn.Open();                                              //Open the connection

                sql = "SELECT * FROM ContactsTable ORDER BY LastName ASC, FirstName ASC;"; //Create a SQL command to read all the records from the ContactsTable
                OleDbCommand dbCmd = new OleDbCommand();                    //Creat an object dbCmd of OleDbCommand type

                dbCmd.CommandText = sql;                    //Property to set the SQL statement to execute at the data source
                dbCmd.Connection = dbConn;                  //Sets the command object to the open connection

                dbReader = dbCmd.ExecuteReader();       //Sends the command text to the command connection and builds an OleDbDataReader
                while (dbReader.Read())                 //Reads the first record, verifies a record exists
                {
                    myContacts[index] = new Contact(); //Create an object of type Contact within myContacts array

                    myContacts[index].FirstName = dbReader["firstName"].ToString();  //Read the "firstName field and set the object's class variable firstName using the property FirstName
                    myContacts[index].LastName = dbReader["lastName"].ToString();   //Repeeat the process for all fields
                    myContacts[index].Address = dbReader["address"].ToString();
                    myContacts[index].City = dbReader["city"].ToString();
                    myContacts[index].State = dbReader["state"].ToString();
                    myContacts[index].ZipCode = dbReader["zipCode"].ToString();
                    myContacts[index].Phone = dbReader["phone"].ToString();
                    myContacts[index].EmailAddress = dbReader["emailAddress"].ToString();

                    index++;
                }
            }
            catch (System.IO.IOException exc)
            {
                error = exc.Message;
            }
            catch (Exception exc)
            {
                error = exc.Message;
            }

            return index;
        }

        public string GetFirstName(int index)
        {
            return myContacts[index].FirstName;
        }

        public string GetLastName(int index)
        {
            return myContacts[index].LastName;
        }

        public string GetAddress(int index)
        {
            return myContacts[index].Address;
        }

        public string GetCity(int index)
        {
            return myContacts[index].City;
        }

        public string GetState(int index)
        {
            return myContacts[index].State;
        }

        public string GetZip(int index)
        {
            return myContacts[index].ZipCode;
        }

        public string GetPhone(int index)
        {
            return myContacts[index].Phone;
        }

        public string GetEMail(int index)
        {
            return myContacts[index].EmailAddress;
        }
    }
}