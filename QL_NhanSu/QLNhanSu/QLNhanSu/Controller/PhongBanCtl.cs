using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhanSu.Model;
using System.Data;
using System.Data.SqlClient;
namespace QLNhanSu.Controller
{
    class PhongBanCtl
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
            cmd.CommandText = "select * from PhongBan";
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
        /// <param name="khobj">đối tượng cần thêm vào ds</param>
        public bool AddPhongBan(PhongBanObj pbobj)
        {
            cmd.CommandText = "Insert into PhongBan values ('" + pbobj.MaPB + "',N'" + pbobj.TenPB + "','" + pbobj.MaTP + "','" + pbobj.NgayNC + "','" + pbobj.DiaDiem + "','" + pbobj.SDT + "','" + pbobj.SoNV + "')";
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

       
        public bool DelPhongBan(string ma)
        {
            cmd.CommandText = "delete PhongBan where MaPB= '" + ma + "'";
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

       
        public bool UpdatePhongBan(PhongBanObj pbobj)
        {
            cmd.CommandText = " update PhongBan set TenPB=N'" + pbobj.TenPB + "',MaTP='" + pbobj.MaTP + "',NgayNC='" + pbobj.NgayNC + "',DiaDiem=N'" + pbobj.DiaDiem + "',SDT='" + pbobj.SDT+ "',SoNV='" + pbobj.SoNV + "' where MaPB='" + pbobj.MaPB + "'";
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
    }
}
