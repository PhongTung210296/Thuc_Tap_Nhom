using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quan_Ly_Nhan_Su.Object;
using Quan_Ly_Nhan_Su.Model;

namespace Quan_Ly_Nhan_Su.View
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVienMod nv = new NhanVienMod();
        NhanVienObj nnvobj = new NhanVienObj();
        int flag = 0;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dvgNhanVien.DataSource = nv.GetData();
            dvgNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dis_en(false);
            LoadData();
        }
        private void LoadData()
        {
            txtMaNV.Text = dvgNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dvgNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dvgNhanVien.CurrentRow.Cells[2].Value.ToString();
            bool Gt;
            if (dvgNhanVien.CurrentRow.Cells[3].Value.ToString().Trim() == "Nam")
                Gt = true;
            else
                Gt = false;
            if (Gt)
                rbtNam.Checked = true;
            else
                rbtNu.Checked = true;
            txtLuong.Text = dvgNhanVien.CurrentRow.Cells[4].Value.ToString();
            cbbMaNGS.Text = dvgNhanVien.CurrentRow.Cells[5].Value.ToString();
            cbbMaPB.Text = dvgNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtSDT.Text = dvgNhanVien.CurrentRow.Cells[7].Value.ToString();
            cbbMaTDHV.Text = dvgNhanVien.CurrentRow.Cells[8].Value.ToString();
            txtDiaChi.Text = dvgNhanVien.CurrentRow.Cells[9].Value.ToString();
            txtQuocTich.Text = dvgNhanVien.CurrentRow.Cells[10].Value.ToString();
            txtDanToc.Text = dvgNhanVien.CurrentRow.Cells[11].Value.ToString();
            txtTonGiao.Text = dvgNhanVien.CurrentRow.Cells[12].Value.ToString();
            txtCMT.Text = dvgNhanVien.CurrentRow.Cells[13].Value.ToString();
            dtNgayCap.Text = dvgNhanVien.CurrentRow.Cells[14].Value.ToString();
            txtNoiCap.Text = dvgNhanVien.CurrentRow.Cells[15].Value.ToString();
        }

        private void clean()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtLuong.Clear();
            txtNoiCap.Clear();
            txtQuocTich.Clear();
            txtSDT.Clear();
            txtTonGiao.Clear();
            txtDiaChi.Clear();
            txtCMT.Clear();
            txtDanToc.Clear();
            cbbMaPB.ResetText();
            cbbMaTDHV.ResetText();
            cbbMaNGS.ResetText();
            dtNgaySinh.Value = DateTime.Now;
            dtNgayCap.Value = DateTime.Now;
        }
        public void dis_en(bool e)
        {
            txtMaNV.Enabled = e;
            txtHoTen.Enabled = e;
            txtLuong.Enabled = e;
            txtNoiCap.Enabled = e;
            txtQuocTich.Enabled = e;
            txtSDT.Enabled = e;
            txtTonGiao.Enabled = e;
            txtDiaChi.Enabled = e;
            txtCMT.Enabled = e;
            txtDanToc.Enabled = e;
            cbbMaNGS.Enabled = e;
            cbbMaPB.Enabled = e;
            cbbMaTDHV.Enabled = e;
            dtNgaySinh.Enabled = e;
            dtNgayCap.Enabled = e;
            groupBox5.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;

        }

        private void GanDuLieu(NhanVienObj nv1obj)
        {
          
        }

        private void dvgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    txtMaNV.Text = Convert.ToString(dvgNhanVien.CurrentRow.Cells[0].Value);
                    txtHoTen.Text = dvgNhanVien.CurrentRow.Cells[1].Value.ToString();
                    dtNgaySinh.Text = dvgNhanVien.CurrentRow.Cells[2].Value.ToString();
                    bool Gt;
                    if (dvgNhanVien.CurrentRow.Cells[3].Value.ToString().Trim() == "Nam")
                        Gt = true;
                    else
                        Gt = false;
                    if (Gt)
                        rbtNam.Checked = true;
                    else
                        rbtNu.Checked = true;
                    txtLuong.Text = dvgNhanVien.CurrentRow.Cells[4].Value.ToString();
                    cbbMaNGS.Text = dvgNhanVien.CurrentRow.Cells[5].Value.ToString();
                    cbbMaPB.Text = dvgNhanVien.CurrentRow.Cells[6].Value.ToString();
                    txtSDT.Text = dvgNhanVien.CurrentRow.Cells[7].Value.ToString();
                    cbbMaTDHV.Text = dvgNhanVien.CurrentRow.Cells[8].Value.ToString();
                    txtDiaChi.Text = dvgNhanVien.CurrentRow.Cells[9].Value.ToString();
                    txtQuocTich.Text = dvgNhanVien.CurrentRow.Cells[10].Value.ToString();
                    txtDanToc.Text = dvgNhanVien.CurrentRow.Cells[11].Value.ToString();
                    txtTonGiao.Text = dvgNhanVien.CurrentRow.Cells[12].Value.ToString();
                    txtCMT.Text = dvgNhanVien.CurrentRow.Cells[13].Value.ToString();
                    dtNgayCap.Text = dvgNhanVien.CurrentRow.Cells[14].Value.ToString();
                    txtNoiCap.Text = dvgNhanVien.CurrentRow.Cells[15].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            dis_en(false);
        }
    }
}
