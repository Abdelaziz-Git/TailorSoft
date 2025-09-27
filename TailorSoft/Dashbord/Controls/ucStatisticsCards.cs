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
using TailorSoft_Business_Layer;
using TailorSoft_Models;

namespace TailorSoft.Dashbord.Controls
{
    public partial class ucStatisticsCards : UserControl
    {
        public ucStatisticsCards()
        {
            InitializeComponent();
            RefreshStatisticsCards();
        }
        public void RefreshStatisticsCards()
        {
            lblTotalOrders.Text = clsOrder.GetAll().Count.ToString();
            lblTotalCustomers.Text = clsCustomer.GetAll().Count.ToString();
            lblTotalProducts.Text = clsProduct.GetAllActiveProductsCount().ToString();
            decimal TotalIncomePerYear = 0; 
            foreach (clsOrderStatisticsDTO orderStatistics in clsGlobal.orderStatisticsDTOs)
            {
                TotalIncomePerYear += orderStatistics.TotalIncome;
            }
            lblAnnualIncome.Text = TotalIncomePerYear.ToString("F1") + " د.م";   
        }
    }
}
