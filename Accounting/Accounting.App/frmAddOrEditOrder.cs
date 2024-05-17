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

        private void radioButton1_Click(object sender, EventArgs e)
        {
            txtAmount.ReadOnly = false;
        }

        private void rbOwnAmount_CheckedChanged(object sender, EventArgs e)
        {
            txtAmount.ReadOnly = true;
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            if (OrderID == 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    OrderModel order = new OrderModel()
                    {
                        MobileID = Convert.ToInt32(cbMobiles.SelectedValue.ToString()),
                        MobileModel = cbMobiles.Text,
                        Date = DateTime.Now,
                        Amount = (int)nudAmount.Value,
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
                    order.MobileID = Convert.ToInt32(cbMobiles.SelectedValue.ToString());
                    order.MobileModel = cbMobiles.Text;
                    order.Amount = (int)nudAmount.Value;
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
                List<MobileList> list = new List<MobileList>();
                if (OrderID != 0)
                {
                    this.Text = "ویرایش سفارش";
                    btnSumbit.Text = "ویرایش";
                    var order = db.OrderRepository.GetById(OrderID);
                    nudAmount.Value = order.Amount;
                    txtDescription.Text = order.Description;
                    list.Add(new MobileList() { MobileID = order.MobileID, MobileModel = order.MobileModel });
                }
                else
                {
                    list.Add(new MobileList() { MobileID = 0, MobileModel = "انتخاب کنید" });
                }
                var mobiles = db.MobileRepository.Get();
                foreach (var mobile in mobiles)
                {
                    list.Add(new MobileList() { MobileID = mobile.MobileID, MobileModel = mobile.Model });
                }
                cbMobiles.DataSource = list;
                cbMobiles.DisplayMember = "MobileModel";
                cbMobiles.ValueMember = "MobileID";
            }
        }
    }
}
