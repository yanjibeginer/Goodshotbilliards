using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Goodshotbilliards
{
    public partial class ucReports : UserControl
    {
        public ucReports()
        {
            InitializeComponent();
         
            //date automatic date now(illusion)
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        // This runs every time the Reports page is opened
        private void ucReports_Load(object sender, EventArgs e)
        {
            LoadTransactions();
         


            // 2. Format the columns to look nice (Optional but recommended)
            if (dgvReports.Columns.Count > 0)
            {
             
             

                    // dgv colors and shit
                    dgvReports.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                    dgvReports.ColumnHeadersDefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;

                    dgvReports.DefaultCellStyle.SelectionBackColor =
                        Color.FromArgb(14, 22, 40);

                    dgvReports.DefaultCellStyle.SelectionForeColor =
                        Color.White;

                    dgvReports.ColumnHeadersDefaultCellStyle.BackColor =
                        Color.FromArgb(19, 30, 51);

                    dgvReports.ColumnHeadersDefaultCellStyle.ForeColor =
                        Color.White;
  
                }
            }
   


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = dateTimePicker1.Value.ToString("dddd, MMMM dd, yyyy");
            LoadTransactions();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Select();
            SendKeys.Send("%{DOWN}");
        }




        private void pnltotalrev_Paint(object sender, PaintEventArgs e)
        {
           
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                //  subtract 1 from the width and height so the line stays  inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.pnltotalrev.Width - 1, this.pnltotalrev.Height - 1);
            }
        }

        private void pnlavgborder_Paint(object sender, PaintEventArgs e)
        {
           
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                // subtract 1 from the width and height so the line stays  inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.pnlavgborder.Width - 1, this.pnlavgborder.Height - 1);
            }
        }

        private void pnlactiveborder_Paint(object sender, PaintEventArgs e)
        {
            
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                // subtract 1 from the width and height so the line stays inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.pnlactiveborder.Width - 1, this.pnlactiveborder.Height - 1);
            }
        }

        private void pnlviprevenueborder_Paint(object sender, PaintEventArgs e)
        {
          
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                // We subtract 1 from the width and height so the line stays  inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.pnlviprevenueborder.Width - 1, this.pnlviprevenueborder.Height - 1);
            }
        }

        private void dgvReports_Paint(object sender, PaintEventArgs e)
        {

            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                //  subtract 1 from the width and height so the line stays  inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.dgvReports.Width - 1, this.dgvReports.Height - 1);
            }
        }

        private void pnltransachistory_Paint(object sender, PaintEventArgs e)
        {
            
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                //  subtract 1 from the width and height so the line stays  inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.pnltransachistory.Width - 1, this.pnltransachistory.Height - 1);
            }
        }
        private void LoadTransactions()
        {

            dgvReports.Columns.Clear();
            dgvReports.DataSource = null; // Guarantees the old RAM list is disconnected

            // 2. Build our 6 custom columns perfectly
            dgvReports.Columns.Add("Table", "TABLE");
            dgvReports.Columns.Add("Type", "TYPE");
            dgvReports.Columns.Add("Duration", "DURATION");
            dgvReports.Columns.Add("Amount", "AMOUNT");
            dgvReports.Columns.Add("SessionEnd", "SESSION END");
            dgvReports.Columns.Add("Customer", "CUSTOMER");

            try
            {
                string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                using (var connection = new System.Data.SQLite.SQLiteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT TableNumber, TableType, TimePlayed, AmountPaid, TimeFinished, CustomerName " + "FROM Transactions WHERE date(TimeFinished) = @date";

                    using (var command = new System.Data.SQLite.SQLiteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@date", selectedDate);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // ... (your existing row-adding logic remains the same)
                                string table = "Table " + reader["TableNumber"].ToString();
                                string type = reader["TableType"].ToString();
                                string duration = reader["TimePlayed"].ToString();
                                string amount = "₱" + reader["AmountPaid"].ToString();

                                DateTime dt = DateTime.Parse(reader["TimeFinished"].ToString());
                                string sessionEnd = dt.ToString("hh:mm tt");

                                string customer = reader["CustomerName"].ToString();

                                dgvReports.Rows.Add(table, type, duration, amount, sessionEnd, customer);
                            }
                        }
                    }
                    CalculateKPIs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load transactions: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalculateKPIs()
        {
            double totalRevenue = 0;
            double vipRevenue = 0;
            int totalSessions = 0;

            // A dictionary to keep score of which table is used the most
            System.Collections.Generic.Dictionary<string, int> tableCounts = new System.Collections.Generic.Dictionary<string, int>();

            // 1. Loop through every single row we just loaded into the grid!
            foreach (DataGridViewRow row in dgvReports.Rows)
            {
                // Safety check: Ignore the blank empty row at the very bottom
                if (row.Cells["Amount"].Value != null)
                {
                    totalSessions++; // Add 1 to our session count

                    // 2. Calculate Revenue (Strip the Peso sign off so we can do math!)
                    string cleanAmount = row.Cells["Amount"].Value.ToString().Replace("₱", "").Trim();
                    double amount = Convert.ToDouble(cleanAmount);
                    totalRevenue += amount;

                    // 3. Calculate VIP Revenue
                    if (row.Cells["Type"].Value.ToString().Trim().ToUpper() == "VIP")
                    {
                        vipRevenue += amount;
                    }

                    // 4. Track Most Active Table
                    string table = row.Cells["Table"].Value.ToString();
                    if (tableCounts.ContainsKey(table))
                        tableCounts[table]++;
                    else
                        tableCounts[table] = 1;
                }
            }

            // --- UPDATE THE LABELS ON THE SCREEN ---
            lblTotalRevenueValue.Text = "₱" + totalRevenue.ToString("N2");
            lblVipRevenueValue.Text = "₱" + vipRevenue.ToString("N2");
            lblAvgTimeValue.Text = totalSessions.ToString() + " Sessions";

            // Find the table with the highest score
            string bestTable = "Table -";
            string bestType = "Regular/VIP";
            int highestCount = 0;

            foreach (DataGridViewRow row in dgvReports.Rows)
            {
                if (row.Cells["Table"].Value == null) continue;

                string table = row.Cells["Table"].Value.ToString();

                // Count this table
                int count = 0;
                foreach (DataGridViewRow r in dgvReports.Rows)
                    if (r.Cells["Table"].Value?.ToString() == table) count++;

                if (count > highestCount)
                {
                    highestCount = count;
                    bestTable = table;
                    bestType = row.Cells["Type"].Value.ToString(); // Grab the type!
                }
            }

            // Update both the Table Name AND the type label!
            lblMostActiveValue.Text = bestTable;
            lblActiveType.Text = bestType; // This updates your "Regular/VIP" label
        }
    }
    }

