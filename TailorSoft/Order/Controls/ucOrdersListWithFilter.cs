using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TailorSoft.Order.Forms;

namespace TailorSoft.Order.Controls
{
    public partial class ucOrdersListWithFilter : UserControl
    {
        private List<clsOrder> _Orders = clsOrder.GetAll();
        public ucOrdersListWithFilter()
        {
            InitializeComponent();
            InitializeUcOrderList();
            InitializeComboBoxFindBy();
        }

        private void InitializeUcOrderList()
        {
            ucOrdersList1.OnOrdersCountChanged += UcOrdersList1_OnOrdersCountChanged;
            ucOrdersList1.SetOrders(_Orders);
        }
        private void InitializeComboBoxFindBy()
        {
            cbFindBy.Items.Clear();
            cbFindBy.Items.Add("لا شيء");
            cbFindBy.Items.Add("رقم الطلب");
            cbFindBy.Items.Add("حالة الطلب");
            cbFindBy.Items.Add("تاريخ الطلب");
            cbFindBy.Items.Add("تاريخ التسليم");
            cbFindBy.Items.Add("اسم الزبون");
            cbFindBy.SelectedIndex = 0;

        }

        private void FilterOrdersListByOrderID(int  orderID)
        {
            ucOrdersList1.SetOrders(_Orders.Where(o => o.Id == orderID).ToList());
        }
        private void FilterOrdersListByStatus(byte status)
        {
            ucOrdersList1.SetOrders(_Orders.Where(o => o.Status == status).ToList());
        }
        private void FilterOrdersListByDate(DateTime date)
        {
            ucOrdersList1.SetOrders(_Orders.Where
                (o => o.OrderDate.ToShortDateString() == date.ToShortDateString()).ToList());
        }
        private void FilterOrdersListByRequiredDate(DateTime requiredDate)
        {
            ucOrdersList1.SetOrders(_Orders.Where
                (o => o.RequiredDate.ToShortDateString() == requiredDate.ToShortDateString()).ToList());
        }
        private void FilterOrdersListCustomerName(string customerName)
        {
            ucOrdersList1.SetOrders(_Orders.Where(o => o?.Customer?.Person?.FullName?.Contains(customerName) == true).ToList());
        }
        private void UcOrdersList1_OnOrdersCountChanged(int obj)
        {
            lblNumberOfOrders.Text = $"عدد الطلبات: {obj}";
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            using (frmAddOrder frm = new frmAddOrder())
            {
                frm.OnOrderSavedSuccessfully += (order) =>
                {
                    // Refresh the orders list after a new order is added
                    ucOrdersList1.SetOrders(clsOrder.GetAll());
                };
                frm.ShowDialog();
            }
        }

        private void ucOrdersListWithFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
