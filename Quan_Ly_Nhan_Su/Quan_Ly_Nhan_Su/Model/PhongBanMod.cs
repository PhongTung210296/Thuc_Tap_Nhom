using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Phần_mềm_quản_lý_nhân_sự_V1._1.Object;
using Quan_Ly_Nhan_Su.Model;

namespace Phần_mềm_quản_lý_nhân_sự_V1._1.Model
{
    class PhongBanMod
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

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


        public bool AddPhongBan(PhongBanObj PBobj)
        {
            cmd.CommandText = "Insert into PhongBan values ('" + PBobj.MAPB + "',N'" + PBobj.TENPB + "','" + PBobj.MATP + "','" + PBobj.NGAYNC + "','" + PBobj.DIADIEM + "','" + PBobj.SDT + "','" + PBobj.SONV + "')";
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
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete PhongBan where MaPB = '" + ma + "'";
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


        public bool UpdatePhongBan(PhongBanObj PBobj)
        {
            cmd.CommandText = " update PhongBan set TenPB=N'" + PBobj.TENPB + "',MaTP='" + PBobj.MATP + "',NgayNC='" + PBobj.NGAYNC + "',DiaDiem='" + PBobj.DIADIEM + "',SDT='" + PBobj.SDT + "',SoNV='" + PBobj.SONV + "'where MaPB='" + PBobj.MAPB + "' ";
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

        public DataTable SeachPhongBan(string maPb)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from PhongBan  where MaNV like '%" + maPb + "%'";
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
