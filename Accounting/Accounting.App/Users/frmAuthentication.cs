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

namespace Accounting.App.Users
{
    public partial class frmAuthentication : Form
    {
        public frmAuthentication()
        {
            InitializeComponent();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var username = txtUserName.Text;
                var pass = txtPass.Text;
                if (!db.UserRepository.Get(u => u.UserName == username).Any() && pass != "")
                {
                    User user = new User()
                    {
                        UserName = username,
                        Password = pass
                    };
                    db.UserRepository.Insert(user);
                    db.Save();
                    Application.Restart();
                }
                else {
                    MessageBox.Show("اطلاعات وارد شده نا معتبر هست!", "هشدار",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var username = txtUserName.Text;
                var pass = txtPass.Text;
                User user = db.UserRepository.Get(u => u.UserName == username).First();
                if (user != null)
                {
                    if (user.Password == pass)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else {
                        MessageBox.Show("رمز عبور اشتباه است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else {
                    MessageBox.Show("کاربری یافت نشد.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}
