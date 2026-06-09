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
    public partial class frmReservationAction : Form
    {
        public string ActionChosen { get; private set; }

        // Update this constructor to accept the customer data
        public frmReservationAction(string customer, string table, string time)
        {
            InitializeComponent();

            ActionChosen = "None"; // Default state

            // The Option 1 Conversational Text!
            lblMessage.Text = $"What would you like to do with {customer}'s\nreservation for {table} at {time}?";
        }

        private void btnCheckIN_Click(object sender, EventArgs e)
        {
            ActionChosen = "CheckIn";
            this.Close(); // Closes the popup
        }

        private void btnCancelRes_Click(object sender, EventArgs e)
        {
            ActionChosen = "Cancel";
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ActionChosen = "None";
            this.Close();
        }
    }
}