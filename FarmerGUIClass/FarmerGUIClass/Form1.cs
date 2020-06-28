using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerGUIClass
{
    public partial class Form1 : Form
    {
        private Farmer theFarmer = new Farmer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (theFarmer.NorthBank.Contains("FARMER"))
            {
                if (radFarmerNS.Checked)
                    theFarmer.Move("");
                else if (radChickenNS.Checked)
                    theFarmer.Move("CHICKEN");
                else if (radFoxNS.Checked)
                    theFarmer.Move("FOX");
                else if (radGrainNS.Checked)
                    theFarmer.Move("GRAIN");

                radChickenNS.Enabled = false;
                radFarmerNS.Enabled = false;
                radFoxNS.Enabled = false;
                radGrainNS.Enabled = false;

                radChickenSS.Enabled = true;
                radFarmerSS.Enabled = true;
                radFoxSS.Enabled = true;
                radGrainSS.Enabled = true;
            }
            else
            {
                if (radFarmerSS.Checked)
                    theFarmer.Move("");
                else if (radChickenSS.Checked)
                    theFarmer.Move("CHICKEN");
                else if (radFoxSS.Checked)
                    theFarmer.Move("FOX");
                else if (radGrainSS.Checked)
                    theFarmer.Move("GRAIN");

                radChickenSS.Enabled = false;
                radFarmerSS.Enabled = false;
                radFoxSS.Enabled = false;
                radGrainSS.Enabled = false;

                radChickenNS.Enabled = true;
                radFarmerNS.Enabled = true;
                radFoxNS.Enabled = true;
                radGrainNS.Enabled = true;
            }

            txtBxNS.Text = "";
            txtBxSS.Text = "";

            ClearRadioButton();

            foreach (string val in theFarmer.NorthBank)
                txtBxNS.Text += val + "   ";

            foreach (string val in theFarmer.SouthBank)
                txtBxSS.Text += val + "   ";
        }

        public void ClearRadioButton()
        {
            radFarmerNS.Checked = false;
            radFarmerSS.Checked = false;
            radChickenNS.Checked = false;
            radChickenSS.Checked = false;
            radFoxNS.Checked = false;
            radFoxSS.Checked = false;
            radGrainNS.Checked = false;
            radGrainSS.Checked = false;
        }
    }
}