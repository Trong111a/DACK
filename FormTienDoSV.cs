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
    public partial class FormTienDoSV : Form
    {
        public FormTienDoSV()
        {
            InitializeComponent();
        }

        private void tabCtrTienDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabCtrTienDo.SelectedIndex == 2) 
            {
                this.Hide();
                Form f = new FormĐTĐK();
                f.ShowDialog();
            }
        }
    }
}
