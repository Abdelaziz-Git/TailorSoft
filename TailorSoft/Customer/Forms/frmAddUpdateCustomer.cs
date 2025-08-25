using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TailorSoft_Business_Layer;

namespace TailorSoft.Customer.Forms
{
    public partial class frmAddUpdateCustomer : Form
    {
        public event Action<clsCustomer>? OnCustomerSaved;

        public frmAddUpdateCustomer()
        {
            InitializeComponent();
            ucAddUpdateCustomer1.AddNewCustomer();
        }
        public frmAddUpdateCustomer(clsCustomer obj)
        {
            InitializeComponent();
            ucAddUpdateCustomer1.LoadCustomerData(obj);
        }
        private void ucAddUpdateCustomer1_OnCloseButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucAddUpdateCustomer1_OnCustomerSaved(clsCustomer obj)
        {
            OnCustomerSaved?.Invoke(obj);
            this.Close();
        }
        
    }
}
