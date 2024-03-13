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
    public partial class FormĐTĐK : Form
    {
        public FormĐTĐK()
        {
            InitializeComponent();
        }

        private void tabCtrĐT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabCtrĐT.SelectedIndex == 1) 
            {
                this.Hide();
                Form f = new FormTienDoSV();
                f.ShowDialog();
            }

            if(tabCtrĐT.SelectedIndex == 3) 
            {
                this.Hide();
                Form f = new ListĐTĐK();
                f.ShowDialog();
            }
        }
    }
}
