namespace bai1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchHàngToolStripMenuItem,
            this.thôngTinMặtHàngToolStripMenuItem,
            this.chiTiếtBánHàngToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            this.thôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngToolStripMenuItem_Click);
            // 
            // thôngTinMặtHàngToolStripMenuItem
            // 
            this.thôngTinMặtHàngToolStripMenuItem.Name = "thôngTinMặtHàngToolStripMenuItem";
            this.thôngTinMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.thôngTinMặtHàngToolStripMenuItem.Text = "Thông tin mặt hàng";
            this.thôngTinMặtHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinMặtHàngToolStripMenuItem_Click);
            // 
            // chiTiếtBánHàngToolStripMenuItem
            // 
            this.chiTiếtBánHàngToolStripMenuItem.Name = "chiTiếtBánHàngToolStripMenuItem";
            this.chiTiếtBánHàngToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.chiTiếtBánHàngToolStripMenuItem.Text = "Chi tiết bán hàng";
            this.chiTiếtBánHàngToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtBánHàngToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmKháchHàngToolStripMenuItem,
            this.tìmKiếmMặtHàngToolStripMenuItem,
            this.tìmKiếmBánToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // tìmKiếmKháchHàngToolStripMenuItem
            // 
            this.tìmKiếmKháchHàngToolStripMenuItem.Name = "tìmKiếmKháchHàngToolStripMenuItem";
            this.tìmKiếmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.tìmKiếmKháchHàngToolStripMenuItem.Text = "Tìm kiếm khách hàng";
            // 
            // tìmKiếmMặtHàngToolStripMenuItem
            // 
            this.tìmKiếmMặtHàngToolStripMenuItem.Name = "tìmKiếmMặtHàngToolStripMenuItem";
            this.tìmKiếmMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.tìmKiếmMặtHàngToolStripMenuItem.Text = "Tìm kiếm mặt hàng";
            // 
            // tìmKiếmBánToolStripMenuItem
            // 
            this.tìmKiếmBánToolStripMenuItem.Name = "tìmKiếmBánToolStripMenuItem";
            this.tìmKiếmBánToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.tìmKiếmBánToolStripMenuItem.Text = "Tìm kiếm bán hàng";
            this.tìmKiếmBánToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmBánToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinMặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmMặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmBánToolStripMenuItem;
    }
}

