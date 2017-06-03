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
            nv1obj.MaNV = txtMaNV.Text.ToString().Trim();
            nv1obj.HoTen = txtHoTen.Text.ToString().Trim();
            nv1obj.NgaySinh = dtNgaySinh.Value;
            if (rbtNam.Checked)
            {
                nv1obj.GioiTinh = "Nam";
            }
            if (rbtNu.Checked)
            {
                nv1obj.GioiTinh = "Nu";
            }
            nv1obj.Luong = txtLuong.Text.ToString().Trim();
            nv1obj.MaNGS = cbbMaNGS.Text.ToString().Trim();
            nv1obj.MaPB = cbbMaPB.Text.ToString().Trim();
            nv1obj.SDT = txtSDT.Text.ToString().Trim();
            nv1obj.MaTDHV = cbbMaTDHV.Text.ToString().Trim();
            nv1obj.DiaChi = txtDiaChi.Text.ToString().Trim();
            nv1obj.QuocTich = txtQuocTich.Text.ToString().Trim();
            nv1obj.DanToc = txtDanToc.Text.ToString().Trim();
            nv1obj.TonGiao = txtTonGiao.Text.ToString().Trim();
            nv1obj.SoCMTND = txtCMT.Text.ToString().Trim();
            nv1obj.NgayCap = dtNgayCap.Value;
            nv1obj.NoiCap = txtNoiCap.Text.ToString().Trim();
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
            flag = 0;
            clean();
            dis_en(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            flag = 1;
            dis_en(true);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    if (nv.DelNhanVien(txtMaNV.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmNhanVien_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóakhông thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(nnvobj);
            if (flag == 0)   // thêm
            {
                if (nv.AddNhanVien(nnvobj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            // sửa
            {
                if (nv.UpdateNhanVien(nnvobj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            dis_en(false);
        }
    }
}
