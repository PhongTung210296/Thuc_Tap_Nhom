﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phần_mềm_quản_lý_nhân_sự_V1._1.Object;
using Phần_mềm_quản_lý_nhân_sự_V1._1.Model;


namespace Quan_Ly_Nhan_Su.View
{
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
        PhongBanMod PbMod = new PhongBanMod();
        PhongBanObj PBObj = new PhongBanObj();
        int flag = 0;
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            dvgPhongBan.DataSource = PbMod.GetData();
            dvgPhongBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dis_en(false);
            LoadData();
        }
        private void LoadData()
        {
            txtMaPB.Text = dvgPhongBan.CurrentRow.Cells[0].Value.ToString();
            txtTenPB.Text = dvgPhongBan.CurrentRow.Cells[1].Value.ToString();
            txtMaTP.Text = dvgPhongBan.CurrentRow.Cells[2].Value.ToString();
            dtNgayNC.Text = dvgPhongBan.CurrentRow.Cells[3].Value.ToString();
            txtDiaDiem.Text = dvgPhongBan.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dvgPhongBan.CurrentRow.Cells[5].Value.ToString();
            txtSoNV.Text = dvgPhongBan.CurrentRow.Cells[6].Value.ToString();
        }
        private void clean()
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtMaTP.Clear();
            txtDiaDiem.Clear();
            txtSDT.Clear();
            txtSoNV.Clear();
            dtNgayNC.Value = DateTime.Now;
        }
        private void dvgPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    txtMaPB.Text = dvgPhongBan.CurrentRow.Cells[0].Value.ToString();
                    txtTenPB.Text = dvgPhongBan.CurrentRow.Cells[1].Value.ToString();
                    txtMaTP.Text = dvgPhongBan.CurrentRow.Cells[2].Value.ToString();
                    dtNgayNC.Text = dvgPhongBan.CurrentRow.Cells[3].Value.ToString();
                    txtDiaDiem.Text = dvgPhongBan.CurrentRow.Cells[4].Value.ToString();
                    txtSDT.Text = dvgPhongBan.CurrentRow.Cells[5].Value.ToString();
                    txtSoNV.Text = dvgPhongBan.CurrentRow.Cells[6].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        public void dis_en(bool e)
        {
            txtMaPB.Enabled = e;
            txtTenPB.Enabled = e;
            txtMaTP.Enabled = e;
            dtNgayNC.Enabled = e;
            txtDiaDiem.Enabled = e;
            txtSDT.Enabled = e;
            txtSoNV.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;

        }

        private void GanDuLieu(PhongBanObj PbObj)
        {
            PbObj.MAPB = txtMaPB.Text.ToString().Trim();
            PbObj.TENPB = txtTenPB.Text.ToString().Trim();
            PbObj.MATP = txtMaTP.Text.ToString().Trim();
            PbObj.NGAYNC = dtNgayNC.Value;
            PbObj.DIADIEM = txtDiaDiem.Text.ToString().Trim();
            PbObj.SDT = txtSDT.Text.ToString().Trim();
            PbObj.SONV = txtSoNV.Text.ToString().Trim();
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
                    if (PbMod.DelPhongBan(txtMaPB.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPhongBan_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            GanDuLieu(PBObj);
            if (flag == 0)
            {
                if (PbMod.AddPhongBan(PBObj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPhongBan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (PbMod.UpdatePhongBan(PBObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPhongBan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmPhongBan_Load(sender, e);
            dis_en(false);
        }
    }
}
