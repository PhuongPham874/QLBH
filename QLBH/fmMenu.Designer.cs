namespace QLBH
{
    partial class fmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanlyttMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XemttMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemmoittMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChinhsuaMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlyttMonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1575, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanlyttMonToolStripMenuItem
            // 
            this.quanlyttMonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XemttMonToolStripMenuItem,
            this.ThemmoittMonToolStripMenuItem,
            this.ChinhsuaMonToolStripMenuItem,
            this.xoaMonToolStripMenuItem});
            this.quanlyttMonToolStripMenuItem.Name = "quanlyttMonToolStripMenuItem";
            this.quanlyttMonToolStripMenuItem.Size = new System.Drawing.Size(280, 36);
            this.quanlyttMonToolStripMenuItem.Text = "Quản lý thông tin Món";
            // 
            // XemttMonToolStripMenuItem
            // 
            this.XemttMonToolStripMenuItem.Name = "XemttMonToolStripMenuItem";
            this.XemttMonToolStripMenuItem.Size = new System.Drawing.Size(419, 44);
            this.XemttMonToolStripMenuItem.Text = "Xem thông tin Món";
            this.XemttMonToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinMonToolStripMenuItem_Click);
            // 
            // ThemmoittMonToolStripMenuItem
            // 
            this.ThemmoittMonToolStripMenuItem.Name = "ThemmoittMonToolStripMenuItem";
            this.ThemmoittMonToolStripMenuItem.Size = new System.Drawing.Size(419, 44);
            this.ThemmoittMonToolStripMenuItem.Text = "Thêm mới thông tin Món";
            this.ThemmoittMonToolStripMenuItem.Click += new System.EventHandler(this.ThemmoittMonToolStripMenuItem_Click);
            // 
            // ChinhsuaMonToolStripMenuItem
            // 
            this.ChinhsuaMonToolStripMenuItem.Name = "ChinhsuaMonToolStripMenuItem";
            this.ChinhsuaMonToolStripMenuItem.Size = new System.Drawing.Size(419, 44);
            this.ChinhsuaMonToolStripMenuItem.Text = "Chỉnh sửa thông tin Món";
            this.ChinhsuaMonToolStripMenuItem.Click += new System.EventHandler(this.ChinhsuaMonToolStripMenuItem_Click);
            // 
            // xoaMonToolStripMenuItem
            // 
            this.xoaMonToolStripMenuItem.Name = "xoaMonToolStripMenuItem";
            this.xoaMonToolStripMenuItem.Size = new System.Drawing.Size(419, 44);
            this.xoaMonToolStripMenuItem.Text = "Xóa Món";
            this.xoaMonToolStripMenuItem.Click += new System.EventHandler(this.xoaMonToolStripMenuItem_Click);
            // 
            // fmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1575, 848);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmMenu";
            this.Load += new System.EventHandler(this.fmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanlyttMonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XemttMonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChinhsuaMonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaMonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemmoittMonToolStripMenuItem;
    }
}