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
    public partial class FormSV : Form
    {
        private Stack<Form> openedForms = new Stack<Form>();
        public FormSV()
        {
            InitializeComponent();
            openedForms.Push(this);
        }

        private void tabCtrSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabCtrSV.SelectedIndex == 1)
            {
                FormLuanVanSV lv = new FormLuanVanSV();
                this.Hide();
                lv.ShowDialog();

            }
            else if(tabCtrSV.SelectedIndex == 2)
            {
                this.Close();

            }
        }

        private void tabInfo_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
