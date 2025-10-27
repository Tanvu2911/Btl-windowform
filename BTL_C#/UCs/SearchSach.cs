//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace BTL_C_
//{
//    public partial class SearchSach : System.Windows.Forms.UserControl
//    {
//        Classes.DataProcesser dtbase = new Classes.DataProcesser();
//        Classes.Funtion ft = new Classes.Funtion();

//        public SearchSach()
//        {
//            InitializeComponent();
//        }

//        private void SearchSach_Load(object sender, EventArgs e)
//        {
//            DataTable dt = dtbase.DocBang("select * from Sach");
//            dgvSach.DataSource = dt;

//            DataTable dttl = dtbase.DocBang("select * from TheLoai");
//            ft.FillCombobox(cb1, dttl, "TenTheLoai", "MaTheLoai");
//            rbtTenSach.Checked = false;
//            rbtNhaXuatBan.Checked = false;
//            rbtTacGia.Checked = false;
//            cb1.SelectedIndex = -1;
//        }

//        private void btSach_Click(object sender, EventArgs e)
//        {
//            Sach sach = new Sach();
//            sach.Show();
//        }

//        private void tbTim_TextChanged(object sender, EventArgs e)
//        {
//            string selectsql = "";
//            if (rbtTenSach.Checked)
//                selectsql = "TenSach";
//            if (rbtTacGia.Checked)
//                selectsql = "TacGia";
//            if (rbtNhaXuatBan.Checked)
//                selectsql = "NhaXuatBan";

//            if (selectsql == "" && cb1.SelectedIndex == -1)
//                return;

//            string sql = "";
//            if (cb1.SelectedIndex != -1 && selectsql != "")
//                sql = $"select * from Sach where {selectsql} LIKE N'%{tbTim.Text}%' and MaTheLoai = N'{cb1.SelectedValue}'";
//            else
//                sql = $"select * from Sach where {selectsql} LIKE N'%{tbTim.Text}%'";

//            DataTable dt = dtbase.DocBang(sql);
//            dgvSach.DataSource = dt;
//        }

//        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (cb1.SelectedValue != null && !(cb1.SelectedValue is DataRowView))
//            {
//                string sql = $"select * from Sach where MaTheLoai = N'{cb1.SelectedValue}'";
//                DataTable dt = dtbase.DocBang(sql);
//                dgvSach.DataSource = dt;
//            }
//        }

//        private void btTheLoai_Click(object sender, EventArgs e)
//        {
//            TheLoai theLoai = new TheLoai();
//            theLoai.Show();
//        }

//        private void btnReset_Click(object sender, EventArgs e)
//        {
//            rbtNhaXuatBan.Checked = false;
//            rbtTacGia.Checked = false;
//            rbtTenSach.Checked = false;
//            cb1.SelectedIndex = -1;
//            DataTable dt = dtbase.DocBang("select * from Sach");
//            dgvSach.DataSource= dt;
//            tbTim.Text = "";
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_
{
    public partial class SearchSach : System.Windows.Forms.UserControl
    {
        Classes.DataProcesser dtbase = new Classes.DataProcesser();
        Classes.Funtion ft = new Classes.Funtion();

        public SearchSach()
        {
            InitializeComponent();
        }

        private void SearchSach_Load(object sender, EventArgs e)
        {
            DataTable dt = dtbase.DocBang("select * from Sach");
            dgvSach.DataSource = dt;

            DataTable dttl = dtbase.DocBang("select * from TheLoai");
            ft.FillCombobox(cb1, dttl, "TenTheLoai", "MaTheLoai");

            rbtTenSach.Checked = false;
            rbtNhaXuatBan.Checked = false;
            rbtTacGia.Checked = false;
            cb1.SelectedIndex = -1;

            dgvSach.DefaultCellStyle.ForeColor = Color.Black;
            dgvSach.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void btSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.Show();
        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            string selectsql = "";
            if (rbtTenSach.Checked)
                selectsql = "TenSach";
            if (rbtTacGia.Checked)
                selectsql = "TacGia";
            if (rbtNhaXuatBan.Checked)
                selectsql = "NhaXuatBan";

            if (string.IsNullOrEmpty(selectsql) && cb1.SelectedIndex == -1)
            {
                DataTable dtAll = dtbase.DocBang("select * from Sach");
                dgvSach.DataSource = dtAll;
                return;
            }

            string sql = "select * from Sach where 1=1";

            if (cb1.SelectedIndex != -1 && cb1.SelectedValue != null && !(cb1.SelectedValue is DataRowView))
                sql += $" and MaTheLoai = N'{cb1.SelectedValue}'";

            if (!string.IsNullOrEmpty(selectsql) && !string.IsNullOrEmpty(tbTim.Text))
                sql += $" and {selectsql} LIKE N'%{tbTim.Text}%'";

            DataTable dt = dtbase.DocBang(sql);
            dgvSach.DataSource = dt;
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb1.SelectedValue != null && !(cb1.SelectedValue is DataRowView))
            {
                string sql = $"select * from Sach where MaTheLoai = N'{cb1.SelectedValue}'";

                string selectsql = "";
                if (rbtTenSach.Checked)
                    selectsql = "TenSach";
                if (rbtTacGia.Checked)
                    selectsql = "TacGia";
                if (rbtNhaXuatBan.Checked)
                    selectsql = "NhaXuatBan";

                if (!string.IsNullOrEmpty(selectsql) && !string.IsNullOrEmpty(tbTim.Text))
                    sql += $" and {selectsql} LIKE N'%{tbTim.Text}%'";

                DataTable dt = dtbase.DocBang(sql);
                dgvSach.DataSource = dt;
            }
        }

        private void btTheLoai_Click(object sender, EventArgs e)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rbtNhaXuatBan.Checked = false;
            rbtTacGia.Checked = false;
            rbtTenSach.Checked = false;
            cb1.SelectedIndex = -1;
            tbTim.Text = "";

            DataTable dt = dtbase.DocBang("select * from Sach");
            dgvSach.DataSource = dt;
        }
    }
}
