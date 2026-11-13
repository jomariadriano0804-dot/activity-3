using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace activity_3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            using (var conn = new SqlConnection(Database.ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM users WHERE username=@u AND password=@p", conn);
                cmd.Parameters.AddWithValue("@u", txtUser.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtPass.Text);

                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("Login successful!");
                    new DashboardForm(txtUser.Text.Trim()).Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            Hide();
        }
    }
}