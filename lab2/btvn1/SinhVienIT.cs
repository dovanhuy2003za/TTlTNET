using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class SinhVienIT:SinhVienUneti
    {
        private double diem;
        public SinhVienIT(string hoTen, string nganh, double diem)
            : base(hoTen, nganh)
        {
            this.diem = diem;
        }
        public override double getDiem()
        {
            return diem;
        }
    }
}
