using System;
using System.Windows.Forms;

namespace Lab3
{
    partial class Form1

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private Label labelTitle;
        private Label labelInputN;
        private Label labelResult;
        private TextBox textBoxN;
        private GroupBox groupBoxOptions;
        private RadioButton radioButtonSumDigits;
        private RadioButton radioButtonSumSeries;
        private Button buttonCalculate;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            // Tạo các điều khiển cần thiết
            this.labelTitle = new Label();
            this.labelInputN = new Label();
            this.labelResult = new Label();
            this.textBoxN = new TextBox();
            this.groupBoxOptions = new GroupBox();
            this.radioButtonSumDigits = new RadioButton();
            this.radioButtonSumSeries = new RadioButton();
            this.buttonCalculate = new Button();

            // 
            // labelTitle (Nhãn tính tổng)
            // 
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Text = "TÍNH TỔNG";
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(150, 20);
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // labelInputN (Nhãn nhập số n)
            // 
            this.labelInputN.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInputN.Text = "Nhập số n:";
            this.labelInputN.AutoSize = true;
            this.labelInputN.Location = new System.Drawing.Point(50, 70);

            // 
            // textBoxN (Textbox nhập số n)
            // 
            this.textBoxN.Location = new System.Drawing.Point(150, 70);
            this.textBoxN.Size = new System.Drawing.Size(200, 30);

            // 
            // groupBoxOptions (Lựa chọn)
            // 
            this.groupBoxOptions.Controls.Add(this.radioButtonSumDigits);
            this.groupBoxOptions.Controls.Add(this.radioButtonSumSeries);
            this.groupBoxOptions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOptions.Location = new System.Drawing.Point(50, 120);
            this.groupBoxOptions.Size = new System.Drawing.Size(300, 100);
            this.groupBoxOptions.Text = "Lựa chọn";

            // 
            // radioButtonSumDigits (Tính tổng chữ số của n)
            // 
            this.radioButtonSumDigits.AutoSize = true;
            this.radioButtonSumDigits.Location = new System.Drawing.Point(20, 30);
            this.radioButtonSumDigits.Text = "Tính tổng chữ số của n";

            // 
            // radioButtonSumSeries (Tính tổng dãy 1 + 2 + ... + n)
            // 
            this.radioButtonSumSeries.AutoSize = true;
            this.radioButtonSumSeries.Location = new System.Drawing.Point(20, 60);
            this.radioButtonSumSeries.Text = "Tính tổng dãy 1 + 1/2 + ... + 1/n";

            // 
            // buttonCalculate (Nút tính)
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(150, 240);
            this.buttonCalculate.Text = "Tính";
            this.buttonCalculate.Click += new EventHandler(this.ButtonCalculate_Click);

            // 
            // labelResult (Kết quả)
            // 
            this.labelResult.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Text = "Kết quả:";
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(50, 290);
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelInputN);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxN.Text);
            double result = 0;

            if (radioButtonSumDigits.Checked)
            {
                result = SumDigits(n);
            }
            else if (radioButtonSumSeries.Checked)
            {
                result = SumHarmonic(n);
            }

            labelResult.Text = "Kết quả: " + result;
        }

        private int SumDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        private double SumHarmonic(int n)
        {
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }
            return sum;
        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

