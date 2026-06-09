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

        private ucDashboard mainDashboard = new ucDashboard();
        private ucQueue queueScreen = new ucQueue();
        private ucReservation reservationScreen = new ucReservation();
        private ucSettings settingsScreen = new ucSettings();

        public Form1()
        {
            InitializeComponent();
            DatabaseHelper.InitializeDatabase();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            mainDashboard.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(mainDashboard);
            mainDashboard.RefreshDashboardUI();

            ResetAllMenuButtons();

            lblDashboardIcon.ForeColor = activeIcon;
            btnDashboard.ForeColor = activeText;
        }
        private void ResetAllMenuButtons()
        {

            lblDashboardIcon.ForeColor = inactiveTextIcon;
            btnDashboard.ForeColor = inactiveTextIcon;

            lblreporticon.ForeColor = inactiveTextIcon;
            btnReports.ForeColor = inactiveTextIcon;

            lblQueueIcon.ForeColor = inactiveTextIcon;
            btnQueue.ForeColor = inactiveTextIcon;

            lblReservationIcon.ForeColor = inactiveTextIcon;
            btnReservation.ForeColor = inactiveTextIcon;

            lblSettingsIcon.ForeColor = inactiveTextIcon;
            btnSettings.ForeColor = inactiveTextIcon;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();
            ucReports reportsPage = new ucReports();
            reportsPage.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(reportsPage);



            ResetAllMenuButtons();

            lblreporticon.ForeColor = activeIcon;
            btnReports.ForeColor = activeText;
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            queueScreen.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(queueScreen);


            ResetAllMenuButtons();

            lblQueueIcon.ForeColor = activeIcon;
            btnQueue.ForeColor = activeText;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            reservationScreen.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(reservationScreen);


            ResetAllMenuButtons();

            lblReservationIcon.ForeColor = activeIcon;
            btnReservation.ForeColor = activeText;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            settingsScreen.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(settingsScreen);


            ResetAllMenuButtons();
            lblSettingsIcon.ForeColor = activeIcon;
            btnSettings.ForeColor = activeIcon;

        }



        private void btnLogoutmain_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out and lock the system?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // 2. The Magic Command: This completely shuts down the app's memory and re-opens the Program.cs file from scratch (which launches your Login screen!)
                Application.Restart();
            }
        }



    }
}
   
    

