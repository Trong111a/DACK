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
    public partial class FormChiTietLuanVanGV : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8PSQBN9;Initial Catalog=QLLV;Integrated Security=True");
        public FormChiTietLuanVanGV()
        {
            InitializeComponent();
        }


        public event Action TabExitClicked;
        private void tabCtrTieuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabCtrTieuDe.SelectedIndex == 3) 
            {
                TabExitClicked?.Invoke();
            }
        }

        private void FormChiTietLuanVanGV_Load(object sender, EventArgs e)
        {
            
        }

        private void cbDuyetDT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDeTai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbChonDT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
