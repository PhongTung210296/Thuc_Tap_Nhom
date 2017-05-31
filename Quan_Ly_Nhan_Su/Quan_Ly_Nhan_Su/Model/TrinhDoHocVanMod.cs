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
    class TrinhDoHocVanMod
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from TrinhDoHocVan";
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


        public bool AddTrinhDoHocVan(TrinhDoHocVanObj hvobj)
        {
            cmd.CommandText = "Insert into TrinhDoHocVan values ('" + hvobj.MaTDHV + "',N'" + hvobj.TenTDHV + "',N'" + hvobj.ChuyenNganh + "');";
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


        public bool DelTrinhDoHocVan(string ma)
        {
            cmd.CommandText = "delete TrinhDoHocVan where MaTDHV= '" + ma + "'";
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


        public bool UpdateTrinhDoHocVan(TrinhDoHocVanObj hvobj)
        {
            cmd.CommandText = " update TrinhDoHocVan set TenTrinhDo=N'" + hvobj.TenTDHV + "',ChuyenNganh=N'" + hvobj.ChuyenNganh + "' where MaTDHV='" + hvobj.MaTDHV + "'";
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

        public DataTable SeachThinhDoHocVan(string TenTrinhDO)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from TrinhDoHocVan  where TenTrinhDo like '%" + TenTrinhDO + "%'";
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
