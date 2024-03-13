namespace QuanLyLuanVan
{
    partial class FormĐTĐK
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
            this.tabCtrĐT = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.btbLuu = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtGV2 = new System.Windows.Forms.TextBox();
            this.txtGV1 = new System.Windows.Forms.TextBox();
            this.txtĐT = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.dpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblGV2 = new System.Windows.Forms.Label();
            this.lblGV1 = new System.Windows.Forms.Label();
            this.lblĐT = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBirthd = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tabTienDo = new System.Windows.Forms.TabPage();
            this.tabDiem = new System.Windows.Forms.TabPage();
            this.tabExit = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabCtrĐT.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.Ảnh_chụp_màn_hình_2024_03_09_152247;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(4, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1347, 125);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // tabCtrĐT
            // 
            this.tabCtrĐT.Controls.Add(this.tabInfo);
            this.tabCtrĐT.Controls.Add(this.tabTienDo);
            this.tabCtrĐT.Controls.Add(this.tabDiem);
            this.tabCtrĐT.Controls.Add(this.tabExit);
            this.tabCtrĐT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrĐT.Location = new System.Drawing.Point(34, 154);
            this.tabCtrĐT.Name = "tabCtrĐT";
            this.tabCtrĐT.SelectedIndex = 0;
            this.tabCtrĐT.Size = new System.Drawing.Size(787, 511);
            this.tabCtrĐT.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabCtrĐT.TabIndex = 1;
            this.tabCtrĐT.SelectedIndexChanged += new System.EventHandler(this.tabCtrĐT_SelectedIndexChanged);
            // 
            // tabInfo
            // 
            this.tabInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabInfo.Controls.Add(this.txtSex);
            this.tabInfo.Controls.Add(this.btbLuu);
            this.tabInfo.Controls.Add(this.txtGhiChu);
            this.tabInfo.Controls.Add(this.txtGV2);
            this.tabInfo.Controls.Add(this.txtGV1);
            this.tabInfo.Controls.Add(this.txtĐT);
            this.tabInfo.Controls.Add(this.txtPhone);
            this.tabInfo.Controls.Add(this.txtAddr);
            this.tabInfo.Controls.Add(this.txtClass);
            this.tabInfo.Controls.Add(this.dpBirthday);
            this.tabInfo.Controls.Add(this.txtName);
            this.tabInfo.Controls.Add(this.txtId);
            this.tabInfo.Controls.Add(this.lblGhiChu);
            this.tabInfo.Controls.Add(this.lblGV2);
            this.tabInfo.Controls.Add(this.lblGV1);
            this.tabInfo.Controls.Add(this.lblĐT);
            this.tabInfo.Controls.Add(this.lblPhone);
            this.tabInfo.Controls.Add(this.lblAddr);
            this.tabInfo.Controls.Add(this.lblClass);
            this.tabInfo.Controls.Add(this.lblSex);
            this.tabInfo.Controls.Add(this.lblBirthd);
            this.tabInfo.Controls.Add(this.lblName);
            this.tabInfo.Controls.Add(this.lblId);
            this.tabInfo.Location = new System.Drawing.Point(4, 32);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(779, 475);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Thông tin đề tài";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(237, 137);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(389, 30);
            this.txtSex.TabIndex = 46;
            // 
            // btbLuu
            // 
            this.btbLuu.Location = new System.Drawing.Point(237, 427);
            this.btbLuu.Name = "btbLuu";
            this.btbLuu.Size = new System.Drawing.Size(71, 35);
            this.btbLuu.TabIndex = 45;
            this.btbLuu.Text = "Lưu ";
            this.btbLuu.UseVisualStyleBackColor = true;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(237, 391);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(389, 30);
            this.txtGhiChu.TabIndex = 44;
            // 
            // txtGV2
            // 
            this.txtGV2.Location = new System.Drawing.Point(237, 355);
            this.txtGV2.Name = "txtGV2";
            this.txtGV2.Size = new System.Drawing.Size(389, 30);
            this.txtGV2.TabIndex = 43;
            // 
            // txtGV1
            // 
            this.txtGV1.Location = new System.Drawing.Point(237, 319);
            this.txtGV1.Name = "txtGV1";
            this.txtGV1.Size = new System.Drawing.Size(389, 30);
            this.txtGV1.TabIndex = 42;
            // 
            // txtĐT
            // 
            this.txtĐT.Location = new System.Drawing.Point(237, 283);
            this.txtĐT.Name = "txtĐT";
            this.txtĐT.Size = new System.Drawing.Size(389, 30);
            this.txtĐT.TabIndex = 41;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(237, 247);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(389, 30);
            this.txtPhone.TabIndex = 40;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(237, 211);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(389, 30);
            this.txtAddr.TabIndex = 39;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(237, 175);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(389, 30);
            this.txtClass.TabIndex = 38;
            // 
            // dpBirthday
            // 
            this.dpBirthday.Location = new System.Drawing.Point(237, 101);
            this.dpBirthday.Name = "dpBirthday";
            this.dpBirthday.Size = new System.Drawing.Size(389, 30);
            this.dpBirthday.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(237, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(389, 30);
            this.txtName.TabIndex = 36;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(237, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(389, 30);
            this.txtId.TabIndex = 35;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(142, 398);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(83, 23);
            this.lblGhiChu.TabIndex = 34;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // lblGV2
            // 
            this.lblGV2.AutoSize = true;
            this.lblGV2.Location = new System.Drawing.Point(40, 362);
            this.lblGV2.Name = "lblGV2";
            this.lblGV2.Size = new System.Drawing.Size(187, 23);
            this.lblGV2.TabIndex = 33;
            this.lblGV2.Text = "Giảng viên đề nghị 2:";
            // 
            // lblGV1
            // 
            this.lblGV1.AutoSize = true;
            this.lblGV1.Location = new System.Drawing.Point(40, 326);
            this.lblGV1.Name = "lblGV1";
            this.lblGV1.Size = new System.Drawing.Size(187, 23);
            this.lblGV1.TabIndex = 32;
            this.lblGV1.Text = "Giảng viên đề nghị 1:";
            // 
            // lblĐT
            // 
            this.lblĐT.AutoSize = true;
            this.lblĐT.Location = new System.Drawing.Point(159, 290);
            this.lblĐT.Name = "lblĐT";
            this.lblĐT.Size = new System.Drawing.Size(68, 23);
            this.lblĐT.TabIndex = 31;
            this.lblĐT.Text = "Đề tài:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(173, 254);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(54, 23);
            this.lblPhone.TabIndex = 30;
            this.lblPhone.Text = "SĐT:";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(152, 218);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(75, 23);
            this.lblAddr.TabIndex = 29;
            this.lblAddr.Text = "Địa chỉ:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(176, 182);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(51, 23);
            this.lblClass.TabIndex = 28;
            this.lblClass.Text = "Lớp:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(135, 144);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(92, 23);
            this.lblSex.TabIndex = 27;
            this.lblSex.Text = "Giới tính:";
            // 
            // lblBirthd
            // 
            this.lblBirthd.AutoSize = true;
            this.lblBirthd.Location = new System.Drawing.Point(128, 108);
            this.lblBirthd.Name = "lblBirthd";
            this.lblBirthd.Size = new System.Drawing.Size(99, 23);
            this.lblBirthd.TabIndex = 26;
            this.lblBirthd.Text = "Ngày sinh:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(152, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 23);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Họ tên:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(182, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(45, 23);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "Mã:";
            // 
            // tabTienDo
            // 
            this.tabTienDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTienDo.Location = new System.Drawing.Point(4, 32);
            this.tabTienDo.Name = "tabTienDo";
            this.tabTienDo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTienDo.Size = new System.Drawing.Size(697, 476);
            this.tabTienDo.TabIndex = 1;
            this.tabTienDo.Text = "Tiến độ đề tài";
            this.tabTienDo.UseVisualStyleBackColor = true;
            // 
            // tabDiem
            // 
            this.tabDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDiem.Controls.Add(this.txtDiem);
            this.tabDiem.Controls.Add(this.lblDiem);
            this.tabDiem.Controls.Add(this.txtTitle);
            this.tabDiem.Controls.Add(this.lblTitle);
            this.tabDiem.Location = new System.Drawing.Point(4, 32);
            this.tabDiem.Name = "tabDiem";
            this.tabDiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiem.Size = new System.Drawing.Size(697, 476);
            this.tabDiem.TabIndex = 2;
            this.tabDiem.Text = "Điểm số";
            this.tabDiem.UseVisualStyleBackColor = true;
            // 
            // tabExit
            // 
            this.tabExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabExit.Location = new System.Drawing.Point(4, 32);
            this.tabExit.Name = "tabExit";
            this.tabExit.Padding = new System.Windows.Forms.Padding(3);
            this.tabExit.Size = new System.Drawing.Size(779, 455);
            this.tabExit.TabIndex = 3;
            this.tabExit.Text = "Thoát";
            this.tabExit.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(55, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tên đề tài:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(213, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(249, 30);
            this.txtTitle.TabIndex = 1;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(95, 121);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(61, 23);
            this.lblDiem.TabIndex = 2;
            this.lblDiem.Text = "Điểm:";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(213, 114);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(249, 30);
            this.txtDiem.TabIndex = 3;
            // 
            // FormĐTĐK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyLuanVan.Properties.Resources.lv2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 802);
            this.Controls.Add(this.tabCtrĐT);
            this.Controls.Add(this.pbLogo);
            this.DoubleBuffered = true;
            this.Name = "FormĐTĐK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đề tài đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabCtrĐT.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.tabDiem.ResumeLayout(false);
            this.tabDiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TabControl tabCtrĐT;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabTienDo;
        private System.Windows.Forms.TabPage tabDiem;
        private System.Windows.Forms.TabPage tabExit;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Button btbLuu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtGV2;
        private System.Windows.Forms.TextBox txtGV1;
        private System.Windows.Forms.TextBox txtĐT;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.DateTimePicker dpBirthday;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblGV2;
        private System.Windows.Forms.Label lblGV1;
        private System.Windows.Forms.Label lblĐT;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBirthd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.TextBox txtTitle;
    }
}