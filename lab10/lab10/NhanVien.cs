using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class NhanVien
    {
        DataBase db;

        public NhanVien()
        {
            db = new DataBase();
        }
        public DataTable laydsnv()
        {
            string sql = "Select Manhanvien, HoTenNhanVien, Ngaysinh,Diachi,Dienthoai, TenBangcap From Nhanvien N, BANGCAP B Where N.MaBangCap = B.MaBangCap";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public void ThemNhanVien(string ten, string ngaysinh, string diachi, string dienthoai, int index_bc)
        {
            string sql = string.Format("Insert Into NhanVien Values(N'{0}', '{1}', N'{2}', '{3}',{4})", ten, ngaysinh, diachi, dienthoai, index_bc);
            //string sql = "Insert Into NhanVien Values(N'"+ten+"', '"+ngaysinh+"', N'"+diachi+"', '"+dienthoai+"',"+index_bc+")";          
            
            db.ExecuteNonQuery(sql);
        }

        //Phương thức cập nhật 
        public void CapNhatNhanVien(int index_nv, string hoten, string ngaysinh, string diachi, string dienthoai, int index_bc)
        {
            string str = string.Format("Update NHANVIEN set HoTenNhanVien = N'{0}', NgaySinh = '{1}', diachi = N'{2}', dienthoai = '{3}', MaBangCap = {4} where MaNhanVien= {5}", hoten, ngaysinh, diachi, dienthoai, index_bc, index_nv);
            db.ExecuteNonQuery(str);
        }
        public void XoaNhanVien(int index_nv)
        {
            string sql = "Delete from NhanVien where MaNhanVien=" + index_nv;
            db.ExecuteNonQuery(sql);
        }

    }
}
