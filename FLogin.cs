using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            DAO d = new DAO();
            d.Thoat(sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TRONG\SQLEXPRESS;Initial Catalog=QuanLyLuanVan;Integrated Security=True");
            try 
            {
                conn.Open();
                string nameLogin = txtNameLogin.Text;
                string password = txtPassword.Text;
                string sql = "select * from NguoiDung where TaiKhoan = '" + nameLogin + "' and MatKhau = '" + password + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    GlobalVariables.Instance.MSSV = txtNameLogin.Text;
                    GlobalVariables.Instance.globalVariablesMSSV = txtNameLogin.Text;
                if (rbtnSV.Checked)
                    {
                        FormSinhVien fsv = new FormSinhVien();
                        fsv.ShowDialog();
                    }
                    else
                    {
                        FormGiangVien fgv = new FormGiangVien();
                        fgv.ShowDialog();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    txtNameLogin.Text = "";
                    txtPassword.Text = "";
                    txtNameLogin.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
