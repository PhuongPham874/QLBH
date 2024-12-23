namespace QLBH
{
    partial class fmChinhsuattMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmChinhsuattMon));
            this.lbCSTTMon = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTenmon = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCSTTMon
            // 
            this.lbCSTTMon.AutoSize = true;
            this.lbCSTTMon.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCSTTMon.Location = new System.Drawing.Point(241, 37);
            this.lbCSTTMon.Name = "lbCSTTMon";
            this.lbCSTTMon.Size = new System.Drawing.Size(548, 42);
            this.lbCSTTMon.TabIndex = 0;
            this.lbCSTTMon.Text = "CHỈNH SỬA THÔNG TIN MÓN";
            this.lbCSTTMon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(777, 339);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbTenmon
            // 
            this.lbTenmon.AutoSize = true;
            this.lbTenmon.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenmon.Location = new System.Drawing.Point(43, 121);
            this.lbTenmon.Name = "lbTenmon";
            this.lbTenmon.Size = new System.Drawing.Size(124, 31);
            this.lbTenmon.TabIndex = 2;
            this.lbTenmon.Text = "Tên món: ";
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTen.Location = new System.Drawing.Point(173, 118);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(281, 39);
            this.tbTen.TabIndex = 3;
            // 
            // tbGia
            // 
            this.tbGia.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGia.Location = new System.Drawing.Point(640, 121);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(281, 39);
            this.tbGia.TabIndex = 5;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(510, 124);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(120, 31);
            this.lbGia.TabIndex = 4;
            this.lbGia.Text = "Giá món: ";
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(427, 197);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(108, 55);
            this.btLuu.TabIndex = 6;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // fmChinhsuattMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 701);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.lbTenmon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbCSTTMon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmChinhsuattMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh_sửa_thông_tin_Món";
            this.Load += new System.EventHandler(this.Chỉnh_sửa_thông_tin_Món_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCSTTMon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTenmon;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Button btLuu;
    }
}