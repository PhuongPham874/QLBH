namespace QLBH
{
    partial class fmXoamon
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
            this.btXoa = new System.Windows.Forms.Button();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.lbTenmon = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbXOAMon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(500, 197);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(108, 55);
            this.btXoa.TabIndex = 13;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // tbGia
            // 
            this.tbGia.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGia.Location = new System.Drawing.Point(721, 115);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(281, 39);
            this.tbGia.TabIndex = 12;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(591, 118);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(120, 31);
            this.lbGia.TabIndex = 11;
            this.lbGia.Text = "Giá món: ";
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTen.Location = new System.Drawing.Point(254, 112);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(281, 39);
            this.tbTen.TabIndex = 10;
            // 
            // lbTenmon
            // 
            this.lbTenmon.AutoSize = true;
            this.lbTenmon.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenmon.Location = new System.Drawing.Point(124, 115);
            this.lbTenmon.Name = "lbTenmon";
            this.lbTenmon.Size = new System.Drawing.Size(124, 31);
            this.lbTenmon.TabIndex = 9;
            this.lbTenmon.Text = "Tên món: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(777, 339);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbXOAMon
            // 
            this.lbXOAMon.AutoSize = true;
            this.lbXOAMon.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXOAMon.Location = new System.Drawing.Point(322, 31);
            this.lbXOAMon.Name = "lbXOAMon";
            this.lbXOAMon.Size = new System.Drawing.Size(420, 42);
            this.lbXOAMon.TabIndex = 7;
            this.lbXOAMon.Text = "XÓA THÔNG TIN MÓN";
            this.lbXOAMon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fmXoamon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBH.Properties.Resources.anhnen1_011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 655);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.lbTenmon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbXOAMon);
            this.DoubleBuffered = true;
            this.Name = "fmXoamon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa_món";
            this.Load += new System.EventHandler(this.fmXoamon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label lbTenmon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbXOAMon;
    }
}