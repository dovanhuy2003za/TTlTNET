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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void quanLyVanBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manhinhphuqlvb vb=new manhinhphuqlvb();
            vb.Show();
            this.Show();
        }

        private void quanLyHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manhinhphuqlvb vb = new manhinhphuqlvb();
            vb.Show();
            this.Show();
        }
    }
}
