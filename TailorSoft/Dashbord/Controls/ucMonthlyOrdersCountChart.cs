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
using TailorSoft_Models;

namespace TailorSoft.Dashbord.Controls
{
    public partial class ucMonthlyOrdersCountChart : UserControl
    {
        private Chart chart = new Chart
        {
            Dock = DockStyle.Fill,
            RightToLeft = RightToLeft.Yes
        };

        Series series = new Series("عدد الطلبات")
        {
            ChartType = SeriesChartType.Column,
            IsValueShownAsLabel = true,
            Font = new System.Drawing.Font("Tahoma", 12),
            XValueType = ChartValueType.String,
            IsXValueIndexed = true
        };

        string[] months = { "يناير", "فبراير", "مارس", "أبريل", "ماي", "يونيو",
                        "يوليوز", "غشت", "شتنبر", "أكتوبر", "نونبر", "دجنبر" };
        public ucMonthlyOrdersCountChart()
        {
            InitializeComponent();
            ShowMonthlyOrdersChart();
        }
        private void ShowMonthlyOrdersChart()
        {
            
            ChartArea chartArea = new ChartArea("الطلبات_الشهرية");
            chartArea.AxisX.Title = "الأشهر";
            chartArea.AxisY.Title = "عدد الطلبات";

            chartArea.AxisX.TitleFont = new Font("Tahoma", 12);
            chartArea.AxisY.TitleFont = new Font("Tahoma", 12);

            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.LineWidth = 0;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;  

            chart.ChartAreas.Add(chartArea);
            int i = 0;
            foreach (clsOrderStatisticsDTO orderStatistics in clsGlobal.orderStatisticsDTOs)
            {
                series.Points.AddXY(months[i], orderStatistics.NumberOfOrders);
                i++;
            }

            chart.Series.Add(series);

            Title chartTitle = new Title("إحصائيات الطلبات الشهرية", Docking.Top,
                new System.Drawing.Font("Tahoma", 14, System.Drawing.FontStyle.Bold),
                System.Drawing.Color.Black);
            chart.Titles.Add(chartTitle);

            this.Controls.Add(chart);
        }
        public void RefreshData()
        {
            chart.Series.Clear();
            series.Points.Clear();
            int i = 0;
            foreach (clsOrderStatisticsDTO orderStatistics in clsGlobal.orderStatisticsDTOs)
            {
                series.Points.AddXY(months[i], orderStatistics.NumberOfOrders);
                i++;
            }
            chart.Series.Add(series);
        }

    }
}
