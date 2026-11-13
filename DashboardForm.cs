using System;
using System.Windows.Forms;

namespace activity_3
{
    public partial class DashboardForm : Form
    {
        public DashboardForm(string username)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome, {username}!";
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new LoginForm().Show();
                Close();
            }
        }
    }
}