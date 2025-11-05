using BTL_C_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BTL_C_.UCs
{
    public partial class NhanVien : UserControl
    {
        DataProcesser dtBase = new DataProcesser();
        string fileAnh = "";
        public NhanVien()
        {
            InitializeComponent();
        }



        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnLamMoi.Enabled = true;

        }
        private void LoadData()
        {
            DataTable dt = dtBase.DocBang("SELECT * FROM NhanVien");
            dgvNhanVien.DataSource = dt;
        }
        private void ClearFields()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtChucVu.Clear();
            txtMucLuong.Clear();
            ptAnh.Image = null;
            fileAnh = "";
            dtpNgaySinh.Value = DateTime.Now;


            // 🔹 Sau khi làm mới hoặc thêm xong: chỉ bật Thêm
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void txtMucLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số hoặc phím điều khiển (Backspace, Delete)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bỏ qua ký tự không hợp lệ
            }
        }
        private void txtSDT_Leave(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(sdt))
                return; // Nếu để trống thì bỏ qua (hoặc bạn có thể yêu cầu nhập nếu muốn)

            // Kiểm tra chỉ chứa số (phòng trường hợp copy/paste)
            if (!sdt.All(char.IsDigit))
            {
                MessageBox.Show("⚠️ Số điện thoại chỉ được chứa các chữ số!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                txtSDT.SelectAll();
                return;
            }

            // Kiểm tra bắt đầu bằng 0 và độ dài hợp lệ
            if (!sdt.StartsWith("0") || sdt.Length < 9 || sdt.Length > 12)
            {
                MessageBox.Show("⚠️ Số điện thoại phải bắt đầu bằng 0 và có từ 9 đến 12 chữ số!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                txtSDT.SelectAll();
                return;
            }
        }


        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 🧱 1️⃣ Nếu click vào header hoặc ngoài vùng dữ liệu => thoát luôn
            if (e.RowIndex < 0 || e.RowIndex >= dgvNhanVien.Rows.Count)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                ClearFields();
                return;
            }

            // 🧱 2️⃣ Nếu dòng là dòng trống (dòng "new row") => thoát luôn
            if (dgvNhanVien.Rows[e.RowIndex].IsNewRow)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                ClearFields(); return;
            }

            // 🧱 3️⃣ Dòng hợp lệ → hiển thị dữ liệu
            var row = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
            txtTenNV.Text = row.Cells["TenNV"].Value?.ToString();
            txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
            txtSDT.Text = row.Cells["SDT"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtMucLuong.Text = row.Cells["MucLuong"].Value?.ToString();

            // Ngày sinh — tránh lỗi DBNull
            if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime ngaySinh))
                dtpNgaySinh.Value = ngaySinh;
            else
                dtpNgaySinh.Value = DateTime.Today;

            // Ảnh — tránh lỗi DBNull & ảnh không tồn tại
            string duongDanAnh = row.Cells["Anh"].Value?.ToString();
            if (!string.IsNullOrEmpty(duongDanAnh) && File.Exists(duongDanAnh))
            {
                ptAnh.Image = Image.FromFile(duongDanAnh);
                ptAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                fileAnh = duongDanAnh;
            }
            else
            {
                ptAnh.Image = null;
                fileAnh = "";
            }

            // 🟢 Kích hoạt nút Sửa/Xóa
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // 1️⃣ Kiểm tra có nhập gì không
            if (maNV == "" && sdt == "")
            {
                MessageBox.Show("⚠️ Vui lòng nhập Mã nhân viên hoặc Số điện thoại để tìm!");
                return;
            }

            // 2️⃣ Tạo câu truy vấn linh hoạt
            string sql = "SELECT * FROM NhanVien WHERE 1=1";
            if (maNV != "") sql += $" AND MaNV = '{maNV}'";
            if (sdt != "") sql += $" AND SDT = '{sdt}'";

            DataTable dt = dtBase.DocBang(sql);

            // 3️⃣ Nếu không tìm thấy
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("❌ Không có nhân viên này!");
                return;
            }

            // 4️⃣ Nếu tìm thấy → hiển thị thông tin ra form
            DataRow nv = dt.Rows[0];
            txtMaNV.Text = nv["MaNV"].ToString();
            txtTenNV.Text = nv["TenNV"].ToString();
            txtChucVu.Text = nv["ChucVu"].ToString();
            txtSDT.Text = nv["SDT"].ToString();
            txtDiaChi.Text = nv["DiaChi"].ToString();
            txtMucLuong.Text = nv["MucLuong"].ToString();

            if (nv["NgaySinh"] != DBNull.Value)
                dtpNgaySinh.Value = Convert.ToDateTime(nv["NgaySinh"]);

            // Nếu có ảnh → hiện lên PictureBox
            if (nv["Anh"] != DBNull.Value && nv["Anh"].ToString() != "")
            {
                fileAnh = nv["Anh"].ToString();
                if (File.Exists(fileAnh))
                {
                    ptAnh.Image = Image.FromFile(fileAnh);
                }
                else
                {
                    ptAnh.Image = null;
                }
            }
            else
            {
                ptAnh.Image = null;
            }

            MessageBox.Show("✅ Đã tìm thấy nhân viên!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }


        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileAnh = ofd.FileName; // 🔹 Lưu đường dẫn đầy đủ vào biến
                ptAnh.Image = Image.FromFile(fileAnh);
                ptAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "" || txtTenNV.Text.Trim() == "" ||
                 txtSDT.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" ||
                 txtMucLuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // ⚠️ Kiểm tra ngày sinh không vượt quá hiện tại và không quá xa (1900)
            if (dtpNgaySinh.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!");
                return;
            }

            if (dtpNgaySinh.Value.Year < 1900)
            {
                MessageBox.Show("Ngày sinh không hợp lệ (phải sau năm 1900)!");
                return;
            }
            // Kiểm tra trùng mã
            string sqlCheck = $"SELECT COUNT(*) FROM NhanVien WHERE MaNV='{txtMaNV.Text.Trim()}'";
            DataTable dtCheck = dtBase.DocBang(sqlCheck);
            if (Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            string sqlCheckSDT = $"SELECT COUNT(*) FROM NhanVien WHERE SDT = '{txtSDT.Text.Trim()}'";
            DataTable dtCheckSDT = dtBase.DocBang(sqlCheckSDT);
            if (Convert.ToInt32(dtCheckSDT.Rows[0][0]) > 0)
            {
                MessageBox.Show("⚠️ Số điện thoại này đã tồn tại, vui lòng nhập số khác!",
                                "Trùng số điện thoại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                txtSDT.SelectAll();
                return;
            }

            string sql = $"INSERT INTO NhanVien(MaNV, TenNV, ChucVu, NgaySinh, SDT, DiaChi, MucLuong, Anh) " +
                         $"VALUES('{txtMaNV.Text}', N'{txtTenNV.Text}', N'{txtChucVu.Text}', " +
                         $"'{dtpNgaySinh.Value:yyyy-MM-dd}', '{txtSDT.Text}', N'{txtDiaChi.Text}', " +
                         $"{txtMucLuong.Text}, N'{fileAnh}')";
            dtBase.CapNhatDuLieu(sql);

            LoadData();
            ClearFields();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Chọn nhân viên cần sửa!");
                return;
            }
            // ⚠️ Kiểm tra ngày sinh không vượt quá hiện tại và không quá xa (1900)
            if (dtpNgaySinh.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!");
                return;
            }

            if (dtpNgaySinh.Value.Year < 1900)
            {
                MessageBox.Show("Ngày sinh không hợp lệ (phải sau năm 1900)!");
                return;
            }

            string sql = $"UPDATE NhanVien SET TenNV=N'{txtTenNV.Text}', ChucVu=N'{txtChucVu.Text}', " +
                         $"NgaySinh='{dtpNgaySinh.Value:yyyy-MM-dd}', SDT='{txtSDT.Text}', DiaChi=N'{txtDiaChi.Text}', " +
                         $"MucLuong={txtMucLuong.Text}, Anh=N'{fileAnh}' WHERE MaNV='{txtMaNV.Text}'";

            dtBase.CapNhatDuLieu(sql);
            LoadData();
            ClearFields();
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Chọn nhân viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = $"DELETE FROM NhanVien WHERE MaNV='{txtMaNV.Text}'";
                dtBase.CapNhatDuLieu(sql);
                LoadData();
                ClearFields();
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        
    }
}
