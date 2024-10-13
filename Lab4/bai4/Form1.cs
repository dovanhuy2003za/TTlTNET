using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Sự kiện khi nhấn nút "Tính tiền"
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu tên khách hàng chưa được nhập
            if (string.IsNullOrWhiteSpace(textBoxTenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Biến lưu tổng tiền
            double tongTien = 0;

            // Kiểm tra các dịch vụ đã chọn và cộng dồn chi phí
            if (checkBoxCaoVoi.Checked)
            {
                tongTien += 100; // Chi phí cạo vôi
            }
            if (checkBoxTayTrang.Checked)
            {
                tongTien += 1200; // Chi phí tẩy trắng
            }
            if (checkBoxChupHinhRang.Checked)
            {
                tongTien += 200; // Chi phí chụp hình răng
            }

            // Xử lý cho dịch vụ trám răng
            if (checkBoxTramRang.Checked)
            {
                int soLuongTramRang = (int)numericUpDownSoLuongTramRang.Value;
                tongTien += soLuongTramRang * 80;
            }

            // Hiển thị tổng tiền
            textBoxTotal.Text = tongTien.ToString("C2"); // Định dạng tiền tệ
        }
        private void checkBoxTramRang_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownSoLuongTramRang.Enabled = checkBoxTramRang.Checked;
        }
        // Sự kiện khi nhấn nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát chương trình
        }
    }
}
