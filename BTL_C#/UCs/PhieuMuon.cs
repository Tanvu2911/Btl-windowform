using BTL_C_.Classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BTL_C_.UCs
{
    public partial class PhieuMuon : UserControl
    {
        public PhieuMuon()
        {
            InitializeComponent();
            KhoiTaoBangTam();
        }
        private int quaHan;
        private DataProcesser db = new DataProcesser();
        private DataTable dtSachMuon = new DataTable(); // Bảng tạm sách mượn
        private string maDocGiaHienTai = "";
        private int maPhieuHienTai = -1;


        #region Khởi tạo bảng tạm sách mượn
        private void KhoiTaoBangTam()
        {
            dtSachMuon.Columns.Add("MaSach", typeof(string));
            dtSachMuon.Columns.Add("TenSach", typeof(string));
            dtSachMuon.Columns.Add("TacGia", typeof(string));
            dtSachMuon.Columns.Add("SoLuong", typeof(int));
            dtSachMuon.Columns.Add("TrangThai", typeof(string));
        }
        #endregion
        private void btnTimDocGia_Click(object sender, EventArgs e)
        {
            string keyword = txtTimDocGia.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập mã hoặc tên độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = "";

                // === KIỂM TRA XEM KEYWORD CÓ PHẢI LÀ SỐ KHÔNG ===
                if (int.TryParse(keyword, out _))
                {
                    // Tìm theo MÃ ĐỘC GIẢ (chính xác)
                    sql = $"SELECT MaDG, HoTen, DienThoai, NgaySinh FROM DocGia WHERE MaDG = '{keyword}' OR DienThoai LIKE '{keyword}'";
                }
                else
                {
                    // Tìm theo TÊN (gần đúng)
                    sql = $"SELECT MaDG, HoTen, DienThoai, NgaySinh FROM DocGia WHERE HoTen LIKE N'%{keyword}%'";
                }

                DataTable dt = db.DocBang(sql);

                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    txtMaDG.Text = r["MaDG"].ToString();
                    txtHoTen.Text = r["HoTen"].ToString();
                    txtDienThoai.Text = r["DienThoai"].ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(r["NgaySinh"]);
                    maDocGiaHienTai = r["MaDG"].ToString();

                    LoadSachDangMuon();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaThongTinDocGia();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Xóa thông tin độc giả
        private void XoaThongTinDocGia()
        {
            txtMaDG.Clear();
            txtHoTen.Clear();
            txtDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            maDocGiaHienTai = "";
            dgvSachDangMuon.DataSource = null;
            dtSachMuon.Clear();
            dgvSachMuon.DataSource = dtSachMuon;
        }
        #endregion

        #region Load sách đang mượn + ngày mượn, hạn, trạng thái hạn
        private void LoadSachDangMuon()
        {
            string sql = $@"
                SELECT 
                    ct.MaSach,
                    s.TenSach,
                    s.TacGia,
                    ct.SoLuong,
                    ct.TrangThai,
                    pm.MaPhieu,
                    pm.NgayMuon,
                    pm.NgayHenTra,
                    CASE 
                        WHEN GETDATE() <= pm.NgayHenTra THEN N'Còn hạn'
                        ELSE N'Quá hạn'
                    END AS TrangThaiHan
                FROM ChiTietMuon ct
                JOIN Sach s ON ct.MaSach = s.MaSach
                JOIN PhieuMuon pm ON ct.MaPhieu = pm.MaPhieu
                WHERE pm.MaDG = '{maDocGiaHienTai}' 
                AND ct.TrangThai = N'Đang mượn'";

            try
            {
                DataTable dt = db.DocBang(sql);

                // Thêm cột trạng thái hạn nếu chưa có (tránh lỗi khi bind)
                if (!dt.Columns.Contains("TrangThaiHan"))
                    dt.Columns.Add("TrangThaiHan", typeof(string));

                // Gán DataSource
                dgvSachDangMuon.DataSource = dt;

                dgvSachDangMuon.Columns["MaSach"].HeaderText = "Mã sách";
                dgvSachDangMuon.Columns["TenSach"].HeaderText = "Tên sách";
                dgvSachDangMuon.Columns["TacGia"].HeaderText = "Tác giả";
                dgvSachDangMuon.Columns["SoLuong"].HeaderText = "SL";
                dgvSachDangMuon.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvSachDangMuon.Columns["NgayMuon"].HeaderText = "Ngày mượn";
                dgvSachDangMuon.Columns["NgayHenTra"].HeaderText = "Hết hạn";
                dgvSachDangMuon.Columns["TrangThaiHan"].HeaderText = "Hạn mượn";

                // Ẩn MaPhieu
                dgvSachDangMuon.Columns["MaPhieu"].Visible = false;

                // Tùy chỉnh hiển thị cột
                if (dgvSachDangMuon.Columns["MaPhieu"] != null)
                    dgvSachDangMuon.Columns["MaPhieu"].Visible = false; // Ẩn MaPhieu

                // Định dạng ngày
                if (dgvSachDangMuon.Columns["NgayMuon"] != null)
                    dgvSachDangMuon.Columns["NgayMuon"].DefaultCellStyle.Format = "dd/MM/yyyy";

                if (dgvSachDangMuon.Columns["NgayHenTra"] != null)
                    dgvSachDangMuon.Columns["NgayHenTra"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Tô màu dòng quá hạn
                foreach (DataGridViewRow row in dgvSachDangMuon.Rows)
                {
                    if (row.Cells["TrangThaiHan"].Value?.ToString() == "Quá hạn")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                        row.DefaultCellStyle.Font = new System.Drawing.Font(dgvSachDangMuon.Font, FontStyle.Bold);
                    }
                }

                // Cập nhật maPhieuHienTai (lấy từ dòng đầu nếu có)
                maPhieuHienTai = dt.Rows.Count > 0
                    ? Convert.ToInt32(dt.Rows[0]["MaPhieu"])
                    : -1;
                quaHan = dt.AsEnumerable().Count(r => r.Field<string>("TrangThaiHan") == "Quá hạn");
                if (quaHan > 0)
                {
                    MessageBox.Show($"Cảnh báo: Có {quaHan} sách quá hạn!", "Quá hạn",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnMuonSach.Enabled = false;
                } else
                {
                    btnMuonSach.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sách đang mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            string keyword = txtTimSach.Text.Trim();
            string sql = $@"
                SELECT s.MaSach, s.TenSach, s.TacGia, tl.TenTheLoai, s.SoLuong
                FROM Sach s
                JOIN TheLoai tl ON s.MaTheLoai = tl.MaTheLoai
                WHERE s.SoLuong > 0
                  AND (s.MaSach LIKE '%{keyword}%' 
                       OR s.TenSach LIKE N'%{keyword}%' 
                       OR s.TacGia LIKE N'%{keyword}%')";

            DataTable dt = db.DocBang(sql);
            dgvSachKhaDung.DataSource = dt;
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (dgvSachKhaDung.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách để mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(maDocGiaHienTai))
            {
                MessageBox.Show("Vui lòng chọn độc giả trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvSachKhaDung.SelectedRows[0];
            string maSach = row.Cells["MaSach"].Value.ToString();
            string tenSach = row.Cells["TenSach"].Value.ToString();
            string tacGia = row.Cells["TacGia"].Value.ToString();
            int soLuongTon = Convert.ToInt32(row.Cells["SoLuong"].Value);

            // Kiểm tra đã mượn chưa
            foreach (DataRow r in dtSachMuon.Rows)
            {
                if (r["MaSach"].ToString() == maSach)
                {
                    MessageBox.Show("Sách này đã có trong phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Nhập số lượng
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Nhập số lượng mượn (tối đa: {soLuongTon})", "Số lượng", "1");

            if (string.IsNullOrEmpty(input)) return;

            if (!int.TryParse(input, out int soLuong) || soLuong <= 0 || soLuong > soLuongTon)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm vào bảng tạm
            dtSachMuon.Rows.Add(maSach, tenSach, tacGia, soLuong, "Đang mượn");
            dgvSachMuon.DataSource = dtSachMuon;
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (dgvSachMuon.SelectedRows.Count > 0)
            {
                dgvSachMuon.Rows.RemoveAt(dgvSachMuon.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            if (dtSachMuon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn sách để mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Tạo phiếu mượn
                string sqlPhieu = $@"
                    INSERT INTO PhieuMuon (NgayMuon, NgayHenTra, MaDG)
                    VALUES (GETDATE(), DATEADD(day, 14, GETDATE()), '{maDocGiaHienTai}');
                    SELECT SCOPE_IDENTITY();";

                int maPhieu = Convert.ToInt32(db.ExecuteScalar(sqlPhieu));

                // 2. Thêm chi tiết mượn + cập nhật tồn kho
                foreach (DataRow r in dtSachMuon.Rows)
                {
                    string maSach = r["MaSach"].ToString();
                    int soLuong = Convert.ToInt32(r["SoLuong"]);

                    // Thêm chi tiết
                    string sqlCT = $@"
                        INSERT INTO ChiTietMuon (MaPhieu, MaSach, SoLuong, TrangThai)
                        VALUES ({maPhieu}, '{maSach}', {soLuong}, N'Đang mượn')";

                    db.CapNhatDuLieu(sqlCT);

                    // Cập nhật tồn kho
                    string sqlTon = $"UPDATE Sach SET SoLuong = SoLuong - {soLuong} WHERE MaSach = '{maSach}'";
                    db.CapNhatDuLieu(sqlTon);
                }

                MessageBox.Show($"Mượn sách thành công! Mã phiếu: {maPhieu}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LamMoiForm();
                LoadSachDangMuon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (dgvSachDangMuon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách để trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvSachDangMuon.SelectedRows[0];
            string maSach = row.Cells["MaSach"].Value.ToString();
            int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
            int maPhieu = Convert.ToInt32(row.Cells["MaPhieu"].Value);

            try
            {
                // Cập nhật trạng thái
                string sql = $@"
                    UPDATE ChiTietMuon 
                    SET TrangThai = N'Đã trả' 
                    WHERE MaPhieu = {maPhieu} AND MaSach = '{maSach}'";

                db.CapNhatDuLieu(sql);

                // Hoàn tồn kho
                string sqlTon = $"UPDATE Sach SET SoLuong = SoLuong + {soLuong} WHERE MaSach = '{maSach}'";
                db.CapNhatDuLieu(sqlTon);

                MessageBox.Show("Trả sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSachDangMuon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }
        private void LamMoiForm()
        {
            txtTimDocGia.Clear();
            txtTimSach.Clear();
            XoaThongTinDocGia();
            dtSachMuon.Clear();
            dgvSachMuon.DataSource = dtSachMuon;
            dgvSachKhaDung.DataSource = null;
            dgvSachDangMuon.DataSource = null;
        }




        //Vũ Tân
        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔹 Thư mục lưu file PDF trong ổ D
                string folderPath = @"D:\PDF";

                // Nếu thư mục chưa tồn tại thì tạo mới
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // 🔹 Tạo tên file PDF (thêm ngày giờ để tránh trùng)
                string fileName = $"PhieuMuon_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string filePath = Path.Combine(folderPath, fileName);

                // 🔹 Khởi tạo file PDF
                Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                // 🔹 Tiêu đề phiếu
                var titleFont = FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.BOLD);
                var normalFont = FontFactory.GetFont("Arial", 12);

                Paragraph title = new Paragraph("PHIẾU MƯỢN SÁCH", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph("\n----------------------------------------\n", normalFont));

                // 🔹 Nội dung phiếu (có thể thay bằng textbox sau)
                doc.Add(new Paragraph("Tên người mượn: Nguyễn Văn A", normalFont));
                doc.Add(new Paragraph("Tên sách: Lập trình C# cơ bản", normalFont));
                doc.Add(new Paragraph("Ngày mượn: " + DateTime.Now.ToShortDateString(), normalFont));
                doc.Add(new Paragraph("Ngày trả dự kiến: " + DateTime.Now.AddDays(7).ToShortDateString(), normalFont));
                doc.Add(new Paragraph("\nChữ ký người mượn: ____________________", normalFont));
                doc.Add(new Paragraph("Chữ ký thủ thư: ____________________", normalFont));

                // 🔹 Kết thúc tài liệu
                doc.Close();

                MessageBox.Show($"✅ Phiếu mượn đã được lưu tại:\n{filePath}",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🔹 Mở file PDF sau khi xuất
                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi tạo phiếu: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
