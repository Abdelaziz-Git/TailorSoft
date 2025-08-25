
using TailorSoft.Properties;
namespace TailorSoft
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msMain = new MenuStrip();
            tsmiProducts = new ToolStripMenuItem();
            tsmiCustomers = new ToolStripMenuItem();
            tsmiOrders = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.AutoSize = false;
            msMain.BackColor = Color.WhiteSmoke;
            msMain.ImageScalingSize = new Size(40, 40);
            msMain.Items.AddRange(new ToolStripItem[] { tsmiProducts, tsmiCustomers, tsmiOrders });
            msMain.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Padding = new Padding(251, 0, 0, 0);
            msMain.RenderMode = ToolStripRenderMode.Professional;
            msMain.Size = new Size(1004, 60);
            msMain.TabIndex = 3;
            msMain.Text = "menuStrip1";
            msMain.SizeChanged += msMain_SizeChanged;
            // 
            // tsmiProducts
            // 
            tsmiProducts.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsmiProducts.Image = Resources.Products_icon_32;
            tsmiProducts.ImageScaling = ToolStripItemImageScaling.None;
            tsmiProducts.ImageTransparentColor = Color.Transparent;
            tsmiProducts.Margin = new Padding(0, 0, 20, 0);
            tsmiProducts.Name = "tsmiProducts";
            tsmiProducts.RightToLeft = RightToLeft.Yes;
            tsmiProducts.ShortcutKeys = Keys.Control | Keys.D1;
            tsmiProducts.Size = new Size(131, 60);
            tsmiProducts.Text = "المنتجات";
            tsmiProducts.Click += tsmiProducts_Click;
            // 
            // tsmiCustomers
            // 
            tsmiCustomers.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsmiCustomers.Image = Resources.Customers_32;
            tsmiCustomers.ImageScaling = ToolStripItemImageScaling.None;
            tsmiCustomers.ImageTransparentColor = Color.Transparent;
            tsmiCustomers.Margin = new Padding(0, 0, 20, 0);
            tsmiCustomers.Name = "tsmiCustomers";
            tsmiCustomers.RightToLeft = RightToLeft.Yes;
            tsmiCustomers.ShortcutKeys = Keys.Control | Keys.D1;
            tsmiCustomers.Size = new Size(114, 60);
            tsmiCustomers.Text = "العملاء";
            tsmiCustomers.Click += tsmiCustomers_Click;
            // 
            // tsmiOrders
            // 
            tsmiOrders.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsmiOrders.Image = Resources.order_32;
            tsmiOrders.ImageScaling = ToolStripItemImageScaling.None;
            tsmiOrders.Margin = new Padding(0, 0, 20, 0);
            tsmiOrders.Name = "tsmiOrders";
            tsmiOrders.Size = new Size(113, 60);
            tsmiOrders.Text = "طلبات";
            tsmiOrders.TextImageRelation = TextImageRelation.TextBeforeImage;
            tsmiOrders.Click += tsmiOrders_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Resources.HFSMS_Logo;
            pictureBox1.Location = new Point(0, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1004, 510);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1004, 570);
            Controls.Add(pictureBox1);
            Controls.Add(msMain);
            IsMdiContainer = true;
            MainMenuStrip = msMain;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            SizeChanged += frmMain_SizeChanged;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem tsmiProducts;
        private ToolStripMenuItem tsmiCustomers;
        private PictureBox pictureBox1;
        private ToolStripMenuItem tsmiOrders;
    }
}