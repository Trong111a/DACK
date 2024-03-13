namespace QuanLyLuanVan
{
    partial class FormGV
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabCtrGV = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.bntLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dpBirthd = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBirthd = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabCtrGV.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Ảnh_chụp_màn_hình_2024_03_09_152247;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(-1, 1);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(948, 101);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // tabCtrGV
            // 
            this.tabCtrGV.Controls.Add(this.tabPage1);
            this.tabCtrGV.Controls.Add(this.tabPage2);
            this.tabCtrGV.ItemSize = new System.Drawing.Size(96, 24);
            this.tabCtrGV.Location = new System.Drawing.Point(237, 136);
            this.tabCtrGV.Margin = new System.Windows.Forms.Padding(2);
            this.tabCtrGV.Name = "tabCtrGV";
            this.tabCtrGV.SelectedIndex = 0;
            this.tabCtrGV.Size = new System.Drawing.Size(481, 431);
            this.tabCtrGV.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbSex);
            this.tabPage1.Controls.Add(this.bntLuu);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.dpBirthd);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.txtAddr);
            this.tabPage1.Controls.Add(this.txtClass);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.lblPhone);
            this.tabPage1.Controls.Add(this.lblBirthd);
            this.tabPage1.Controls.Add(this.lblSex);
            this.tabPage1.Controls.Add(this.lblClass);
            this.tabPage1.Controls.Add(this.lblAddr);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.lblId);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông Tin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Luận Văn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(121, 179);
            this.cbSex.Margin = new System.Windows.Forms.Padding(2);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(258, 21);
            this.cbSex.TabIndex = 33;
            // 
            // bntLuu
            // 
            this.bntLuu.Location = new System.Drawing.Point(233, 353);
            this.bntLuu.Margin = new System.Windows.Forms.Padding(2);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(56, 27);
            this.bntLuu.TabIndex = 32;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(121, 353);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 27);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // dpBirthd
            // 
            this.dpBirthd.Location = new System.Drawing.Point(121, 136);
            this.dpBirthd.Margin = new System.Windows.Forms.Padding(2);
            this.dpBirthd.Name = "dpBirthd";
            this.dpBirthd.Size = new System.Drawing.Size(258, 20);
            this.dpBirthd.TabIndex = 30;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 294);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(258, 20);
            this.txtPhone.TabIndex = 29;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(121, 255);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(258, 20);
            this.txtAddr.TabIndex = 28;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(121, 216);
            this.txtClass.Margin = new System.Windows.Forms.Padding(2);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(258, 20);
            this.txtClass.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 98);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 20);
            this.txtName.TabIndex = 26;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(51, 299);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(32, 13);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "SĐT:";
            // 
            // lblBirthd
            // 
            this.lblBirthd.AutoSize = true;
            this.lblBirthd.Location = new System.Drawing.Point(26, 141);
            this.lblBirthd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthd.Name = "lblBirthd";
            this.lblBirthd.Size = new System.Drawing.Size(57, 13);
            this.lblBirthd.TabIndex = 24;
            this.lblBirthd.Text = "Ngày sinh:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(31, 181);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(50, 13);
            this.lblSex.TabIndex = 23;
            this.lblSex.Text = "Giới tính:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(58, 221);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(31, 13);
            this.lblClass.TabIndex = 22;
            this.lblClass.Text = "Lớp: ";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(40, 260);
            this.lblAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(46, 13);
            this.lblAddr.TabIndex = 21;
            this.lblAddr.Text = "Địa chỉ: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 103);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 13);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Họ tên: ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 62);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(258, 20);
            this.txtId.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(62, 68);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 13);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "Mã: ";
            // 
            // FormGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 626);
            this.Controls.Add(this.tabCtrGV);
            this.Controls.Add(this.pbLogo);
            this.Name = "FormGV";
            this.Text = "FormGV";
            this.Load += new System.EventHandler(this.FormGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabCtrGV.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabCtrGV;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DateTimePicker dpBirthd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirthd;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}