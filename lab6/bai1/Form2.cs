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

namespace bai1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] tenvideo;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "all file| *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tenvideo = ofd.FileNames;
                foreach (string filename in ofd.FileNames)
                {
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(filename)); //them duong dan vao listbox
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                
                try
                {
                    string selectFilePath = tenvideo[listBox1.SelectedIndex];
                    axWindowsMediaPlayer1.URL = selectFilePath;
                    toolStripStatusLabel1.Text ="phat : "+ Path.GetFileName(selectFilePath);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("khong th mo file: " + ex.Message);
                }
            }
        }
    }
}
