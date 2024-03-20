namespace QuanLyLuanVan
{
    partial class FormChiTietLuanVanSV
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
            this.pnLV = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbChiTiet = new System.Windows.Forms.PictureBox();
            this.pnLV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLV
            // 
            this.pnLV.Controls.Add(this.pbBack);
            this.pnLV.Controls.Add(this.btnBack);
            this.pnLV.Controls.Add(this.pbChiTiet);
            this.pnLV.Controls.Add(this.btnChiTiet);
            this.pnLV.Controls.Add(this.dataGridView1);
            this.pnLV.Controls.Add(this.lblTieuDe);
            this.pnLV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnLV.Location = new System.Drawing.Point(1, 4);
            this.pnLV.Name = "pnLV";
            this.pnLV.Size = new System.Drawing.Size(795, 361);
            this.pnLV.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTieuDe.Location = new System.Drawing.Point(25, 28);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(251, 23);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Danh sách đề tài đã đăng ký:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(437, 216);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.Azure;
            this.btnChiTiet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnChiTiet.Location = new System.Drawing.Point(29, 313);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(137, 31);
            this.btnChiTiet.TabIndex = 2;
            this.btnChiTiet.Text = "     Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Azure;
            this.btnBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Location = new System.Drawing.Point(224, 313);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 31);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "    Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Azure;
            this.pbBack.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Previous_Location;
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBack.Location = new System.Drawing.Point(237, 319);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(23, 19);
            this.pbBack.TabIndex = 5;
            this.pbBack.TabStop = false;
            // 
            // pbChiTiet
            // 
            this.pbChiTiet.BackColor = System.Drawing.Color.Azure;
            this.pbChiTiet.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Checked_Radio_Button;
            this.pbChiTiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbChiTiet.Location = new System.Drawing.Point(42, 319);
            this.pbChiTiet.Name = "pbChiTiet";
            this.pbChiTiet.Size = new System.Drawing.Size(23, 19);
            this.pbChiTiet.TabIndex = 3;
            this.pbChiTiet.TabStop = false;
            // 
            // FormLienQuanLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.pnLV);
            this.Name = "FormLienQuanLV";
            this.Text = "FormLienQuanLV";
            this.pnLV.ResumeLayout(false);
            this.pnLV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.PictureBox pbChiTiet;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Button btnBack;
    }
}