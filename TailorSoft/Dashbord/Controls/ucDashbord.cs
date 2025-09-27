using HFS.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TailorSoft.Dashbord.Controls
{
    public partial class ucDashbord : UserControl
    {
        public ucDashbord()
        {
            InitializeComponent();
        }
        public void RefreshData()
        {
            clsGlobal.orderStatisticsDTOs = clsOrder.GetOrdersStatisticsForEachMonthByYear(DateTime.Now.Year);
            ucStatisticsCards1.RefreshStatisticsCards();
            ucMonthlyIncomeChart1.RefreshData();
            ucMonthlyOrdersCountChart1.RefreshData();
        }
    }
}
