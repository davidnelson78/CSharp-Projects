using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordList : Form
    {
        public PasswordList()
        {
            InitializeComponent();
        }

        public static int rowID;
        public static string rowTitle;
        public static string rowPassword;
        public static string rowCustomPassword;
        private int deletedRow;
        private string deletedCustomPassword;
        private string clickedItem = "";

        private Provider p = new Provider("psCnf.ok");

        private void PasswordList_Load(object sender, EventArgs e)
        {
            dgvPasswordList.AutoGenerateColumns = false;
            dgvPasswordList.RowHeadersVisible = false;
            dgvPasswordList.AllowUserToAddRows = false;

            dgvPasswordList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPasswordList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPasswordList.Columns[0].Width = 160;
            dgvPasswordList.DataSource = p.GetDataTable();
            dgvPasswordList.ClearSelection();
        }

        private void dgvPasswordList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PasswordDetailLogin pl = new PasswordDetailLogin();
                PasswordDetail plDetail = new PasswordDetail();

                string rowCustomPassword = dgvPasswordList.Rows[e.RowIndex].Cells["CustomPassword"].Value.ToString();

                rowID = int.Parse(dgvPasswordList.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                rowTitle = dgvPasswordList.Rows[e.RowIndex].Cells["title"].Value.ToString();
                rowPassword = dgvPasswordList.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                rowCustomPassword = dgvPasswordList.Rows[e.RowIndex].Cells["CustomPassword"].Value.ToString();

                if (rowCustomPassword != string.Empty)
                {
                    pl.ShowDialog();
                }
                else
                {
                    PasswordDetail.rowID = rowID;
                    plDetail.txtTitle.Text = rowTitle;
                    plDetail.txtPassword.Text = rowPassword;
                    plDetail.txtCustomPassword.Text = rowCustomPassword;
                    plDetail.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                dgvPasswordList.ClearSelection();
            }
        }

        private void txtSearchKeyword_TextChanged(object sender, EventArgs e)
        {
            dgvPasswordList.DataSource = p.GetDataTable(txtSearchKeyword.Text);
        }

        private void dgvPasswordList_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    cntRightMenu.Items.Clear();
                    cntRightMenu.Items.Add("Delete").Tag = "Delete";
                    cntRightMenu.Items.Add("Update Password").Tag = "Update";
                    dgvPasswordList.ClearSelection();
                    dgvPasswordList.Rows[dgvPasswordList.HitTest(e.X, e.Y).RowIndex].Selected = true;

                    deletedRow = int.Parse(dgvPasswordList.Rows[dgvPasswordList.HitTest(e.X, e.Y).RowIndex].Cells["ID"].Value.ToString());
                    deletedCustomPassword = dgvPasswordList.Rows[dgvPasswordList.HitTest(e.X, e.Y).RowIndex].Cells["CustomPassword"].Value.ToString();

                    cntRightMenu.Show(dgvPasswordList, new Point(e.X, e.Y));
                }
            }
            catch
            {
            }
        }

        private void cntRightMenu_Click(object sender, EventArgs e)
        {
        }

        private void cntRightMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            clickedItem = e.ClickedItem.Text;

            cntRightMenu.Visible = false;

            if (clickedItem.ToLower().Contains("delete"))
            {
                var isOk = MessageBox.Show("Are you sure you want to delete?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (isOk == DialogResult.Yes)
                {
                    p.DeleteData(deletedRow);
                    dgvPasswordList.DataSource = p.GetDataTable();
                }
            }
            else
            {
                PasswordDetailLogin pl = new PasswordDetailLogin();
                PasswordDetail plDetail = new PasswordDetail();
                int rowInd = dgvPasswordList.SelectedRows[0].Index;
                string rowCustomPassword = dgvPasswordList.Rows[rowInd].Cells["CustomPassword"].Value.ToString();

                rowID = int.Parse(dgvPasswordList.Rows[rowInd].Cells["ID"].Value.ToString());
                rowTitle = dgvPasswordList.Rows[rowInd].Cells["title"].Value.ToString();
                rowPassword = dgvPasswordList.Rows[rowInd].Cells["Password"].Value.ToString();
                rowCustomPassword = dgvPasswordList.Rows[rowInd].Cells["CustomPassword"].Value.ToString();

                if (rowCustomPassword != string.Empty)
                {
                    pl.ShowDialog();
                }
                else
                {
                    PasswordDetail.rowID = rowID;
                    plDetail.txtTitle.Text = rowTitle;
                    plDetail.txtPassword.Text = rowPassword;
                    plDetail.txtCustomPassword.Text = rowCustomPassword;
                    plDetail.ShowDialog();
                }
            }
            dgvPasswordList.ClearSelection();
        }
    }
}