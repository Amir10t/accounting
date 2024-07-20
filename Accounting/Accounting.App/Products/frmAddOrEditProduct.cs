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
using Accounting.DataLayer;

namespace Accounting.App.Mobiles
{
    public partial class frmAddOrEditProduct : Form
    {
        public int ProductID = 0;
        public frmAddOrEditProduct()
        {
            InitializeComponent();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (ProductID == 0)
                {
                    var new_product = new Product()
                    {
                        ProductName = txtModel.Text,
                        ProductBrand = txtBrand.Text,
                        Amount = Convert.ToInt32(nudAmount.Value)
                    };
                    db.ProductRepository.Insert(new_product);
                }
                else
                {
                    var product = db.ProductRepository.GetById(ProductID);
                    product.ProductName = txtModel.Text;
                    product.ProductBrand = txtBrand.Text;
                    product.Amount = Convert.ToInt32(nudAmount.Value);

                    db.ProductRepository.Update(product);
                }
                db.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void frmAddOrEditProduct_Load(object sender, EventArgs e)
        {
            if (ProductID != 0)
            {
                this.Text = "ویرایش";
                btnSumbit.Text = "ویرایش";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var product = db.ProductRepository.GetById(ProductID);
                    txtModel.Text = product.ProductName;
                    txtBrand.Text = product.ProductBrand;
                    nudAmount.Value = Convert.ToDecimal(product.Amount);
                }
            }
        }
    }
}
