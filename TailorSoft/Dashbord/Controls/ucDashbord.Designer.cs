namespace TailorSoft.Dashbord.Controls
{
    partial class ucDashbord
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ucStatisticsCards1 = new ucStatisticsCards();
            ucMonthlyIncomeChart1 = new ucMonthlyIncomeChart();
            ucMonthlyOrdersCountChart1 = new ucMonthlyOrdersCountChart();
            SuspendLayout();
            // 
            // ucStatisticsCards1
            // 
            ucStatisticsCards1.BackColor = Color.White;
            ucStatisticsCards1.Dock = DockStyle.Top;
            ucStatisticsCards1.Location = new Point(0, 0);
            ucStatisticsCards1.Name = "ucStatisticsCards1";
            ucStatisticsCards1.RightToLeft = RightToLeft.Yes;
            ucStatisticsCards1.Size = new Size(1112, 150);
            ucStatisticsCards1.TabIndex = 0;
            // 
            // ucMonthlyIncomeChart1
            // 
            ucMonthlyIncomeChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucMonthlyIncomeChart1.BackColor = Color.White;
            ucMonthlyIncomeChart1.BorderStyle = BorderStyle.Fixed3D;
            ucMonthlyIncomeChart1.Location = new Point(0, 151);
            ucMonthlyIncomeChart1.Name = "ucMonthlyIncomeChart1";
            ucMonthlyIncomeChart1.RightToLeft = RightToLeft.Yes;
            ucMonthlyIncomeChart1.Size = new Size(1112, 271);
            ucMonthlyIncomeChart1.TabIndex = 1;
            // 
            // ucMonthlyOrdersCountChart1
            // 
            ucMonthlyOrdersCountChart1.BackColor = Color.White;
            ucMonthlyOrdersCountChart1.Dock = DockStyle.Bottom;
            ucMonthlyOrdersCountChart1.Location = new Point(0, 420);
            ucMonthlyOrdersCountChart1.Name = "ucMonthlyOrdersCountChart1";
            ucMonthlyOrdersCountChart1.RightToLeft = RightToLeft.Yes;
            ucMonthlyOrdersCountChart1.Size = new Size(1112, 304);
            ucMonthlyOrdersCountChart1.TabIndex = 2;
            // 
            // ucDashbord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ucMonthlyOrdersCountChart1);
            Controls.Add(ucMonthlyIncomeChart1);
            Controls.Add(ucStatisticsCards1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ucDashbord";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1112, 724);
            ResumeLayout(false);
        }

        #endregion

        private ucStatisticsCards ucStatisticsCards1;
        private ucMonthlyIncomeChart ucMonthlyIncomeChart1;
        private ucMonthlyOrdersCountChart ucMonthlyOrdersCountChart1;
    }
}
