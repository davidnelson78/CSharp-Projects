using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUISayingsForm
{
    public partial class Form1 : Form
    {
        private StreamWriter fil;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStoreSaying_Click(object sender, EventArgs e)
        {
            try
            {
                fil.WriteLine(txtBxSaying.Text);
                txtBxSaying.Text = "";
                txtBxSaying.Focus();
            }
            catch (IOException exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fil = new StreamWriter("Saying.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                lblMessage.Text = "Invalid Directory\n" + exc.Message;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fil.Close();
            }
            catch
            {
                lblMessage.Text = "File did not close properly";
            }
        }
    }
}