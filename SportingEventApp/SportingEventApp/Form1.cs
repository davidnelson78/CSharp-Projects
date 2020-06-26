using System;
using System.Windows.Forms;

namespace SportingEventApp
{
    public partial class Form1 : Form
    {
        private String SportChoice;

        public Form1()
        {
            InitializeComponent();
        }

        private void RadBtnHockey_Checked(object sender, EventArgs e)
        {
            SportChoice = "Hockey";

            pctBxHockey.Visible = true;
            pctBxBasketball.Visible = false;
            pctBxGolf.Visible = false;
            pctBxBaseball.Visible = false;
            pctBxFootball.Visible = false;
            pctBxTennis.Visible = false;
            txtBxMessage.Text = ("This years hockey league will be FULL CONTACT so be sure to bring your protective gear!");
        }

        private void RadBtnBasketball_Checked(object sender, EventArgs e)
        {
            SportChoice = "Basketball";

            pctBxHockey.Visible = false;
            pctBxBasketball.Visible = true;
            pctBxGolf.Visible = false;
            pctBxBaseball.Visible = false;
            pctBxFootball.Visible = false;
            pctBxTennis.Visible = false;
            txtBxMessage.Text = ("Hone your NBA draft skills in our newly expanded league");
        }

        private void RadBtnGolf_Checked(object sender, EventArgs e)
        {
            SportChoice = "Golf";

            pctBxHockey.Visible = false;
            pctBxBasketball.Visible = false;
            pctBxGolf.Visible = true;
            pctBxBaseball.Visible = false;
            pctBxFootball.Visible = false;
            pctBxTennis.Visible = false;
            txtBxMessage.Text = ("Let's tee up some fun!");
        }

        private void RadBtnBaseball_Checked(object sender, EventArgs e)
        {
            SportChoice = "Baseball";

            pctBxHockey.Visible = false;
            pctBxBasketball.Visible = false;
            pctBxGolf.Visible = false;
            pctBxBaseball.Visible = true;
            pctBxFootball.Visible = false;
            pctBxTennis.Visible = false;
            txtBxMessage.Text = ("Choosing this sport is a home run for sure!");
        }

        private void RadBtnFootball_Checked(object sender, EventArgs e)
        {
            SportChoice = "Football";

            pctBxHockey.Visible = false;
            pctBxBasketball.Visible = false;
            pctBxGolf.Visible = false;
            pctBxBaseball.Visible = false;
            pctBxFootball.Visible = true;
            pctBxTennis.Visible = false;
            txtBxMessage.Text = ("We can almost guarantee you won't get a concussion");
        }

        private void RadBtnTennis_Checked(object sender, EventArgs e)
        {
            SportChoice = "Tennis";

            pctBxHockey.Visible = false;
            pctBxBasketball.Visible = false;
            pctBxGolf.Visible = false;
            pctBxBaseball.Visible = false;
            pctBxFootball.Visible = false;
            pctBxTennis.Visible = true;
            txtBxMessage.Text = ("You only live once, but you get to serve twice");
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*********************************************************************************\n\n\t\tYou are all signed up for " + SportChoice + ".\n\tThank you for participating in our youth sports group!\n\n*********************************************************************************");
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name:\t\tDavid Nelson\nCourse:\t\tITDEV - 115 - 501\nInstructor:\t\tMr. Menzl\nAssignment:\tSporting Event App\nDate:\t\t" + System.DateTime.Today.ToShortDateString());
        }

        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("***************\n\nVersion 1.0\n\n***************");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*********************************************************************************\n\n\tPlease select the sport you would like to participate in this year!\n\n*********************************************************************************");
        }
    }
}