using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9_DoVanHuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vohieuhoa(true);
            try
            {
                load_lstview();
                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void load_lstview()
        {
            string sql = "select * from tblSach";
            DataTable dataTable = new DataTable();
            dataTable = ketnoi.truyvan(sql);
            foreach (DataRow dr in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                item.SubItems.Add(dr[5].ToString());
                listView1.Items.Add(item);
            }
        }
        private void vohieuhoa(bool bt)
        {
            textBox1.Enabled = bt;
            textBox2.Enabled = bt;
            textBox3.Enabled = bt;
            textBox4.Enabled = bt;
            textBox5.Enabled = bt;
            textBox6.Enabled = bt;
        }
        bool kiemtra_du_lieu()
        {
            if (kiemtra(textBox1.Text) || kiemtra(textBox2.Text) || kiemtra(textBox3.Text) || kiemtra(textBox4.Text) || kiemtra(textBox5.Text)||kiemtra(textBox6.Text))
            {
                return false;
            }
            int sl=Convert.ToInt32(textBox6.Text);
            int namxb=Convert.ToInt32(textBox5.Text);
            if (sl<=0||namxb<0||namxb>2024)
            {
                return false;
            }
            else
            {
                return true;
            }


            
        }
        bool kiemtra(string s)
        {
            if (s.Trim().Length == 0)
            {
                return true;
            }
            else return false;
        }
        void reset()
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
        }
        private Boolean kttrung(string ma)
        {
            string sql = "select masach from tblSach";
            DataTable dataTable = new DataTable();
            dataTable = ketnoi.truyvan(sql);
            foreach (DataRow dr in dataTable.Rows)
            {
                if (string.Compare(ma.Trim(), dr[0].ToString().Trim()) == 0)
                    return true;

            }
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.Compare(button2.Text, "Sửa") == 0)
            {
                vohieuhoa(true);
                textBox1.Focus();
                button2.Text = "Cập nhật";
            }
            else if (kiemtra_du_lieu() == true)
            {
                string masach, tensach, tentg, nhaxb;
                int namxb, soluong;
                masach = textBox1.Text;
                tensach = textBox2.Text;
                tentg = textBox3.Text;
                nhaxb = textBox4.Text;
                namxb = int.Parse(textBox5.Text.ToString());
                soluong = int.Parse(textBox6.Text.ToString());

                string sql = "update tblSach set masach='" + masach + "',tensach=N'" + tensach + "',tentacgia=N'" + tentg + "',nhaxb=N'" + nhaxb + "',namxb='" + namxb + "',soluong='" + soluong + "'where masach='" + masach + "'";
                ketnoi.thucthi(sql);
                listView1.Items.Clear();
                load_lstview();
                button2.Text = "Sửa";

                reset();

            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo lỗi");
                button1.Text = "Lưu";

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (item.Selected == true)
                {
                    textBox1.Text = item.Text;
                    textBox2.Text = item.SubItems[1].Text;
                    textBox3.Text = item.SubItems[2].Text;
                    textBox4.Text = item.SubItems[3].Text;
                    textBox5.Text = item.SubItems[4].Text;
                    textBox6.Text = item.SubItems[5].Text;
                }
            }
            button3.Enabled = true;
            button2.Enabled = true;
            vohieuhoa(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (item.Selected == true)
                {
                    string sql = "delete from tblSach where masach='" + item.Text.ToString() + "'";
                    ketnoi.thucthi(sql);
                    listView1.Items.Clear();
                    load_lstview();
                    reset();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.Compare(button1.Text, "Thêm") == 0)
            {
                vohieuhoa(true);
                textBox1.Focus();
                button1.Text = "Lưu";
            }
            else if (kiemtra_du_lieu() == true)
            {
                string masach, tensach, tentg, nhaxb;
                int namxb, soluong;
                masach = textBox1.Text;
                tensach = textBox2.Text;
                tentg = textBox3.Text;
                nhaxb = textBox4.Text;
                namxb = int.Parse(textBox5.Text.ToString());
                soluong = int.Parse(textBox6.Text.ToString());
                if (kttrung(masach) == true)
                {
                    MessageBox.Show("Trùng mã sách", "Thông báo lỗi");
                    textBox1.Focus();
                }
                else
                {   
                    string sql = "insert into tblSach values('" + masach + "',N'" + tensach + "',N'" + tentg + "',N'" + nhaxb + "'," + namxb + "," + soluong + ")";
                    ketnoi.thucthi(sql);
                    listView1.Items.Clear();
                    load_lstview();
                    button1.Text = "Thêm";
                    reset();
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo lỗi");
                button1.Text = "Lưu";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }
    }
}
