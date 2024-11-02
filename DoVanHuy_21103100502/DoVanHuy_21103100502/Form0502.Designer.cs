namespace DoVanHuy_21103100502
{
    partial class Form0502
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1_0502 = new System.Windows.Forms.RichTextBox();
            this.buttonLoad_0502 = new System.Windows.Forms.Button();
            this.buttonModify_0502 = new System.Windows.Forms.Button();
            this.buttonStats_0502 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1_0502
            // 
            this.richTextBox1_0502.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1_0502.Name = "richTextBox1_0502";
            this.richTextBox1_0502.Size = new System.Drawing.Size(360, 200);
            this.richTextBox1_0502.TabIndex = 0;
            this.richTextBox1_0502.Text = "";
            // 
            // buttonLoad_0502
            // 
            this.buttonLoad_0502.Location = new System.Drawing.Point(12, 218);
            this.buttonLoad_0502.Name = "buttonLoad_0502";
            this.buttonLoad_0502.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad_0502.TabIndex = 1;
            this.buttonLoad_0502.Text = "Load Data";
            this.buttonLoad_0502.UseVisualStyleBackColor = true;
            this.buttonLoad_0502.Click += new System.EventHandler(this.buttonLoad_0502_Click);
            // 
            // buttonModify_0502
            // 
            this.buttonModify_0502.Location = new System.Drawing.Point(150, 218);
            this.buttonModify_0502.Name = "buttonModify_0502";
            this.buttonModify_0502.Size = new System.Drawing.Size(75, 23);
            this.buttonModify_0502.TabIndex = 2;
            this.buttonModify_0502.Text = "Modify Player";
            this.buttonModify_0502.UseVisualStyleBackColor = true;
            this.buttonModify_0502.Click += new System.EventHandler(this.buttonModify_0502_Click);
            // 
            // buttonStats_0502
            // 
            this.buttonStats_0502.Location = new System.Drawing.Point(297, 218);
            this.buttonStats_0502.Name = "buttonStats_0502";
            this.buttonStats_0502.Size = new System.Drawing.Size(75, 23);
            this.buttonStats_0502.TabIndex = 3;
            this.buttonStats_0502.Text = "Show Stats";
            this.buttonStats_0502.UseVisualStyleBackColor = true;
            this.buttonStats_0502.Click += new System.EventHandler(this.buttonStats_0502_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.buttonStats_0502);
            this.Controls.Add(this.buttonModify_0502);
            this.Controls.Add(this.buttonLoad_0502);
            this.Controls.Add(this.richTextBox1_0502);
            this.Name = "MainForm";
            this.Text = "Skill Management";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1_0502;
        private System.Windows.Forms.Button buttonLoad_0502;
        private System.Windows.Forms.Button buttonModify_0502;
        private System.Windows.Forms.Button buttonStats_0502;
    }
}