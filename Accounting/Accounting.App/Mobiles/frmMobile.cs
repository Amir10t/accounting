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
    public partial class frmMobile : Form
    {
        public frmMobile()
        {
            InitializeComponent();
        }

        private void frmMobile_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvMobiles.AutoGenerateColumns = false;
                dgvMobiles.DataSource = db.MobileRepository.Get();
            }
        }

        void Refresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvMobiles.AutoGenerateColumns = false;
                dgvMobiles.DataSource = db.MobileRepository.Get();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvMobiles.DataSource = db.MobileRepository.Get(m=> m.Model.Contains(txtSearch.Text)|| m.Brand.Contains(txtSearch.Text) || m.Amount.Contains(txtSearch.Text));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            txtSearch.Text = "";
        }

        private void btnAddMobile_Click(object sender, EventArgs e)
        {
            frmAddOrEditMobile frm = new frmAddOrEditMobile();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void btnEditMobile_Click(object sender, EventArgs e)
        {
            int MobileID = (int)dgvMobiles.CurrentRow.Cells[0].Value;
            frmAddOrEditMobile frm = new frmAddOrEditMobile();
            frm.MobileID = MobileID;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void btnDeleteMobile_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                int MobileID = (int)dgvMobiles.CurrentRow.Cells[0].Value;
                var mobile = db.MobileRepository.GetById(MobileID);
                if (MessageBox.Show($"ایا از حذف {mobile.Model} مطمین هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.MobileRepository.Delete(mobile);
                    db.Save();
                    Refresh();
                }
            }
        }
    }
}
