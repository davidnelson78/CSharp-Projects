using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataSetExample
{
    public partial class Form1 : Form
    {
        private string sConnection;
        private string sql;

        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private OleDbDataAdapter contactDataAdap;
        private DataSet contactDS;
        private OleDbCommandBuilder cBuilder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cBuilder = new OleDbCommandBuilder(contactDataAdap);
                contactDataAdap.Update(contactDS, "ContactsTable");
            }
            catch (System.Exception exc)
            {
                this.lblMessage.Text = exc.Message;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                sConnection = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Contacts.accdb";
                dbConn = new OleDbConnection(sConnection);

                sql = "SELECT * FROM ContactsTable ORDER BY lastName ASC, firstName ASC;";
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;

                dbCmd.Connection = dbConn;

                contactDataAdap = new OleDbDataAdapter();
                contactDataAdap.SelectCommand = dbCmd;

                contactDS = new DataSet();
                contactDataAdap.Fill(contactDS, "ContactsTable");

                dataGrdVwContacts.DataSource = contactDS;
                dataGrdVwContacts.DataMember = "ContactsTable";
            }
            catch (System.Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }
    }
}