using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLuanVan
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void pbPwLock_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*') 
            {
                pbPwShow.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void pbPwShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                pbPwLock.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rbtnSV.Checked)
            {
                this.Hide();
                FormSV fsv = new FormSV();
                fsv.ShowDialog();
                this.Show();
            }
        }
    }
}
