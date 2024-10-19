using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b3
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&textBox2.Text!="")
            {
                int tuoi=DateTime.Now.Year-dateTimePicker1.Value.Year;
                if (tuoi<18)
                {
                    MessageBox.Show("Phai du 18 tuoi moi duoc dan ky");
                }
                else
                {
                    MessageBox.Show("dang ky thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap du thong tin");
            }
        }
    }
}
