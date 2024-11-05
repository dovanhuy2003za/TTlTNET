using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab9_DoVanHuy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            vohieuhoa(true);
            try
            {
                load_lstview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void load_lstview()
        {
            string sql = "select * from tblDocgia";
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
                listView1.Items.Add(item);
            }
        }

        private void vohieuhoa(bool bt)
        {
           groupBox1.Enabled = bt;
            
        }
        bool kiemtra_du_lieu()
        {
            if (kiemtra(textBox1.Text)|| kiemtra(textBox2.Text) || kiemtra(textBox3.Text) || kiemtra(textBox4.Text) || kiemtra(textBox5.Text))
            {
                return false;
            }
            string dt =textBox5.Text;
            if (dt.Length <0 || dt.Length>10) {
                return false; 
            
            }
            for (int i = 0; i < dt.Length; i++)
            {
                if ((dt[i] < '0' || dt[i]>'9')) return false;
            }
            if (dt[0]!='0') return false;
            return true;
        }
        bool kiemtra(string s)
        {
            if (s.Trim().Length == 0)
            {
                return true;
            } else return false;
        }
        void reset()
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
        }
        private Boolean kttrung(string ma)
        {
            string sql = "select madocgia from tblDocgia";
            DataTable dataTable=new DataTable();
            dataTable = ketnoi.truyvan(sql);
            foreach (DataRow dr in dataTable.Rows) {
                if (string.Compare(ma.Trim(), dr[0].ToString().Trim())==0)
                    return true;
            
            }
            return false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.Compare(button1.Text,"Thêm")==0)
            {
                vohieuhoa(true);
                textBox1.Focus();
                button1.Text = "Lưu";
            }else if (kiemtra_du_lieu()==true)
            {
                string madocgia, tendocgia, coquan, diachi, sodienthoai;
                madocgia=textBox1.Text;
                tendocgia=textBox2.Text;
                coquan=textBox3.Text;
                diachi=textBox4.Text;
                sodienthoai=textBox5.Text;
                if (kttrung(madocgia)==true)
                {
                    MessageBox.Show("Trùng mã độc giả", "Thông báo lỗi");
                    textBox1.Focus() ;
                }
                else
                {
                    string sql = "insert into tblDocgia values('" + madocgia + "',N'" + tendocgia + "',N'" + coquan + "',N'" + diachi + "','" + sodienthoai + "')";
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



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (item.Selected==true)
                {
                    textBox1.Text = item.Text; 
                    textBox2.Text =item.SubItems[1].Text;
                    textBox3.Text = item.SubItems[2].Text;
                    textBox4.Text = item.SubItems[3].Text;
                    textBox5.Text = item.SubItems[4].Text;
                }
            }
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (item.Selected==true)
                {
                    string sql = "delete from tblDocgia where madocgia='"+item.Text.ToString()+"'";
                    ketnoi.thucthi(sql);
                    listView1.Items.Clear();
                    load_lstview();
                    reset();
                }
            }
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
                string madocgia, tendocgia, coquan, diachi, sodienthoai;
                madocgia = textBox1.Text;
                tendocgia = textBox2.Text;
                coquan = textBox3.Text;
                diachi = textBox4.Text;
                sodienthoai = textBox5.Text;
                
                    string sql = "update tblDocgia set madocgia='"+madocgia + "',tendocgia=N'" +tendocgia+ "',coquan=N'"+coquan+"',diachi=N'"+diachi+"',tel='"+sodienthoai+"'where madocgia='"+madocgia+"'";
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
