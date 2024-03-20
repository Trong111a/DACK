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
    public partial class FormCapNhatTTGV : Form
    {
        public FormCapNhatTTGV()
        {
            InitializeComponent();
        }

        public event Action SaveButtonClicked;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveButtonClicked?.Invoke();
        }
    }
}
