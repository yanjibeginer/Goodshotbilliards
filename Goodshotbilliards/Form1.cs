using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goodshotbilliards
{

    public partial class Form1 : Form
    {
        // The neon green for the active icon
        Color activeIcon = Color.FromArgb(44, 226, 107);
        // White for the active text
        Color activeText = Color.White;
        // The dark sidebar background color
        // The gray color for unselected text and icons
        Color inactiveTextIcon = Color.FromArgb(160, 165, 181);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();
            ucDashboard dashPage = new ucDashboard();
            dashPage.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(dashPage);


            ResetAllMenuButtons();
          
            lblDashboardIcon.ForeColor = activeIcon;
            btnDashboard.ForeColor = activeText;
        }
        private void ResetAllMenuButtons()
        {

            lblDashboardIcon.ForeColor = inactiveTextIcon;
            btnDashboard.ForeColor = inactiveTextIcon;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();
            ucReports reportsPage = new ucReports();
            reportsPage.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(reportsPage);
        }
    }

    }
   
    

