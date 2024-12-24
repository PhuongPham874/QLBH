
namespace WindowsFormsApp1
{
    partial class Nhanvien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tTen = new System.Windows.Forms.Label();
            this.tSDT = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.tdanhsach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtThemmoi = new System.Windows.Forms.Button();
            this.Btxem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 355);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(773, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tTen
            // 
            this.tTen.AutoSize = true;
            this.tTen.Location = new System.Drawing.Point(102, 141);
            this.tTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tTen.Name = "tTen";
            this.tTen.Size = new System.Drawing.Size(155, 25);
            this.tTen.TabIndex = 1;
            this.tTen.Text = "Tên nhân viên:";
            this.tTen.Click += new System.EventHandler(this.label1_Click);
            // 
            // tSDT
            // 
            this.tSDT.AutoSize = true;
            this.tSDT.Location = new System.Drawing.Point(97, 196);
            this.tSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tSDT.Name = "tSDT";
            this.tSDT.Size = new System.Drawing.Size(160, 25);
            this.tSDT.TabIndex = 2;
            this.tSDT.Text = "SĐT nhân viên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(357, 141);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(315, 31);
            this.txtTen.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(357, 196);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(315, 31);
            this.txtSDT.TabIndex = 4;
            // 
            // tdanhsach
            // 
            this.tdanhsach.AutoSize = true;
            this.tdanhsach.Location = new System.Drawing.Point(97, 326);
            this.tdanhsach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tdanhsach.Name = "tdanhsach";
            this.tdanhsach.Size = new System.Drawing.Size(215, 25);
            this.tdanhsach.TabIndex = 5;
            this.tdanhsach.Text = "Danh sách nhân viên";
            this.tdanhsach.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(781, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 7;
            // 
            // BtThemmoi
            // 
            this.BtThemmoi.Location = new System.Drawing.Point(648, 305);
            this.BtThemmoi.Margin = new System.Windows.Forms.Padding(4);
            this.BtThemmoi.Name = "BtThemmoi";
            this.BtThemmoi.Size = new System.Drawing.Size(133, 38);
            this.BtThemmoi.TabIndex = 8;
            this.BtThemmoi.Text = "Thêm mới";
            this.BtThemmoi.UseVisualStyleBackColor = true;
            this.BtThemmoi.Click += new System.EventHandler(this.BtThemmoi_Click);
            // 
            // Btxem
            // 
            this.Btxem.Location = new System.Drawing.Point(789, 305);
            this.Btxem.Margin = new System.Windows.Forms.Padding(4);
            this.Btxem.Name = "Btxem";
            this.Btxem.Size = new System.Drawing.Size(101, 38);
            this.Btxem.TabIndex = 9;
            this.Btxem.Text = "Xem";
            this.Btxem.UseVisualStyleBackColor = true;
            this.Btxem.Click += new System.EventHandler(this.Btxem_Click);
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::QLBH.Properties.Resources.anhnen1_012;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 721);
            this.Controls.Add(this.Btxem);
            this.Controls.Add(this.BtThemmoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tdanhsach);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.tSDT);
            this.Controls.Add(this.tTen);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhanvien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nhanvien_FormClosing);
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tTen;
        private System.Windows.Forms.Label tSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label tdanhsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtThemmoi;
        private System.Windows.Forms.Button Btxem;
    }
}

