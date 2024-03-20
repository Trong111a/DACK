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
    public partial class FormChiTietLuanVanSV : Form
    {
        public FormChiTietLuanVanSV()
        {
            InitializeComponent();
        }


        public event Action BackButtonClicked;
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke();
        }


        public event Action ChiTietButtonClicked;
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietButtonClicked?.Invoke();
        }
    }
}
