using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Object
{
    class ChucVuObj
    {
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public ChucVuObj()
        {

        }
        public ChucVuObj(string MaCV, string TenCV)
        {
            this.MaCV = MaCV;
            this.TenCV = TenCV;
        }
    }
}
