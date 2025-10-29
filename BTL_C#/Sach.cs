

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BTL_C_
{
    public partial class Sach : Form
    {
        Classes.DataProcesser dtbase = new Classes.DataProcesser();
        Classes.Funtion ft = new Classes.Funtion();
        string image = ""; // Tên file ảnh mới (nếu chọn)

        public Sach()
        {
            InitializeComponent();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            // Load thể loại
            DataTable dtTheLoai = dtbase.DocBang("SELECT * FROM TheLoai");
            ft.FillCombobox(cb1, dtTheLoai, "TenTheLoai", "MaTheLoai");
            cb1.SelectedIndex = -1;

            // Load sách
            LoadDataToGrid();

            // Màu chữ đen
            dgvSach.DefaultCellStyle.ForeColor = Color.Black;
        }

        // Tải dữ liệu vào DataGridView
        private void LoadDataToGrid()
        {
            DataTable dt = dtbase.DocBang("SELECT * FROM Sach");
            dgvSach.DataSource = dt;
        }

        // Lấy tên ảnh hiện tại từ CSDL
        private string GetCurrentImage(string maSach)
        {
            string query = $"SELECT Anh FROM Sach WHERE MaSach = N'{maSach}'";
            DataTable dt = dtbase.DocBang(query);
            if (dt.Rows.Count > 0 && dt.Rows[0]["Anh"] != DBNull.Value)
                return dt.Rows[0]["Anh"].ToString().Trim();
            return "";
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSach.Rows[e.RowIndex];

            tbMaSach.Text = row.Cells[0].Value?.ToString() ?? "";
            tbTenSach.Text = row.Cells[1].Value?.ToString() ?? "";
            tbTacGia.Text = row.Cells[2].Value?.ToString() ?? "";
            tbNhaXuatBan.Text = row.Cells[3].Value?.ToString() ?? "";
            tbNamXuatBan.Text = row.Cells[4].Value?.ToString() ?? "";
            tbSoLuong.Text = row.Cells[6].Value?.ToString() ?? "";

            // Thể loại
            object maTL = row.Cells[5].Value;
            cb1.SelectedValue = (maTL != null && maTL != DBNull.Value) ? maTL.ToString() : (object)-1;

            // Ngày nhập
            object ngayNhapObj = row.Cells[7].Value;
            if (ngayNhapObj != null && DateTime.TryParse(ngayNhapObj.ToString(), out DateTime ngayNhap))
                dtNgayNhap.Value = ngayNhap;
            else
                dtNgayNhap.Value = DateTime.Now;

            // Hiển thị ảnh
            string tenAnh = row.Cells[8].Value?.ToString();
            try
            {
                if (!string.IsNullOrEmpty(tenAnh))
                {
                    string duongDan = Path.Combine(Application.StartupPath, @"..\..\Images\", tenAnh);
                    if (File.Exists(duongDan))
                        ptAnh.Image = Image.FromFile(duongDan);
                    else
                        ptAnh.Image = null;
                }
                else
                {
                    ptAnh.Image = null;
                }
            }
            catch
            {
                ptAnh.Image = null;
            }

            // Bật nút
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetall();
            image = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTim.Enabled = true;
        }

        public void resetall()
        {
            tbMaSach.Text = "";
            tbTenSach.Text = "";
            tbTacGia.Text = "";
            tbNhaXuatBan.Text = "";
            tbNamXuatBan.Text = "";
            tbSoLuong.Text = "";
            cb1.SelectedIndex = -1;
            dtNgayNhap.Value = DateTime.Now;
            ptAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa.");
                return;
            }
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnTim.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.CapNhatDuLieu($"DELETE FROM Sach WHERE MaSach = N'{tbMaSach.Text}'");
                MessageBox.Show("Xóa thành công!");
                LoadDataToGrid();
                resetall();
                image = "";
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sách cần tìm.");
                return;
            }

            DataTable dt = dtbase.DocBang($"SELECT * FROM Sach WHERE MaSach = N'{tbMaSach.Text}'");
            if (dt.Rows.Count > 0)
            {
                dgvSach.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách.");
                LoadDataToGrid();
                resetall();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra bắt buộc
            if (string.IsNullOrWhiteSpace(tbMaSach.Text) ||
                string.IsNullOrWhiteSpace(tbTenSach.Text) ||
                cb1.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(tbTacGia.Text) ||
                string.IsNullOrWhiteSpace(tbSoLuong.Text) ||
                string.IsNullOrWhiteSpace(tbNhaXuatBan.Text) ||
                string.IsNullOrWhiteSpace(tbNamXuatBan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc.");
                return;
            }

            try
            {
                string maSach = tbMaSach.Text.Trim();
                string tenSach = tbTenSach.Text.Trim();
                string tacGia = tbTacGia.Text.Trim();
                string nhaXuatBan = tbNhaXuatBan.Text.Trim();
                string maTheLoai = cb1.SelectedValue.ToString();
                int soLuong = int.Parse(tbSoLuong.Text);
                int namXuatBan = int.Parse(tbNamXuatBan.Text);
                DateTime ngayNhap = dtNgayNhap.Value;

                // Lấy ảnh hiện tại từ CSDL
                string anhHienTai = GetCurrentImage(maSach);
                string anhBia = string.IsNullOrEmpty(image) ? anhHienTai : image;

                DataTable dtCheck = dtbase.DocBang($"SELECT * FROM Sach WHERE MaSach = N'{maSach}'");
                string query;

                if (dtCheck.Rows.Count == 0)
                {
                    // THÊM MỚI
                    query = $@"INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXuatBan, MaTheLoai, SoLuong, NamXuatBan, NgayNhap, Anh)
                               VALUES (N'{maSach}', N'{tenSach}', N'{tacGia}', N'{nhaXuatBan}', N'{maTheLoai}', 
                                       {soLuong}, {namXuatBan}, '{ngayNhap:yyyy-MM-dd}', N'{anhBia}')";
                    dtbase.CapNhatDuLieu(query);
                    MessageBox.Show("Thêm sách thành công!");
                }
                else
                {
                    // CẬP NHẬT
                    query = $@"UPDATE Sach SET 
                               TenSach = N'{tenSach}', 
                               TacGia = N'{tacGia}', 
                               NhaXuatBan = N'{nhaXuatBan}', 
                               MaTheLoai = N'{maTheLoai}', 
                               SoLuong = {soLuong}, 
                               NamXuatBan = {namXuatBan}, 
                               NgayNhap = '{ngayNhap:yyyy-MM-dd}', 
                               Anh = N'{anhBia}'
                               WHERE MaSach = N'{maSach}'";
                    dtbase.CapNhatDuLieu(query);
                    MessageBox.Show("Cập nhật sách thành công!");
                }

                LoadDataToGrid();
                resetall();
                image = "";

                // Cập nhật nút
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng hoặc năm xuất bản phải là số nguyên.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // =============== CHỌN ẢNH ===============
        private void ptAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";
            dlg.Title = "Chọn ảnh bìa sách";
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ptAnh.Image = Image.FromFile(dlg.FileName);
                    image = Path.GetFileName(dlg.FileName);

                    // Copy vào thư mục Images (cùng cấp với .csproj)
                    string projectImagesPath = Path.Combine(Application.StartupPath, @"..\..\Images");
                    if (!Directory.Exists(projectImagesPath))
                        Directory.CreateDirectory(projectImagesPath);

                    string destFile = Path.Combine(projectImagesPath, image);
                    File.Copy(dlg.FileName, destFile, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải ảnh: " + ex.Message);
                    image = "";
                }
            }
        }

        // =============== NÚT RESET ===============
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetall();
            image = "";
            LoadDataToGrid();
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        //private void btnExcel_Click(object sender, EventArgs e)
        //{

        //}
    }
}