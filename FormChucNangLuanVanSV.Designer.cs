namespace QuanLyLuanVan
{
    partial class FormChucNangLuanVanSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtrTieuDe = new System.Windows.Forms.TabControl();
            this.tabTienDo = new System.Windows.Forms.TabPage();
            this.lbnTienDo = new System.Windows.Forms.Label();
            this.tabCapNhat = new System.Windows.Forms.TabPage();
            this.llbCapNhat = new System.Windows.Forms.Label();
            this.cbCapNhat = new System.Windows.Forms.ComboBox();
            this.tabDiem = new System.Windows.Forms.TabPage();
            this.lblDiem = new System.Windows.Forms.Label();
            this.tabExit = new System.Windows.Forms.TabPage();
            this.txtTienDo = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.tabCtrTieuDe.SuspendLayout();
            this.tabTienDo.SuspendLayout();
            this.tabCapNhat.SuspendLayout();
            this.tabDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrTieuDe
            // 
            this.tabCtrTieuDe.Controls.Add(this.tabTienDo);
            this.tabCtrTieuDe.Controls.Add(this.tabCapNhat);
            this.tabCtrTieuDe.Controls.Add(this.tabDiem);
            this.tabCtrTieuDe.Controls.Add(this.tabExit);
            this.tabCtrTieuDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrTieuDe.Location = new System.Drawing.Point(2, 2);
            this.tabCtrTieuDe.Name = "tabCtrTieuDe";
            this.tabCtrTieuDe.SelectedIndex = 0;
            this.tabCtrTieuDe.Size = new System.Drawing.Size(574, 304);
            this.tabCtrTieuDe.TabIndex = 0;
            this.tabCtrTieuDe.SelectedIndexChanged += new System.EventHandler(this.tabCtrTieuDe_SelectedIndexChanged);
            // 
            // tabTienDo
            // 
            this.tabTienDo.Controls.Add(this.txtTienDo);
            this.tabTienDo.Controls.Add(this.lbnTienDo);
            this.tabTienDo.Location = new System.Drawing.Point(4, 32);
            this.tabTienDo.Name = "tabTienDo";
            this.tabTienDo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTienDo.Size = new System.Drawing.Size(566, 268);
            this.tabTienDo.TabIndex = 0;
            this.tabTienDo.Text = "Tiến độ";
            this.tabTienDo.UseVisualStyleBackColor = true;
            // 
            // lbnTienDo
            // 
            this.lbnTienDo.AutoSize = true;
            this.lbnTienDo.Location = new System.Drawing.Point(19, 34);
            this.lbnTienDo.Name = "lbnTienDo";
            this.lbnTienDo.Size = new System.Drawing.Size(177, 23);
            this.lbnTienDo.TabIndex = 0;
            this.lbnTienDo.Text = "Bạn đã hoàn thành: ";
            // 
            // tabCapNhat
            // 
            this.tabCapNhat.Controls.Add(this.btnLuu);
            this.tabCapNhat.Controls.Add(this.llbCapNhat);
            this.tabCapNhat.Controls.Add(this.cbCapNhat);
            this.tabCapNhat.Location = new System.Drawing.Point(4, 32);
            this.tabCapNhat.Name = "tabCapNhat";
            this.tabCapNhat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCapNhat.Size = new System.Drawing.Size(566, 268);
            this.tabCapNhat.TabIndex = 1;
            this.tabCapNhat.Text = "Cập nhật tiến độ";
            this.tabCapNhat.UseVisualStyleBackColor = true;
            // 
            // llbCapNhat
            // 
            this.llbCapNhat.AutoSize = true;
            this.llbCapNhat.Location = new System.Drawing.Point(41, 28);
            this.llbCapNhat.Name = "llbCapNhat";
            this.llbCapNhat.Size = new System.Drawing.Size(93, 23);
            this.llbCapNhat.TabIndex = 1;
            this.llbCapNhat.Text = "Cập nhật:";
            // 
            // cbCapNhat
            // 
            this.cbCapNhat.FormattingEnabled = true;
            this.cbCapNhat.Location = new System.Drawing.Point(149, 25);
            this.cbCapNhat.Name = "cbCapNhat";
            this.cbCapNhat.Size = new System.Drawing.Size(59, 31);
            this.cbCapNhat.TabIndex = 0;
            // 
            // tabDiem
            // 
            this.tabDiem.Controls.Add(this.txtDiem);
            this.tabDiem.Controls.Add(this.lblDiem);
            this.tabDiem.Location = new System.Drawing.Point(4, 32);
            this.tabDiem.Name = "tabDiem";
            this.tabDiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiem.Size = new System.Drawing.Size(566, 268);
            this.tabDiem.TabIndex = 2;
            this.tabDiem.Text = "Xem điểm";
            this.tabDiem.UseVisualStyleBackColor = true;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(24, 38);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(140, 23);
            this.lblDiem.TabIndex = 0;
            this.lblDiem.Text = "Điểm đạt được:";
            // 
            // tabExit
            // 
            this.tabExit.Location = new System.Drawing.Point(4, 32);
            this.tabExit.Name = "tabExit";
            this.tabExit.Padding = new System.Windows.Forms.Padding(3);
            this.tabExit.Size = new System.Drawing.Size(566, 268);
            this.tabExit.TabIndex = 3;
            this.tabExit.Text = "Thoát";
            this.tabExit.UseVisualStyleBackColor = true;
            // 
            // txtTienDo
            // 
            this.txtTienDo.Location = new System.Drawing.Point(225, 27);
            this.txtTienDo.Name = "txtTienDo";
            this.txtTienDo.Size = new System.Drawing.Size(100, 30);
            this.txtTienDo.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(149, 84);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 34);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(180, 31);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 30);
            this.txtDiem.TabIndex = 1;
            // 
            // FormChucNangLuanVanSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 308);
            this.Controls.Add(this.tabCtrTieuDe);
            this.Name = "FormChucNangLuanVanSV";
            this.Text = "FormChiTietLV";
            this.tabCtrTieuDe.ResumeLayout(false);
            this.tabTienDo.ResumeLayout(false);
            this.tabTienDo.PerformLayout();
            this.tabCapNhat.ResumeLayout(false);
            this.tabCapNhat.PerformLayout();
            this.tabDiem.ResumeLayout(false);
            this.tabDiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrTieuDe;
        private System.Windows.Forms.TabPage tabTienDo;
        private System.Windows.Forms.TabPage tabCapNhat;
        private System.Windows.Forms.TabPage tabDiem;
        private System.Windows.Forms.TabPage tabExit;
        private System.Windows.Forms.Label lbnTienDo;
        private System.Windows.Forms.ComboBox cbCapNhat;
        private System.Windows.Forms.Label llbCapNhat;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.TextBox txtTienDo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtDiem;
    }
}