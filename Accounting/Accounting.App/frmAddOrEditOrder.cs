using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.ViewModel.Mobiles;

namespace Accounting.App
{
    public partial class frmAddOrEditOrder : Form
    {
        public int OrderID = 0;
        public frmAddOrEditOrder()
        {
            InitializeComponent();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            if (OrderID == 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Order order = new Order()
                    {
                        ProductID = Convert.ToInt32(cbProducts.SelectedValue.ToString()),
                        ProductName = cbProducts.Text,
                        Date = DateTime.Now,
                        Amount = (int)nudAmount.Value,
                        Number = (int)nudNumber.Value,
                        Description = txtDescription.Text
                    };
                    db.OrderRepository.Insert(order);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var order = db.OrderRepository.GetById(OrderID);
                    order.ProductID = Convert.ToInt32(cbProducts.SelectedValue.ToString());
                    order.ProductName = cbProducts.Text;
                    order.Amount = (int)nudAmount.Value;
                    order.Number = (int)nudNumber.Value;
                    order.Description = txtDescription.Text;

                    db.OrderRepository.Update(order);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void frmAddOrEditOrder_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ProductList> list = new List<ProductList>();
                if (OrderID != 0)
                {
                    this.Text = "ویرایش سفارش";
                    btnSumbit.Text = "ویرایش";
                    var order = db.OrderRepository.GetById(OrderID);
                    nudAmount.Value = order.Amount;
                    nudNumber.Value = order.Number;
                    txtDescription.Text = order.Description;
                    list.Add(new ProductList() { ProductID = order.ProductID, ProductName = order.ProductName });
                }
                else
                {
                    list.Add(new ProductList() { ProductID = 0, ProductName = "انتخاب کنید" });
                }
                var products = db.ProductRepository.Get();
                foreach (var product in products)
                {
                    list.Add(new ProductList() { ProductID = product.ProductID, ProductName = product.ProductName });
                }
                cbProducts.DataSource = list;
                cbProducts.DisplayMember = "ProductName";
                cbProducts.ValueMember = "ProductID";
            }
        }
    }
}
