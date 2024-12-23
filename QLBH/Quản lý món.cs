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
    public partial class fmQuanLyMon : Form
    {
        string sConnect = "Data Source=PHUONGPHAM\\MSSQLDEV;Initial Catalog=QLBH;Integrated Security=True";
        public fmQuanLyMon()
        {
            InitializeComponent();
        }

        

        private void lbChinhsua_Click(object sender, EventArgs e)
        {

        }

        private void fmQuanLyMon_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sConnect);
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối với CSDL");
            }
            string Struyvan = "select * from Mon ";
            SqlDataAdapter adapter = new SqlDataAdapter(Struyvan, sConnect);
            DataSet dsmon = new DataSet();
            adapter.Fill(dsmon,"Mon");
            dataGridView1.DataSource = dsmon.Tables["Mon"];
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
