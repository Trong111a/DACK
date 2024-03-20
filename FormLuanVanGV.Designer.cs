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
            this.pbKiemTra = new System.Windows.Forms.PictureBox();
            this.lblKiemTra = new System.Windows.Forms.Label();
            this.pnTaoDT = new System.Windows.Forms.Panel();
            this.pbTaoDT = new System.Windows.Forms.PictureBox();
            this.lblTaoDT = new System.Windows.Forms.Label();
            this.pnLV = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnTieuDe.SuspendLayout();
            this.pnKiemTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKiemTra)).BeginInit();
            this.pnTaoDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaoDT)).BeginInit();
            this.pnLV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTieuDe
            // 
            this.pnTieuDe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnTieuDe.Controls.Add(this.pnKiemTra);
            this.pnTieuDe.Controls.Add(this.pnTaoDT);
            this.pnTieuDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTieuDe.Location = new System.Drawing.Point(0, 1);
            this.pnTieuDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTieuDe.Name = "pnTieuDe";
            this.pnTieuDe.Size = new System.Drawing.Size(599, 40);
            this.pnTieuDe.TabIndex = 0;
            // 
            // pnKiemTra
            // 
            this.pnKiemTra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnKiemTra.Controls.Add(this.pbKiemTra);
            this.pnKiemTra.Controls.Add(this.lblKiemTra);
            this.pnKiemTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnKiemTra.Location = new System.Drawing.Point(147, 2);
            this.pnKiemTra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnKiemTra.Name = "pnKiemTra";
            this.pnKiemTra.Size = new System.Drawing.Size(106, 33);
            this.pnKiemTra.TabIndex = 4;
            // 
            // pbKiemTra
            // 
            this.pbKiemTra.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Done;
            this.pbKiemTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKiemTra.Location = new System.Drawing.Point(4, 2);
            this.pbKiemTra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbKiemTra.Name = "pbKiemTra";
            this.pbKiemTra.Size = new System.Drawing.Size(30, 28);
            this.pbKiemTra.TabIndex = 1;
            this.pbKiemTra.TabStop = false;
            // 
            // lblKiemTra
            // 
            this.lblKiemTra.AutoSize = true;
            this.lblKiemTra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKiemTra.Location = new System.Drawing.Point(38, 7);
            this.lblKiemTra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKiemTra.Name = "lblKiemTra";
            this.lblKiemTra.Size = new System.Drawing.Size(58, 19);
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
            this.pnTaoDT.Location = new System.Drawing.Point(9, 2);
            this.pnTaoDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTaoDT.Name = "pnTaoDT";
            this.pnTaoDT.Size = new System.Drawing.Size(118, 33);
            this.pnTaoDT.TabIndex = 3;
            // 
            // pbTaoDT
            // 
            this.pbTaoDT.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Content;
            this.pbTaoDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTaoDT.Location = new System.Drawing.Point(4, 2);
            this.pbTaoDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbTaoDT.Name = "pbTaoDT";
            this.pbTaoDT.Size = new System.Drawing.Size(30, 28);
            this.pbTaoDT.TabIndex = 1;
            this.pbTaoDT.TabStop = false;
            // 
            // lblTaoDT
            // 
            this.lblTaoDT.AutoSize = true;
            this.lblTaoDT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTaoDT.Location = new System.Drawing.Point(38, 7);
            this.lblTaoDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaoDT.Name = "lblTaoDT";
            this.lblTaoDT.Size = new System.Drawing.Size(76, 19);
            this.lblTaoDT.TabIndex = 0;
            this.lblTaoDT.Text = "Tạo đề tài";
            this.lblTaoDT.Click += new System.EventHandler(this.lblTaoDT_Click);
            this.lblTaoDT.MouseEnter += new System.EventHandler(this.lblTaoDT_MouseEnter);
            this.lblTaoDT.MouseLeave += new System.EventHandler(this.lblTaoDT_MouseLeave);
            // 
            // pnLV
            // 
            this.pnLV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnLV.Controls.Add(this.dataGridView1);
            this.pnLV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLV.Location = new System.Drawing.Point(0, 76);
            this.pnLV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnLV.Name = "pnLV";
            this.pnLV.Size = new System.Drawing.Size(599, 285);
            this.pnLV.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormLuanVanGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pnLV);
            this.Controls.Add(this.pnTieuDe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLuanVanGV";
            this.Text = "FormLuanVanGV";
            this.Load += new System.EventHandler(this.FormLuanVanGV_Load);
            this.pnTieuDe.ResumeLayout(false);
            this.pnKiemTra.ResumeLayout(false);
            this.pnKiemTra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKiemTra)).EndInit();
            this.pnTaoDT.ResumeLayout(false);
            this.pnTaoDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaoDT)).EndInit();
            this.pnLV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}