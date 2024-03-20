using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLuanVan
{
    public partial class FormLuanVanGV : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8PSQBN9;Initial Catalog=QLLV;Integrated Security=True");
        public FormLuanVanGV()
        {
            InitializeComponent();
        }

        private void lblTaoDT_MouseEnter(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.label_MouseEnter(sender, e);
        }

        private void lblTaoDT_MouseLeave(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.label_MouseLeave(sender, e);
        }

        private void lblKiemTra_MouseEnter(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.label_MouseEnter(sender, e);
        }

        private void lblKiemTra_MouseLeave(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.label_MouseLeave(sender, e);
        }

        public event Action TaoDeTaiLabelClicked;
        private void lblTaoDT_Click(object sender, EventArgs e)
        {
            TaoDeTaiLabelClicked?.Invoke();
        }

        public event Action KiemTraLabelClicked;
        private void lblKiemTra_Click(object sender, EventArgs e)
        {
            KiemTraLabelClicked?.Invoke();
        }

        private void FormLuanVanGV_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        private void HienThiDuLieu()
        {
            try
            {
                // Mở kết nối
                conn.Open();

                // Câu truy vấn SQL để lấy dữ liệu từ bảng DeTaiLuanVan
                string query = "SELECT * FROM DeTaiLuanVan";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(query, conn);

                // Tạo đối tượng SqlDataAdapter để lưu trữ dữ liệu
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Tạo đối tượng DataTable để hiển thị dữ liệu trên DataGridView
                DataTable dt = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(dt);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối sau khi sử dụng
                conn.Close();
            }
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
