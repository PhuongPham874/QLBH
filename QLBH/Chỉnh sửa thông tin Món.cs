using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH
{

    public partial class fmChinhsuattMon : Form
    {
        private string sMonid;
        string sConnect = "Data Source=PHUONGPHAM\\MSSQLDEV;Initial Catalog=QLBH;Integrated Security=True";
        public fmChinhsuattMon()
        {
            InitializeComponent();
        }

        private void Chỉnh_sửa_thông_tin_Món_Load(object sender, EventArgs e)
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
            string Struyvan = "select * from Mon ";
            SqlDataAdapter adapter = new SqlDataAdapter(Struyvan, sConnect);
            DataSet dsmon = new DataSet();
            adapter.Fill(dsmon, "Mon");
            dataGridView1.DataSource = dsmon.Tables["Mon"];
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            sMonid =  dataGridView1.Rows[e.RowIndex].Cells["MON_ID"].Value.ToString();
            tbTen.Text = dataGridView1.Rows[e.RowIndex].Cells["MON_TEN"].Value.ToString();
            tbGia.Text = dataGridView1.Rows[e.RowIndex].Cells["MON_GIA"].Value.ToString();
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
            string sUpdateGia = "exec spUpdateGiaMon @monid, @giamonmoi,@ret output";
            string sUpdateTen = "exec chinhsuatenmon @monid, @tenmonmoi,@ret output";
            SqlCommand updateGia = new SqlCommand(sUpdateGia, conn);
            SqlCommand updateTen = new SqlCommand(sUpdateTen, conn);
            updateGia.Parameters.AddWithValue("@monid", sMonid);
            updateGia.Parameters.AddWithValue("@giamonmoi", decimal.Parse(sGiamon));
            updateGia.Parameters.AddWithValue("@ret", ret);
            updateTen.Parameters.AddWithValue("@monid", sMonid);
            updateTen.Parameters.AddWithValue("@tenmonmoi", sTenmon);
            updateTen.Parameters.AddWithValue("@ret", ret);
            try
            {
                updateGia.ExecuteNonQuery();
                updateTen.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thông tin thành công !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình Chỉnh sửa.");
            }
            conn.Close();
        }
    }
}
