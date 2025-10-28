using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.UCs
{
    public partial class DocGia : System.Windows.Forms.UserControl
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        DataTable dtDocGia;

        public DocGia()
        {
            InitializeComponent();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            button2.Enabled = false;
            button3.Enabled = false;
            txtMaDG.Enabled = false;
            string sql = "SELECT MaDG, HoTen, CONVERT(varchar, NgaySinh, 103) AS NgaySinh, DiaChi, DienThoai FROM DocGia";
            dtDocGia = dtBase.DocBang(sql);
            dgvDocGia.DataSource = dtDocGia;
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 🧱 1️⃣ Nếu click vào header hoặc ngoài vùng dữ liệu => thoát luôn
            if (e.RowIndex < 0 || e.RowIndex >= dgvDocGia.Rows.Count)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = true;

                txtMaDG.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();
                txtDienThoai.Clear();
                return;
            }

            // 🧱 2️⃣ Nếu dòng là dòng trống (dòng "new row") => thoát luôn
            if (dgvDocGia.Rows[e.RowIndex].IsNewRow)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = true;

                txtMaDG.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();
                txtDienThoai.Clear();
                return;
            }

            // 🧱 3️⃣ Nếu dòng hợp lệ => hiển thị dữ liệu
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;

            var row = dgvDocGia.Rows[e.RowIndex];

            txtMaDG.Text = row.Cells["MaDG"].Value?.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();

            if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime ngay))
                dtpNgaySinh.Value = ngay;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }

            // Kiểm tra số điện thoại chỉ chứa số và độ dài hợp lệ
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDienThoai.Text, @"^\d{9,11}$"))
            {
                MessageBox.Show("Số điện thoại chỉ gồm 9–11 chữ số.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }

            // Kiểm tra ngày sinh
            if (dtpNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại.", "Sai ngày", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }
            if (dtpNgaySinh.Value.Year < 1900)
            {
                MessageBox.Show("Ngày sinh không hợp lệ (năm quá nhỏ).", "Sai ngày", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }

            try
            {
                // Không thêm MaDG vì nó là IDENTITY tự tăng
                string sql = $"INSERT INTO DocGia (HoTen, NgaySinh, DiaChi, DienThoai) " +
                             $"VALUES (N'{txtHoTen.Text}', '{dtpNgaySinh.Value:yyyy-MM-dd}', N'{txtDiaChi.Text}', N'{txtDienThoai.Text}')";
                dtBase.CapNhatDuLieu(sql);
                MessageBox.Show("Thêm mới thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"UPDATE DocGia SET HoTen = N'{txtHoTen.Text}', " +
                             $"NgaySinh = '{dtpNgaySinh.Value:yyyy-MM-dd}', " +
                             $"DiaChi = N'{txtDiaChi.Text}', DienThoai = N'{txtDienThoai.Text}' " +
                             $"WHERE MaDG = {txtMaDG.Text}";
                dtBase.CapNhatDuLieu(sql);
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM DocGia WHERE MaDG = {txtMaDG.Text}";
                dtBase.CapNhatDuLieu(sql);
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string dk = "";
            if (rdbTen.Checked)
                dk = $"HoTen LIKE N'%{txtTimKiem.Text}%'";
            else if (rdbSDT.Checked)
                dk = $"DienThoai LIKE N'%{txtTimKiem.Text}%'";

            string sql = "SELECT MaDG, HoTen, CONVERT(varchar, NgaySinh, 103) AS NgaySinh, DiaChi, DienThoai FROM DocGia";
            if (dk != "")
                sql += " WHERE " + dk;

            dgvDocGia.DataSource = dtBase.DocBang(sql);
        }
    }
}
