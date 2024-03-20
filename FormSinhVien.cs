using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyLuanVan
{
    public partial class FormSinhVien : Form
    {
        private Size initialPanelSize;
        public FormSinhVien()
        {
            InitializeComponent();
            initialPanelSize = pnNoiDung.Size;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            FLogin f = new FLogin();
            f.Show();
            this.Hide();
        }

        private void pbLoad_Click(object sender, EventArgs e)
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

        private void pbBack_MouseEnter(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.pictureBox_MouseEnter(sender, e);
        }

        private void pbBack_MouseLeave(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.pictureBox_MouseLeave(sender, e);

        }

        private void pbLoad_MouseEnter(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.pictureBox_MouseEnter(sender, e);
        }

        private void pbLoad_MouseLeave(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.pictureBox_MouseLeave(sender, e);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.btnInfo_Click(pnNoiDung, lblTieuDe, pbTieuDe, "Sinh viên");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.btnHome_Click(pnNoiDung, lblTieuDe, pbTieuDe, initialPanelSize);
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
            FormLuanVanSV flv = new FormLuanVanSV();
            flv.FormBorderStyle = FormBorderStyle.None;
            flv.TopLevel = false;
            pnNoiDung.Controls.Add(flv);
            pnNoiDung.Size = flv.Size;
            flv.Dock = DockStyle.Fill;
            flv.Show();

            flv.DKDTLabelClicked += () =>
            {
                lblTieuDe.Text = "Đăng ký đề tài";
                System.Drawing.Image newImageDK = Properties.Resources.Hand_With_Pen;
                pbTieuDe.Image = newImageDK;

                pnNoiDung.Controls.Remove(flv);
                FormDKDeTai fdk = new FormDKDeTai();
                fdk.FormBorderStyle = FormBorderStyle.None;
                fdk.TopLevel = false;
                pnNoiDung.Controls.Add(fdk);
                pnNoiDung.Size = flv.Size;
                fdk.Dock = DockStyle.Fill;
                pnNoiDung.Controls.Add(fdk);
                fdk.Show();

                fdk.LuuDKButtonClicked += () =>
                {
                    lblTieuDe.Text = "Luận văn";
                    pbTieuDe.Image = newImageLV;
                    pnNoiDung.Controls.Remove(fdk);
                    pnNoiDung.Controls.Add(flv);
                    flv.Show();
                };
            };

            flv.KiemTraDTLabelClicked += () =>
            {
                lblTieuDe.Text = "Đề tài đã đăng ký";
                System.Drawing.Image newImageDK = Properties.Resources.Content;
                pbTieuDe.Image = newImageDK;

                pnNoiDung.Controls.Remove(flv);
                FormChiTietLuanVanSV fct = new FormChiTietLuanVanSV();
                fct.FormBorderStyle = FormBorderStyle.None;
                fct.TopLevel = false;
                pnNoiDung.Controls.Add(fct);
                pnNoiDung.Size = fct.Size;
                fct.Dock = DockStyle.Fill;
                fct.Show();

                fct.BackButtonClicked += () =>
                {
                    lblTieuDe.Text = "Luận văn";
                    pbTieuDe.Image = newImageLV;
                    pnNoiDung.Controls.Remove(fct);
                    pnNoiDung.Size = initialPanelSize;
                    pnNoiDung.Controls.Add(flv);
                    flv.Show();
                };

                fct.ChiTietButtonClicked += () =>
                {
                    lblTieuDe.Text = "Chi tiết luận văn";
                    System.Drawing.Image newImageCT = Properties.Resources.Checked_Radio_Button;
                    pbTieuDe.Image = newImageCT;
                    pnNoiDung.Controls.Remove(fct);
                    FormChucNangLuanVanSV fcn = new FormChucNangLuanVanSV();
                    fcn.FormBorderStyle = FormBorderStyle.None;
                    fcn.TopLevel = false;
                    pnNoiDung.Controls.Add(fcn);
                    pnNoiDung.Size = fcn.Size;
                    fcn.Dock = DockStyle.Fill;
                    fcn.Show();

                    fcn.TabExitClicked += () =>
                    {
                        lblTieuDe.Text = "Đề tài đã đăng ký";
                        pbTieuDe.Image = newImageDK;
                        pnNoiDung.Controls.Remove(fcn);
                        pnNoiDung.Size = fct.Size;
                        pnNoiDung.Controls.Add(fct);
                        fct.Show();
                    };
                };
             };
        }

        private void btnPw_Click(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.btnPw_Click(pnNoiDung, lblTieuDe, pbTieuDe, initialPanelSize);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DAO d = new DAO();
            d.Thoat(sender, e);
        }
    }
}
