using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        NhanVien nv;
        BangCap bc;
        bool themmoi=false;
        public Form1()
        {
            InitializeComponent();
            nv=new NhanVien();
            bc=new BangCap();
        }
        public void HienThiDSNhanVien()
        {
            dataGridView1.DataSource = nv.laydsnv();
        }
        public void HienThiBangCap()
        {
            DataTable dt=bc.laydsbc();
            comboBox1.DataSource= dt;
            comboBox1.DisplayMember = "tenbangcap";
            comboBox1.ValueMember = "mabangcap";
            comboBox1.SelectedIndex = -1;
        }
        void setnull()
        {
            dateTimePicker1.ResetText();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex=-1;
        }
        void setEnable(bool val)
        {
            textBox1.Enabled = val;
            textBox2.Enabled = val;
            textBox3.Enabled = val;
            dateTimePicker1.Enabled = val;
            comboBox1 .Enabled = val;
        }
        void setButton(bool val)
        {
            button1.Enabled = val;
            button2.Enabled = val;
            button3.Enabled = val;
            button4 .Enabled = !val;
            button5 .Enabled = !val;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVien();
            dataGridView1.CurrentCell = null;
            HienThiBangCap();
            setnull();
            setEnable(false);
            setButton(true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null) {
                DataGridViewRow r=dataGridView1.CurrentRow;
                textBox1.Text = r.Cells[1].Value.ToString();
                dateTimePicker1.Text=r.Cells[2].Value.ToString();
                textBox2.Text=r.Cells[3].Value.ToString();
                textBox3.Text=r.Cells[4].Value.ToString();
                comboBox1.Text=r.Cells[5].Value.ToString();
            
            }
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setEnable(false);
            setButton(true);
            setnull();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themmoi=true;
            setButton(false);
            setEnable(true );
            setnull();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Ban co chac xoa khong","xac nhan xoa",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    nv.XoaNhanVien(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    HienThiDSNhanVien();
                    setnull();
                    MessageBox.Show("Da xoa thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Hay chon nhan vien can xoa");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                themmoi = false;
                setButton(false);
                setEnable(true);
            }
            else
            {
                MessageBox.Show("Hay chon nhan vien can sua");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:yyyy/MM/dd}", dateTimePicker1.Value);
            if (themmoi)
            {
                nv.ThemNhanVien(textBox1.Text, ngay, textBox2.Text, textBox3.Text, int.Parse(comboBox1.SelectedValue.ToString()));
                MessageBox.Show("da them thanh cong");
                HienThiDSNhanVien() ;
                setnull();
            }
            else
            {
                int i=dataGridView1.CurrentCell.RowIndex;
                nv.CapNhatNhanVien(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),textBox1.Text, ngay, textBox2.Text, textBox3.Text, int.Parse(comboBox1.SelectedValue.ToString()));
                HienThiDSNhanVien();
                dataGridView1.Rows[i].Selected = true;
                MessageBox.Show("da them thanh cong");
            }
            setEnable(false);
            setButton(true);
        }
    }
}
