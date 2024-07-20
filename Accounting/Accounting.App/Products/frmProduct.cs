using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;

namespace Accounting.App.Mobiles
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvProduct.AutoGenerateColumns = false;
                dgvProduct.DataSource = db.ProductRepository.Get();
            }
        }

        void RefreshGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvProduct.AutoGenerateColumns = false;
                dgvProduct.DataSource = db.ProductRepository.Get();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvProduct.DataSource = db.ProductRepository.Get(p => p.ProductName.Contains(txtSearch.Text) || p.ProductBrand.Contains(txtSearch.Text));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            txtSearch.Text = "";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddOrEditProduct frm = new frmAddOrEditProduct();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            int ProductID = (int)dgvProduct.CurrentRow.Cells[0].Value;
            frmAddOrEditProduct frm = new frmAddOrEditProduct();
            frm.ProductID = ProductID;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                int ProductID = (int)dgvProduct.CurrentRow.Cells[0].Value;
                var product = db.ProductRepository.GetById(ProductID);
                if (MessageBox.Show($"ایا از حذف {product.ProductName} مطمین هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.ProductRepository.Delete(product);
                    db.Save();
                    RefreshGrid();
                }
            }
        }
    }
}
