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
    public partial class ucQueue : UserControl
    {
        int currentQueueCount = 1;
        public static ucQueue Instance;
        public ucQueue()
        {
            InitializeComponent();
            Instance = this;
        }

        private void ucQueue_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelqueue_Paint(object sender, PaintEventArgs e)
        {
            // 1. Define your subtle greyish-blue border color
            // This RGB (45, 55, 75) is specifically picked to look great against your 17, 24, 39 panel!
            Color borderColor = Color.FromArgb(100, 45, 55, 70);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                // We subtract 1 from the width and height so the line stays perfectly inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.flowLayoutPanelqueue.Width - 1, this.flowLayoutPanelqueue.Height - 1);
            }
        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "Enter customer name....")
            {
                txtCustomerName.Text = "";
            }
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                txtCustomerName.Text = "Enter customer name....";

            }
        }

        private void pnlCustomerInput_Paint(object sender, PaintEventArgs e)
        {

            Color borderColor = Color.FromArgb(100, 45, 55, 75);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                // -1 from the width and height so the line stays inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.pnlCustomerInput.Width - 1, this.pnlCustomerInput.Height - 1);
            }
        }

        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || txtCustomerName.Text == "Enter customer name....")
            {
                MessageBox.Show("Please enter a customer name first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // --- THE RESET CHECK ---
            // If there is nobody currently in the visual list...
            if (flowLayoutPanelqueue.Controls.Count == 0)
            {
                // Reset the tracker back to 1!
                currentQueueCount = 1;
            }
            // 2. Create a brand new copy of  card
            ucQueueCard newPerson = new ucQueueCard();

            // 3. put the  data into it
            newPerson.CustomerName = txtCustomerName.Text;
            newPerson.ArrivalTime = DateTime.Now.ToString("h:mm tt"); // Gets current time 

            newPerson.QueueNumber = "#" + currentQueueCount.ToString();
            currentQueueCount++;

            // Listen for this specific card's ASSIGN button to be clicked!
            newPerson.OnAssignClicked += (s, ev) =>
            {
                // 1. Create the popup and hand it the customer's name!
                frmAssignTable assignWindow = new frmAssignTable(newPerson.CustomerName);

                // 2. Show the popup on the screen as a dialog
                assignWindow.ShowDialog();
            };

            // 4. put name in  FlowLayoutPanel
            flowLayoutPanelqueue.Controls.Add(newPerson);

            // Clear the text box 
            txtCustomerName.Clear();
        }


            public void AddVipToQueue(string vipName)
        {
            // 1. Create a brand new copy of the card
            ucQueueCard newPerson = new ucQueueCard();

            // 2. Put the VIP data into it
            newPerson.CustomerName = vipName;
            newPerson.ArrivalTime = DateTime.Now.ToString("h:mm tt");
            newPerson.QueueNumber = "VIP"; // Give them a cool VIP tag instead of a normal number!

            // 3. Listen for the ASSIGN button (Exact same as your normal code!)
            newPerson.OnAssignClicked += (s, ev) =>
            {
                frmAssignTable assignWindow = new frmAssignTable(newPerson.CustomerName);
                assignWindow.ShowDialog();
            };

            // 4. Put them in the visual list...
            flowLayoutPanelqueue.Controls.Add(newPerson);

            // 5. THE MAGIC TRICK: Force this specific card to the absolute TOP of the queue!
            flowLayoutPanelqueue.Controls.SetChildIndex(newPerson, 0);
        }
    }
}

