using System;
using System.Windows.Forms;

namespace bai3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxHoTen;
        private ListBox listBoxThongTin;
        private Button btnNhapThongTin;
        private Button btnXoaThongTinDaChon;
        private Button btnXoaThongTinDau;
        private Button btnXoaThongTinCuoi;
        private Button btnXoaTatCaThongTin;
        private Label labelHoTen;
        private Label labelTongSo;
        private Label tieude;
        private TextBox textBoxTongSo;
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
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.listBoxThongTin = new System.Windows.Forms.ListBox();
            this.btnNhapThongTin = new System.Windows.Forms.Button();
            this.btnXoaThongTinDaChon = new System.Windows.Forms.Button();
            this.btnXoaThongTinDau = new System.Windows.Forms.Button();
            this.btnXoaThongTinCuoi = new System.Windows.Forms.Button();
            this.btnXoaTatCaThongTin = new System.Windows.Forms.Button();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelTongSo = new System.Windows.Forms.Label();
            this.textBoxTongSo = new System.Windows.Forms.TextBox();
            this.tieude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(12, 200);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(150, 22);
            this.textBoxHoTen.TabIndex = 0;
            // 
            // listBoxThongTin
            // 
            this.listBoxThongTin.FormattingEnabled = true;
            this.listBoxThongTin.ItemHeight = 16;
            this.listBoxThongTin.Location = new System.Drawing.Point(285, 84);
            this.listBoxThongTin.Name = "listBoxThongTin";
            this.listBoxThongTin.Size = new System.Drawing.Size(250, 180);
            this.listBoxThongTin.TabIndex = 1;
            // 
            // btnNhapThongTin
            // 
            this.btnNhapThongTin.Location = new System.Drawing.Point(12, 245);
            this.btnNhapThongTin.Name = "btnNhapThongTin";
            this.btnNhapThongTin.Size = new System.Drawing.Size(127, 33);
            this.btnNhapThongTin.TabIndex = 2;
            this.btnNhapThongTin.Text = "Nhập thông tin";
            this.btnNhapThongTin.Click += new System.EventHandler(this.btnNhapThongTin_Click);
            // 
            // btnXoaThongTinDaChon
            // 
            this.btnXoaThongTinDaChon.Location = new System.Drawing.Point(404, 393);
            this.btnXoaThongTinDaChon.Name = "btnXoaThongTinDaChon";
            this.btnXoaThongTinDaChon.Size = new System.Drawing.Size(150, 30);
            this.btnXoaThongTinDaChon.TabIndex = 3;
            this.btnXoaThongTinDaChon.Text = "Xóa thông tin đã chọn";
            this.btnXoaThongTinDaChon.Click += new System.EventHandler(this.btnXoaThongTinDaChon_Click);
            // 
            // btnXoaThongTinDau
            // 
            this.btnXoaThongTinDau.Location = new System.Drawing.Point(404, 346);
            this.btnXoaThongTinDau.Name = "btnXoaThongTinDau";
            this.btnXoaThongTinDau.Size = new System.Drawing.Size(150, 30);
            this.btnXoaThongTinDau.TabIndex = 4;
            this.btnXoaThongTinDau.Text = "Xóa thông tin đầu";
            this.btnXoaThongTinDau.Click += new System.EventHandler(this.btnXoaThongTinDau_Click);
            // 
            // btnXoaThongTinCuoi
            // 
            this.btnXoaThongTinCuoi.Location = new System.Drawing.Point(230, 346);
            this.btnXoaThongTinCuoi.Name = "btnXoaThongTinCuoi";
            this.btnXoaThongTinCuoi.Size = new System.Drawing.Size(150, 30);
            this.btnXoaThongTinCuoi.TabIndex = 5;
            this.btnXoaThongTinCuoi.Text = "Xóa thông tin cuối";
            this.btnXoaThongTinCuoi.Click += new System.EventHandler(this.btnXoaThongTinCuoi_Click);
            // 
            // btnXoaTatCaThongTin
            // 
            this.btnXoaTatCaThongTin.Location = new System.Drawing.Point(233, 393);
            this.btnXoaTatCaThongTin.Name = "btnXoaTatCaThongTin";
            this.btnXoaTatCaThongTin.Size = new System.Drawing.Size(150, 30);
            this.btnXoaTatCaThongTin.TabIndex = 6;
            this.btnXoaTatCaThongTin.Text = "Xóa tất cả thông tin";
            this.btnXoaTatCaThongTin.Click += new System.EventHandler(this.btnXoaTatCaThongTin_Click);
            // 
            // labelHoTen
            // 
            this.labelHoTen.Location = new System.Drawing.Point(49, 151);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(60, 22);
            this.labelHoTen.TabIndex = 7;
            this.labelHoTen.Text = "Họ tên:";
            // 
            // labelTongSo
            // 
            this.labelTongSo.Location = new System.Drawing.Point(230, 294);
            this.labelTongSo.Name = "labelTongSo";
            this.labelTongSo.Size = new System.Drawing.Size(150, 22);
            this.labelTongSo.TabIndex = 8;
            this.labelTongSo.Text = "Tổng số người đã khai báo:";
            // 
            // textBoxTongSo
            // 
            this.textBoxTongSo.Location = new System.Drawing.Point(445, 294);
            this.textBoxTongSo.Name = "textBoxTongSo";
            this.textBoxTongSo.ReadOnly = true;
            this.textBoxTongSo.Size = new System.Drawing.Size(90, 22);
            this.textBoxTongSo.TabIndex = 9;
            // 
            // tieude
            // 
            this.tieude.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieude.Location = new System.Drawing.Point(12, 21);
            this.tieude.Name = "tieude";
            this.tieude.Size = new System.Drawing.Size(676, 43);
            this.tieude.TabIndex = 9;
            this.tieude.Text = "Khai báo y tế điện tử";
            this.tieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.textBoxHoTen);
            this.Controls.Add(this.listBoxThongTin);
            this.Controls.Add(this.btnNhapThongTin);
            this.Controls.Add(this.btnXoaThongTinDaChon);
            this.Controls.Add(this.btnXoaThongTinDau);
            this.Controls.Add(this.btnXoaThongTinCuoi);
            this.Controls.Add(this.btnXoaTatCaThongTin);
            this.Controls.Add(this.labelHoTen);
            this.Controls.Add(this.labelTongSo);
            this.Controls.Add(this.textBoxTongSo);
            this.Controls.Add(this.tieude);
            this.Name = "Form1";
            this.Text = "Khai báo y tế điện tử";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

