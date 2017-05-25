using Quan_Ly_Nhan_Su.Model;
using Quan_Ly_Nhan_Su.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Su.View
{
    public partial class frmTrinhDoHocVan : Form
    {
        public frmTrinhDoHocVan()
        {
            InitializeComponent();
        }

        TrinhDoHocVanMod hvmod = new TrinhDoHocVanMod();
        TrinhDoHocVanObj hvobj = new TrinhDoHocVanObj();
        int flag = 0;
        private void frmTrinhDoHocVan_Load(object sender, EventArgs e)
        {
            dvgTrinhDoHocVan.DataSource = hvmod.GetData();
            dvgTrinhDoHocVan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dis_en(false);
            LoadData();
        }
        private void LoadData()
        {
            txtMaTDHV.Text = dvgTrinhDoHocVan.CurrentRow.Cells[0].Value.ToString();
            txtTenTDHV.Text = dvgTrinhDoHocVan.CurrentRow.Cells[1].Value.ToString();
            txtChuyenNganh.Text = dvgTrinhDoHocVan.CurrentRow.Cells[2].Value.ToString();
        }
        private void clean()
        {
            txtMaTDHV.Clear();
            txtTenTDHV.Clear();
            txtChuyenNganh.Clear();

        }

        private void dvgTrinhDoHocVan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    txtMaTDHV.Text = dvgTrinhDoHocVan.CurrentRow.Cells[0].Value.ToString();
                    txtTenTDHV.Text = dvgTrinhDoHocVan.CurrentRow.Cells[1].Value.ToString();
                    txtChuyenNganh.Text = dvgTrinhDoHocVan.CurrentRow.Cells[2].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        public void dis_en(bool e)
        {
            txtMaTDHV.Enabled = e;
            txtTenTDHV.Enabled = e;
            txtChuyenNganh.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;

        }

        private void GanDuLieu(TrinhDoHocVanObj hv1obj)
        {
            hv1obj.MaTDHV = txtMaTDHV.Text.ToString().Trim();
            hv1obj.TenTDHV = txtTenTDHV.Text.ToString().Trim();
            hv1obj.ChuyenNganh = txtChuyenNganh.Text.ToString().Trim();
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
                    if (hvmod.DelTrinhDoHocVan(txtMaTDHV.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmTrinhDoHocVan_Load(sender, e);
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
            GanDuLieu(hvobj);
            if (flag == 0)   // thêm
            {
                if (hvmod.AddTrinhDoHocVan(hvobj))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmTrinhDoHocVan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            // sửa
            {
                if (hvmod.UpdateTrinhDoHocVan(hvobj))
                {
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmTrinhDoHocVan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmTrinhDoHocVan_Load(sender, e);
            dis_en(false);
        }
    }
}
