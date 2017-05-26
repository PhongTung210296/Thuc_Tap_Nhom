using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý_nhân_sự_V1._1.Object
{
    class PhongBanObj
    {
        public string MaPB { get; set; }
        public string TenPB { get; set; }
        public string MaTP { get; set; }
        public DateTime NgayNC { get; set; }
        public string DiaDiem { get; set; }
        public string SDT { get; set; }
        public string SoNV { get; set; }
        public PhongBanObj()
        {

        }
        public PhongBanObj(string mapb, string tenpb, string matp, DateTime ngaync, string diadiem, string sdt, string sonv)
        {
            this.MaPB = mapb;
            this.TenPB = tenpb;
            this.MaTP = matp;
            this.NgayNC = ngaync;
            this.DiaDiem = diadiem;
            this.SDT = sdt;
            this.SoNV = sonv;
        }

    }
}
