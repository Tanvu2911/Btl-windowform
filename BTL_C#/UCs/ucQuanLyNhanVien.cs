using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BTL_C_.Classes;

namespace BTL_C_.UCs
{
    public partial class ucQuanLyNhanVien : UserControl
    {
        private readonly DataProcesser dtbase = new DataProcesser();
        private string image = "";
        private bool isAdding = false;

        public ucQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void ucQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
            dgvNhanVien.DefaultCellStyle.ForeColor = Color.Black;

        
        }

        private void LoadDataToGrid()
        {
            string query = "SELECT * FROM Users WHERE Role = N'NhanVien' ORDER BY UserID";
            DataTable dt = dtbase.DocBang(query);
            dgvNhanVien.DataSource = dt;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            txtUserID.Text = row.Cells["UserID"].Value?.ToString() ?? "";
            txtUserName.Text = row.Cells["UserName"].Value?.ToString() ?? "";

            txtPassword.Text = row.Cells["Password"].Value?.ToString() ?? "";

            txtTen.Text = row.Cells["Ten"].Value?.ToString() ?? "";
            txtSDT.Text = row.Cells["SoDienThoai"].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";

            string gt = row.Cells["GioiTinh"].Value?.ToString() ?? "Nam";
            rbNam.Checked = gt == "Nam";
            rbNu.Checked = gt == "Nữ";

            if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime ngaySinh))
                dtpNgaySinh.Value = ngaySinh;
            else
                dtpNgaySinh.Value = DateTime.Now;

            string tenAnh = row.Cells["Anh"].Value?.ToString();
            image = tenAnh ?? "";

            picAnh.Image = null;
            if (!string.IsNullOrEmpty(tenAnh))
            {
                string path = Path.Combine(Application.StartupPath, @"..\..\Images\", tenAnh);
                if (File.Exists(path))
                    picAnh.Image = Image.FromFile(path);
            }

            EnableEditButtons(true);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadDataToGrid();
                return;
            }

            string query = $@"
                SELECT * FROM Users
                WHERE Role = N'NhanVien'
                  AND (UserName LIKE N'%{keyword}%'
                    OR Ten LIKE N'%{keyword}%'
                    OR SoDienThoai LIKE N'%{keyword}%')
                ORDER BY UserID";

            dgvNhanVien.DataSource = dtbase.DocBang(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ResetAll();
            image = "";
            EnableEditButtons(false);
            btnLuu.Enabled = true;
            txtUserID.Enabled = true;
            txtUserID.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isAdding = false;
            EnableEditButtons(false);  
            btnLuu.Enabled = true;     
            txtUserID.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text)) return;

            if (!int.TryParse(txtUserID.Text, out int id))
            {
                MessageBox.Show("ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Xóa nhân viên ID = {id}?\n\nKhông thể hoàn tác!",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dtbase.CapNhatDuLieu($"DELETE FROM Users WHERE UserID = {id}");
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToGrid();
                    ResetAll();
                    image = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Ảnh (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                dlg.Title = "Chọn ảnh nhân viên";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileName = Path.GetFileName(dlg.FileName);
                        string imgDir = Path.Combine(Application.StartupPath, @"..\..\Images");
                        Directory.CreateDirectory(imgDir);
                        string dest = Path.Combine(imgDir, fileName);
                        File.Copy(dlg.FileName, dest, true);
                        picAnh.Image = Image.FromFile(dest);
                        image = fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        image = "";
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text) ||
                string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Vui lòng nhập ID và tên đăng nhập!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtUserID.Text.Trim(), out int userID))
            {
                MessageBox.Show("UserID phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string gioiTinh = rbNam.Checked ? "Nam" : "Nữ";
            string role = "NhanVien";
            string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            string anh = string.IsNullOrEmpty(image) ? "NULL" : $"N'{image}'";

            try
            {
                if (isAdding)
                {
                    var check = dtbase.DocBang($"SELECT 1 FROM Users WHERE UserID = {userID}");
                    if (check.Rows.Count > 0)
                    {
                        MessageBox.Show("ID nhân viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu khi thêm mới.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sql = $@"
                        INSERT INTO Users (UserID, UserName, Password, Role, Ten, GioiTinh, 
                                           SoDienThoai, DiaChi, Anh, NgaySinh)
                        VALUES ({userID}, N'{userName}', N'{password}', N'{role}', N'{ten}',
                                N'{gioiTinh}', N'{sdt}', N'{diaChi}', {anh}, '{ngaySinh}')";

                    dtbase.CapNhatDuLieu(sql);
                    MessageBox.Show("Thêm nhân viên thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql = $@"
                        UPDATE Users SET
                            UserName = N'{userName}',
                            Ten = N'{ten}',
                            GioiTinh = N'{gioiTinh}',
                            SoDienThoai = N'{sdt}',
                            DiaChi = N'{diaChi}',
                            Anh = {anh},
                            NgaySinh = '{ngaySinh}'";

                    if (!string.IsNullOrEmpty(password))
                        sql += $", Password = N'{password}'";

                    sql += $" WHERE UserID = {userID}";

                    dtbase.CapNhatDuLieu(sql);
                    MessageBox.Show("Cập nhật thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadDataToGrid();
                ResetAll();
                ResetButtons();
                image = "";
                isAdding = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetAll();
            image = "";
            ResetButtons();
            isAdding = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadDataToGrid();
            ResetAll();
            image = "";
            ResetButtons();
        }

        private void ResetAll()
        {
            txtUserID.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            rbNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            picAnh.Image = null;
            image = "";
            txtUserID.Enabled = true;
        }

        private void ResetButtons()
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void EnableEditButtons(bool enable)
        {
            btnSua.Enabled = enable;
            btnXoa.Enabled = enable;
            btnThem.Enabled = !enable;
            btnLuu.Enabled = false;
        }
    }
}
