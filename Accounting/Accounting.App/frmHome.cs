using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.App.Mobiles;
using Accounting.DataLayer.Context;
using Accounting.App.Users;

namespace Accounting.App
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            frmAuthentication frm = new frmAuthentication();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
                RefreshGrid();
                using (UnitOfWork db = new UnitOfWork())
                {
                    var user = db.UserRepository.GetById(frm.userID);
                    lblUser.Text = $"{user.UserName} خوش آمدید";
                    var orders = db.OrderRepository.Get();
                    int benefit = BenefitCalculator();
                    lblBenefit.Text = $"سود کلی شما : {Convert.ToString(benefit)}";
                }
            }
            else
            {
                Application.Exit();
            }
        }

        void RefreshGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvOrders.AutoGenerateColumns = false;
                dgvOrders.DataSource = db.OrderRepository.Get();
            }
            int benefit = BenefitCalculator();
            lblBenefit.Text = $"سود کلی شما : {Convert.ToString(benefit)}";
        }

        private int BenefitCalculator()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var orders = db.OrderRepository.Get();
                int benefit = 0;
                foreach (var order in orders)
                {
                    benefit += Convert.ToInt32(order.Amount);
                }

                return benefit;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvOrders.DataSource = db.OrderRepository.Get(o => o.ProductName.Contains(txtSearch.Text) || o.Description.Contains(txtSearch.Text));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                int OrderID = (int)dgvOrders.CurrentRow.Cells[0].Value;
                var order = db.OrderRepository.GetById(OrderID);
                if (MessageBox.Show($"ایا از حذف {order.Product} مطمین هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.OrderRepository.Delete(order);
                    db.Save();
                    RefreshGrid();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            txtSearch.Text = "";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmAddOrEditOrder frm = new frmAddOrEditOrder();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddOrEditOrder frm = new frmAddOrEditOrder();
            frm.OrderID = (int)dgvOrders.CurrentRow.Cells[0].Value;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void btnProductClick(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.ShowDialog();
        }
    }
}
