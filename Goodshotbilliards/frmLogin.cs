using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goodshotbilliards
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
        !txtPassword.UseSystemPasswordChar;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string typedPassword = txtPassword.Text; // Just grab the password

                using (var connection = new System.Data.SQLite.SQLiteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT AdminPassword FROM Settings WHERE Id = 1";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string realPassword = reader["AdminPassword"].ToString();

                            // Check ONLY the password
                            if (typedPassword == realPassword)
                            {
                                Form1 mainApp = new Form1();
                                mainApp.FormClosed += (s, args) => this.Close();
                                mainApp.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Password. Access Denied.", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPassword.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
