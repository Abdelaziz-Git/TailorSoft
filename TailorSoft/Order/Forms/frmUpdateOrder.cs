using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TailorSoft.Order.Forms
{
    public partial class frmUpdateOrder : Form
    {
        private clsOrder _order;
        public event Action<clsOrder>? OnOrderSavedSuccessfully;
        public frmUpdateOrder(clsOrder order)
        {
            InitializeComponent();
            _order = order;
            ucAddUpdateOrder1.SetOrder(order);
        }

        private void ucAddUpdateOrder1_OnButtonCloseClicked()
        {
            this.Close();
        }

        private void ucAddUpdateOrder1_OnOrderSavedSuccessfully(clsOrder obj)
        {
            this.OnOrderSavedSuccessfully?.Invoke(obj);
        }
    }
}
