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
    public partial class ucMonthlyIncomeChart : UserControl
    {
        private Chart chart = new Chart
        {
            Dock = DockStyle.Fill,
            RightToLeft = RightToLeft.Yes
        };
        Series series = new Series("الدخل الشهري")
        {
            ChartType = SeriesChartType.Column,
            IsValueShownAsLabel = true, // إظهار القيمة فوق العمود
            Font = new System.Drawing.Font("Tahoma", 9),
            XValueType = ChartValueType.String,
            IsXValueIndexed = true
        };
        string[] months = { "يناير", "فبراير", "مارس", "أبريل", "ماي", "يونيو",
                            "يوليوز", "غشت", "شتنبر", "أكتوبر", "نونبر", "دجنبر" };

        System.Drawing.Color[] colors = {
            System.Drawing.Color.DarkBlue,
            System.Drawing.Color.DarkGreen,
            System.Drawing.Color.DarkRed,
            System.Drawing.Color.Purple,
            System.Drawing.Color.Teal,
            System.Drawing.Color.Orange,
            System.Drawing.Color.Crimson,
            System.Drawing.Color.SteelBlue,
            System.Drawing.Color.ForestGreen,
            System.Drawing.Color.DarkGoldenrod,
            System.Drawing.Color.MediumVioletRed,
            System.Drawing.Color.CadetBlue
            };

        public ucMonthlyIncomeChart()
        {
            InitializeComponent();
            ShowMonthlyIncomeChart();
        }
        private void ShowMonthlyIncomeChart()
        {
            ChartArea chartArea = new ChartArea("الدخل_الشهري");
            chartArea.AxisX.Title = "الأشهر";
            chartArea.AxisY.Title = "الدخل بالدرهم";

            chartArea.AxisX.TitleFont = new Font("Tahoma", 12);
            chartArea.AxisY.TitleFont = new Font("Tahoma", 12);

            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Font = new System.Drawing.Font("Tahoma", 10);
            chartArea.AxisY.LabelStyle.Font = new System.Drawing.Font("Tahoma", 10);

            chartArea.AxisX.MajorGrid.LineWidth = 0;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;

            chart.ChartAreas.Add(chartArea);

            int i = 0;
            foreach(clsOrderStatisticsDTO orderStatistics in clsGlobal.orderStatisticsDTOs)
            {
                int pointIndex = series.Points.AddXY(months[i], orderStatistics.TotalIncome);
                series.Points[pointIndex].Color = colors[i];
                series.Points[pointIndex].Label = orderStatistics.TotalIncome % 1 == 0 ? orderStatistics.TotalIncome.ToString("F0") : orderStatistics.TotalIncome.ToString("F1");
                i++;
            }

            chart.Series.Add(series);

            Title chartTitle = new Title("إحصائيات الدخل الشهري بالدرهم", Docking.Top,
                new System.Drawing.Font("Tahoma", 12, System.Drawing.FontStyle.Bold),
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
                int pointIndex = series.Points.AddXY(months[i], orderStatistics.TotalIncome);
                series.Points[pointIndex].Color = colors[i];
                series.Points[pointIndex].Label = orderStatistics.TotalIncome % 1 == 0 ? orderStatistics.TotalIncome.ToString("F0") : orderStatistics.TotalIncome.ToString("F1");
                i++;
            }
            chart.Series.Add(series);
        }
    }
}
