using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Object
{
    class NhanVienObj
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Luong { get; set; }
        public string MaNGS { get; set; }
        public string MaPB { get; set; }
        public string SDT { get; set; }
        public string MaTDHV { get; set; }
        public string DiaChi { get; set; }
        public string QuocTich { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string SoCMTND { get; set; }
        public DateTime NgayCap { get; set; }
        public string NoiCap { get; set; }
        public NhanVienObj() { }
        public NhanVienObj(string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string Luong, string MaNGS, string MaPB, string SDT
            , string MaTDHV, string DiaChi, string QuocTich, string DanToc, string TonGiao, string SoCMTND, DateTime NgayCap, string NoiCap)
        {
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.Luong = Luong;
            this.MaNGS = MaNGS;
            this.MaPB = MaPB;
            this.SDT = SDT;
            this.MaTDHV = MaTDHV;
            this.DiaChi = DiaChi;
            this.QuocTich = QuocTich;
            this.DanToc = DanToc;
            this.TonGiao = TonGiao;
            this.SoCMTND = SoCMTND;
            this.NgayCap = NgayCap;
            this.NoiCap = NoiCap;
        }
    }
}
