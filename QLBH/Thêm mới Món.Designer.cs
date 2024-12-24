namespace QLBH
{
    partial class fmThemmoimon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmThemmoimon));
            this.btLuu = new System.Windows.Forms.Button();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.lbTenmon = new System.Windows.Forms.Label();
            this.lbThemmoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(468, 556);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(108, 55);
            this.btLuu.TabIndex = 13;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // tbGia
            // 
            this.tbGia.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGia.Location = new System.Drawing.Point(724, 257);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(281, 39);
            this.tbGia.TabIndex = 12;
            this.tbGia.TextChanged += new System.EventHandler(this.tbGia_TextChanged);
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(598, 265);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(120, 31);
            this.lbGia.TabIndex = 11;
            this.lbGia.Text = "Giá món: ";
            this.lbGia.Click += new System.EventHandler(this.lbGia_Click);
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTen.Location = new System.Drawing.Point(193, 257);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(281, 39);
            this.tbTen.TabIndex = 10;
            this.tbTen.TextChanged += new System.EventHandler(this.tbTen_TextChanged);
            // 
            // lbTenmon
            // 
            this.lbTenmon.AutoSize = true;
            this.lbTenmon.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenmon.Location = new System.Drawing.Point(63, 265);
            this.lbTenmon.Name = "lbTenmon";
            this.lbTenmon.Size = new System.Drawing.Size(124, 31);
            this.lbTenmon.TabIndex = 9;
            this.lbTenmon.Text = "Tên món: ";
            this.lbTenmon.Click += new System.EventHandler(this.lbTenmon_Click);
            // 
            // lbThemmoi
            // 
            this.lbThemmoi.AutoSize = true;
            this.lbThemmoi.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemmoi.Location = new System.Drawing.Point(265, 175);
            this.lbThemmoi.Name = "lbThemmoi";
            this.lbThemmoi.Size = new System.Drawing.Size(541, 42);
            this.lbThemmoi.TabIndex = 7;
            this.lbThemmoi.Text = "THÊM MỚI THÔNG TIN MÓN";
            this.lbThemmoi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbThemmoi.Click += new System.EventHandler(this.lbCSTTMon_Click);
            // 
            // fmThemmoimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBH.Properties.Resources.anhnen1_011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 641);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.lbTenmon);
            this.Controls.Add(this.lbThemmoi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmThemmoimon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới Món";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmThemmoimon_FormClosing);
            this.Load += new System.EventHandler(this.fmThemmoimon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label lbTenmon;
        private System.Windows.Forms.Label lbThemmoi;
    }
}