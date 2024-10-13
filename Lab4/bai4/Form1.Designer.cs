using System;
using System.Windows.Forms;

namespace bai4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxTenKhachHang;
        private NumericUpDown numericUpDownSoLuongTramRang;
        private TextBox textBoxTotal;
        private CheckBox checkBoxCaoVoi;
        private CheckBox checkBoxTayTrang;
        private CheckBox checkBoxChupHinhRang;
        private CheckBox checkBoxTramRang;
        private Button btnTinhTien;
        private Button btnThoat;
        private Label labelTenKhachHang;
        private Label labelSoLuongTramRang;
        private Label labelTotal;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTenKhachHang = new System.Windows.Forms.TextBox();
            this.numericUpDownSoLuongTramRang = new NumericUpDown();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.checkBoxCaoVoi = new System.Windows.Forms.CheckBox();
            this.checkBoxTayTrang = new System.Windows.Forms.CheckBox();
            this.checkBoxChupHinhRang = new System.Windows.Forms.CheckBox();
            this.checkBoxTramRang = new System.Windows.Forms.CheckBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.labelTenKhachHang = new System.Windows.Forms.Label();
            this.labelSoLuongTramRang = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTenKhachHang
            // 
            this.textBoxTenKhachHang.Location = new System.Drawing.Point(150, 50);
            this.textBoxTenKhachHang.Name = "textBoxTenKhachHang";
            this.textBoxTenKhachHang.Size = new System.Drawing.Size(200, 22);
            this.textBoxTenKhachHang.TabIndex = 0;
            // 
            // textBoxSoLuongTramRang
            // 
            this.numericUpDownSoLuongTramRang.Location = new System.Drawing.Point(250, 180);
            this.numericUpDownSoLuongTramRang.Name = "numericUpDownSoLuongTramRang";
            this.numericUpDownSoLuongTramRang.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownSoLuongTramRang.Minimum = 0; // Số lượng tối thiểu
            this.numericUpDownSoLuongTramRang.Maximum = 10; // Số lượng tối đa
            this.numericUpDownSoLuongTramRang.Value = 0;    // Giá trị mặc định
            this.numericUpDownSoLuongTramRang.Enabled = true;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(150, 260);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(200, 22);
            this.textBoxTotal.TabIndex = 2;
            // 
            // checkBoxCaoVoi
            // 
            this.checkBoxCaoVoi.Location = new System.Drawing.Point(50, 90);
            this.checkBoxCaoVoi.Name = "checkBoxCaoVoi";
            this.checkBoxCaoVoi.Size = new System.Drawing.Size(200, 24);
            this.checkBoxCaoVoi.TabIndex = 3;
            this.checkBoxCaoVoi.Text = "Cạo vôi - $100";
            // 
            // checkBoxTayTrang
            // 
            this.checkBoxTayTrang.Location = new System.Drawing.Point(50, 120);
            this.checkBoxTayTrang.Name = "checkBoxTayTrang";
            this.checkBoxTayTrang.Size = new System.Drawing.Size(200, 24);
            this.checkBoxTayTrang.TabIndex = 4;
            this.checkBoxTayTrang.Text = "Tẩy trắng - $1200";
            // 
            // checkBoxChupHinhRang
            // 
            this.checkBoxChupHinhRang.Location = new System.Drawing.Point(50, 150);
            this.checkBoxChupHinhRang.Name = "checkBoxChupHinhRang";
            this.checkBoxChupHinhRang.Size = new System.Drawing.Size(200, 24);
            this.checkBoxChupHinhRang.TabIndex = 5;
            this.checkBoxChupHinhRang.Text = "Chụp hình răng - $200";
            // 
            // checkBoxTramRang
            // 
            this.checkBoxTramRang.Location = new System.Drawing.Point(50, 180);
            this.checkBoxTramRang.Name = "checkBoxTramRang";
            this.checkBoxTramRang.Size = new System.Drawing.Size(500, 24);
            this.checkBoxTramRang.TabIndex = 6;
            this.checkBoxTramRang.Text = "Trám răng - $80/cái";
           
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(50, 220);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(150, 30);
            this.btnTinhTien.TabIndex = 7;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(250, 220);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelTenKhachHang
            // 
            this.labelTenKhachHang.Location = new System.Drawing.Point(50, 50);
            this.labelTenKhachHang.Name = "labelTenKhachHang";
            this.labelTenKhachHang.Size = new System.Drawing.Size(100, 22);
            this.labelTenKhachHang.TabIndex = 9;
            this.labelTenKhachHang.Text = "Tên khách hàng:";
            // 
            // labelSoLuongTramRang
            // 
            this.labelSoLuongTramRang.Location = new System.Drawing.Point(200, 180);
            this.labelSoLuongTramRang.Name = "labelSoLuongTramRang";
            this.labelSoLuongTramRang.Size = new System.Drawing.Size(50, 22);
            this.labelSoLuongTramRang.TabIndex = 10;
            this.labelSoLuongTramRang.Text = "Số lượng:";
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(50, 260);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(100, 22);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.textBoxTenKhachHang);
            this.Controls.Add(this.numericUpDownSoLuongTramRang);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.checkBoxCaoVoi);
            this.Controls.Add(this.checkBoxTayTrang);
            this.Controls.Add(this.checkBoxChupHinhRang);
            this.Controls.Add(this.checkBoxTramRang);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.labelTenKhachHang);
            this.Controls.Add(this.labelSoLuongTramRang);
            this.Controls.Add(this.labelTotal);
            this.Name = "Form1";
            this.Text = "Dental Payment Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CheckBoxTramRang_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

