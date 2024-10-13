namespace bai1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMau;
        private System.Windows.Forms.Button btnDoiMau;
        private System.Windows.Forms.Button button1;
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMau = new System.Windows.Forms.ComboBox();
            this.btnDoiMau = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào mừng bạn đến học phần Lập trình. NET ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn màu";
            // 
            // cboMau
            // 
            this.cboMau.FormattingEnabled = true;
            this.cboMau.Items.AddRange(new object[] {
            "Yellow",
            "Red",
            "Blue",
            "Green"});
            this.cboMau.Location = new System.Drawing.Point(249, 90);
            this.cboMau.Name = "cboMau";
            this.cboMau.Size = new System.Drawing.Size(167, 29);
            this.cboMau.TabIndex = 2;
            // 
            // btnDoiMau
            // 
            this.btnDoiMau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMau.ForeColor = System.Drawing.Color.Blue;
            this.btnDoiMau.Location = new System.Drawing.Point(189, 150);
            this.btnDoiMau.Name = "btnDoiMau";
            this.btnDoiMau.Size = new System.Drawing.Size(104, 41);
            this.btnDoiMau.TabIndex = 3;
            this.btnDoiMau.Text = "Đổi màu";
            this.btnDoiMau.UseVisualStyleBackColor = true;
            this.btnDoiMau.Click += new System.EventHandler(this.btnDoiMau_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(388, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDoiMau);
            this.Controls.Add(this.cboMau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Lựa chọn màu nền qua Combo Box";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

