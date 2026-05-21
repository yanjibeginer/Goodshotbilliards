using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goodshotbilliards
{
    public partial class ucDashboard : UserControl
    {
        int availableTables = 8;
        int occupiedTables = 0;
        //table 1 timer
        private System.Windows.Forms.Timer table1Timer = new System.Windows.Forms.Timer();
        private TimeSpan table1TimeRemaining;

        // Table 2 Setup
        private System.Windows.Forms.Timer table2Timer = new System.Windows.Forms.Timer();
        private TimeSpan table2TimeRemaining;
        //3
        private System.Windows.Forms.Timer table3Timer = new System.Windows.Forms.Timer();
        private TimeSpan table3TimeRemaining;

        //4
        private System.Windows.Forms.Timer table4Timer = new System.Windows.Forms.Timer();
        private TimeSpan table4TimeRemaining;

        //5
        private System.Windows.Forms.Timer table5Timer = new System.Windows.Forms.Timer();
        private TimeSpan table5TimeRemaining;

        //6
        private System.Windows.Forms.Timer table6Timer = new System.Windows.Forms.Timer();
        private TimeSpan table6TimeRemaining;

        //7
        private System.Windows.Forms.Timer table7Timer = new System.Windows.Forms.Timer();
        private TimeSpan table7TimeRemaining;

        //8
        private System.Windows.Forms.Timer table8Timer = new System.Windows.Forms.Timer();
        private TimeSpan table8TimeRemaining;

        public ucDashboard()
        {
            InitializeComponent();

        }
        private void ucDashboard_Load(object sender, EventArgs e)
        {
            lblTotalTables.Text = "8";
            lblAvailable.Text = availableTables.ToString();
            lblOccupied.Text = occupiedTables.ToString();

            table1Timer.Interval = 1000; // 1 second
            table1Timer.Tick += Table1Timer_Tick;

            table2Timer.Interval = 1000;
            table2Timer.Tick += Table2Timer_Tick;

            table3Timer.Interval = 1000;
            table3Timer.Tick += Table3Timer_Tick;

            table4Timer.Interval = 1000;
            table4Timer.Tick += Table4Timer_Tick;

            table5Timer.Interval = 1000;
            table5Timer.Tick += Table5Timer_Tick;

            table6Timer.Interval = 1000;
            table6Timer.Tick += Table6Timer_Tick;

            table7Timer.Interval = 1000;
            table7Timer.Tick += Table7Timer_Tick;

            table8Timer.Interval = 1000;
            table8Timer.Tick += Table8Timer_Tick;

        }
        private void Table1Timer_Tick(object sender, EventArgs e)
        {
            // Check if there is still time left
            if (table1TimeRemaining.TotalSeconds > 0)
            {
                // Subtract 1 second
                table1TimeRemaining = table1TimeRemaining.Subtract(TimeSpan.FromSeconds(1));

                // Update the label to look like "03:00:00"
                lblTimer1.Text = table1TimeRemaining.ToString(@"hh\:mm\:ss");
            }
            else
            {
                // TIME IS UP!
                table1Timer.Stop();
                lblStatus1.Text = "● TIME UP";
                lblStatus1.ForeColor = Color.Red;
                MessageBox.Show("Time is up for Table 1!", "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Table2Timer_Tick(object sender, EventArgs e)
        {
            // Check if there is still time left
            if (table2TimeRemaining.TotalSeconds > 0)
            {
                // Subtract 1 second
                table2TimeRemaining = table2TimeRemaining.Subtract(TimeSpan.FromSeconds(1));

                // Update the label to look like "03:00:00"
                lblTimer2.Text = table2TimeRemaining.ToString(@"hh\:mm\:ss");
            }
            else
            {
                // TIME IS UP!
                table2Timer.Stop();
                lblStatus2.Text = "● TIME UP";
                lblStatus2.ForeColor = Color.Red;
                MessageBox.Show("Time is up for Table 2!", "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- TABLE 3 TICK ---
        private void Table3Timer_Tick(object sender, EventArgs e)
        {
            if (table3TimeRemaining.TotalSeconds > 0)
            {
                table3TimeRemaining = table3TimeRemaining.Subtract(TimeSpan.FromSeconds(1));
                lblTimer3.Text = table3TimeRemaining.ToString(@"hh\:mm\:ss");
            }
            else
            {
                table3Timer.Stop();
                lblStatus3.Text = "● TIME UP";
                lblStatus3.ForeColor = Color.Red;
                MessageBox.Show("Time is up for Table 3!", "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- TABLE 4 TICK ---
        private void Table4Timer_Tick(object sender, EventArgs e)
        {
            if (table4TimeRemaining.TotalSeconds > 0)
            {
                table4TimeRemaining = table4TimeRemaining.Subtract(TimeSpan.FromSeconds(1));
                lblTimer4.Text = table4TimeRemaining.ToString(@"hh\:mm\:ss");
            }
            else
            {
                table4Timer.Stop();
                lblStatus4.Text = "● TIME UP";
                lblStatus4.ForeColor = Color.Red;
                MessageBox.Show("Time is up for Table 4!", "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- TABLE 5 TICK ---
        private void Table5Timer_Tick(object sender, EventArgs e)
        {
            if (table5TimeRemaining.TotalSeconds > 0)
            {
                table5TimeRemaining = table5TimeRemaining.Subtract(TimeSpan.FromSeconds(1));
                lblTimer5.Text = table5TimeRemaining.ToString(@"hh\:mm\:ss");
            }
            else
            {
                table5Timer.Stop();
                lblStatus5.Text = "● TIME UP";
                lblStatus5.ForeColor = Color.Red;
                MessageBox.Show("Time is up for Table 5!", "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- TABLE 6 TICK ---
        private void Table6Timer_Tick(object sender, EventArgs e)
        {
            if (table6TimeRemaining.TotalSeconds > 0)
            {
                table6TimeRemaining = table6TimeRemaining.Subtract(TimeSpan.FromSeconds(1));
                lblTimer6.Text = table6TimeRemaining.ToString(@"hh\:mm\:ss");
            }
            else
            {
                table6Timer.Stop();
                lblStatus6.Text = "● TIME UP";
                lblStatus6.ForeColor = Color.Red;
                MessageBox.Show("Time is up for Table 6!", "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // --- TABLE 7 VIP TICK ---
        private void Table7Timer_Tick(object sender, EventArgs e)
        {
            if (table7TimeRemaining.TotalSeconds > 0)
            {
                table7TimeRemaining = table7TimeRemaining.Subtract(TimeSpan.FromSeconds(1));
                lblTimer7.Text = table7TimeRemaining.ToString(@"hh\:mm\:ss");
            }
            else
            {
                table7Timer.Stop();
                lblStatus7.Text = "● TIME UP";
                lblStatus7.ForeColor = Color.Red;
                MessageBox.Show("Time is up for VIP Table 7!", "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- TABLE 8 VIP TICK ---
        private void Table8Timer_Tick(object sender, EventArgs e)
        {
            if (table8TimeRemaining.TotalSeconds > 0)
            {
                table8TimeRemaining = table8TimeRemaining.Subtract(TimeSpan.FromSeconds(1));
                lblTimer8.Text = table8TimeRemaining.ToString(@"hh\:mm\:ss");
            }
            else
            {
                table8Timer.Stop();
                lblStatus8.Text = "● TIME UP";
                lblStatus8.ForeColor = Color.Red;
                MessageBox.Show("Time is up for VIP Table 8!", "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //  END SESSION LOGIC FOR ALL TABLES

        // table 1 click
        private void btnTable1_Click(object sender, EventArgs e)
        {
            if (lblStatus1.Text.Trim() == "AVAILABLE" || lblStatus1.Text.Contains("AVAILABLE"))
            {
                int hours;

                if (!int.TryParse(txtHours1.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours.");
                    return;
                }

                double charge = hours * 100;

                lblStatus1.Text = "  ● IN USE";
                lblStatus1.ForeColor = Color.OrangeRed;

                // --- NEW TIMER LOGIC START ---
                // Convert the hours into a TimeSpan and start the timer
                table1TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer1.Text = table1TimeRemaining.ToString(@"hh\:mm\:ss");
                table1Timer.Start();
                // --- NEW TIMER LOGIC END ---

                lblCurrentCharge1.Text = "₱" + charge.ToString("N0");

                btnTable1.Text = "END SESSION";
                btnTable1.BackColor = Color.Firebrick;

                availableTables--;
                occupiedTables++;

                lblAvailable.Text = availableTables.ToString();
                lblOccupied.Text = occupiedTables.ToString();
            }
            else
            {

                table1Timer.Stop();
                string cleanAmount1 = lblCurrentCharge1.Text.Replace("₱", "").Replace(",", "");
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TableNumber = 1,
                    TableType = "Regular",
                    TimePlayed = txtHours1.Text + " hours",
                    AmountPaid = Convert.ToDouble(cleanAmount1),
                    TimeFinished = DateTime.Now,

                    CustomerName = txtCustomer1.Text
                });

             

                lblStatus1.Text = "AVAILABLE"; // Removed the circle to match your original check
                lblStatus1.ForeColor = Color.Lime;
                lblTimer1.Text = "00:00:00";
                lblCurrentCharge1.Text = "₱0.00";
                btnTable1.Text = "START SESSION";
                btnTable1.BackColor = Color.FromArgb(34, 197, 94);

                availableTables++;
                occupiedTables--;

                lblAvailable.Text = availableTables.ToString();
                lblOccupied.Text = occupiedTables.ToString();
                
                txtCustomer1.Text = "Enter player name";
                txtCustomer1.ForeColor = Color.FromArgb(156, 163, 175);
                txtHours1.Clear();


            }
        }
        // TABLE 2 clik
        private void btnTable2_Click(object sender, EventArgs e)
        {
            if (lblStatus2.Text.Trim() == "AVAILABLE" || lblStatus2.Text.Contains("AVAILABLE"))
            {
                int hours;

                if (!int.TryParse(txtHours2.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours.");
                    return;
                }

                double charge = hours * 100;

                lblStatus2.Text = "  ● IN USE";
                lblStatus2.ForeColor = Color.OrangeRed;

                // --- NEW TIMER LOGIC START ---
                // Convert the hours into a TimeSpan and start the timer
                table2TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer2.Text = table2TimeRemaining.ToString(@"hh\:mm\:ss");
                table2Timer.Start();
                // --- NEW TIMER LOGIC END ---

                lblCurrentCharge2.Text = "₱" + charge.ToString("N0");

                btnTable2.Text = "END SESSION";
                btnTable2.BackColor = Color.Firebrick;

                availableTables--;
                occupiedTables++;

                lblAvailable.Text = availableTables.ToString();
                lblOccupied.Text = occupiedTables.ToString();
            }
            else
            {
                // --- NEW TIMER LOGIC START ---
                // Stop the timer when the session ends
                table2Timer.Stop();
                string cleanAmount2 = lblCurrentCharge2.Text.Replace("₱", "").Replace(",", "");
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TableNumber = 2,
                    TableType = "Regular",
                    TimePlayed = txtHours2.Text + " hours",
                    AmountPaid = Convert.ToDouble(cleanAmount2),
                    TimeFinished = DateTime.Now,
                    CustomerName = txtCustomer2.Text
                });


                lblStatus2.Text = "AVAILABLE"; // Removed the circle to match your original check
                lblStatus2.ForeColor = Color.Lime;

                lblTimer2.Text = "00:00:00";
                lblCurrentCharge2.Text = "₱0.00";

                btnTable2.Text = "START SESSION";
                btnTable2.BackColor = Color.FromArgb(34, 197, 94);
                availableTables++;
                occupiedTables--;

                lblAvailable.Text = availableTables.ToString();
                lblOccupied.Text = occupiedTables.ToString();
                txtCustomer2.Text = "Enter player name";
                txtCustomer2.ForeColor = Color.FromArgb(156, 163, 175);
                txtHours2.Clear();


            }
        }
        // table 3 clik
        private void btnTable3_Click(object sender, EventArgs e)
        {
            if (lblStatus3.Text.Trim() == "AVAILABLE" || lblStatus3.Text.Contains("AVAILABLE"))
            {
                int hours;
                if (!int.TryParse(txtHours3.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours."); return;
                }
                double charge = hours * 100;
                lblStatus3.Text = "  ● IN USE";
                lblStatus3.ForeColor = Color.OrangeRed;

                table3TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer3.Text = table3TimeRemaining.ToString(@"hh\:mm\:ss");
                table3Timer.Start();

                lblCurrentCharge3.Text = "₱" + charge.ToString("N0");
                btnTable3.Text = "END SESSION";
                btnTable3.BackColor = Color.Firebrick;
                availableTables--; occupiedTables++;
                lblAvailable.Text = availableTables.ToString(); lblOccupied.Text = occupiedTables.ToString();
            }
            else
            {
                table3Timer.Stop();
                string cleanAmount3 = lblCurrentCharge3.Text.Replace("₱", "").Replace(",", "");
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TableNumber = 3,
                    TableType = "Regular",
                    TimePlayed = txtHours3.Text + " hours",
                    AmountPaid = Convert.ToDouble(cleanAmount3),
                    TimeFinished = DateTime.Now,
                    CustomerName = txtCustomer3.Text
                });

                lblStatus3.Text = "AVAILABLE";
                lblStatus3.ForeColor = Color.Lime;
                lblTimer3.Text = "00:00:00";
                lblCurrentCharge3.Text = "₱0.00";
                btnTable3.Text = "START SESSION";
                btnTable3.BackColor = Color.FromArgb(34, 197, 94);
                availableTables++; occupiedTables--;
                lblAvailable.Text = availableTables.ToString(); lblOccupied.Text = occupiedTables.ToString();

                txtCustomer3.Text = "Enter player name";
                txtCustomer3.ForeColor = Color.FromArgb(156, 163, 175);
                txtHours3.Clear();
            }
        }

        // table 4 clik
        private void btnTable4_Click(object sender, EventArgs e)
        {
            if (lblStatus4.Text.Trim() == "AVAILABLE" || lblStatus4.Text.Contains("AVAILABLE"))
            {
                int hours;
                if (!int.TryParse(txtHours4.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours."); return;
                }
                double charge = hours * 100;
                lblStatus4.Text = "  ● IN USE";
                lblStatus4.ForeColor = Color.OrangeRed;

                table4TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer4.Text = table4TimeRemaining.ToString(@"hh\:mm\:ss");
                table4Timer.Start();

                lblCurrentCharge4.Text = "₱" + charge.ToString("N0");
                btnTable4.Text = "END SESSION";
                btnTable4.BackColor = Color.Firebrick;

                availableTables--;
                occupiedTables++;
                lblAvailable.Text = availableTables.ToString();
                lblOccupied.Text = occupiedTables.ToString();
            }
            else
            {
                table4Timer.Stop();
                string cleanAmount4 = lblCurrentCharge4.Text.Replace("₱", "").Replace(",", "");
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TableNumber = 4,
                    TableType = "Regular",
                    TimePlayed = txtHours4.Text + " hours",
                    AmountPaid = Convert.ToDouble(cleanAmount4),
                    TimeFinished = DateTime.Now,
                    CustomerName = txtCustomer4.Text
                });

                lblStatus4.Text = "AVAILABLE";
                lblStatus4.ForeColor = Color.Lime;
                lblTimer4.Text = "00:00:00";
                lblCurrentCharge4.Text = "₱0.00";
                btnTable4.Text = "START SESSION";
                btnTable4.BackColor = Color.FromArgb(34, 197, 94);
                availableTables++; occupiedTables--;
                lblAvailable.Text = availableTables.ToString(); lblOccupied.Text = occupiedTables.ToString();
               
                txtCustomer4.Text = "Enter player name";
                txtCustomer4.ForeColor = Color.FromArgb(156, 163, 175);
                txtHours4.Clear();
            }
        }

        // table 5 clik
        private void btnTable5_Click(object sender, EventArgs e)
        {
            if (lblStatus5.Text.Trim() == "AVAILABLE" || lblStatus5.Text.Contains("AVAILABLE"))
            {
                int hours;
                if (!int.TryParse(txtHours5.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours."); return;
                }
                double charge = hours * 100;
                lblStatus5.Text = "  ● IN USE";
                lblStatus5.ForeColor = Color.OrangeRed;

                table5TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer5.Text = table5TimeRemaining.ToString(@"hh\:mm\:ss");
                table5Timer.Start();

                lblCurrentCharge5.Text = "₱" + charge.ToString("N0");
                btnTable5.Text = "END SESSION";
                btnTable5.BackColor = Color.Firebrick;
                availableTables--; occupiedTables++;
                lblAvailable.Text = availableTables.ToString(); lblOccupied.Text = occupiedTables.ToString();
            }
            else
            {
                table5Timer.Stop();

             
                string cleanAmount5 = lblCurrentCharge5.Text.Replace("₱", "").Replace(",", "");
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TableNumber = 5,
                    TableType = "Regular",
                    TimePlayed = txtHours5.Text + " hours",
                    AmountPaid = Convert.ToDouble(cleanAmount5),
                    TimeFinished = DateTime.Now,
                    CustomerName = txtCustomer5.Text
                });
                lblStatus5.Text = "AVAILABLE";
                lblStatus5.ForeColor = Color.Lime;
                lblTimer5.Text = "00:00:00";
                lblCurrentCharge5.Text = "₱0.00";
                btnTable5.Text = "START SESSION";
                btnTable5.BackColor = Color.FromArgb(34, 197, 94);
                availableTables++; occupiedTables--;
                lblAvailable.Text = availableTables.ToString(); lblOccupied.Text = occupiedTables.ToString();

                txtCustomer5.Text = "Enter player name";
                txtCustomer5.ForeColor = Color.FromArgb(156, 163, 175);
                txtHours5.Clear();
            }
        }

        // table 6 clik
        private void btnTable6_Click(object sender, EventArgs e)
        {
            if (lblStatus6.Text.Trim() == "AVAILABLE" || lblStatus6.Text.Contains("AVAILABLE"))
            {
                int hours;
                if (!int.TryParse(txtHours6.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours."); return;
                }
                double charge = hours * 100;
                lblStatus6.Text = "  ● IN USE";
                lblStatus6.ForeColor = Color.OrangeRed;

                table6TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer6.Text = table6TimeRemaining.ToString(@"hh\:mm\:ss");
                table6Timer.Start();

                lblCurrentCharge6.Text = "₱" + charge.ToString("N0");
                btnTable6.Text = "END SESSION";
                btnTable6.BackColor = Color.Firebrick;
                availableTables--; occupiedTables++;
                lblAvailable.Text = availableTables.ToString(); lblOccupied.Text = occupiedTables.ToString();
            }
            else
            {
                table6Timer.Stop();

                string cleanAmount6 = lblCurrentCharge6.Text.Replace("₱", "").Replace(",", "");
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TableNumber = 6,
                    TableType = "Regular",
                    TimePlayed = txtHours6.Text + " hours",
                    AmountPaid = Convert.ToDouble(cleanAmount6),
                    TimeFinished = DateTime.Now,
                    CustomerName = txtCustomer6.Text
                });

                lblStatus6.Text = "AVAILABLE";
                lblStatus6.ForeColor = Color.Lime;
                lblTimer6.Text = "00:00:00";
                lblCurrentCharge6.Text = "₱0.00";
                btnTable6.Text = "START SESSION";
                btnTable6.BackColor = Color.FromArgb(34, 197, 94);
                availableTables++; occupiedTables--;
                lblAvailable.Text = availableTables.ToString(); lblOccupied.Text = occupiedTables.ToString();

                txtCustomer6.Text = "Enter player name";
                txtCustomer6.ForeColor = Color.FromArgb(156, 163, 175);
                txtHours6.Clear();
            }
        }
        // --- TABLE 7 VIP CLICK ---
        private void btnTable7_Click(object sender, EventArgs e)
        {
            if (lblStatus7.Text.Trim() == "AVAILABLE" || lblStatus7.Text.Contains("AVAILABLE"))
            {
                int hours;
                if (!int.TryParse(txtHours7.Text, out hours) || hours < 2)
                {
                    MessageBox.Show("VIP Tables require a minimum of 2 hours.", "Minimum Time Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; //reset
                }


                // VIP RATE: ₱200 per hour
                double charge = hours * 200;

                lblStatus7.Text = "  ● IN USE";
                lblStatus7.ForeColor = Color.OrangeRed;

                table7TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer7.Text = table7TimeRemaining.ToString(@"hh\:mm\:ss");
                table7Timer.Start();

                // Using "N0" for clean numbers!
                lblCurrentCharge7.Text = "₱" + charge.ToString("N0");

                btnTable7.Text = "END SESSION";
                btnTable7.BackColor = Color.Firebrick;
                availableTables--; occupiedTables++;
                lblAvailable.Text = availableTables.ToString(); lblOccupied.Text = occupiedTables.ToString();
            }
            else
            {
                table7Timer.Stop();
                string cleanAmount7 = lblCurrentCharge7.Text.Replace("₱", "").Replace(",", "");
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TableNumber = 7,
                    TableType = "VIP",
                    TimePlayed = txtHours7.Text + " hours",
                    AmountPaid = Convert.ToDouble(cleanAmount7),
                    TimeFinished = DateTime.Now,
                    CustomerName = txtCustomer7.Text
                });

                lblStatus7.Text = "AVAILABLE";
                lblStatus7.ForeColor = Color.Gold;
                lblTimer7.Text = "00:00:00";
                lblCurrentCharge7.Text = "₱0.00";
                btnTable7.Text = "START SESSION";
                btnTable7.BackColor = Color.Goldenrod;
                availableTables++; occupiedTables--;
                lblAvailable.Text = availableTables.ToString(); lblOccupied.Text = occupiedTables.ToString();

                txtCustomer7.Text = "Enter player name";
                txtCustomer7.ForeColor = Color.FromArgb(156, 163, 175);
                txtHours7.Clear();
            }
        }

        // --- TABLE 8 VIP CLICK ---
        private void btnTable8_Click(object sender, EventArgs e)
        {
            if (lblStatus8.Text.Trim() == "AVAILABLE" || lblStatus8.Text.Contains("AVAILABLE"))
            {
                int hours;
                if (!int.TryParse(txtHours8.Text, out hours) || hours < 2)
                {
                    MessageBox.Show("VIP Tables require a minimum of 2 hours.", "Minimum Time Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // reset
                }

                // VIP RATE: ₱200 per hour
                double charge = hours * 200;

                lblStatus8.Text = "  ● IN USE";
                lblStatus8.ForeColor = Color.OrangeRed;

                table8TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer8.Text = table8TimeRemaining.ToString(@"hh\:mm\:ss");
                table8Timer.Start();

                // Using "N0" for clean numbers!
                lblCurrentCharge8.Text = "₱" + charge.ToString("N0");

                btnTable8.Text = "END SESSION";
                btnTable8.BackColor = Color.Firebrick;
                availableTables--; occupiedTables++;
                lblAvailable.Text = availableTables.ToString(); lblOccupied.Text = occupiedTables.ToString();
            }
            else
            {
                table8Timer.Stop();
                string cleanAmount8 = lblCurrentCharge8.Text.Replace("₱", "").Replace(",", "");
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TableNumber = 8,
                    TableType = "VIP",
                    TimePlayed = txtHours8.Text + " hours",
                    AmountPaid = Convert.ToDouble(cleanAmount8),
                    TimeFinished = DateTime.Now,
                    CustomerName = txtCustomer8.Text
                });

                lblStatus8.Text = "AVAILABLE";
                lblStatus8.ForeColor = Color.Gold;
                lblTimer8.Text = "00:00:00";
                lblCurrentCharge8.Text = "₱0.00";
                btnTable8.Text = "START SESSION";
                btnTable8.BackColor = Color.Goldenrod;
                availableTables++; occupiedTables--;
                lblAvailable.Text = availableTables.ToString(); lblOccupied.Text = occupiedTables.ToString();

                txtCustomer8.Text = "Enter player name";
                txtCustomer8.ForeColor = Color.FromArgb(156, 163, 175);
                txtHours8.Clear();
            }
        }

        // Customer name logics
        private void txtCustomer1_Enter(object sender, EventArgs e)
        {
            // If the box still has the placeholder, clear it and change text to white/normal
            if (txtCustomer1.Text == "Enter player name")
            {
                txtCustomer1.Text = "";
                txtCustomer1.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }

        //TABLE 1 CUSTOMER NAME
        private void txtCustomer1_Leave(object sender, EventArgs e)
        {
            // If they left the box empty, put the placeholder back and make it gray
            if (string.IsNullOrWhiteSpace(txtCustomer1.Text))
            {
                txtCustomer1.Text = "Enter player name";
                txtCustomer1.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }

        //TABLE 2 CUSTOMER NAME 
        private void txtCustomer2_Enter(object sender, EventArgs e)
        {
            // If the box still has the placeholder, clear it and change text to white/normal
            if (txtCustomer2.Text == "Enter player name")
            {
                txtCustomer2.Text = "";
                txtCustomer2.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }
        private void txtCustomer2_Leave(object sender, EventArgs e)
        {
            // If they left the box empty, put the placeholder back and make it gray
            if (string.IsNullOrWhiteSpace(txtCustomer2.Text))
            {
                txtCustomer2.Text = "Enter player name";
                txtCustomer2.ForeColor = Color.FromArgb(156, 163, 175);
            }
           }

        //TABLE 3 CUSTOMER NAME 
        private void txtCustomer3_Enter(object sender, EventArgs e)
        {
            // If the box still has the placeholder, clear it and change text to white/normal
            if (txtCustomer3.Text == "Enter player name")
            {
                txtCustomer3.Text = "";
                txtCustomer3.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }
        private void txtCustomer3_Leave(object sender, EventArgs e)
        {
            // If they left the box empty, put the placeholder back and make it gray
            if (string.IsNullOrWhiteSpace(txtCustomer3.Text))
            {
                txtCustomer3.Text = "Enter player name";
                txtCustomer3.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }
        //TABLE 4 CUSTOMER NAME 
        private void txtCustomer4_Enter(object sender, EventArgs e)
        {
            // If the box still has the placeholder, clear it and change text to white/normal
            if (txtCustomer4.Text == "Enter player name")
            {
                txtCustomer4.Text = "";
                txtCustomer4.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }
        private void txtCustomer4_Leave(object sender, EventArgs e)
        {
            // If they left the box empty, put the placeholder back and make it gray
            if (string.IsNullOrWhiteSpace(txtCustomer4.Text))
            {
                txtCustomer4.Text = "Enter player name";
                txtCustomer4.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }
        //TABLE 5 CUSTOMER NAME 
        private void txtCustomer5_Enter(object sender, EventArgs e)
        {
            // If the box still has the placeholder, clear it and change text to white/normal
            if (txtCustomer5.Text == "Enter player name")
            {
                txtCustomer5.Text = "";
                txtCustomer5.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }
        private void txtCustomer5_Leave(object sender, EventArgs e)
        {
            // If they left the box empty, put the placeholder back and make it gray
            if (string.IsNullOrWhiteSpace(txtCustomer5.Text))
            {
                txtCustomer5.Text = "Enter player name";
                txtCustomer5.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }
        //TABLE 6 CUSTOMER NAME 
        private void txtCustomer6_Enter(object sender, EventArgs e)
        {
            // If the box still has the placeholder, clear it and change text to white/normal
            if (txtCustomer6.Text == "Enter player name")
            {
                txtCustomer6.Text = "";
                txtCustomer6.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }
        private void txtCustomer6_Leave(object sender, EventArgs e)
        {
            // If they left the box empty, put the placeholder back and make it gray
            if (string.IsNullOrWhiteSpace(txtCustomer6.Text))
            {
                txtCustomer6.Text = "Enter player name";
                txtCustomer6.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }

        //TABLE 7 CUSTOMER NAME
        private void txtCustomer7_Enter(object sender, EventArgs e)
        {
            // If the box still has the placeholder, clear it and change text to white/normal
            if (txtCustomer7.Text == "Enter player name")
            {
                txtCustomer7.Text = "";
                txtCustomer7.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }
        private void txtCustomer7_Leave(object sender, EventArgs e)
        {
            // If they left the box empty, put the placeholder back and make it gray
            if (string.IsNullOrWhiteSpace(txtCustomer7.Text))
            {
                txtCustomer7.Text = "Enter player name";
                txtCustomer7.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }
        //TABLE 8 CUSTOMER NAME
        private void txtCustomer8_Enter(object sender, EventArgs e)
        {
            // If the box still has the placeholder, clear it and change text to white/normal
            if (txtCustomer8.Text == "Enter player name")
            {
                txtCustomer8.Text = "";
                txtCustomer8.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }
        private void txtCustomer8_Leave(object sender, EventArgs e)
        {
            // If they left the box empty, put the placeholder back and make it gray
            if (string.IsNullOrWhiteSpace(txtCustomer8.Text))
            {
                txtCustomer8.Text = "Enter player name";
                txtCustomer8.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }

    }
}











