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
    public partial class FormThongTinSV : Form
    {
        string mssv = GlobalVariables.Instance.globalVariablesMSSV;
        public event Action UpdateButtonClicked;
        public FormThongTinSV()
        {
            InitializeComponent();
            LoadStudentData(mssv);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateButtonClicked?.Invoke();
        }

        public void LoadStudentData(string mssv)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TRONG\SQLEXPRESS;Initial Catalog=QuanLyLuanVan;Integrated Security=True");
            try
            {
                conn.Open();
                string sql = "select * from SinhVien where MSSV = @MSSV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MSSV", mssv);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    lblMssv.Text = rdr["MSSV"].ToString();
                    lblTen.Text = rdr["HoTen"].ToString();
                    DateTime NgaySinh = Convert.ToDateTime(rdr["NgaySinh"]);
                    lblNgaySinh.Text = NgaySinh.ToString("dd/MM/yyyy");
                    lblGioiTinh.Text = rdr["GioiTinh"].ToString();
                    lblDiaChi.Text = rdr["DiaChi"].ToString();
                    lblLop.Text = rdr["Lop"].ToString();
                    lblNganh.Text = rdr["Nganh"].ToString();
                    lblMail.Text = rdr["Email"].ToString();
                    lblSDT.Text = rdr["SDT"].ToString();
                }
                rdr.Close();
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
    }
}
