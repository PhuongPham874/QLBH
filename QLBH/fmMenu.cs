using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTDT;
using WindowsFormsApp1;

namespace QLBH
{
    public partial class fmMenu : Form
    {
        public fmMenu()
        {
            InitializeComponent();
        }

        private void xemThôngTinMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmQuanLyMon Mon = new fmQuanLyMon();
            Mon.MdiParent = this;
            Mon.Show();
        }

        private void ChinhsuaMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmChinhsuattMon Mon = new fmChinhsuattMon();
            Mon.MdiParent = this;
            Mon.Show();

        }

        private void xoaMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmXoamon Mon = new fmXoamon();
            Mon.MdiParent = this;
            Mon.Show();
        }

        private void ThemmoittMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmThemmoimon Mon = new fmThemmoimon();
            Mon.MdiParent = this;
            Mon.Show();
        }

        private void fmMenu_Load(object sender, EventArgs e)
        {

        }

        private void HoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadon HD = new frmHoadon();
            HD.MdiParent = this;
            HD.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChitiethoadon HD = new frmChitiethoadon();
            HD.MdiParent = this;
            HD.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien NV = new Nhanvien();
            NV.MdiParent = this;
            NV.Show();
        }

        private void hiểnThịDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThiDoanhThu DT = new HienThiDoanhThu();
            DT.MdiParent = this;
            DT.Show();
        }

        private void thôngTinĐặtBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinDatBan Ban = new frmThongTinDatBan();
            Ban.MdiParent = this;
            Ban.Show();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBan Ban = new frmBan();
            Ban.MdiParent = this;
            Ban.Show();
        }
    }
}
