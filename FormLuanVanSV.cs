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
    public partial class FormLuanVanSV : Form
    {
    
        public FormLuanVanSV()
        {
            InitializeComponent();  
         
        }

        private void tabCtrLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabCtrLV.SelectedIndex == 1)
            {
                this.Hide();
                Form f = new ListĐTĐK();
                f.ShowDialog();
            }

            if(tabCtrLV.SelectedIndex == 2) 
            {
                this.Hide();
                Form f = new FormSV();
                f.ShowDialog();
            }
        }
    }
}
