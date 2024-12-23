using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
