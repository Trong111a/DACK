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
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        public event Action HuyBoButtonClicked;
        private void btnHuy_Click(object sender, EventArgs e)
        {
            HuyBoButtonClicked?.Invoke();
        }
    }
}
