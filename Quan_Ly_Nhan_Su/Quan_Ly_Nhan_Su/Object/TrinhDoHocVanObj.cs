using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Object
{
    class TrinhDoHocVanObj
    {
        public string MaTDHV { get; set; }
        public string TenTDHV { get; set; }
        public string ChuyenNganh { get; set; }
        public TrinhDoHocVanObj()
        {

        }
        public TrinhDoHocVanObj(string matdhv, string tentdv, string chuyennganh)
        {
            this.MaTDHV = matdhv;
            this.TenTDHV = tentdv;
            this.ChuyenNganh = chuyennganh;
        }
    }
}
