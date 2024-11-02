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

namespace bt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryWriter bw;
            FileStream fileStream = new FileStream("data", FileMode.Create);
            try
            {
                bw = new BinaryWriter(fileStream);
            }
            catch (Exception ex) {
                MessageBox.Show("Loi tao file");
                return;
            }
            int songuyen=int.Parse(textBox1.Text);
            double sothuc=double.Parse(textBox2.Text);
            bool logic=bool.Parse(comboBox1.Text);
            string xau=textBox3.Text;
            try
            {
                bw.Write(songuyen);
                bw.Write(sothuc);
                bw.Write(logic);
                bw.Write(xau);
                MessageBox.Show("Ghi file thanh cong");
            }
            catch(IOException ex) 
            {
                MessageBox.Show("ghi file that bai"+ex.Message);
            }
            bw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryReader bw;
            FileStream fileStream = new FileStream("data", FileMode.Open);
            try
            {
                bw = new BinaryReader(fileStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi mo file");
                return;
            }
            
            try
            {
                int songuyen = bw.ReadInt32();
                double sothuc = bw.ReadDouble();
                bool logic = bw.ReadBoolean();
                string xau = bw.ReadString();
                MessageBox.Show("So nguyen: "+songuyen+"\n Sothuc: "+sothuc+"\n logic: "+logic+"\n xau: "+xau);
            }
            catch (IOException ex)
            {
                MessageBox.Show("doc file that bai" + ex.Message);
            }
            bw.Close();
        }
    }
}
