using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace activity_3
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFull.Text) ||
                string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                using (var conn = new SqlConnection(Database.ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "INSERT INTO users (username, password, fullname) VALUES (@u, @p, @f)", conn);
                    cmd.Parameters.AddWithValue("@u", txtUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", txtPass.Text);
                    cmd.Parameters.AddWithValue("@f", txtFull.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Registered successfully!");
                new LoginForm().Show();
                Hide();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Username already exists.");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Hide();
        }
    }
}