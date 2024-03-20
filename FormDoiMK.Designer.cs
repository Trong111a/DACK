namespace QuanLyLuanVan
{
    partial class FormDoiMK
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
            this.pnDoiMK = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.lblMKmoi = new System.Windows.Forms.Label();
            this.lblMKcu = new System.Windows.Forms.Label();
            this.pnDoiMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDoiMK
            // 
            this.pnDoiMK.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnDoiMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDoiMK.Controls.Add(this.btnHuy);
            this.pnDoiMK.Controls.Add(this.btnDongY);
            this.pnDoiMK.Controls.Add(this.txtNhapLai);
            this.pnDoiMK.Controls.Add(this.txtMKmoi);
            this.pnDoiMK.Controls.Add(this.txtMKcu);
            this.pnDoiMK.Controls.Add(this.lblNhapLai);
            this.pnDoiMK.Controls.Add(this.lblMKmoi);
            this.pnDoiMK.Controls.Add(this.lblMKcu);
            this.pnDoiMK.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDoiMK.Location = new System.Drawing.Point(3, 4);
            this.pnDoiMK.Name = "pnDoiMK";
            this.pnDoiMK.Size = new System.Drawing.Size(565, 229);
            this.pnDoiMK.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(372, 170);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 35);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(249, 170);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(98, 35);
            this.btnDongY.TabIndex = 7;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(249, 125);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(235, 22);
            this.txtNhapLai.TabIndex = 6;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Location = new System.Drawing.Point(249, 79);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(235, 22);
            this.txtMKmoi.TabIndex = 5;
            // 
            // txtMKcu
            // 
            this.txtMKcu.Location = new System.Drawing.Point(249, 31);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(235, 22);
            this.txtMKcu.TabIndex = 4;
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapLai.Location = new System.Drawing.Point(28, 125);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(205, 23);
            this.lblNhapLai.TabIndex = 3;
            this.lblNhapLai.Text = "Nhập lại mật khẩu mới:";
            // 
            // lblMKmoi
            // 
            this.lblMKmoi.AutoSize = true;
            this.lblMKmoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKmoi.Location = new System.Drawing.Point(99, 78);
            this.lblMKmoi.Name = "lblMKmoi";
            this.lblMKmoi.Size = new System.Drawing.Size(134, 23);
            this.lblMKmoi.TabIndex = 2;
            this.lblMKmoi.Text = "Mật khẩu mới:";
            // 
            // lblMKcu
            // 
            this.lblMKcu.AutoSize = true;
            this.lblMKcu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKcu.Location = new System.Drawing.Point(111, 28);
            this.lblMKcu.Name = "lblMKcu";
            this.lblMKcu.Size = new System.Drawing.Size(122, 23);
            this.lblMKcu.TabIndex = 1;
            this.lblMKcu.Text = "Mật khẩu cũ:";
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 235);
            this.Controls.Add(this.pnDoiMK);
            this.Name = "FormDoiMK";
            this.Text = "FormDoiMK";
            this.pnDoiMK.ResumeLayout(false);
            this.pnDoiMK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDoiMK;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.Label lblNhapLai;
        private System.Windows.Forms.Label lblMKmoi;
        private System.Windows.Forms.Label lblMKcu;
        private System.Windows.Forms.Button btnHuy;
    }
}