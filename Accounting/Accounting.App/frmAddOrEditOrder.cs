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

        private void frmAddOrEditOrder_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<MobileList> list = new List<MobileList>();
                list.Add(new MobileList() { MobileID = 0, MobileModel = "انتخاب کنید" });
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
