
using HFS;
using TailorSoft.Customer.Controls;
using TailorSoft.Dashbord.Controls;
using TailorSoft.Order.Controls;
using TailorSoft.Product.Controls;
using TailorSoft.Store.Forms;

namespace TailorSoft
{
    public partial class frmMain : Form
    {
        private int _MenuHeight = 60; // Height of the menu strip
        private ucProductListWithFilter? _ucProductListWithFilter1;
        private ucCustomersList? _ucCustomersList1;
        private ucOrdersListWithFilter? _ucOrdersList1;
        private ucDashbord? _ucDashbord;

        public frmMain()
        {
            InitializeComponent();
            tsmiDashbord_Click(null, null);
        }

        // Methods
        private void InitializeDashbord()
        {
            _ucDashbord = new ucDashbord();
            _ucDashbord.Location = new Point(0, _MenuHeight);
            //_ucOrdersList1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _ucDashbord.Dock = DockStyle.Fill;
            _ucDashbord.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - _MenuHeight);
            _ucDashbord.BackColor = Color.White;
            _ucDashbord.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(_ucDashbord);
        }
        private void InitializeUcProductListWithFilter()
        {
            _ucProductListWithFilter1 = new ucProductListWithFilter();
            _ucProductListWithFilter1.Location = new Point(0, _MenuHeight);
            //_ucProductListWithFilter1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _ucProductListWithFilter1.Dock = DockStyle.Fill;
            _ucProductListWithFilter1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - _MenuHeight);
            _ucProductListWithFilter1.BackColor = Color.White;
            _ucProductListWithFilter1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(_ucProductListWithFilter1);
        }
        private void InitializeUcCustomersList()
        {
            _ucCustomersList1 = new ucCustomersList();
            _ucCustomersList1.Location = new Point(0, _MenuHeight);
            //_ucCustomersList1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _ucCustomersList1.Dock = DockStyle.Fill;
            _ucCustomersList1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - _MenuHeight);
            _ucCustomersList1.BackColor = Color.White;
            _ucCustomersList1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(_ucCustomersList1);
        }
        private void InitializeUcOrdersList()
        {
            _ucOrdersList1 = new ucOrdersListWithFilter();
            _ucOrdersList1.Location = new Point(0, _MenuHeight);
            //_ucOrdersList1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _ucOrdersList1.Dock = DockStyle.Fill;
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
                _ucProductListWithFilter1?.BringToFront();
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
                _ucCustomersList1?.BringToFront();
            }
            else
            {
                _ucCustomersList1.BringToFront();
                _ucCustomersList1.LoadAndRefreshData();
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
                _ucOrdersList1?.BringToFront();
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

        private void tsmiEditStoreInfo_Click(object sender, EventArgs e)
        {
            using (frmUpdateStoreInfo frm = new frmUpdateStoreInfo())
            {
                frm.ShowDialog();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void tsmiDashbord_Click(object sender, EventArgs e)
        {
            if (_ucDashbord == null)
            {
                InitializeDashbord();
                _ucDashbord?.BringToFront();
            }
            else
            {
                _ucDashbord.BringToFront();
                _ucDashbord.RefreshData();
            }
            
        }
    }
}
