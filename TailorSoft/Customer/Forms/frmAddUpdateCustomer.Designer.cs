namespace TailorSoft.Customer.Forms
{
    partial class frmAddUpdateCustomer
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
            ucAddUpdateCustomer1 = new TailorSoft.Customers.Controls.ucAddUpdateCustomer();
            SuspendLayout();
            // 
            // ucAddUpdateCustomer1
            // 
            ucAddUpdateCustomer1.BackColor = Color.White;
            ucAddUpdateCustomer1.Dock = DockStyle.Fill;
            ucAddUpdateCustomer1.Location = new Point(0, 0);
            ucAddUpdateCustomer1.Name = "ucAddUpdateCustomer1";
            ucAddUpdateCustomer1.RightToLeft = RightToLeft.Yes;
            ucAddUpdateCustomer1.Size = new Size(832, 514);
            ucAddUpdateCustomer1.TabIndex = 0;
            ucAddUpdateCustomer1.OnCloseButtonClicked += ucAddUpdateCustomer1_OnCloseButtonClicked;
            ucAddUpdateCustomer1.OnCustomerSaved += ucAddUpdateCustomer1_OnCustomerSaved;
            // 
            // frmAddUpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 514);
            Controls.Add(ucAddUpdateCustomer1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUpdateCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Customers.Controls.ucAddUpdateCustomer ucAddUpdateCustomer1;
    }
}