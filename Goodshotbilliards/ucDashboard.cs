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

            // 1. Listen to the megaphone
            BilliardsState.OnTableStateChanged += RefreshDashboardUI;

            // 2. Run the math right away
            RefreshDashboardUI();
        }
        public void RefreshDashboardUI()
        {
            int availableCount = 0;
            int occupiedCount = 0;

            foreach (var table in BilliardsState.TableStatuses)
            {
                if (table.Value == true)
                {
                    occupiedCount++;
                }
                else
                {
                    availableCount++;
                }
            }

            // Using your exact label names from lines 57 & 58!
            lblAvailable.Text = availableCount.ToString();
            lblOccupied.Text = occupiedCount.ToString();

            // --- NEW CODE: UPDATE TABLE 1 ---
            if (BilliardsState.TableStatuses["Table 1"] == true)
            {// MAGIC CHECK: Is the timer actually ticking right now?
                if (table1Timer.Enabled == true)
                {
                    lblStatus1.Text = "  ● IN USE";
                    lblStatus1.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblStatus1.Text = "  ● OCCUPIED";
                    lblStatus1.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68); // The normal Red
                }

                txtCustomer1.Text = BilliardsState.TableAssignments["Table 1"];
            }
            else
            {
                lblStatus1.Text = "● AVAILABLE";
                lblStatus1.ForeColor = System.Drawing.Color.FromArgb(0, 255, 120);
                txtCustomer1.Text = "Enter player name";
            }
            //TABLE 2 STATUS UPDATE
            if (BilliardsState.TableStatuses["Table 2"] == true)
            {
                if (table2Timer.Enabled == true)
                {
                    lblStatus2.Text = "  ● IN USE";
                    lblStatus2.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblStatus2.Text = "  ● OCCUPIED";
                    lblStatus2.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
                }

                txtCustomer2.Text = BilliardsState.TableAssignments["Table 2"];
            }
            else
            {
                lblStatus2.Text = "  ● AVAILABLE";
                lblStatus2.ForeColor = System.Drawing.Color.FromArgb(0, 219, 100);
                txtCustomer2.Text = "Enter player name";
            }
            //TABLE 3 STATUS UPDATE
            if (BilliardsState.TableStatuses["Table 3"] == true)
            {
                if (table3Timer.Enabled == true)
                {
                    lblStatus3.Text = "  ● IN USE";
                    lblStatus3.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblStatus3.Text = "  ● OCCUPIED";
                    lblStatus3.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
                }

                txtCustomer3.Text = BilliardsState.TableAssignments["Table 3"];
            }
            else
            {
                lblStatus3.Text = "  ● AVAILABLE";
                lblStatus3.ForeColor = System.Drawing.Color.FromArgb(0, 219, 100);
                txtCustomer3.Text = "Enter player name";
            }
            //TABLE 4 STATUS UPDATE
            if (BilliardsState.TableStatuses["Table 4"] == true)
            {
                if (table4Timer.Enabled == true)
                {
                    lblStatus4.Text = "  ● IN USE";
                    lblStatus4.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblStatus4.Text = "  ● OCCUPIED";
                    lblStatus4.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
                }

                txtCustomer4.Text = BilliardsState.TableAssignments["Table 4"];
            }
            else
            {
                lblStatus4.Text = "  ● AVAILABLE";
                lblStatus4.ForeColor = System.Drawing.Color.FromArgb(0, 219, 100);
                txtCustomer4.Text = "Enter player name";
            }
            //TABLE 5 STATUS UPDATE
            if (BilliardsState.TableStatuses["Table 5"] == true)
            {
                if (table5Timer.Enabled == true)
                {
                    lblStatus5.Text = "  ● IN USE";
                    lblStatus5.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblStatus5.Text = "  ● OCCUPIED";
                    lblStatus5.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
                }

                txtCustomer5.Text = BilliardsState.TableAssignments["Table 5"];
            }
            else
            {
                lblStatus5.Text = "  ● AVAILABLE";
                lblStatus5.ForeColor = System.Drawing.Color.FromArgb(0, 219, 100);
                txtCustomer5.Text = "Enter player name";
            }
            //TABLE 6 STATUS UPDATE
            if (BilliardsState.TableStatuses["Table 6"] == true)
            {
                if (table6Timer.Enabled == true)
                {
                    lblStatus6.Text = "  ● IN USE";
                    lblStatus6.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblStatus6.Text = "  ● OCCUPIED";
                    lblStatus6.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
                }

                txtCustomer6.Text = BilliardsState.TableAssignments["Table 6"];
            }
            else
            {
                lblStatus6.Text = "  ● AVAILABLE";
                lblStatus6.ForeColor = System.Drawing.Color.FromArgb(0, 219, 100);
                txtCustomer6.Text = "Enter player name";
            }
            // UPDATE TABLE 7 (VIP) ---
            if (BilliardsState.TableStatuses["Table 7"] == true)
            {
                if (table7Timer.Enabled == true)
                {
                    lblStatus7.Text = "  ● IN USE";
                    lblStatus7.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblStatus7.Text = "  ● OCCUPIED";
                    lblStatus7.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
                }

                txtCustomer7.Text = BilliardsState.TableAssignments["Table 7"];
            }
            else
            {
                lblStatus7.Text = "  ● AVAILABLE";
                lblStatus7.ForeColor = Color.Goldenrod; // Keeps your VIP text Gold!
                txtCustomer7.Text = "Enter player name";
            }
                                // --- NEW CODE: UPDATE TABLE 8 (VIP) ---
                                if (BilliardsState.TableStatuses["Table 8"] == true)
                                {
                                    if (table8Timer.Enabled == true)
                                    {
                                        lblStatus8.Text = "  ● IN USE";
                                        lblStatus8.ForeColor = Color.OrangeRed;
                                    }
                                    else
                                    {
                                        lblStatus8.Text = "  ● OCCUPIED";
                                        lblStatus8.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
                                    }

                                    txtCustomer8.Text = BilliardsState.TableAssignments["Table 8"];
                                }
                                else
                                {
                                    lblStatus8.Text = "  ● AVAILABLE";
                                    lblStatus8.ForeColor = Color.Goldenrod; // Keeps your VIP text Gold!
                                    txtCustomer8.Text = "Enter player name";
                                }
                            }
                        
   
        private void ucDashboard_Load(object sender, EventArgs e)
        {
            lblTotalTables.Text = "8";

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
            if (btnTable1.Text.Contains("START"))
            {
                double hours;
                if (!double.TryParse(txtHours1.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours (e.g., 1 or 1.5).");
                    return;
                }
                if (hours < 1)
                {
                    hours = 1; // Force the computer to use 1 hour
                    txtHours1.Text = "1"; // Update the textbox so the customer sees it!
                }

                // Calculate charge (100 per hour)
                double charge = hours * 100;
                lblCurrentCharge1.Text = "₱" + charge.ToString("N2"); // Added the exact Peso symbol!
               
                lblStatus1.Text = "  ● IN USE";
                lblStatus1.ForeColor = Color.OrangeRed;
                // Start Timer
                table1TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer1.Text = table1TimeRemaining.ToString(@"hh\:mm\:ss");
                table1Timer.Start();

            
                lblStatus1.ForeColor = Color.OrangeRed;
                // Update UI for running state
                btnTable1.Text = "END SESSION"; // Or add a square symbol if you want!
                btnTable1.BackColor = Color.Firebrick;
                txtHours1.Enabled = false;

                // FIX 3: If you typed the name manually, tell the Brain so it updates the Top Numbers!
                BilliardsState.TableStatuses["Table 1"] = true;
                BilliardsState.TableAssignments["Table 1"] = txtCustomer1.Text;
                RefreshDashboardUI();
            }
            // --- IF WE ARE ENDING A SESSION ---
            else
            {
                table1Timer.Stop();

                // FIX 2: Safely remove BOTH the standard P and the Peso symbol ₱
                string cleanAmount1 = lblCurrentCharge1.Text.Replace("₱", "").Replace("P", "").Replace(",", "").Trim();

                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TABLE = 1,
                    TYPE = "Regular",
                    DURATION = txtHours1.Text + " hours",
                    AMOUNT = Convert.ToDouble(cleanAmount1),
                    SESSION_END = DateTime.Now,
                    CUSTOMER = txtCustomer1.Text
                });

                SaveTransactionToDatabase("1", "Regular", txtHours1.Text, Convert.ToDouble(cleanAmount1), txtCustomer1.Text);

                // Tell the brain the table is free!
                BilliardsState.TableStatuses["Table 1"] = false;
                BilliardsState.TableAssignments["Table 1"] = "";
                RefreshDashboardUI();

                // Reset the screen
                lblTimer1.Text = "00:00:00";
                lblCurrentCharge1.Text = "₱0.00";
                btnTable1.Text = "▷ START SESSION"; // Put  triangle back
                btnTable1.BackColor = Color.FromArgb(34, 197, 94);
                txtHours1.Clear();
                txtHours1.Enabled = true;

            }
        }
        // TABLE 2 clik
        private void btnTable2_Click(object sender, EventArgs e)
        {
            // --- IF WE ARE STARTING A SESSION ---
            if (btnTable2.Text.Contains("START"))
            {
                double hours;
                if (!double.TryParse(txtHours2.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours (e.g., 1 or 1.5).");
                    return;
                }
               
                if (hours < 1)
                {
                    hours = 1; // Force the computer to use 1 hour
                    txtHours2.Text = "1"; // Update the textbox so the customer sees it!
                }

                // 1. Calculate charge (100 per hour)
                double charge = hours * 100;
                lblCurrentCharge2.Text = "₱" + charge.ToString("N2");

                // 2. Start Timer
                table2TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer2.Text = table2TimeRemaining.ToString(@"hh\:mm\:ss");
                table2Timer.Start();

                // 3. Update UI for running state
                lblStatus2.Text = "  ● IN USE";
                lblStatus2.ForeColor = Color.OrangeRed;
                btnTable2.Text = "END SESSION";
                btnTable2.BackColor = Color.Firebrick;
                txtHours2.Enabled = false;

                // 4. Tell the Brain!
                BilliardsState.TableStatuses["Table 2"] = true;
                BilliardsState.TableAssignments["Table 2"] = txtCustomer2.Text;
                RefreshDashboardUI();
            }
            // --- IF WE ARE ENDING A SESSION ---
            else
            {
                table2Timer.Stop();

                // Log Transaction 
                string cleanAmount2 = lblCurrentCharge2.Text.Replace("₱", "").Replace("P", "").Replace(",", "").Trim();
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TABLE = 2,
                    TYPE = "Regular",
                    DURATION = txtHours2.Text + " hours",
                    AMOUNT = Convert.ToDouble(cleanAmount2),
                    SESSION_END = DateTime.Now,
                    CUSTOMER = txtCustomer2.Text
                });
                SaveTransactionToDatabase("2", "Regular", txtHours2.Text, Convert.ToDouble(cleanAmount2), txtCustomer2.Text);

                // TELL THE BRAIN THE TABLE IS FREE!
                BilliardsState.TableStatuses["Table 2"] = false;
                BilliardsState.TableAssignments["Table 2"] = "";
                RefreshDashboardUI();

                // Reset the specific Table 2 numbers
                lblTimer2.Text = "00:00:00";
                lblCurrentCharge2.Text = "₱0.00";
                btnTable2.Text = "▷ START SESSION";
                btnTable2.BackColor = Color.FromArgb(34, 197, 94);
                txtHours2.Clear();
                txtHours2.Enabled = true;


            }
        }
        // table 3 clik
        private void btnTable3_Click(object sender, EventArgs e)
        {
            // --- IF WE ARE STARTING A SESSION ---
            if (btnTable3.Text.Contains("START"))
            {
                double hours;
                if (!double.TryParse(txtHours3.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours (e.g., 1 or 1.5).");
                    return;
                }
             
                if (hours < 1)
                {
                    hours = 1; // Force the computer to use 1 hour
                    txtHours3.Text = "1"; // Update the textbox so the customer sees it!
                }

                // 1. Calculate charge (100 per hour)
                double charge = hours * 100;
                lblCurrentCharge3.Text = "₱" + charge.ToString("N2");

                // 2. Start Timer
                table3TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer3.Text = table3TimeRemaining.ToString(@"hh\:mm\:ss");
                table3Timer.Start();

                // 3. Update UI for running state
                lblStatus3.Text = "  ● IN USE";
                lblStatus3.ForeColor = Color.OrangeRed;
                btnTable3.Text = "END SESSION";
                btnTable3.BackColor = Color.Firebrick;
                txtHours3.Enabled = false;

                // 4. Tell the Brain!
                BilliardsState.TableStatuses["Table 3"] = true;
                BilliardsState.TableAssignments["Table 3"] = txtCustomer3.Text;
                RefreshDashboardUI();
            }
            // --- IF WE ARE ENDING A SESSION ---
            else
            {
                table3Timer.Stop();

                // Log Transaction 
                string cleanAmount3 = lblCurrentCharge3.Text.Replace("₱", "").Replace("P", "").Replace(",", "").Trim();
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TABLE = 3,
                    TYPE = "Regular",
                    DURATION = txtHours3.Text + " hours",
                    AMOUNT = Convert.ToDouble(cleanAmount3),
                    SESSION_END = DateTime.Now,
                    CUSTOMER = txtCustomer3.Text
                });
                SaveTransactionToDatabase("3", "Regular", txtHours3.Text, Convert.ToDouble(cleanAmount3), txtCustomer3.Text);

                // TELL THE BRAIN THE TABLE IS FREE!
                BilliardsState.TableStatuses["Table 3"] = false;
                BilliardsState.TableAssignments["Table 3"] = "";
                RefreshDashboardUI();

                // Reset the specific Table 3 numbers
                lblTimer3.Text = "00:00:00";
                lblCurrentCharge3.Text = "₱0.00";
                btnTable3.Text = "▷ START SESSION";
                btnTable3.BackColor = Color.FromArgb(34, 197, 94);
                txtHours3.Clear();
                txtHours3.Enabled = true;
            }
        }

        // table 4 clik
        private void btnTable4_Click(object sender, EventArgs e)
        {
            // --- IF WE ARE STARTING A SESSION ---
            if (btnTable4.Text.Contains("START"))
            {
                double hours;
                if (!double.TryParse(txtHours4.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours (e.g., 1 or 1.5).");
                    return;
                }

                if (hours < 1)
                {
                    hours = 1; // Force the computer to use 1 hour
                    txtHours4.Text = "1"; // Update the textbox so the customer sees it!
                }

                // 1. Calculate charge (100 per hour)
                double charge = hours * 100;
                lblCurrentCharge4.Text = "₱" + charge.ToString("N2");

                // 2. Start Timer
                table4TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer4.Text = table4TimeRemaining.ToString(@"hh\:mm\:ss");
                table4Timer.Start();

                // 3. Update UI for running state
                lblStatus4.Text = "  ● IN USE";
                lblStatus4.ForeColor = Color.OrangeRed;
                btnTable4.Text = "END SESSION";
                btnTable4.BackColor = Color.Firebrick;
                txtHours4.Enabled = false;

                // 4. Tell the Brain!
                BilliardsState.TableStatuses["Table 4"] = true;
                BilliardsState.TableAssignments["Table 4"] = txtCustomer4.Text;
                RefreshDashboardUI();
            }
            // --- IF WE ARE ENDING A SESSION ---
            else
            {
                table4Timer.Stop();

                // Log Transaction 
                string cleanAmount4 = lblCurrentCharge4.Text.Replace("₱", "").Replace("P", "").Replace(",", "").Trim();
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TABLE = 4,
                    TYPE = "Regular",
                    DURATION = txtHours4.Text + " hours",
                    AMOUNT = Convert.ToDouble(cleanAmount4),
                    SESSION_END = DateTime.Now,
                    CUSTOMER = txtCustomer4.Text
                });
                SaveTransactionToDatabase("4", "Regular", txtHours4.Text, Convert.ToDouble(cleanAmount4), txtCustomer4.Text);

                // TELL THE BRAIN THE TABLE IS FREE!
                BilliardsState.TableStatuses["Table 4"] = false;
                BilliardsState.TableAssignments["Table 4"] = "";
                RefreshDashboardUI();

                // Reset the specific Table 4 numbers
                lblTimer4.Text = "00:00:00";
                lblCurrentCharge4.Text = "₱0.00";
                btnTable4.Text = "▷ START SESSION";
                btnTable4.BackColor = Color.FromArgb(34, 197, 94);
                txtHours4.Clear();
                txtHours4.Enabled = true;
            }
        }

        // table 5 clik
        private void btnTable5_Click(object sender, EventArgs e)
        {
            // --- IF WE ARE STARTING A SESSION ---
            if (btnTable5.Text.Contains("START"))
            {
                double hours;
                if (!double.TryParse(txtHours5.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours (e.g., 1 or 1.5).");
                    return;
                }

                if (hours < 1)
                {
                    hours = 1; // Force the computer to use 1 hour
                    txtHours5.Text = "1"; // Update the textbox so the customer sees it!
                }

                // 1. Calculate charge (100 per hour)
                double charge = hours * 100;
                lblCurrentCharge5.Text = "₱" + charge.ToString("N2");

                // 2. Start Timer
                table5TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer5.Text = table5TimeRemaining.ToString(@"hh\:mm\:ss");
                table5Timer.Start();

                // 3. Update UI for running state
                lblStatus5.Text = "  ● IN USE";
                lblStatus5.ForeColor = Color.OrangeRed;
                btnTable5.Text = "END SESSION";
                btnTable5.BackColor = Color.Firebrick;
                txtHours5.Enabled = false;

                // 4. Tell the Brain!
                BilliardsState.TableStatuses["Table 5"] = true;
                BilliardsState.TableAssignments["Table 5"] = txtCustomer5.Text;
                RefreshDashboardUI();
            }
            // --- IF WE ARE ENDING A SESSION ---
            else
            {
                table5Timer.Stop();

                // Log Transaction 
                string cleanAmount5 = lblCurrentCharge5.Text.Replace("₱", "").Replace("P", "").Replace(",", "").Trim();
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TABLE = 5,
                    TYPE = "Regular",
                    DURATION = txtHours5.Text + " hours",
                    AMOUNT = Convert.ToDouble(cleanAmount5),
                    SESSION_END = DateTime.Now,
                    CUSTOMER = txtCustomer5.Text
                });

                SaveTransactionToDatabase("5", "Regular", txtHours5.Text, Convert.ToDouble(cleanAmount5), txtCustomer5.Text);
                // TELL THE BRAIN THE TABLE IS FREE!
                BilliardsState.TableStatuses["Table 5"] = false;
                BilliardsState.TableAssignments["Table 5"] = "";
                RefreshDashboardUI();

                // Reset the specific Table 5 numbers
                lblTimer5.Text = "00:00:00";
                lblCurrentCharge5.Text = "₱0.00";
                btnTable5.Text = "▷ START SESSION";
                btnTable5.BackColor = Color.FromArgb(34, 197, 94);
                txtHours5.Clear();
                txtHours5.Enabled = true;
            }
        }

        // table 6 clik
        private void btnTable6_Click(object sender, EventArgs e)
        {

            // --- IF WE ARE STARTING A SESSION ---
            if (btnTable6.Text.Contains("START"))
            {
                double hours;
                if (!double.TryParse(txtHours6.Text, out hours) || hours <= 0)
                {
                    MessageBox.Show("Enter valid hours (e.g., 1 or 1.5).");
                    return;
                }

                if (hours < 1)
                {
                    hours = 1; // Force the computer to use 1 hour
                    txtHours6.Text = "1"; // Update the textbox so the customer sees it!
                }

                // 1. Calculate charge (100 per hour)
                double charge = hours * 100;
                lblCurrentCharge6.Text = "₱" + charge.ToString("N2");

                // 2. Start Timer
                table6TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer6.Text = table6TimeRemaining.ToString(@"hh\:mm\:ss");
                table6Timer.Start();

                // 3. Update UI for running state
                lblStatus6.Text = "  ● IN USE";
                lblStatus6.ForeColor = Color.OrangeRed;
                btnTable6.Text = "END SESSION";
                btnTable6.BackColor = Color.Firebrick;
                txtHours6.Enabled = false;

                // 4. Tell the Brain!
                BilliardsState.TableStatuses["Table 6"] = true;
                BilliardsState.TableAssignments["Table 6"] = txtCustomer6.Text;
                RefreshDashboardUI();
            }
            // --- IF WE ARE ENDING A SESSION ---
            else
            {
                table6Timer.Stop();

                // Log Transaction 
                string cleanAmount6 = lblCurrentCharge6.Text.Replace("₱", "").Replace("P", "").Replace(",", "").Trim();
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TABLE = 6,
                    TYPE = "Regular",
                    DURATION = txtHours6.Text + " hours",
                    AMOUNT = Convert.ToDouble(cleanAmount6),
                    SESSION_END = DateTime.Now,
                    CUSTOMER = txtCustomer6.Text
                });
                SaveTransactionToDatabase("6", "Regular", txtHours6.Text, Convert.ToDouble(cleanAmount6), txtCustomer6.Text);

                // TELL THE BRAIN THE TABLE IS FREE!
                BilliardsState.TableStatuses["Table 6"] = false;
                BilliardsState.TableAssignments["Table 6"] = "";
                RefreshDashboardUI();

                // Reset the specific Table 6 numbers
                lblTimer6.Text = "00:00:00";
                lblCurrentCharge6.Text = "₱0.00";
                btnTable6.Text = "▷ START SESSION";
                btnTable6.BackColor = Color.FromArgb(34, 197, 94);
                txtHours6.Clear();
                txtHours6.Enabled = true;
            }
        }
        // --- TABLE 7 VIP CLICK ---
        private void btnTable7_Click(object sender, EventArgs e)
        {
            // --- IF WE ARE STARTING A SESSION ---
            if (btnTable7.Text.Contains("START"))
            {
                double hours;

                // VIP RULE 1: The number MUST be 2 or higher!
                if (!double.TryParse(txtHours7.Text, out hours) || hours < 2)
                {
                    MessageBox.Show("VIP Tables require a minimum of 2 hours! Please enter 2 or more.", "VIP Requirement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // VIP RULE 2: Calculate charge (₱140 per hour = ₱280 for 2 hours)
                double charge = hours * 140;
                lblCurrentCharge7.Text = "₱" + charge.ToString("N2");

                // Start Timer
                table7TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer7.Text = table7TimeRemaining.ToString(@"hh\:mm\:ss");
                table7Timer.Start();

                // Update UI for running state
                lblStatus7.Text = "  ● IN USE";
                lblStatus7.ForeColor = Color.OrangeRed;
                btnTable7.Text = "END SESSION";
                btnTable7.BackColor = Color.Firebrick;
                txtHours7.Enabled = false;

                // Tell the Brain!
                BilliardsState.TableStatuses["Table 7"] = true;
                BilliardsState.TableAssignments["Table 7"] = txtCustomer7.Text;
                RefreshDashboardUI();
            }
            // --- IF WE ARE ENDING A SESSION ---
            else
            {
                table7Timer.Stop();

                // Save it to the database as a "VIP" transaction
                string cleanAmount7 = lblCurrentCharge7.Text.Replace("₱", "").Replace("P", "").Replace(",", "").Trim();
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TABLE = 7,
                    TYPE = "VIP",
                    DURATION = txtHours7.Text + " hours",
                    AMOUNT = Convert.ToDouble(cleanAmount7),
                    SESSION_END = DateTime.Now,
                    CUSTOMER = txtCustomer7.Text
                });
                SaveTransactionToDatabase("7", "VIP", txtHours7.Text, Convert.ToDouble(cleanAmount7), txtCustomer7.Text);

                // TELL THE BRAIN THE TABLE IS FREE
                BilliardsState.TableStatuses["Table 7"] = false;
                BilliardsState.TableAssignments["Table 7"] = "";
                RefreshDashboardUI();

                // Reset the screen, keep it Gold!
                lblTimer7.Text = "00:00:00";
                lblCurrentCharge7.Text = "₱0.00";
                btnTable7.Text = "▷ START SESSION";
                btnTable7.BackColor = Color.Goldenrod;
                txtHours7.Clear();
                txtHours7.Enabled = true;
            }
        }

        // --- TABLE 8 VIP CLICK ---
        private void btnTable8_Click(object sender, EventArgs e)
        {
            // --- IF WE ARE STARTING A SESSION ---
            if (btnTable8.Text.Contains("START"))
            {
                double hours;

                // VIP RULE 1: The number MUST be 2 or higher!
                if (!double.TryParse(txtHours8.Text, out hours) || hours < 2)
                {
                    MessageBox.Show("VIP Tables require a minimum of 2 hours! Please enter 2 or more.", "VIP Requirement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // VIP RULE 2: Calculate charge (₱140 per hour = ₱280 for 2 hours)
                double charge = hours * 140;
                lblCurrentCharge8.Text = "₱" + charge.ToString("N2");

                // Start Timer
                table8TimeRemaining = TimeSpan.FromHours(hours);
                lblTimer8.Text = table8TimeRemaining.ToString(@"hh\:mm\:ss");
                table8Timer.Start();

                // Update UI for running state
                lblStatus8.Text = "  ● IN USE";
                lblStatus8.ForeColor = Color.OrangeRed;
                btnTable8.Text = "END SESSION";
                btnTable8.BackColor = Color.Firebrick;
                txtHours8.Enabled = false;

                // Tell the Brain!
                BilliardsState.TableStatuses["Table 8"] = true;
                BilliardsState.TableAssignments["Table 8"] = txtCustomer8.Text;
                RefreshDashboardUI();
            }
            // --- IF WE ARE ENDING A SESSION ---
            else
            {
                table8Timer.Stop();

                // Save it to the database as a "VIP" transaction
                string cleanAmount8 = lblCurrentCharge8.Text.Replace("₱", "").Replace("P", "").Replace(",", "").Trim();
                GlobalData.DailyTransactions.Add(new Transaction
                {
                    TABLE = 8,
                    TYPE = "VIP",
                    DURATION = txtHours8.Text + " hours",
                    AMOUNT = Convert.ToDouble(cleanAmount8),
                    SESSION_END = DateTime.Now,
                    CUSTOMER = txtCustomer8.Text
                });
                SaveTransactionToDatabase("8", "VIP", txtHours8.Text, Convert.ToDouble(cleanAmount8), txtCustomer8.Text);

                // TELL THE BRAIN THE TABLE IS FREE
                BilliardsState.TableStatuses["Table 8"] = false;
                BilliardsState.TableAssignments["Table 8"] = "";
                RefreshDashboardUI();

                // Reset the screen, keep it Gold!
                lblTimer8.Text = "00:00:00";
                lblCurrentCharge8.Text = "₱0.00";
                btnTable8.Text = "▷ START SESSION";
                btnTable8.BackColor = Color.Goldenrod;
                txtHours8.Clear();
                txtHours8.Enabled = true;
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

        private void cardOccupied_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                //  subtract 1 from the width and height so the line stays  inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.cardOccupied.Width - 1, this.cardOccupied.Height - 1);
            }

        }

        private void cardTotalTables_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                //  subtract 1 from the width and height so the line stays  inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.cardTotalTables.Width - 1, this.cardTotalTables.Height - 1);
            }

        }

        private void cardAvailable_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                //  subtract 1 from the width and height so the line stays  inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.cardAvailable.Width - 1, this.cardAvailable.Height - 1);
            }
        }
        // --- THE MASTER SAVE METHOD ---
        private void SaveTransactionToDatabase(string tableNumber, string tableType, string hours, double amount, string customer)
        {
            try
            {
                using (var connection = new System.Data.SQLite.SQLiteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    string insertQuery = @"INSERT INTO Transactions 
                                     (TableNumber, TableType, TimePlayed, AmountPaid, TimeFinished, CustomerName) 
                                     VALUES (@table, @type, @duration, @amount, @timeFinished, @customer)";

                    using (var command = new System.Data.SQLite.SQLiteCommand(insertQuery, connection))
                    {
                        // It uses whatever flexible data was passed to it!
                        command.Parameters.AddWithValue("@table", tableNumber);
                        command.Parameters.AddWithValue("@type", tableType);
                        command.Parameters.AddWithValue("@duration", hours + " hours");
                        command.Parameters.AddWithValue("@amount", amount);
                        command.Parameters.AddWithValue("@timeFinished", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@customer", customer);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save transaction to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}












