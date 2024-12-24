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

namespace HTDT
{
    public partial class frmBan : Form
    {
        string sCon = "Data Source=PHUONGPHAM\\MSSQLDEV;Initial Catalog=QLBH;Integrated Security=True";
        public frmBan()
        {
            InitializeComponent();
        }


        private void frmBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối DB", "Thông báo");
            }

            int ret = 0;
            string sQuery = "exec themban @ret output";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@ret", ret);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mới");
            }
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection(sCon);
            try

            {
                con.Open();
                string sQuery = "select * from BAN";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, sCon);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "ThongTin");
                dataGridView1.DataSource = ds.Tables["ThongTin"];
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi kết nối DB");
            }
            con.Close();
        }
    }
}
