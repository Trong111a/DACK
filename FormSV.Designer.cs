namespace QuanLyLuanVan
{
    partial class FormSV
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
            this.tabCtrSV = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
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
            this.tabLV = new System.Windows.Forms.TabPage();
            this.tabExit = new System.Windows.Forms.TabPage();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabCtrSV.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrSV
            // 
            this.tabCtrSV.Controls.Add(this.tabInfo);
            this.tabCtrSV.Controls.Add(this.tabLV);
            this.tabCtrSV.Controls.Add(this.tabExit);
            this.tabCtrSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrSV.Location = new System.Drawing.Point(128, 114);
            this.tabCtrSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCtrSV.Multiline = true;
            this.tabCtrSV.Name = "tabCtrSV";
            this.tabCtrSV.SelectedIndex = 0;
            this.tabCtrSV.Size = new System.Drawing.Size(568, 392);
            this.tabCtrSV.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCtrSV.TabIndex = 0;
            this.tabCtrSV.SelectedIndexChanged += new System.EventHandler(this.tabCtrSV_SelectedIndexChanged);
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabInfo.Controls.Add(this.cbSex);
            this.tabInfo.Controls.Add(this.bntLuu);
            this.tabInfo.Controls.Add(this.btnSua);
            this.tabInfo.Controls.Add(this.dpBirthd);
            this.tabInfo.Controls.Add(this.txtPhone);
            this.tabInfo.Controls.Add(this.txtAddr);
            this.tabInfo.Controls.Add(this.txtClass);
            this.tabInfo.Controls.Add(this.txtName);
            this.tabInfo.Controls.Add(this.lblPhone);
            this.tabInfo.Controls.Add(this.lblBirthd);
            this.tabInfo.Controls.Add(this.lblSex);
            this.tabInfo.Controls.Add(this.lblClass);
            this.tabInfo.Controls.Add(this.lblAddr);
            this.tabInfo.Controls.Add(this.lblName);
            this.tabInfo.Controls.Add(this.txtId);
            this.tabInfo.Controls.Add(this.lblId);
            this.tabInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInfo.Location = new System.Drawing.Point(4, 28);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabInfo.Size = new System.Drawing.Size(560, 360);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Thông tin ";
            this.tabInfo.Click += new System.EventHandler(this.tabInfo_Click);
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(111, 134);
            this.cbSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(258, 27);
            this.cbSex.TabIndex = 17;
            // 
            // bntLuu
            // 
            this.bntLuu.Location = new System.Drawing.Point(223, 308);
            this.bntLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(56, 27);
            this.bntLuu.TabIndex = 16;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(111, 308);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 27);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // dpBirthd
            // 
            this.dpBirthd.Location = new System.Drawing.Point(111, 91);
            this.dpBirthd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dpBirthd.Name = "dpBirthd";
            this.dpBirthd.Size = new System.Drawing.Size(258, 26);
            this.dpBirthd.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(111, 249);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(258, 26);
            this.txtPhone.TabIndex = 13;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(111, 210);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(258, 26);
            this.txtAddr.TabIndex = 12;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(111, 171);
            this.txtClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(258, 26);
            this.txtClass.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 53);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 26);
            this.txtName.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(41, 254);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 19);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "SĐT:";
            // 
            // lblBirthd
            // 
            this.lblBirthd.AutoSize = true;
            this.lblBirthd.Location = new System.Drawing.Point(16, 96);
            this.lblBirthd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthd.Name = "lblBirthd";
            this.lblBirthd.Size = new System.Drawing.Size(81, 19);
            this.lblBirthd.TabIndex = 6;
            this.lblBirthd.Text = "Ngày sinh:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(21, 136);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(72, 19);
            this.lblSex.TabIndex = 5;
            this.lblSex.Text = "Giới tính:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(48, 176);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(45, 19);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Lớp: ";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(30, 215);
            this.lblAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(65, 19);
            this.lblAddr.TabIndex = 3;
            this.lblAddr.Text = "Địa chỉ: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 58);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ tên: ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(111, 15);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(258, 26);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(52, 21);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã: ";
            // 
            // tabLV
            // 
            this.tabLV.BackColor = System.Drawing.Color.White;
            this.tabLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLV.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabLV.Location = new System.Drawing.Point(4, 28);
            this.tabLV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabLV.Name = "tabLV";
            this.tabLV.Size = new System.Drawing.Size(560, 360);
            this.tabLV.TabIndex = 3;
            this.tabLV.Text = "Luận văn";
            // 
            // tabExit
            // 
            this.tabExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExit.Location = new System.Drawing.Point(4, 28);
            this.tabExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabExit.Name = "tabExit";
            this.tabExit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabExit.Size = new System.Drawing.Size(560, 360);
            this.tabExit.TabIndex = 4;
            this.tabExit.Text = "Thoát";
            this.tabExit.UseVisualStyleBackColor = true;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Ảnh_chụp_màn_hình_2024_03_09_152247;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(2, 2);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(896, 89);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FormSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 553);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tabCtrSV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang của bạn";
            this.tabCtrSV.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrSV;
        private System.Windows.Forms.TabPage tabLV;
        private System.Windows.Forms.TabPage tabExit;
        private System.Windows.Forms.PictureBox pbLogo;
        protected internal System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirthd;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.DateTimePicker dpBirthd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbSex;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}