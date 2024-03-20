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
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbChiTiet = new System.Windows.Forms.PictureBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnLV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pnLV.Location = new System.Drawing.Point(1, 3);
            this.pnLV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnLV.Name = "pnLV";
            this.pnLV.Size = new System.Drawing.Size(596, 293);
            this.pnLV.TabIndex = 0;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Azure;
            this.pbBack.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Previous_Location;
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBack.Location = new System.Drawing.Point(178, 259);
            this.pbBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(17, 15);
            this.pbBack.TabIndex = 5;
            this.pbBack.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Azure;
            this.btnBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Location = new System.Drawing.Point(168, 254);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 25);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "    Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbChiTiet
            // 
            this.pbChiTiet.BackColor = System.Drawing.Color.Azure;
            this.pbChiTiet.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Checked_Radio_Button;
            this.pbChiTiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbChiTiet.Location = new System.Drawing.Point(32, 259);
            this.pbChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbChiTiet.Name = "pbChiTiet";
            this.pbChiTiet.Size = new System.Drawing.Size(17, 15);
            this.pbChiTiet.TabIndex = 3;
            this.pbChiTiet.TabStop = false;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.Azure;
            this.btnChiTiet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnChiTiet.Location = new System.Drawing.Point(22, 254);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(103, 25);
            this.btnChiTiet.TabIndex = 2;
            this.btnChiTiet.Text = "     Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(328, 176);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTieuDe.Location = new System.Drawing.Point(19, 23);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(202, 19);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Danh sách đề tài đã đăng ký:";
            // 
            // FormChiTietLuanVanSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 297);
            this.Controls.Add(this.pnLV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormChiTietLuanVanSV";
            this.Text = "FormLienQuanLV";
            this.pnLV.ResumeLayout(false);
            this.pnLV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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