using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Nhan_Su.Model;
using Quan_Ly_Nhan_Su.View;
namespace Quan_Ly_Nhan_Su
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmPhongBan pb = new frmPhongBan();
            pb.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmChucVu cv = new frmChucVu();
            cv.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmTrinhDoHocVan hv = new frmTrinhDoHocVan();
            hv.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmDamNhiem dn = new frmDamNhiem();
            dn.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            this.Hide();
            lg.Show();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain m = new frmMain();
            m.Show();
            this.Hide();
        }

        private void hướngĐẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongDan hd = new frmHuongDan();
            hd.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            this.Hide();
            l.Show();
        }
    }
}
