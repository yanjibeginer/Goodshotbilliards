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
    public partial class frmAssignTable : Form
    {
        public string CustomerToAssign { get; set; }

        // Modify this part to require a string name!
        public frmAssignTable(string customerName)
        {
            InitializeComponent();

            CustomerToAssign = customerName;
            lblcustomername.Text = CustomerToAssign; // Display the name on the form for confirmation

            cbtables.Items.Clear();
            foreach (var table in BilliardsState.TableStatuses)
            {
                cbtables.Items.Add("               " + table.Key); // Added spaces for your UI design!
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the popup
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
            if (cbtables.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table.", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedTable = cbtables.SelectedItem.ToString().Trim();

            // Stop them if the table is already taken!
            if (BilliardsState.TableStatuses[selectedTable] == true)
            {
                MessageBox.Show("That table is already occupied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- SAVE TO THE BRAIN ---
            // 1. Mark table as Occupied
            BilliardsState.TableStatuses[selectedTable] = true;
            BilliardsState.TriggerStateChanged();
            // 2. Save the customer's name to that table
            BilliardsState.TableAssignments[selectedTable] = this.CustomerToAssign;

            // 3. Close the popup successfully
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbtables_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblcustomername.Focus();
            if (cbtables.SelectedIndex == -1) return;

            // 1. Grab the table name and chop off the spaces
            string selectedTable = cbtables.SelectedItem.ToString().Trim();

            // 2. Ask the Brain: Is this table occupied?
            bool isOccupied = BilliardsState.TableStatuses[selectedTable];

            // 3. Change colors based on the REAL answer
            if (isOccupied == true)
            {
                lbltblstatus.Text = "Occupied";
                lbltblstatus.ForeColor = Color.FromArgb(239, 68, 68);
            }
            else
            {
                lbltblstatus.Text = "Available";
                lbltblstatus.ForeColor = Color.FromArgb(0, 219, 100);
            }}



    }
}