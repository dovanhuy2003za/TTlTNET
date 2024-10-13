using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Xử lý sự kiện khi nhấn nút "Nhập thông tin"
        private void btnNhapThongTin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxHoTen.Text))
            {
                listBoxThongTin.Items.Add(textBoxHoTen.Text);
                textBoxHoTen.Clear(); // Xóa nội dung TextBox sau khi nhập
                CapNhatSoLuong();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xử lý sự kiện khi nhấn nút "Xóa thông tin đã chọn"
        private void btnXoaThongTinDaChon_Click(object sender, EventArgs e)
        {
            if (listBoxThongTin.SelectedIndex != -1)
            {
                listBoxThongTin.Items.RemoveAt(listBoxThongTin.SelectedIndex);
                CapNhatSoLuong();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xử lý sự kiện khi nhấn nút "Xóa thông tin đầu"
        private void btnXoaThongTinDau_Click(object sender, EventArgs e)
        {
            if (listBoxThongTin.Items.Count > 0)
            {
                listBoxThongTin.Items.RemoveAt(0);
                CapNhatSoLuong();
            }
            else
            {
                MessageBox.Show("Không có thông tin nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xử lý sự kiện khi nhấn nút "Xóa thông tin cuối"
        private void btnXoaThongTinCuoi_Click(object sender, EventArgs e)
        {
            if (listBoxThongTin.Items.Count > 0)
            {
                listBoxThongTin.Items.RemoveAt(listBoxThongTin.Items.Count - 1);
                CapNhatSoLuong();
            }
            else
            {
                MessageBox.Show("Không có thông tin nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xử lý sự kiện khi nhấn nút "Xóa tất cả thông tin"
        private void btnXoaTatCaThongTin_Click(object sender, EventArgs e)
        {
            listBoxThongTin.Items.Clear();
            CapNhatSoLuong();
        }

        // Hàm cập nhật số lượng người đã khai báo
        private void CapNhatSoLuong()
        {
            textBoxTongSo.Text = listBoxThongTin.Items.Count.ToString();
        }
    }
}
