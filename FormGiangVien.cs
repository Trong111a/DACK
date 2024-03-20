using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLuanVan
{
    public partial class FormGiangVien : Form
    {
        private Size initialPanelSize;
        public FormGiangVien()
        {
            InitializeComponent();
            initialPanelSize = pnNoiDung.Size;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.btnHome_Click(pnNoiDung, lblTieuDe, pbTieuDe, initialPanelSize);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.Thoat(sender, e);
        }

        private void btnPw_Click(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.btnPw_Click(pnNoiDung, lblTieuDe, pbTieuDe, initialPanelSize);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.btnInfo_Click(pnNoiDung, lblTieuDe, pbTieuDe, "Giảng viên");
        }

        private void pbThoat_MouseEnter(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.pictureBox_MouseEnter(sender, e);
        }

        private void pbThoat_MouseLeave(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.pictureBox_MouseLeave(sender, e);
        }

        private void pbRefesh_MouseEnter(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.pictureBox_MouseEnter(sender, e);
        }

        private void pbRefesh_MouseLeave(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.pictureBox_MouseLeave(sender, e);
        }

        private void pbRefesh_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }
            Thread.Sleep(2000);
            foreach (Control control in Controls)
            {
                control.Visible = true;
            }
        }

        private void btnLV_Click(object sender, EventArgs e)
        {
            foreach (Control control in pnNoiDung.Controls)
            {
                control.Visible = false;
            }
            lblTieuDe.Text = "Luận văn";
            System.Drawing.Image newImageLV = Properties.Resources.Book_Stack;
            pbTieuDe.Image = newImageLV;

            pnNoiDung.Size = initialPanelSize;
            FormLuanVanGV flv = new FormLuanVanGV();
            flv.FormBorderStyle = FormBorderStyle.None;
            flv.TopLevel = false;
            pnNoiDung.Controls.Add(flv);
            pnNoiDung.Size = flv.Size;
            flv.Dock = DockStyle.Fill;
            flv.Show();

            flv.TaoDeTaiLabelClicked += () =>
            {
                lblTieuDe.Text = "Tạo đề tài";
                System.Drawing.Image newImageDK = Properties.Resources.Content;
                pbTieuDe.Image = newImageDK;

                pnNoiDung.Controls.Remove(flv);
                FormTaoDeTai fdt = new FormTaoDeTai();
                fdt.FormBorderStyle = FormBorderStyle.None;
                fdt.TopLevel = false;
                pnNoiDung.Controls.Add(fdt);
                pnNoiDung.Size = flv.Size;
                fdt.Dock = DockStyle.Fill;
                fdt.Show();

                fdt.TaoDTButtonClicked += () =>
                {
                    lblTieuDe.Text = "Luận văn";
                    pbTieuDe.Image = newImageLV;
                    pnNoiDung.Controls.Remove(fdt);
                    pnNoiDung.Controls.Add(flv);
                    flv.Show();
                };
            };

            flv.KiemTraLabelClicked += () =>
            {
                lblTieuDe.Text = "Chi tiết";
                System.Drawing.Image newImageKT = Properties.Resources.Done;
                pbTieuDe.Image = newImageKT;

                pnNoiDung.Controls.Remove(flv);
                FormChiTietLuanVanGV fct = new FormChiTietLuanVanGV();
                fct.FormBorderStyle = FormBorderStyle.None;
                fct.TopLevel = false;
                pnNoiDung.Controls.Add(fct);
                pnNoiDung.Size = fct.Size;
                fct.Dock = DockStyle.Fill;
                fct.Show();

                fct.TabExitClicked += () =>
                {
                    lblTieuDe.Text = "Luận văn";
                    pbTieuDe.Image = newImageLV;
                    pnNoiDung.Controls.Remove(fct);
                    pnNoiDung.Size = initialPanelSize;
                    pnNoiDung.Controls.Add(flv);
                    pnNoiDung.Size = flv.Size;
                    flv.Dock = DockStyle.Fill;
                    flv.Show();
                };

            };
        }
    }
}
