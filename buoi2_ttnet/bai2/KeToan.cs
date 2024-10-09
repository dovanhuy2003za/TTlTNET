using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class KeToan : NhanVien
    {
        public KeToan() {
            this.className=this.GetType().Name;
        }
        public override string ChucVu()
        {
            return "ke toan";
        }

        public override void CongViec()
        {
            Console.WriteLine(", Kiem ke ngan sach, thu chi");
        }
    }
}
