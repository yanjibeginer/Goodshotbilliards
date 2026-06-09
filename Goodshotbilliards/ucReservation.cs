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
    public partial class ucReservation : UserControl
    {
        public ucReservation()
        {
            InitializeComponent();
            LoadReservations();

            dtpResDate.Value = DateTime.Now;  //  Set the calendar to today's date automatically

            // 2. Push that date into your dark Label so it's visible instantly
            lblResDate.Text = dtpResDate.Value.ToString("MM/dd/yyyy");

            cmbResTable.Items.Clear();

            foreach (var table in BilliardsState.TableStatuses)
            {
                cmbResTable.Items.Add(table.Key); // Added spaces for your UI design!
            }




        }
        //reserve date
        private void dtpResDate_ValueChanged(object sender, EventArgs e)
        {
            lblResDate.Text = dtpResDate.Value.ToString("MM/dd/yyyy");
        }

        private void pnlBookReserveborder_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                // subtract 1 from the width and height so the line stays inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.pnlBookReserveborder.Width - 1, this.pnlBookReserveborder.Height - 1);
            }
        }
        private void lblResDate_Click(object sender, EventArgs e)
        {
            dtpResDate.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void pnlUpcomingResborder_Paint_1(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                // subtract 1 from the width and height so the line stays inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.pnlUpcomingResborder.Width - 1, this.pnlUpcomingResborder.Height - 1);
            }
        }


        private void cmbResTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabledecoy.Focus();
        }

        private void cbAmPm_SelectedIndexChanged(object sender, EventArgs e)
        {
            timedecoy.Focus();
        }

        private void txtCustomerReservation_Enter(object sender, EventArgs e)
        {
            if (txtCustomerReservation.Text == "Enter customer name....")
            {
                txtCustomerReservation.Text = "";
            }

        }

        private void txtCustomerReservation_Leave(object sender, EventArgs e)
        {
            if (txtCustomerReservation.Text == "")
            {
                txtCustomerReservation.Text = "Enter customer name....";
            }
        }

        private void btnBookReservations_Click(object sender, EventArgs e)
        {
            //  Grab all the data from your inputs
            string customer = txtCustomerReservation.Text.Trim();
            string table = cmbResTable.Text;


            string date = dtpResDate.Text;

            // Glue the Time numbers and the AM/PM box together!
            string time = masktime.Text + " " + cbAmPm.Text;

            // 2. Safety Check: Make sure they didn't leave anything blank
            if (string.IsNullOrWhiteSpace(customer) || string.IsNullOrWhiteSpace(table) || masktime.Text == "  :")
            {
                MessageBox.Show("Please fill out all fields before booking.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stops the code here so it doesn't add a blank row
            }
            // 12 HOURS TIME ONLY 13+ BAWAL 
            DateTime validTimeCheck;
            bool isRealTime = DateTime.TryParseExact(time, "hh:mm tt", null, System.Globalization.DateTimeStyles.None, out validTimeCheck);

            if (isRealTime == false)
            {
                MessageBox.Show("Please enter a valid 12-hour time (e.g., 01:00 to 12:59 PM/AM).", "Invalid Time Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // SCANNER PARA DI SAME YUNG TIME AND TABLE NG SCHED

            // Look at every single row currently sitting in the grid
            foreach (DataGridViewRow row in dgvReservations.Rows)
            {
                // Skip the blank empty row at the very bottom
                if (row.IsNewRow) continue;

                // Grab the Table, Date, and Time from the current row in the loop
                // (Remember: Column 0 is Name, 1 is Table, 2 is Date, 3 is Time)
                string existingTable = row.Cells[1].Value.ToString();
                string existingDate = row.Cells[2].Value.ToString();
                string existingTime = row.Cells[3].Value.ToString();

                // Check if the exact Table, Date, AND Time match the new booking
                if (existingTable == table && existingDate == date && existingTime == time)
                {
                    // CRASH THE PARTY: Show the popup and stop the code!
                    MessageBox.Show($"Sorry, {table} is already reserved for {time} on {date}.", "Time Slot Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // This return kicks them out of the method so the row is NEVER added!
                }
            }


            // Add the brand new row to your grid!
            dgvReservations.Rows.Add(customer, table, date, time);

            // --- SAVE TO DATABASE ---
            try
            {
                // Connect to your SQLite file
                using (var connection = new System.Data.SQLite.SQLiteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    // Build the exact insert command
                    string insertQuery = "INSERT INTO Reservations (CustomerName, TableNumber, Date, Time) " + 
                        "VALUES (@customer, @table, @date, @time)";

                    using (var command = new System.Data.SQLite.SQLiteCommand(insertQuery, connection))
                    {
                        // We use parameters (@) here for security, so weird names with symbols don't break your database!
                        command.Parameters.AddWithValue("@customer", customer);
                        command.Parameters.AddWithValue("@table", table);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@time", time);

                        command.ExecuteNonQuery(); // Fires the command!
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear the form so it is ready for the next customer
            txtCustomerReservation.Clear();
            cmbResTable.SelectedIndex = -1; // Deselects the table
            masktime.Clear();

            // Put the cursor back in the Name box to save the admin a mouse click
            txtCustomerReservation.Focus();
        }

        private void dgvReservations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check: Ignore clicks on the column headers (-1) or the empty blank row at the very bottom
            if (e.RowIndex < 0 || e.RowIndex == dgvReservations.NewRowIndex)
            {
                return;
            }
            // 2. Grab ALL the data from the clicked row (not just the name)
            string customer = dgvReservations.Rows[e.RowIndex].Cells[0].Value.ToString();
            string table = dgvReservations.Rows[e.RowIndex].Cells[1].Value.ToString();
            string time = dgvReservations.Rows[e.RowIndex].Cells[3].Value.ToString();
            string date = dgvReservations.Rows[e.RowIndex].Cells[2].Value.ToString();


            // 3. Open your brand new custom popup
            frmReservationAction popup = new frmReservationAction(customer, table, time);
            popup.ShowDialog(); // Freezes the screen until they click a button

            // 4. Check the "Memory" to see what button they clicked
            if (popup.ActionChosen == "Cancel")
            {
                try
                {
                    // 1. Tell the Database to delete them permanently
                    using (var connection = new System.Data.SQLite.SQLiteConnection(DatabaseHelper.ConnectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Reservations WHERE CustomerName = @customer AND Date = @date AND Time = @time";

                        using (var command = new System.Data.SQLite.SQLiteCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@customer", customer);
                            command.Parameters.AddWithValue("@date", date); // Uses the date we just grabbed!
                            command.Parameters.AddWithValue("@time", time);

                            command.ExecuteNonQuery();
                        }
                    }

                    // 2. Wipe the grid and reload it fresh from the newly updated database
                    LoadReservations();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete from database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
            else if (popup.ActionChosen == "CheckIn")
            {
                // They clicked the Green Button: Run VIP Logic!

                // Ask the Brain if the table is currently occupied
                bool isOccupied = BilliardsState.TableStatuses[table];

                if (isOccupied == false)
                {
                    // PATH A: Table is empty! Claim it instantly.
                    BilliardsState.TableStatuses[table] = true;
                    BilliardsState.TableAssignments[table] = customer;
                    BilliardsState.TriggerStateChanged(); // Refresh the colors across the app

                    MessageBox.Show($"{table} is ready! {customer} has been assigned instantly.", "VIP Walk-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // PATH B: Table is occupied!
                    MessageBox.Show($"{table} is currently occupied. {customer} has been placed at the FRONT of the queue.", "VIP Queue", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    ucQueue.Instance.AddVipToQueue(customer);
                }

                // Finally, remove the reservation from the grid since they are now checked in
                dgvReservations.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void LoadReservations()
        {
            dgvReservations.Rows.Clear(); // Clear the grid first so we don't get duplicates

            try
            {
                using (var connection = new System.Data.SQLite.SQLiteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    // Ask the database for all the saved reservations
                    string selectQuery = "SELECT CustomerName, TableNumber, Date, Time FROM Reservations";

                    using (var command = new System.Data.SQLite.SQLiteCommand(selectQuery, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        // Loop through every single row it finds in the file
                        while (reader.Read())
                        {
                            string customer = reader["CustomerName"].ToString();
                            string table = reader["TableNumber"].ToString();
                            string date = reader["Date"].ToString();
                            string time = reader["Time"].ToString();

                            // Add it directly back to your visual grid!
                            dgvReservations.Rows.Add(customer, table, date, time);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load reservations: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
    