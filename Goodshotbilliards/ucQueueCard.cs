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
    public partial class ucQueueCard : UserControl
    {
        public event EventHandler OnAssignClicked;
        public ucQueueCard()
        {
            InitializeComponent();
        }

        public string CustomerName
        {
            get { return lblCustomerName.Text; }
            set { lblCustomerName.Text = value; }
        }

        public string ArrivalTime
        {
            get { return lblArrival.Text; }
            set { lblArrival.Text = value; }

        }
        public string QueueNumber
        {
            get { return lblQueueNumber.Text; } // Make sure 'lblNumber' matches the actual Name of your "#1" label!
            set { lblQueueNumber.Text = value; }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            // 1. Define your subtle greyish-blue border color
            // This RGB (45, 55, 75) is specifically picked to look great against your 17, 24, 39 panel!
            Color borderColor = Color.FromArgb(100, 45, 55, 70);

            // 2. Draw the border
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                // We subtract 1 from the width and height so the line stays perfectly inside the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.pnlqueueholder.Width - 1, this.pnlqueueholder.Height - 1);
            }
        }

        private void btnAssigntable_Click(object sender, EventArgs e)
        {
            //  OnAssignClicked?.Invoke(this, e);
            // 1. Grab the name from THIS specific queue card
            string nameToPass = lblCustomerName.Text;

            using (frmAssignTable popup = new frmAssignTable(nameToPass))
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    // THE NUCLEAR DELETE:
                    this.Hide();     // 1. Instantly make the card invisible
                    this.Dispose();  // 2. Completely destroy the card from the computer's memor



                }
            }
        }
    }
}







