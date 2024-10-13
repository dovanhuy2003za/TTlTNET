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
        private void btnDoiMau_Click(object sender, EventArgs e)
        {
            if (cboMau.Text == "Yellow")
                this.BackColor = Color.Yellow;
            if (cboMau.Text == "Red")
                this.BackColor = Color.Red;
            if (cboMau.Text == "Blue")
                this.BackColor = Color.Blue;
            if (cboMau.Text == "Green")
                this.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
