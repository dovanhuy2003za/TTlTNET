using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tạo hộp thoại mở file 
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // lọc hiển thị các loại file 

            openFileDialog.Filter = "video file| *.avi; *.mpeg; *.wav; *.midi; *.mp4";

            //hiển thị openDialog 
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // lấy tên file cần mở 
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
            toolStripStatusLabel1.Text = "ngay: "+ DateTime.Today.ToShortDateString();
            toolStripStatusLabel1.Text = "bay gio la: " + DateTime.Now.ToString("hh:mm:ss:tt");
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Show();
        }
    }
}
