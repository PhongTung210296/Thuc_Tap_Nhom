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
        public PhongBanObj(string maPB, string tenPB, string maTP, DateTime ngayNC, string diaDiem, string SDT, string soNV)
        {
            this.MaPB = maPB;
            this.TenPB = tenPB;
            this.MaTP = maTP;
            this.NgayNC = ngayNC;
            this.DiaDiem = diaDiem;
            this.SDT = SDT;
            this.SoNV = soNV;
        }

    }
}
