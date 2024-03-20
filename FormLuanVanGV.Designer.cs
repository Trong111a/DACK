namespace QuanLyLuanVan
{
    partial class FormLuanVanGV
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
            this.pnKiemTra = new System.Windows.Forms.Panel();
            this.lblKiemTra = new System.Windows.Forms.Label();
            this.pnTaoDT = new System.Windows.Forms.Panel();
            this.lblTaoDT = new System.Windows.Forms.Label();
            this.pnLV = new System.Windows.Forms.Panel();
            this.pbKiemTra = new System.Windows.Forms.PictureBox();
            this.pbTaoDT = new System.Windows.Forms.PictureBox();
            this.pnTieuDe.SuspendLayout();
            this.pnKiemTra.SuspendLayout();
            this.pnTaoDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKiemTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaoDT)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTieuDe
            // 
            this.pnTieuDe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnTieuDe.Controls.Add(this.pnKiemTra);
            this.pnTieuDe.Controls.Add(this.pnTaoDT);
            this.pnTieuDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTieuDe.Location = new System.Drawing.Point(0, 1);
            this.pnTieuDe.Name = "pnTieuDe";
            this.pnTieuDe.Size = new System.Drawing.Size(799, 49);
            this.pnTieuDe.TabIndex = 0;
            // 
            // pnKiemTra
            // 
            this.pnKiemTra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnKiemTra.Controls.Add(this.pbKiemTra);
            this.pnKiemTra.Controls.Add(this.lblKiemTra);
            this.pnKiemTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnKiemTra.Location = new System.Drawing.Point(196, 3);
            this.pnKiemTra.Name = "pnKiemTra";
            this.pnKiemTra.Size = new System.Drawing.Size(142, 41);
            this.pnKiemTra.TabIndex = 4;
            // 
            // lblKiemTra
            // 
            this.lblKiemTra.AutoSize = true;
            this.lblKiemTra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKiemTra.Location = new System.Drawing.Point(51, 9);
            this.lblKiemTra.Name = "lblKiemTra";
            this.lblKiemTra.Size = new System.Drawing.Size(73, 23);
            this.lblKiemTra.TabIndex = 0;
            this.lblKiemTra.Text = "Chi tiết";
            this.lblKiemTra.Click += new System.EventHandler(this.lblKiemTra_Click);
            this.lblKiemTra.MouseEnter += new System.EventHandler(this.lblKiemTra_MouseEnter);
            this.lblKiemTra.MouseLeave += new System.EventHandler(this.lblKiemTra_MouseLeave);
            // 
            // pnTaoDT
            // 
            this.pnTaoDT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnTaoDT.Controls.Add(this.pbTaoDT);
            this.pnTaoDT.Controls.Add(this.lblTaoDT);
            this.pnTaoDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTaoDT.Location = new System.Drawing.Point(12, 3);
            this.pnTaoDT.Name = "pnTaoDT";
            this.pnTaoDT.Size = new System.Drawing.Size(157, 41);
            this.pnTaoDT.TabIndex = 3;
            // 
            // lblTaoDT
            // 
            this.lblTaoDT.AutoSize = true;
            this.lblTaoDT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTaoDT.Location = new System.Drawing.Point(51, 9);
            this.lblTaoDT.Name = "lblTaoDT";
            this.lblTaoDT.Size = new System.Drawing.Size(95, 23);
            this.lblTaoDT.TabIndex = 0;
            this.lblTaoDT.Text = "Tạo đề tài";
            this.lblTaoDT.Click += new System.EventHandler(this.lblTaoDT_Click);
            this.lblTaoDT.MouseEnter += new System.EventHandler(this.lblTaoDT_MouseEnter);
            this.lblTaoDT.MouseLeave += new System.EventHandler(this.lblTaoDT_MouseLeave);
            // 
            // pnLV
            // 
            this.pnLV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnLV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLV.Location = new System.Drawing.Point(0, 94);
            this.pnLV.Name = "pnLV";
            this.pnLV.Size = new System.Drawing.Size(799, 351);
            this.pnLV.TabIndex = 1;
            // 
            // pbKiemTra
            // 
            this.pbKiemTra.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Done;
            this.pbKiemTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKiemTra.Location = new System.Drawing.Point(5, 3);
            this.pbKiemTra.Name = "pbKiemTra";
            this.pbKiemTra.Size = new System.Drawing.Size(40, 35);
            this.pbKiemTra.TabIndex = 1;
            this.pbKiemTra.TabStop = false;
            // 
            // pbTaoDT
            // 
            this.pbTaoDT.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Content;
            this.pbTaoDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTaoDT.Location = new System.Drawing.Point(5, 3);
            this.pbTaoDT.Name = "pbTaoDT";
            this.pbTaoDT.Size = new System.Drawing.Size(40, 35);
            this.pbTaoDT.TabIndex = 1;
            this.pbTaoDT.TabStop = false;
            // 
            // FormLuanVanGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnLV);
            this.Controls.Add(this.pnTieuDe);
            this.Name = "FormLuanVanGV";
            this.Text = "FormLuanVanGV";
            this.pnTieuDe.ResumeLayout(false);
            this.pnKiemTra.ResumeLayout(false);
            this.pnKiemTra.PerformLayout();
            this.pnTaoDT.ResumeLayout(false);
            this.pnTaoDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKiemTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaoDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTieuDe;
        private System.Windows.Forms.Panel pnLV;
        private System.Windows.Forms.Panel pnTaoDT;
        private System.Windows.Forms.PictureBox pbTaoDT;
        private System.Windows.Forms.Label lblTaoDT;
        private System.Windows.Forms.Panel pnKiemTra;
        private System.Windows.Forms.PictureBox pbKiemTra;
        private System.Windows.Forms.Label lblKiemTra;
    }
}