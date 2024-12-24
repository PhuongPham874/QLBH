using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH
{
    public partial class fmThemmoimon : Form
    {
        string sConnect = "Data Source=PHUONGPHAM\\MSSQLDEV;Initial Catalog=QLBH;Integrated Security=True";
        public fmThemmoimon()
        {
            InitializeComponent();
        }

        private void lbCSTTMon_Click(object sender, EventArgs e)
        {

        }

        private void tbGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbGia_Click(object sender, EventArgs e)
        {

        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTenmon_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sConnect);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối với CSDL");
            }
            //Gán dữ liệu vào biến
            string sTenmon = tbTen.Text;
            string sGiamon = tbGia.Text;
            int ret = 0;
            if (string.IsNullOrEmpty(sTenmon) && string.IsNullOrEmpty(sGiamon))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (decimal.TryParse(sGiamon, out decimal giaMon))
            {
                
            }
            else
            {
                MessageBox.Show("Giá món không hợp lệ. Vui lòng nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sInsert = "exec addMon @tenmon, @giamon,@ret output";
            SqlCommand cmd = new SqlCommand(sInsert, conn);
            cmd.Parameters.AddWithValue("@tenmon", sTenmon);
            cmd.Parameters.AddWithValue("@giamon", decimal.Parse(sGiamon));
            cmd.Parameters.AddWithValue("@ret", ret);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công !!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới.");
            }
            conn.Close();
        }

        private void fmThemmoimon_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void fmThemmoimon_Load(object sender, EventArgs e)
        {

        }
    }
}
