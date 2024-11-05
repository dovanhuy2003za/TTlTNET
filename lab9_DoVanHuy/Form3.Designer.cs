namespace lab9_DoVanHuy
{
    partial class Form3
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
            this.thôngTinSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinSáchToolStripMenuItem,
            this.thôngTinĐộcGiảToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinSáchToolStripMenuItem
            // 
            this.thôngTinSáchToolStripMenuItem.Name = "thôngTinSáchToolStripMenuItem";
            this.thôngTinSáchToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.thôngTinSáchToolStripMenuItem.Text = "Thông tin sách";
            this.thôngTinSáchToolStripMenuItem.Click += new System.EventHandler(this.thôngTinSáchToolStripMenuItem_Click);
            // 
            // thôngTinĐộcGiảToolStripMenuItem
            // 
            this.thôngTinĐộcGiảToolStripMenuItem.Name = "thôngTinĐộcGiảToolStripMenuItem";
            this.thôngTinĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.thôngTinĐộcGiảToolStripMenuItem.Text = "Thông tin độc giả";
            this.thôngTinĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.thôngTinĐộcGiảToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem,
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem1});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // tìmKiếmThôngTinĐộcGảiToolStripMenuItem
            // 
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem.Name = "tìmKiếmThôngTinĐộcGảiToolStripMenuItem";
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem.Text = "Tìm kiếm thông tin độc gải";
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem_Click);
            // 
            // tìmKiếmThôngTinĐộcGảiToolStripMenuItem1
            // 
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem1.Name = "tìmKiếmThôngTinĐộcGảiToolStripMenuItem1";
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem1.Text = "Tìm kiếm thông tin độc gải";
            this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem1.Click += new System.EventHandler(this.tìmKiếmThôngTinĐộcGảiToolStripMenuItem1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmThôngTinĐộcGảiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmThôngTinĐộcGảiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}