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

namespace QLBH
{
    public partial class fmXoamon : Form
    {
        private string sMonid;
        string sConnect = "Data Source=PHUONGPHAM\\MSSQLDEV;Initial Catalog=QLBH;Integrated Security=True";
        public fmXoamon()
        {
            InitializeComponent();
        }

        

        private void fmXoamon_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sMonid = dataGridView1.Rows[e.RowIndex].Cells["MON_ID"].Value.ToString();
            tbTen.Text = dataGridView1.Rows[e.RowIndex].Cells["MON_TEN"].Value.ToString();
            tbGia.Text = dataGridView1.Rows[e.RowIndex].Cells["MON_GIA"].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
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
            string sDeleteMon = "Delete from Mon where MON_ID = @monid";
            SqlCommand DeleteMon = new SqlCommand(sDeleteMon, conn);
            DeleteMon.Parameters.AddWithValue("@monid", sMonid);
            try
            {
                DeleteMon.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin thành công !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình Xóa.");
            }
            conn.Close();
        }
    }
}
