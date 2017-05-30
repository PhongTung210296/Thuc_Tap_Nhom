using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Object
{
    class DamNhiemObj
    {
        public string ThoiGianCongTac { get; set; }
        public string MaNV { get; set; }
        public string MaCV { get; set; }
        public DamNhiemObj()
        {

        }
        public DamNhiemObj(string thoigiancongtac, string manv, string macv)
        {
            this.ThoiGianCongTac = thoigiancongtac;
            this.MaCV = macv;
            this.MaNV = manv;
        }
    }
}
