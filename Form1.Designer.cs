﻿namespace QuanLyLuanVan
{
    partial class FLogin
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
            this.rbtnSV = new System.Windows.Forms.RadioButton();
            this.rbtnGV = new System.Windows.Forms.RadioButton();
            this.pnLogin2 = new System.Windows.Forms.Panel();
            this.pnLogin1 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNameLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNameLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.pbPwLock = new System.Windows.Forms.PictureBox();
            this.pbPwShow = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnLogin2.SuspendLayout();
            this.pnLogin1.SuspendLayout();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnSV
            // 
            this.rbtnSV.AutoSize = true;
            this.rbtnSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSV.Location = new System.Drawing.Point(7, 10);
            this.rbtnSV.Name = "rbtnSV";
            this.rbtnSV.Size = new System.Drawing.Size(106, 27);
            this.rbtnSV.TabIndex = 1;
            this.rbtnSV.TabStop = true;
            this.rbtnSV.Text = "Sinh viên";
            this.rbtnSV.UseVisualStyleBackColor = true;
            // 
            // rbtnGV
            // 
            this.rbtnGV.AutoSize = true;
            this.rbtnGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGV.Location = new System.Drawing.Point(128, 9);
            this.rbtnGV.Name = "rbtnGV";
            this.rbtnGV.Size = new System.Drawing.Size(121, 27);
            this.rbtnGV.TabIndex = 10;
            this.rbtnGV.TabStop = true;
            this.rbtnGV.Text = "Giảng viên";
            this.rbtnGV.UseVisualStyleBackColor = true;
            // 
            // pnLogin2
            // 
            this.pnLogin2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogin2.Controls.Add(this.rbtnGV);
            this.pnLogin2.Controls.Add(this.rbtnSV);
            this.pnLogin2.Location = new System.Drawing.Point(114, 200);
            this.pnLogin2.Name = "pnLogin2";
            this.pnLogin2.Size = new System.Drawing.Size(552, 46);
            this.pnLogin2.TabIndex = 0;
            // 
            // pnLogin1
            // 
            this.pnLogin1.Controls.Add(this.lblLogin);
            this.pnLogin1.Location = new System.Drawing.Point(0, 0);
            this.pnLogin1.Name = "pnLogin1";
            this.pnLogin1.Size = new System.Drawing.Size(551, 46);
            this.pnLogin1.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(3, 10);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(99, 23);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Đăng nhập";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameLogin
            // 
            this.lblNameLogin.AutoSize = true;
            this.lblNameLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLogin.Location = new System.Drawing.Point(49, 109);
            this.lblNameLogin.Name = "lblNameLogin";
            this.lblNameLogin.Size = new System.Drawing.Size(139, 23);
            this.lblNameLogin.TabIndex = 1;
            this.lblNameLogin.Text = "Tên đăng nhập:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(90, 145);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 23);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // txtNameLogin
            // 
            this.txtNameLogin.Location = new System.Drawing.Point(219, 109);
            this.txtNameLogin.Name = "txtNameLogin";
            this.txtNameLogin.Size = new System.Drawing.Size(240, 22);
            this.txtNameLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(219, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(240, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(219, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 33);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(350, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnLogin
            // 
            this.pnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogin.Controls.Add(this.pbPwLock);
            this.pnLogin.Controls.Add(this.pbPwShow);
            this.pnLogin.Controls.Add(this.btnExit);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.txtPassword);
            this.pnLogin.Controls.Add(this.txtNameLogin);
            this.pnLogin.Controls.Add(this.lblPassword);
            this.pnLogin.Controls.Add(this.lblNameLogin);
            this.pnLogin.Controls.Add(this.pnLogin1);
            this.pnLogin.Location = new System.Drawing.Point(114, 154);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(552, 265);
            this.pnLogin.TabIndex = 1;
            // 
            // pbPwLock
            // 
            this.pbPwLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPwLock.Image = global::QuanLyLuanVan.Properties.Resources.Ảnh_chụp_màn_hình_2024_03_09_201109;
            this.pbPwLock.Location = new System.Drawing.Point(466, 145);
            this.pbPwLock.Name = "pbPwLock";
            this.pbPwLock.Size = new System.Drawing.Size(32, 22);
            this.pbPwLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPwLock.TabIndex = 8;
            this.pbPwLock.TabStop = false;
            this.pbPwLock.Click += new System.EventHandler(this.pbPwLock_Click);
            // 
            // pbPwShow
            // 
            this.pbPwShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPwShow.Image = global::QuanLyLuanVan.Properties.Resources.Ảnh_chụp_màn_hình_2024_03_09_200235;
            this.pbPwShow.Location = new System.Drawing.Point(466, 145);
            this.pbPwShow.Name = "pbPwShow";
            this.pbPwShow.Size = new System.Drawing.Size(32, 22);
            this.pbPwShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPwShow.TabIndex = 7;
            this.pbPwShow.TabStop = false;
            this.pbPwShow.Click += new System.EventHandler(this.pbPwShow_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Ảnh_chụp_màn_hình_2024_03_09_152247;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(1, 1);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(782, 104);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 476);
            this.Controls.Add(this.pnLogin2);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pbLogo);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
            this.pnLogin2.ResumeLayout(false);
            this.pnLogin2.PerformLayout();
            this.pnLogin1.ResumeLayout(false);
            this.pnLogin1.PerformLayout();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.RadioButton rbtnSV;
        private System.Windows.Forms.RadioButton rbtnGV;
        private System.Windows.Forms.Panel pnLogin2;
        private System.Windows.Forms.Panel pnLogin1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNameLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtNameLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbPwShow;
        private System.Windows.Forms.PictureBox pbPwLock;
        private System.Windows.Forms.Panel pnLogin;
    }
}

