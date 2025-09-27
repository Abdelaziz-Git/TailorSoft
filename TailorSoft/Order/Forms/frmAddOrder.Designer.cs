namespace TailorSoft.Order.Forms
{
    partial class frmAddOrder
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
            pnlSelectCustomer = new Panel();
            btnNext = new Button();
            ucCustomerCardWithFilter1 = new TailorSoft.Customer.Controls.ucCustomerCardWithFilter();
            lblTitle = new Label();
            pnlSelectCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSelectCustomer
            // 
            pnlSelectCustomer.Controls.Add(btnNext);
            pnlSelectCustomer.Controls.Add(ucCustomerCardWithFilter1);
            pnlSelectCustomer.Controls.Add(lblTitle);
            pnlSelectCustomer.Dock = DockStyle.Fill;
            pnlSelectCustomer.Location = new Point(0, 0);
            pnlSelectCustomer.Name = "pnlSelectCustomer";
            pnlSelectCustomer.RightToLeft = RightToLeft.Yes;
            pnlSelectCustomer.Size = new Size(1146, 705);
            pnlSelectCustomer.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom;
            btnNext.BackColor = Color.Gainsboro;
            btnNext.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnNext.Image = Properties.Resources.Next_Icon_White_32;
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(462, 585);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(10, 0, 20, 0);
            btnNext.Size = new Size(214, 71);
            btnNext.TabIndex = 19;
            btnNext.Text = "التالي";
            btnNext.TextAlign = ContentAlignment.MiddleLeft;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // ucCustomerCardWithFilter1
            // 
            ucCustomerCardWithFilter1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucCustomerCardWithFilter1.BackColor = Color.White;
            ucCustomerCardWithFilter1.Location = new Point(36, 91);
            ucCustomerCardWithFilter1.Name = "ucCustomerCardWithFilter1";
            ucCustomerCardWithFilter1.RightToLeft = RightToLeft.Yes;
            ucCustomerCardWithFilter1.Size = new Size(1070, 434);
            ucCustomerCardWithFilter1.TabIndex = 1;
            ucCustomerCardWithFilter1.OnCustomerSelected += ucCustomerCardWithFilter1_OnCustomerSelected;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Gainsboro;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DeepSkyBlue;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1146, 75);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "من فضلك, قم باختيار الزبون اولا.";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAddOrder
            // 
            AcceptButton = btnNext;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1146, 705);
            Controls.Add(pnlSelectCustomer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddOrder";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += frmAddOrder_FormClosing;
            KeyPress += frmAddOrder_KeyPress;
            KeyUp += frmAddOrder_KeyUp;
            pnlSelectCustomer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSelectCustomer;
        private Label lblTitle;
        private Customer.Controls.ucCustomerCardWithFilter ucCustomerCardWithFilter1;
        private Button btnNext;
    }
}