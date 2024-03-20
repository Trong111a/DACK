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
    public partial class FormLuanVanGV : Form
    {
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
    }
}
