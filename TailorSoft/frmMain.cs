using HFS.Product.Forms;
using TailorSoft_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TailorSoft.Product.Forms;
using TailorSoft.Product.Controls;
using TailorSoft.Customer.Controls;
using TailorSoft.Order.Controls;
using System.Diagnostics;

namespace TailorSoft
{
    public partial class frmMain : Form
    {
        private int _MenuHeight = 60; // Height of the menu strip
        private ucProductListWithFilter? _ucProductListWithFilter1;
        private ucCustomersList? _ucCustomersList1;
        private ucOrdersListWithFilter? _ucOrdersList1;


        public frmMain()
        {
            InitializeComponent();
        }

        // Methods
        private void InitializeUcProductListWithFilter()
        {
            _ucProductListWithFilter1 = new ucProductListWithFilter();
            _ucProductListWithFilter1.Location = new Point(0, _MenuHeight);
            _ucProductListWithFilter1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _ucProductListWithFilter1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - _MenuHeight);
            _ucProductListWithFilter1.BackColor = Color.White;
            _ucProductListWithFilter1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(_ucProductListWithFilter1);
        }
        private void InitializeUcCustomersList()
        {
            _ucCustomersList1 = new ucCustomersList();
            _ucCustomersList1.Location = new Point(0, _MenuHeight);
            _ucCustomersList1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _ucCustomersList1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - _MenuHeight);
            _ucCustomersList1.BackColor = Color.White;
            _ucCustomersList1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(_ucCustomersList1);
        }
        private void InitializeUcOrdersList()
        {
            _ucOrdersList1 = new ucOrdersListWithFilter();
            _ucOrdersList1.Location = new Point(0, _MenuHeight);
            _ucOrdersList1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _ucOrdersList1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - _MenuHeight);
            _ucOrdersList1.BackColor = Color.White;
            _ucOrdersList1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(_ucOrdersList1);
        }

        private void tsmiProducts_Click(object sender, EventArgs e)
        {
            if (_ucProductListWithFilter1 == null)
            {
                InitializeUcProductListWithFilter();
            }
            else
            {
                _ucProductListWithFilter1.BringToFront();
            }
        }

        private void tsmiCustomers_Click(object sender, EventArgs e)
        {
            if (_ucCustomersList1 == null)
            {
                InitializeUcCustomersList();
            }
            else
            {
                _ucCustomersList1.BringToFront();
            }
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            // Ensure minimum width for the form
            if (this.Width < 1280 || this.Height < 800)
            {
                this.Width = 1280;
                this.Height = 800;
            }
            this.msMain.Padding = new Padding((this.Width / 4) + 200, 0, 0, 0);

        }

        private void tsmiOrders_Click(object sender, EventArgs e)
        {
            if (_ucOrdersList1 == null)
            {
                InitializeUcOrdersList();
            }
            else
            {
                _ucOrdersList1.BringToFront();
            }
        }

        private void msMain_SizeChanged(object sender, EventArgs e)
        {
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_ucProductListWithFilter1 != null && _ucProductListWithFilter1._cts != null && _ucProductListWithFilter1._cts.Token.CanBeCanceled)
                {
                    _ucProductListWithFilter1._cts?.Cancel();
                }
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show($"Error while closing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while closing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
