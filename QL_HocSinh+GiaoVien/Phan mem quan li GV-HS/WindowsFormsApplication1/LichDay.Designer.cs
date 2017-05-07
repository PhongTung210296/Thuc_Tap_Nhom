namespace WindowsFormsApplication1
{
    partial class LichDay
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmMiớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbBM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLichDay = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMiớiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmMiớiToolStripMenuItem
            // 
            this.thêmMiớiToolStripMenuItem.Name = "thêmMiớiToolStripMenuItem";
            this.thêmMiớiToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.thêmMiớiToolStripMenuItem.Text = "Thêm Mới";
            this.thêmMiớiToolStripMenuItem.Click += new System.EventHandler(this.thêmMiớiToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // lbBM
            // 
            this.lbBM.AutoSize = true;
            this.lbBM.Location = new System.Drawing.Point(279, 41);
            this.lbBM.Name = "lbBM";
            this.lbBM.Size = new System.Drawing.Size(0, 13);
            this.lbBM.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bộ Môn:";
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Location = new System.Drawing.Point(85, 41);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(0, 13);
            this.lbHT.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giáo Viên: ";
            // 
            // dgvLichDay
            // 
            this.dgvLichDay.AllowUserToAddRows = false;
            this.dgvLichDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenLop,
            this.TenMH,
            this.NamHoc,
            this.HocKi,
            this.PhongHoc,
            this.ThoiGian});
            this.dgvLichDay.Location = new System.Drawing.Point(12, 69);
            this.dgvLichDay.Name = "dgvLichDay";
            this.dgvLichDay.Size = new System.Drawing.Size(733, 367);
            this.dgvLichDay.TabIndex = 18;
            this.dgvLichDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichDay_CellClick);
            this.dgvLichDay.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvLichDay_RowPrePaint);
            this.dgvLichDay.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvLichDay_PreviewKeyDown);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "TenLop";
            this.TenLop.Name = "TenLop";
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Môn Học";
            this.TenMH.Name = "TenMH";
            // 
            // NamHoc
            // 
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.HeaderText = "Năm Học";
            this.NamHoc.Name = "NamHoc";
            // 
            // HocKi
            // 
            this.HocKi.DataPropertyName = "HocKi";
            this.HocKi.HeaderText = "Học Kì";
            this.HocKi.Name = "HocKi";
            // 
            // PhongHoc
            // 
            this.PhongHoc.DataPropertyName = "PhongHoc";
            this.PhongHoc.HeaderText = "Phòng Học";
            this.PhongHoc.Name = "PhongHoc";
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Lịch Dạy";
            this.ThoiGian.Name = "ThoiGian";
            // 
            // LichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 448);
            this.Controls.Add(this.dgvLichDay);
            this.Controls.Add(this.lbBM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbHT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LichDay";
            this.Text = "LichDay";
            this.Load += new System.EventHandler(this.LichDay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmMiớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label lbBM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLichDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
    }
}