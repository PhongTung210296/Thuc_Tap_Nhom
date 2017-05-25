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
using Quan_Ly_Nhan_Su.Object;

namespace Quan_Ly_Nhan_Su.View
{
    public partial class frmDamNhiem : Form
    {
        public frmDamNhiem()
        {
            InitializeComponent();
        }
        DamNhiemMod dnctl = new DamNhiemMod();
        DamNhiemObj dnobj = new DamNhiemObj();
        int flag = 0;
        public void dis_en(bool e)
        {
            txtThoiGian.Enabled = e;
            cbbMaCV.Enabled = e;
            cbbMaNV.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        private void clean()
        {
            txtThoiGian.Clear();
        }
        private void GanDuLieu(DamNhiemObj dn1obj)
        {
            dn1obj.ThoiGianCongTac = txtThoiGian.Text.ToString().Trim();
            dn1obj.MaNV = cbbMaNV.Text.ToString().Trim();
            dn1obj.MaCV = cbbMaCV.Text.ToString().Trim();
        }
        private void frmDamNhiem_Load(object sender, EventArgs e)
        {

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
                    if (dnctl.DelDamNhiem(txtThoiGian.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmDamNhiem_Load(sender, e);
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
            GanDuLieu(dnobj);
            if (flag == 0)   // thêm
            {
                if (dnctl.AddDamNhiem(dnobj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDamNhiem_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            // sửa
            {
                if (dnctl.UpdateDamNhiem(dnobj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDamNhiem_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDamNhiem_Load(sender, e);
            dis_en(false);
        }
    }
    }
}
