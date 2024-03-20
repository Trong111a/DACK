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
    public partial class FormChucNangLuanVanSV : Form
    {
        public FormChucNangLuanVanSV()
        {
            InitializeComponent();
        }

        public event Action TabExitClicked;
        private void tabCtrTieuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabCtrTieuDe.SelectedIndex == 3)
                TabExitClicked?.Invoke();
        }
    }
}
