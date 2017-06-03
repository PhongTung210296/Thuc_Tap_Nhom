using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý_nhân_sự_V1._1.Object
{
    class PhongBanObj
    {
        public string MAPB { get; set; }
        public string TENPB { get; set; }
        public string MATP { get; set; }
        public DateTime NGAYNC { get; set; }
        public string DIADIEM { get; set; }
        public string SDT { get; set; }
        public string SONV { get; set; }
        public PhongBanObj()
        {

        }
        public PhongBanObj(string maPB, string tenPB, string maTP, DateTime ngayNC, string diaDiem, string SDT, string soNV)
        {
            this.MAPB = maPB;
            this.TENPB = tenPB;
            this.MATP = maTP;
            this.NGAYNC = ngayNC;
            this.DIADIEM = diaDiem;
            this.SDT = SDT;
            this.SONV = soNV;
        }

    }
}
