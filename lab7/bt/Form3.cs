using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bt
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strings = textBox1.Text.Split(' ');
            int[] ints=Array.ConvertAll(strings,int.Parse);
            BinaryWriter bw;
            FileStream fileStream = new FileStream("data.dat", FileMode.Create);
            try
            {
                bw = new BinaryWriter(fileStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tao file");
                return;
            }
           
            try
            {
                bw.Write(ints.Length);
                foreach (int i in ints) {
                    bw.Write(i);
                }
                MessageBox.Show("Ghi file thanh cong");
            }
            catch (IOException ex)
            {
                MessageBox.Show("ghi file that bai" + ex.Message);
            }
            bw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryReader bw;
            FileStream fileStream = new FileStream("data.dat", FileMode.Open);
            try
            {
                bw = new BinaryReader(fileStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi mo file");
                return;
            }
            int a=bw.ReadInt32();
            int[] numbers=new int[a];
            for (int i = 0; i < a; i++)
            {
                numbers[i] = bw.ReadInt32();
            }
            bw.Close();
            textBox2.Text = "";
            foreach (int i in numbers) { 
                textBox2.Text += i+" ";
            }
        }
    }
}
