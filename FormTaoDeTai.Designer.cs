namespace QuanLyLuanVan
{
    partial class FormTaoDeTai
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
            this.lblLoaiDeTai = new System.Windows.Forms.Label();
            this.lblTenDeTai = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtTenDeTai = new System.Windows.Forms.TextBox();
            this.cbLoaiDT = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnTaoDT = new System.Windows.Forms.Button();
            this.pnTaoDT = new System.Windows.Forms.Panel();
            this.pbTaoDT = new System.Windows.Forms.PictureBox();
            this.pnTaoDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaoDT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoaiDeTai
            // 
            this.lblLoaiDeTai.AutoSize = true;
            this.lblLoaiDeTai.Location = new System.Drawing.Point(41, 38);
            this.lblLoaiDeTai.Name = "lblLoaiDeTai";
            this.lblLoaiDeTai.Size = new System.Drawing.Size(217, 23);
            this.lblLoaiDeTai.TabIndex = 20;
            this.lblLoaiDeTai.Text = "Loại đề tài                      :";
            // 
            // lblTenDeTai
            // 
            this.lblTenDeTai.AutoSize = true;
            this.lblTenDeTai.Location = new System.Drawing.Point(42, 87);
            this.lblTenDeTai.Name = "lblTenDeTai";
            this.lblTenDeTai.Size = new System.Drawing.Size(216, 23);
            this.lblTenDeTai.TabIndex = 21;
            this.lblTenDeTai.Text = "Tên đề tài                       :";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(42, 132);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(217, 23);
            this.lblMoTa.TabIndex = 24;
            this.lblMoTa.Text = "Mô tả                              :";
            // 
            // txtTenDeTai
            // 
            this.txtTenDeTai.Location = new System.Drawing.Point(290, 80);
            this.txtTenDeTai.Name = "txtTenDeTai";
            this.txtTenDeTai.Size = new System.Drawing.Size(353, 30);
            this.txtTenDeTai.TabIndex = 26;
            // 
            // cbLoaiDT
            // 
            this.cbLoaiDT.FormattingEnabled = true;
            this.cbLoaiDT.Location = new System.Drawing.Point(290, 30);
            this.cbLoaiDT.Name = "cbLoaiDT";
            this.cbLoaiDT.Size = new System.Drawing.Size(353, 31);
            this.cbLoaiDT.TabIndex = 27;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(290, 129);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(353, 30);
            this.txtMoTa.TabIndex = 28;
            // 
            // btnTaoDT
            // 
            this.btnTaoDT.BackColor = System.Drawing.Color.Azure;
            this.btnTaoDT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTaoDT.Location = new System.Drawing.Point(290, 176);
            this.btnTaoDT.Name = "btnTaoDT";
            this.btnTaoDT.Size = new System.Drawing.Size(170, 57);
            this.btnTaoDT.TabIndex = 31;
            this.btnTaoDT.Text = "         Tạo đề tài";
            this.btnTaoDT.UseVisualStyleBackColor = false;
            this.btnTaoDT.Click += new System.EventHandler(this.btnTaoDT_Click);
            // 
            // pnTaoDT
            // 
            this.pnTaoDT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnTaoDT.Controls.Add(this.pbTaoDT);
            this.pnTaoDT.Controls.Add(this.btnTaoDT);
            this.pnTaoDT.Controls.Add(this.txtMoTa);
            this.pnTaoDT.Controls.Add(this.cbLoaiDT);
            this.pnTaoDT.Controls.Add(this.txtTenDeTai);
            this.pnTaoDT.Controls.Add(this.lblMoTa);
            this.pnTaoDT.Controls.Add(this.lblTenDeTai);
            this.pnTaoDT.Controls.Add(this.lblLoaiDeTai);
            this.pnTaoDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTaoDT.Location = new System.Drawing.Point(2, 1);
            this.pnTaoDT.Name = "pnTaoDT";
            this.pnTaoDT.Size = new System.Drawing.Size(795, 267);
            this.pnTaoDT.TabIndex = 1;
            // 
            // pbTaoDT
            // 
            this.pbTaoDT.BackColor = System.Drawing.Color.Azure;
            this.pbTaoDT.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Create;
            this.pbTaoDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTaoDT.Location = new System.Drawing.Point(298, 188);
            this.pbTaoDT.Name = "pbTaoDT";
            this.pbTaoDT.Size = new System.Drawing.Size(46, 36);
            this.pbTaoDT.TabIndex = 32;
            this.pbTaoDT.TabStop = false;
            // 
            // FormTaoDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 270);
            this.Controls.Add(this.pnTaoDT);
            this.Name = "FormTaoDeTai";
            this.Text = "FormTaoDeTai";
            this.pnTaoDT.ResumeLayout(false);
            this.pnTaoDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaoDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoaiDeTai;
        private System.Windows.Forms.Label lblTenDeTai;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtTenDeTai;
        private System.Windows.Forms.ComboBox cbLoaiDT;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnTaoDT;
        private System.Windows.Forms.PictureBox pbTaoDT;
        private System.Windows.Forms.Panel pnTaoDT;
    }
}