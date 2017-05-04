using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Model
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
        public PhongBanObj() { }
        public PhongBanObj(string MaPB, string TenPB,string MaTP,DateTime NgayNC,string DiaDiem,string SDT,string SoNV)
        {
            this.MaPB = MaPB;
            this.TenPB = TenPB;
            this.MaTP = MaTP;
            this.NgayNC = NgayNC;
            this.DiaDiem = DiaDiem;
            this.SDT = SDT;
            this.SoNV = SoNV;
        }

    }
}
