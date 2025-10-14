using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_
{
    public partial class QLThuVien : Form
    {
        public QLThuVien()
        {
            InitializeComponent();
        }

        private void qlSach1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            scoll.Height= btnSach.Height;
            scoll.Top = btnSach.Top;
            //qlSach1.BringToFront();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            scoll.Height = btnDocGia.Height;
            scoll.Top = btnDocGia.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            scoll.Height = btnMuonTra.Height;
            scoll.Top = btnMuonTra.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            scoll.Height = btnNhanVien.Height;
            scoll.Top = btnNhanVien.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            scoll.Height = btnThongKe.Height;
            scoll.Top = btnThongKe.Top;
        }
    }
}
