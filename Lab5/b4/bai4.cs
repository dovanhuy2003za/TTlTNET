using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b4
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&&textBox2.Text!=""&&textBox3.Text!="")
            {
                
                if (int.TryParse(textBox3.Text,out int number)==false)
                {
                    MessageBox.Show("gia phai la so");
                }
                else if (dateTimePicker1.Value.Year<2010)
                {
                    MessageBox.Show("hang can thanh ly");
                }
                else
                {
                    MessageBox.Show("hang con dung duoc");
                }

            }
            else
            {
                MessageBox.Show("vui long nhap day du");
            }
        }
    }
}
