using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Quan_Ly_Nhan_Su.Object;

namespace Quan_Ly_Nhan_Su.Model
{
    class NhanVienMod
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        /// <summary>
        /// Hàm lấy dữ liệu . Trả về 1 data table
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConnection();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return dt;
        }

        /// <summary>
        /// Hàm Thêm nhân viên vào danh sách
        /// </summary>
        /// <param name="nvobj">đối tượng cần thêm vào ds</param>
        public bool AddNhanVien(NhanVienObj nvobj)
        {
            cmd.CommandText = "Insert into NhanVien values ('" + nvobj.MaNV + "',N'" + nvobj.HoTen + "','" + nvobj.NgaySinh + "','" + nvobj.GioiTinh + "','" + nvobj.Luong + "','" + nvobj.MaNGS + "','" + nvobj.MaPB + "','" + nvobj.SDT + "','" + nvobj.MaTDHV + "',N'" + nvobj.DiaChi + "',N'" + nvobj.QuocTich + "',N'" + nvobj.DanToc + "',N'" + nvobj.TonGiao + "','" + nvobj.SoCMTND + "','" + nvobj.NgayCap + "',N'" + nvobj.NoiCap + "');";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return true;
        }

        /// <summary>
        /// Hàm xóa một nhân viên ra khỏi danh sách
        /// </summary>
        /// <param name="ma"> mã nhân viên cần xóa</param>
        public bool DelNhanVien(string ma)
        {
            cmd.CommandText = "delete NhanVien where MaNV= '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                cmd.ExecuteNonQuery();
                con.CloseConnection();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return true;
        }

        /// <summary>
        /// Hàm sửa thông tin một nhân viên
        /// </summary>
        /// <param name="nvobj"> đối tượng nhân viên cần sửa</param>
        public bool UpdateNhanVien(NhanVienObj nvobj)
        {
            cmd.CommandText = " update NhanVien set HoTen=N'" + nvobj.HoTen + "',NgaySinh='" + nvobj.NgaySinh + "',GT=N'" + nvobj.GioiTinh + "',Luong='" + nvobj.Luong + "',MaNGS='" + nvobj.MaNGS + "',MaPB='" + nvobj.MaPB + "',SDT='" + nvobj.SDT + "',MaTDHV='" + nvobj.MaTDHV + "',DiaChi=N'" + nvobj.DiaChi + "',QuocTich=N'" + nvobj.QuocTich + "',DanToc=N'" + nvobj.DanToc + "',TonGiao=N'" + nvobj.TonGiao + "',SoCMTND='" + nvobj.SoCMTND + "',NgayCap='" + nvobj.NgayCap + "',NoiCap=N'" + nvobj.NoiCap + "' where MaNV='" + nvobj.MaNV + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return true;
        }

        public DataTable SeachNhanVien(string maNV)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from NhanVien  where MaNV like '%" + maNV + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConnection();
                return dt;

            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return dt;
        }
    }
}
