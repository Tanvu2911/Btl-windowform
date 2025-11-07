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
    public partial class TheLoai : Form
    {
        Classes.DataProcesser db = new Classes.DataProcesser();
        Classes.Funtion ft = new Classes.Funtion();
        public TheLoai()
        {
            InitializeComponent();
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            DataTable dt = db.DocBang("select * from TheLoai");
            dgvTheLoai.DataSource = dt;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ma = tbMaTheLoai.Text.Trim();
            string ten = tbTim.Text.Trim();

            // Nếu cả 2 đều rỗng => load toàn bộ
            if (ma == "" && ten == "")
            {
                DataTable dtAll = db.DocBang("SELECT * FROM TheLoai");
                dgvTheLoai.DataSource = dtAll;
                return;
            }

            // Tạo câu truy vấn động
            string query = "SELECT * FROM TheLoai WHERE 1=1";

            if (ma != "")
            {
                query += " AND MaTheLoai LIKE N'%" + ma + "%'";
            }

            if (ten != "")
            {
                query += " AND TenTheLoai LIKE N'%" + ten + "%'";
            }

            // Thực hiện truy vấn
            DataTable dt = db.DocBang(query);
            dgvTheLoai.DataSource = dt;

            // Nếu không có kết quả
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thể loại nào phù hợp!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = tbMaTheLoai.Text.Trim();
            string ten = tbTim.Text.Trim();

            if (ma == "" || ten == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            DataTable dt = db.DocBang("SELECT * FROM TheLoai WHERE MaTheLoai = N'" + ma + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã thể loại đã tồn tại!");
                return;
            }

            string query = "INSERT INTO TheLoai(MaTheLoai, TenTheLoai) VALUES (N'" + ma + "', N'" + ten + "')";
            db.CapNhatDuLieu(query);
            DataTable dt1 = db.DocBang("SELECT * FROM TheLoai");
            dgvTheLoai.DataSource = dt1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbTim.Text != "" && tbMaTheLoai.Text != "")
            {
                DataTable dt1 = db.DocBang("select * from TheLoai where MaTheLoai = N'" + tbMaTheLoai.Text + "'");
                if(dt1.Rows.Count > 0)
                {
                    string str = "update TheLoai set TenTheLoai = N'" + tbTim.Text + "' where MaTheLoai = N'" + tbMaTheLoai.Text+"'";
                    db.CapNhatDuLieu(str);
                    DataTable dt = db.DocBang("select * from TheLoai");
                    dgvTheLoai.DataSource = dt;
                    return;

                }
                string str2 = "insert into TheLoai(MaTheLoai, TenTheLoai) " +
                     "values (N'" + tbMaTheLoai.Text + "', N'" + tbTim.Text + "')";
                db.CapNhatDuLieu(str2);
                DataTable dt2 = db.DocBang("select * from TheLoai");
                dgvTheLoai.DataSource = dt2;
                return;

            }
            MessageBox.Show("vui long nhap du thong tin");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMaTheLoai.Text != "")
            {
                string str = "delete from TheLoai where MaTheLoai = N'" + tbMaTheLoai.Text + "'";
                db.CapNhatDuLieu(str);
                DataTable dt = db.DocBang("select * from TheLoai");
                dgvTheLoai.DataSource = dt;
                return;
            }

            MessageBox.Show("Vui lòng nhập mã thể loại cần xóa!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaTheLoai.Text = dgvTheLoai.CurrentRow.Cells[0].Value.ToString();
            tbTim.Text = dgvTheLoai.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaTheLoai.Text = "";
            tbTim.Text = "";
            DataTable dt2 = db.DocBang("select * from TheLoai");
            dgvTheLoai.DataSource = dt2;
        }
    }
}
