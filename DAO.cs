using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QuanLyLuanVan
{
    class DAO
    { 
        public void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.BackColor = Color.LightGray;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Refresh();
            }
        }

        public void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                pictureBox.BorderStyle = BorderStyle.None;
                pictureBox.BackColor = Color.Transparent;
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                pictureBox.Refresh();
            }
        }

        public void Thoat(object sender, EventArgs args)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void label_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = SystemColors.Highlight;
        }

        public void label_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.Red;
        }

        public void btnHome_Click(Panel pnNoiDung, Label lblTieuDe, PictureBox pbTieuDe, Size initialPanelSize)
        {
            foreach (Control control in pnNoiDung.Controls)
            {
                control.Visible = false;
            }

            lblTieuDe.Text = "Trang của bạn";
            System.Drawing.Image newImage = Properties.Resources.Home_Page;
            pbTieuDe.Image = newImage;

            System.Drawing.Image image = Properties.Resources.Ảnh_chụp_màn_hình_2024_03_16_000120;
            PictureBox pb = new PictureBox();
            pb.Image = image;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pnNoiDung.Size = initialPanelSize;
            pb.Size = pnNoiDung.Size;
            pnNoiDung.BackgroundImageLayout = ImageLayout.Stretch;
            pnNoiDung.Controls.Add(pb);
        }

        public void btnPw_Click(Panel pnNoiDung, Label lblTieuDe, PictureBox pbTieuDe, Size initialPanelSize)
        {
            foreach (Control control in pnNoiDung.Controls)
            {
                control.Visible = false;
            }
            lblTieuDe.Text = "Đổi mật khẩu";
            System.Drawing.Image newImageMK = Properties.Resources.Lease;
            pbTieuDe.Image = newImageMK;

            FormDoiMK fmk = new FormDoiMK();
            fmk.FormBorderStyle = FormBorderStyle.None;
            fmk.TopLevel = false;
            pnNoiDung.Controls.Add(fmk);
            pnNoiDung.Size = fmk.Size;
            fmk.Dock = DockStyle.Fill;
            fmk.Show();

            fmk.HuyBoButtonClicked += () =>
            {
                lblTieuDe.Text = "Trang của bạn";
                System.Drawing.Image newImage = Properties.Resources.Home_Page;
                pbTieuDe.Image = newImage;

                pnNoiDung.Controls.Remove(fmk);
                System.Drawing.Image image = Properties.Resources.Ảnh_chụp_màn_hình_2024_03_16_000120;
                PictureBox pb = new PictureBox();
                pb.Image = image;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pnNoiDung.Size = initialPanelSize;
                pb.Size = pnNoiDung.Size;
                pnNoiDung.BackgroundImageLayout = ImageLayout.Stretch;
                pnNoiDung.Controls.Add(pb);
            };
        }

        public void btnInfo_Click(Panel pnNoiDung, Label lblTieuDe, PictureBox pbTieuDe, string doituong)
        {
            foreach (Control control in pnNoiDung.Controls)
            {
                control.Visible = false;
            }
            if (doituong == "Sinh viên")
            {
                lblTieuDe.Text = "Hồ sơ sinh viên";
                System.Drawing.Image newImage = Properties.Resources.Male_User;
                pbTieuDe.Image = newImage;

                FormThongTinSV ftt = new FormThongTinSV();
                ftt.FormBorderStyle = FormBorderStyle.None;
                ftt.TopLevel = false;
                pnNoiDung.Controls.Add(ftt);
                pnNoiDung.Size = ftt.Size;
                ftt.Dock = DockStyle.Fill;
                ftt.Show();

                ftt.UpdateButtonClicked += () =>
                {
                    FormCapNhatTTSV fcn = new FormCapNhatTTSV();
                    pnNoiDung.Controls.Remove(ftt);
                    fcn.FormBorderStyle = FormBorderStyle.None;
                    fcn.TopLevel = false;
                    pnNoiDung.Controls.Add(fcn);
                    pnNoiDung.Size = fcn.Size;
                    fcn.Dock = DockStyle.Fill;
                    fcn.Show();

                    fcn.SaveButtonClicked += () =>
                    {
                        pnNoiDung.Controls.Remove(fcn);
                        pnNoiDung.Controls.Add(ftt);
                        string mssv = GlobalVariables.Instance.globalVariablesMSSV;
                        ftt.LoadStudentData(mssv);
                        ftt.Show();
                    };

                    fcn.ThoatButtonClicked += () =>
                    {
                        pnNoiDung.Controls.Remove(fcn);
                        pnNoiDung.Controls.Add(ftt);
                        ftt.Show();
                    };
                };
            }
            else
            {
                lblTieuDe.Text = "Hồ sơ giảng viên";
                System.Drawing.Image newImage = Properties.Resources.Male_User;
                pbTieuDe.Image = newImage;

                FormThongTinGV ftt = new FormThongTinGV();
                ftt.FormBorderStyle = FormBorderStyle.None;
                ftt.TopLevel = false;
                pnNoiDung.Controls.Add(ftt);
                pnNoiDung.Size = ftt.Size;
                ftt.Dock = DockStyle.Fill;
                ftt.Show();

                ftt.UpdateButtonClicked += () =>
                {
                    FormCapNhatTTGV fcn = new FormCapNhatTTGV();
                    pnNoiDung.Controls.Remove(ftt);
                    fcn.FormBorderStyle = FormBorderStyle.None;
                    fcn.TopLevel = false;
                    pnNoiDung.Controls.Add(fcn);
                    pnNoiDung.Size = fcn.Size;
                    fcn.Dock = DockStyle.Fill;
                    fcn.Show();

                    fcn.SaveButtonClicked += () =>
                    {
                        pnNoiDung.Controls.Remove(fcn);
                        pnNoiDung.Controls.Add(ftt);
                        ftt.Show();
                    };
                };
            }
        }
    }
}
