namespace WindowsFormsApplication1
{
    partial class ThemLichDay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.txbMH = new System.Windows.Forms.TextBox();
            this.txbPhongHoc = new System.Windows.Forms.TextBox();
            this.txbLịchHoc = new System.Windows.Forms.TextBox();
            this.cboNH = new System.Windows.Forms.ComboBox();
            this.cboHK = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboNienKhoa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên GV: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Học Kì";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phòng Học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lịch Học";
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(103, 36);
            this.txbTen.Name = "txbTen";
            this.txbTen.ReadOnly = true;
            this.txbTen.Size = new System.Drawing.Size(215, 20);
            this.txbTen.TabIndex = 6;
            // 
            // txbMH
            // 
            this.txbMH.Location = new System.Drawing.Point(103, 89);
            this.txbMH.Name = "txbMH";
            this.txbMH.ReadOnly = true;
            this.txbMH.Size = new System.Drawing.Size(215, 20);
            this.txbMH.TabIndex = 7;
            // 
            // txbPhongHoc
            // 
            this.txbPhongHoc.AutoCompleteCustomSource.AddRange(new string[] {
            " "});
            this.txbPhongHoc.Location = new System.Drawing.Point(458, 213);
            this.txbPhongHoc.Name = "txbPhongHoc";
            this.txbPhongHoc.Size = new System.Drawing.Size(215, 20);
            this.txbPhongHoc.TabIndex = 8;
            // 
            // txbLịchHoc
            // 
            this.txbLịchHoc.AutoCompleteCustomSource.AddRange(new string[] {
            " "});
            this.txbLịchHoc.Location = new System.Drawing.Point(458, 149);
            this.txbLịchHoc.Name = "txbLịchHoc";
            this.txbLịchHoc.Size = new System.Drawing.Size(215, 20);
            this.txbLịchHoc.TabIndex = 9;
            // 
            // cboNH
            // 
            this.cboNH.FormattingEnabled = true;
            this.cboNH.Items.AddRange(new object[] {
            "2014-2015",
            "2015-2016",
            "2017-2018",
            "2019-2020",
            "2020-2021",
            "2021-2022"});
            this.cboNH.Location = new System.Drawing.Point(458, 33);
            this.cboNH.Name = "cboNH";
            this.cboNH.Size = new System.Drawing.Size(215, 21);
            this.cboNH.TabIndex = 10;
            // 
            // cboHK
            // 
            this.cboHK.FormattingEnabled = true;
            this.cboHK.Items.AddRange(new object[] {
            "Học Kì I",
            "Học Kì II"});
            this.cboHK.Location = new System.Drawing.Point(458, 89);
            this.cboHK.Name = "cboHK";
            this.cboHK.Size = new System.Drawing.Size(215, 21);
            this.cboHK.TabIndex = 11;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(261, 280);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 12;
            this.btOK.Text = "Thêm";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(394, 280);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lớp Học";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3"});
            this.cboLop.Location = new System.Drawing.Point(103, 149);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(215, 21);
            this.cboLop.TabIndex = 15;
            // 
            // cboNienKhoa
            // 
            this.cboNienKhoa.FormattingEnabled = true;
            this.cboNienKhoa.Items.AddRange(new object[] {
            "2014-2017",
            "2015-2018",
            "2016-2019",
            "2017-2020",
            "2018-2021",
            "2019-2022",
            "2020-2023",
            "2021-2024"});
            this.cboNienKhoa.Location = new System.Drawing.Point(103, 208);
            this.cboNienKhoa.Name = "cboNienKhoa";
            this.cboNienKhoa.Size = new System.Drawing.Size(215, 21);
            this.cboNienKhoa.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Niên Khóa";
            // 
            // ThemLichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 326);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboNienKhoa);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cboHK);
            this.Controls.Add(this.cboNH);
            this.Controls.Add(this.txbLịchHoc);
            this.Controls.Add(this.txbPhongHoc);
            this.Controls.Add(this.txbMH);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemLichDay";
            this.Text = "ThemLichDay";
            this.Load += new System.EventHandler(this.ThemLichDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.TextBox txbMH;
        private System.Windows.Forms.TextBox txbPhongHoc;
        private System.Windows.Forms.TextBox txbLịchHoc;
        private System.Windows.Forms.ComboBox cboNH;
        private System.Windows.Forms.ComboBox cboHK;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.Label label8;
    }
}