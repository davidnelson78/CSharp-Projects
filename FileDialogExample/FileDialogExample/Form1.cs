using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileDialogExample
{
    public partial class Form1 : Form
    {
        private StreamReader inFile;
        private StreamWriter outFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string inValue;
            int count = 0;

            try
            {
                openFileDialog1.ShowDialog();
                inFile = new StreamReader(openFileDialog1.FileName);
                lblMessage.Text = "File: " + openFileDialog1.FileName;

                while ((inValue = inFile.ReadLine()) != null)
                {
                    if (count == 0)
                        lstBxQuestions.Items.Add("- " + inValue);

                    count = count + 1;

                    if (count == 7)
                        count = 0;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            finally
            {
                inFile.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();
                outFile = new StreamWriter(saveFileDialog1.FileName);

                foreach (string outValue in lstBxQuestions.Items)
                {
                    outFile.WriteLine(outValue);
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            finally
            {
                outFile.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}