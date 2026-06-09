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
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();
        }

    


        private void pnlSecurity_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                //  subtract 1 from the width and height so the line stays  inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.pnlSecurity.Width - 1, this.pnlSecurity.Height - 1);
            }
        }

        private void pnlMaintenance_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                //  subtract 1 from the width and height so the line stays  inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.pnlMaintenance.Width - 1, this.pnlMaintenance.Height - 1);
            }
        }

        private void cmbCleanData_SelectedIndexChanged(object sender, EventArgs e)
        {
            decoyClear.Focus();
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure your textboxes are named something like this!
                string currentTyped = txtCurrentPass.Text;
                string newPass = txtNewPass.Text;
                string confirmPass = txtConfirmPass.Text;

                if (newPass != confirmPass)
                {
                    MessageBox.Show("New passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop the code right here
                }

                using (var connection = new System.Data.SQLite.SQLiteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    // 1. Check if the current password is correct
                    string checkQuery = "SELECT AdminPassword FROM Settings WHERE Id = 1";
                    string actualPassword = "";

                    using (var checkCmd = new System.Data.SQLite.SQLiteCommand(checkQuery, connection))
                    using (var reader = checkCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            actualPassword = reader["AdminPassword"].ToString();
                        }
                    }

                    if (currentTyped != actualPassword)
                    {
                        MessageBox.Show("Current password is incorrect!", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the code
                    }

                    // 2. If it is correct, save the new password!
                    string updateQuery = "UPDATE Settings SET AdminPassword = @newPass WHERE Id = 1";
                    using (var updateCmd = new System.Data.SQLite.SQLiteCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@newPass", newPass);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the boxes
                    txtCurrentPass.Clear();
                    txtNewPass.Clear();
                    txtConfirmPass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
            }
        }

        private void btnCleanDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Read what the user picked in the dropdown
                string selectedOption = cmbCleanData.Text;

                // Safety Check: Make sure they actually picked something!
                if (string.IsNullOrWhiteSpace(selectedOption))
                {
                    MessageBox.Show("Please select a timeframe from the dropdown first.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. The Scary Warning
                DialogResult warning = MessageBox.Show(
                    $"Are you absolutely sure you want to delete records for: {selectedOption}?\n\nThis cannot be undone.",
                    "CRITICAL WARNING",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (warning == DialogResult.Yes)
                {
                    using (var connection = new System.Data.SQLite.SQLiteConnection(DatabaseHelper.ConnectionString))
                    {
                        connection.Open();
                        string deleteQuery = "";

                        using (var command = new System.Data.SQLite.SQLiteCommand(connection))
                        {
                            // 3. Decide exactly what to delete based on the ComboBox!
                            if (selectedOption == "Older than 30 Days")
                            {
                                deleteQuery = "DELETE FROM Transactions WHERE TimeFinished <= @cutoff";
                                command.Parameters.AddWithValue("@cutoff", DateTime.Now.AddDays(-30));
                            }
                            else if (selectedOption == "Older than 90 Days")
                            {
                                deleteQuery = "DELETE FROM Transactions WHERE TimeFinished <= @cutoff";
                                command.Parameters.AddWithValue("@cutoff", DateTime.Now.AddDays(-90));
                            }
                            else // "All Time"
                            {
                                deleteQuery = "DELETE FROM Transactions;";
                                // Reset the ID counter only if we delete EVERYTHING
                                using (var resetCmd = new System.Data.SQLite.SQLiteCommand("DELETE FROM sqlite_sequence WHERE name='Transactions';", connection))
                                {
                                    resetCmd.ExecuteNonQuery();
                                }
                            }

                            // 4. Execute the targeted strike
                            command.CommandText = deleteQuery;
                            int rowsDeleted = command.ExecuteNonQuery();

                            MessageBox.Show($"Success! {rowsDeleted} old records were deleted from the database.", "Data Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error purging data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
    }

     
            
        
    

