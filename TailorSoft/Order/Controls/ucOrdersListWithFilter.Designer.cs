namespace TailorSoft.Order.Controls
{
    partial class ucOrdersListWithFilter
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
            lblNumberOfOrders = new Label();
            txtSearch = new TextBox();
            btnAddNewOrder = new Button();
            cbFindBy = new ComboBox();
            label2 = new Label();
            ucOrdersList1 = new ucOrdersList();
            SuspendLayout();
            // 
            // lblNumberOfOrders
            // 
            lblNumberOfOrders.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNumberOfOrders.AutoEllipsis = true;
            lblNumberOfOrders.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblNumberOfOrders.Location = new Point(550, 320);
            lblNumberOfOrders.Name = "lblNumberOfOrders";
            lblNumberOfOrders.RightToLeft = RightToLeft.Yes;
            lblNumberOfOrders.Size = new Size(276, 19);
            lblNumberOfOrders.TabIndex = 17;
            lblNumberOfOrders.Text = "عدد الطلبات: 0";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI Light", 13.25F);
            txtSearch.Location = new Point(209, 49);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "ابحث ...";
            txtSearch.RightToLeft = RightToLeft.Yes;
            txtSearch.Size = new Size(329, 31);
            txtSearch.TabIndex = 23;
            // 
            // btnAddNewOrder
            // 
            btnAddNewOrder.BackColor = Color.WhiteSmoke;
            btnAddNewOrder.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnAddNewOrder.Image = Properties.Resources.add_icon_32;
            btnAddNewOrder.ImageAlign = ContentAlignment.TopCenter;
            btnAddNewOrder.Location = new Point(26, 30);
            btnAddNewOrder.Name = "btnAddNewOrder";
            btnAddNewOrder.RightToLeft = RightToLeft.Yes;
            btnAddNewOrder.Size = new Size(131, 69);
            btnAddNewOrder.TabIndex = 22;
            btnAddNewOrder.Text = "إضافة طلب جديد";
            btnAddNewOrder.TextAlign = ContentAlignment.BottomCenter;
            btnAddNewOrder.UseVisualStyleBackColor = false;
            btnAddNewOrder.Click += btnAddNewOrder_Click;
            // 
            // cbFindBy
            // 
            cbFindBy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFindBy.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbFindBy.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFindBy.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFindBy.FormattingEnabled = true;
            cbFindBy.Location = new Point(587, 52);
            cbFindBy.Name = "cbFindBy";
            cbFindBy.RightToLeft = RightToLeft.Yes;
            cbFindBy.Size = new Size(173, 25);
            cbFindBy.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(768, 55);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(58, 19);
            label2.TabIndex = 20;
            label2.Text = "البحث ب:";
            // 
            // ucOrdersList1
            // 
            ucOrdersList1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucOrdersList1.BackColor = Color.White;
            ucOrdersList1.Location = new Point(26, 128);
            ucOrdersList1.Name = "ucOrdersList1";
            ucOrdersList1.Size = new Size(800, 176);
            ucOrdersList1.TabIndex = 24;
            // 
            // ucOrdersListWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ucOrdersList1);
            Controls.Add(txtSearch);
            Controls.Add(btnAddNewOrder);
            Controls.Add(cbFindBy);
            Controls.Add(label2);
            Controls.Add(lblNumberOfOrders);
            Name = "ucOrdersListWithFilter";
            Size = new Size(859, 352);
            Load += ucOrdersListWithFilter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumberOfOrders;
        private TextBox txtSearch;
        private Button btnAddNewOrder;
        private ComboBox cbFindBy;
        private Label label2;
        private ucOrdersList ucOrdersList1;
    }
}
