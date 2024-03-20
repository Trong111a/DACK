namespace QuanLyLuanVan
{
    partial class FormLuanVanSV
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
            this.pnTieuDe = new System.Windows.Forms.Panel();
            this.pnDTDK = new System.Windows.Forms.Panel();
            this.lblKiemTra = new System.Windows.Forms.Label();
            this.pnDK = new System.Windows.Forms.Panel();
            this.lblDK = new System.Windows.Forms.Label();
            this.pnLV = new System.Windows.Forms.Panel();
            this.pbDTDK = new System.Windows.Forms.PictureBox();
            this.pbDK = new System.Windows.Forms.PictureBox();
            this.pnTieuDe.SuspendLayout();
            this.pnDTDK.SuspendLayout();
            this.pnDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDTDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDK)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTieuDe
            // 
            this.pnTieuDe.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnTieuDe.Controls.Add(this.pnDTDK);
            this.pnTieuDe.Controls.Add(this.pnDK);
            this.pnTieuDe.Location = new System.Drawing.Point(1, 1);
            this.pnTieuDe.Name = "pnTieuDe";
            this.pnTieuDe.Size = new System.Drawing.Size(1071, 48);
            this.pnTieuDe.TabIndex = 0;
            // 
            // pnDTDK
            // 
            this.pnDTDK.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnDTDK.Controls.Add(this.pbDTDK);
            this.pnDTDK.Controls.Add(this.lblKiemTra);
            this.pnDTDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDTDK.Location = new System.Drawing.Point(230, 4);
            this.pnDTDK.Name = "pnDTDK";
            this.pnDTDK.Size = new System.Drawing.Size(216, 41);
            this.pnDTDK.TabIndex = 2;
            // 
            // lblKiemTra
            // 
            this.lblKiemTra.AutoSize = true;
            this.lblKiemTra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKiemTra.Location = new System.Drawing.Point(51, 9);
            this.lblKiemTra.Name = "lblKiemTra";
            this.lblKiemTra.Size = new System.Drawing.Size(157, 23);
            this.lblKiemTra.TabIndex = 0;
            this.lblKiemTra.Text = "Đề tài đã đăng ký";
            this.lblKiemTra.Click += new System.EventHandler(this.lblKiemTra_Click);
            this.lblKiemTra.MouseEnter += new System.EventHandler(this.lblDTDK_MouseEnter);
            this.lblKiemTra.MouseLeave += new System.EventHandler(this.lblDTDK_MouseLeave);
            // 
            // pnDK
            // 
            this.pnDK.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnDK.Controls.Add(this.pbDK);
            this.pnDK.Controls.Add(this.lblDK);
            this.pnDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDK.Location = new System.Drawing.Point(3, 4);
            this.pnDK.Name = "pnDK";
            this.pnDK.Size = new System.Drawing.Size(191, 41);
            this.pnDK.TabIndex = 1;
            
            // 
            // lblDK
            // 
            this.lblDK.AutoSize = true;
            this.lblDK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDK.Location = new System.Drawing.Point(51, 9);
            this.lblDK.Name = "lblDK";
            this.lblDK.Size = new System.Drawing.Size(132, 23);
            this.lblDK.TabIndex = 0;
            this.lblDK.Text = "Đăng ký đề tài";
            this.lblDK.Click += new System.EventHandler(this.lblDK_Click);
            this.lblDK.MouseEnter += new System.EventHandler(this.lblDK_MouseEnter);
            this.lblDK.MouseLeave += new System.EventHandler(this.lblDK_MouseLeave);
            // 
            // pnLV
            // 
            this.pnLV.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnLV.Location = new System.Drawing.Point(1, 76);
            this.pnLV.Name = "pnLV";
            this.pnLV.Size = new System.Drawing.Size(1071, 492);
            this.pnLV.TabIndex = 1;
            // 
            // pbDTDK
            // 
            this.pbDTDK.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Content;
            this.pbDTDK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDTDK.Location = new System.Drawing.Point(5, 3);
            this.pbDTDK.Name = "pbDTDK";
            this.pbDTDK.Size = new System.Drawing.Size(40, 35);
            this.pbDTDK.TabIndex = 1;
            this.pbDTDK.TabStop = false;
            // 
            // pbDK
            // 
            this.pbDK.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Hand_With_Pen;
            this.pbDK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDK.Location = new System.Drawing.Point(5, 3);
            this.pbDK.Name = "pbDK";
            this.pbDK.Size = new System.Drawing.Size(40, 35);
            this.pbDK.TabIndex = 1;
            this.pbDK.TabStop = false;
            // 
            // FormLuanVanSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1074, 570);
            this.Controls.Add(this.pnLV);
            this.Controls.Add(this.pnTieuDe);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormLuanVanSV";
            this.Text = "FormLuanVanSV";
            this.pnTieuDe.ResumeLayout(false);
            this.pnDTDK.ResumeLayout(false);
            this.pnDTDK.PerformLayout();
            this.pnDK.ResumeLayout(false);
            this.pnDK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDTDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTieuDe;
        private System.Windows.Forms.Panel pnDK;
        private System.Windows.Forms.PictureBox pbDK;
        private System.Windows.Forms.Label lblDK;
        private System.Windows.Forms.Panel pnDTDK;
        private System.Windows.Forms.PictureBox pbDTDK;
        private System.Windows.Forms.Label lblKiemTra;
        private System.Windows.Forms.Panel pnLV;
    }
}