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
    public partial class frmAddOrEditMobile : Form
    {
        //public int MobileID = 0;
        public frmAddOrEditMobile()
        {
            InitializeComponent();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            //    using (UnitOfWork db = new UnitOfWork())
            //    {
            //        if (MobileID == 0)
            //        {
            //            var new_mobile = new MobileModel()
            //            {
            //                Model = txtModel.Text,
            //                Brand = txtBrand.Text,
            //                Amount = Convert.ToString(nudAmount.Value)
            //            };
            //            db.MobileRepository.Insert(new_mobile);
            //        }
            //        else {
            //            var mobile = db.MobileRepository.GetById(MobileID);
            //            mobile.Model = txtModel.Text;
            //            mobile.Brand = txtBrand.Text;
            //            mobile.Amount = Convert.ToString(nudAmount.Value);

            //            db.MobileRepository.Update(mobile);
            //        }
            //        db.Save();
            //        DialogResult = DialogResult.OK;
            //    }
        }

        private void frmAddOrEditMobile_Load(object sender, EventArgs e)
        {
            //    if (MobileID != 0)
            //    {
            //        this.Text = "ویرایش";
            //        btnSumbit.Text = "ویرایش";
            //        using (UnitOfWork db = new UnitOfWork())
            //        {
            //            var mobile = db.MobileRepository.GetById(MobileID);
            //            txtModel.Text = mobile.Model;
            //            txtBrand.Text = mobile.Brand;
            //            nudAmount.Value  = Convert.ToDecimal(mobile.Amount);
            //        }
            //    }
        }
    }
}
