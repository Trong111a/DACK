namespace QuanLyLuanVan
{
    partial class FormTienDoSV
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tabCtrTienDo = new System.Windows.Forms.TabControl();
            this.tabTienDo = new System.Windows.Forms.TabPage();
            this.tabCapNhat = new System.Windows.Forms.TabPage();
            this.tabExit = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabCtrTienDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Ảnh_chụp_màn_hình_2024_03_09_152247;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(2, 1);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1064, 109);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // tabCtrTienDo
            // 
            this.tabCtrTienDo.Controls.Add(this.tabTienDo);
            this.tabCtrTienDo.Controls.Add(this.tabCapNhat);
            this.tabCtrTienDo.Controls.Add(this.tabExit);
            this.tabCtrTienDo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrTienDo.Location = new System.Drawing.Point(107, 147);
            this.tabCtrTienDo.Name = "tabCtrTienDo";
            this.tabCtrTienDo.SelectedIndex = 0;
            this.tabCtrTienDo.Size = new System.Drawing.Size(541, 337);
            this.tabCtrTienDo.TabIndex = 4;
            this.tabCtrTienDo.SelectedIndexChanged += new System.EventHandler(this.tabCtrTienDo_SelectedIndexChanged);
            // 
            // tabTienDo
            // 
            this.tabTienDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTienDo.Location = new System.Drawing.Point(4, 32);
            this.tabTienDo.Name = "tabTienDo";
            this.tabTienDo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTienDo.Size = new System.Drawing.Size(533, 301);
            this.tabTienDo.TabIndex = 0;
            this.tabTienDo.Text = "Tiến Độ";
            this.tabTienDo.UseVisualStyleBackColor = true;
            // 
            // tabCapNhat
            // 
            this.tabCapNhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCapNhat.Location = new System.Drawing.Point(4, 32);
            this.tabCapNhat.Name = "tabCapNhat";
            this.tabCapNhat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCapNhat.Size = new System.Drawing.Size(533, 301);
            this.tabCapNhat.TabIndex = 1;
            this.tabCapNhat.Text = "Cập nhật";
            this.tabCapNhat.UseVisualStyleBackColor = true;
            // 
            // tabExit
            // 
            this.tabExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabExit.Location = new System.Drawing.Point(4, 32);
            this.tabExit.Name = "tabExit";
            this.tabExit.Padding = new System.Windows.Forms.Padding(3);
            this.tabExit.Size = new System.Drawing.Size(533, 301);
            this.tabExit.TabIndex = 2;
            this.tabExit.Text = "Thoát";
            this.tabExit.UseVisualStyleBackColor = true;
            // 
            // FormTienDoSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.lv2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 606);
            this.Controls.Add(this.tabCtrTienDo);
            this.Controls.Add(this.pbLogo);
            this.DoubleBuffered = true;
            this.Name = "FormTienDoSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiến Độ";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabCtrTienDo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TabControl tabCtrTienDo;
        private System.Windows.Forms.TabPage tabTienDo;
        private System.Windows.Forms.TabPage tabCapNhat;
        private System.Windows.Forms.TabPage tabExit;
    }
}