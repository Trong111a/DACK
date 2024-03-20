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
    public partial class FormCapNhatTTSV : Form
    {
        string mssv = GlobalVariables.Instance.globalVariablesMSSV;

        public FormCapNhatTTSV()
        {
            InitializeComponent();
        }

        public event Action SaveButtonClicked;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            UpdateStudentData(mssv);
            SaveButtonClicked?.Invoke();
        }

        private void UpdateStudentData(string mssv)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TRONG\SQLEXPRESS;Initial Catalog=QuanLyLuanVan;Integrated Security=True");
            try
            {
                conn.Open();
                string sql = "UPDATE SinhVien SET MSSV = @MSSV, HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, " +
                             "Lop = @Lop, Nganh = @Nganh, Email = @Email, SDT = @SDT WHERE MSSV = @OldMSSV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MSSV", txtId.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtName.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dpBirth.Value);
                cmd.Parameters.AddWithValue("@DiaChi", txtAddr.Text);
                cmd.Parameters.AddWithValue("@Lop", txtClass.Text);
                cmd.Parameters.AddWithValue("@Nganh", txtNganh.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SDT", txtPhone.Text);
                if (rbtnNam.Checked)
                {
                    cmd.Parameters.AddWithValue("@GioiTinh", "Nam");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@GioiTinh", "Nữ");
                }
                cmd.Parameters.AddWithValue("@OldMSSV", mssv);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên có MSSV = " + mssv);
                }

                string updateMatKhauQuery = @"update NguoiDung set TaiKhoan = @NewMSSV Where TaiKhoan = @OldMSSV";

                SqlCommand updateMatKhauCmd = new SqlCommand(updateMatKhauQuery, conn);
                updateMatKhauCmd.Parameters.AddWithValue("@NewMSSV", txtId.Text);
                updateMatKhauCmd.Parameters.AddWithValue("@OldMSSV", mssv);
                updateMatKhauCmd.ExecuteNonQuery();
                GlobalVariables.Instance.MSSV = txtId.Text;
                GlobalVariables.Instance.globalVariablesMSSV = txtId.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public event Action ThoatButtonClicked;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            ThoatButtonClicked?.Invoke();
        }
    }
}
