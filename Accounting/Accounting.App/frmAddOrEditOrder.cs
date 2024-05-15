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
                    MobileID = Convert.ToInt32(db.MobileRepository.Get(m => m.Model == cbMobiles.SelectedValue).Select(m => m.MobileID)),
                    Date = DateTime.Now,
                    Amount = (int)nudAmount.Value,
                    Description = txtDescription.Text
                };

                db.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void frmAddOrEditOrder_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var mobiles = db.MobileRepository.Get().Select(m => m.Model).ToList();
                foreach (var mobile in mobiles)
                {
                    cbMobiles.Items.Add(mobile);
                    txtDescription.Text += mobile.ToString();
                }
            }
        }
    }
}
