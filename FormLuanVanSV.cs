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

        private void lblDK_MouseEnter(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.label_MouseEnter(sender, e);
        }

        private void lblDK_MouseLeave(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.label_MouseLeave(sender, e);
        }

        private void lblDTDK_MouseEnter(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.label_MouseEnter(sender, e);
        }

        private void lblDTDK_MouseLeave(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.label_MouseLeave(sender, e);
        }

        private void lblBack_MouseEnter(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.label_MouseEnter(sender, e);
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.label_MouseLeave(sender, e);
        }


        public event Action DKDTLabelClicked;
        private void lblDK_Click(object sender, EventArgs e)
        {
            DKDTLabelClicked?.Invoke();
        }

        public event Action KiemTraDTLabelClicked;
        private void lblKiemTra_Click(object sender, EventArgs e)
        {
            KiemTraDTLabelClicked?.Invoke();
        }

     
    }
}
