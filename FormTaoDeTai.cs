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
    public partial class FormTaoDeTai : Form
    {
        public FormTaoDeTai()
        {
            InitializeComponent();
        }

        public event Action TaoDTButtonClicked;
        private void btnTaoDT_Click(object sender, EventArgs e)
        {
            TaoDTButtonClicked?.Invoke();
        }
    }
}
