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
    public partial class ucReports : UserControl
    {
        public ucReports()
        {
            InitializeComponent();
        }
        // This runs every time the Reports page is opened
        private void ucReports_Load(object sender, EventArgs e)
        {
            // 1. Put the logbook data into the spreadsheet
            dgvReports.DataSource = null;
            dgvReports.DataSource = GlobalData.DailyTransactions;

            // 2. Format the columns to look nice (Optional but recommended)
            if (dgvReports.Columns.Count > 0)
            {
                dgvReports.Columns["AmountPaid"].DefaultCellStyle.Format = "₱0.00";
                dgvReports.Columns["TimeFinished"].DefaultCellStyle.Format = "hh:mm tt";


                // 2. CALCULATE KPI PANEL DATA
                if (GlobalData.DailyTransactions.Count > 0)
                {
                    // Total Revenue
                    double totalRevenue = GlobalData.DailyTransactions.Sum(t => t.AmountPaid);
                    lblTotalRevenueValue.Text = "₱" + totalRevenue.ToString("N2");

                    // VIP Revenue Only
                    double vipRevenue = GlobalData.DailyTransactions
                                                  .Where(t => t.TableType == "VIP")
                                                  .Sum(t => t.AmountPaid);
                    lblVipRevenueValue.Text = "₱" + vipRevenue.ToString("N2");

                    // Most Active Table
                    var mostActive = GlobalData.DailyTransactions
                                               .GroupBy(t => t.TableNumber)
                                               .OrderByDescending(g => g.Count())
                                               .First();
                    lblMostActiveValue.Text = "Table " + mostActive.Key;

                    // Total Sessions (for Average panel)
                    lblAvgTimeValue.Text = GlobalData.DailyTransactions.Count + " Sessions";
                }
            }
        }

     
        }
    }
