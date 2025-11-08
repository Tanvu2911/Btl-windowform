using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BTL_C_.Classes;

namespace BTL_C_.UCs
{
    public partial class TaiKhoan : UserControl
    {
        private readonly DataProcesser dtbase = new DataProcesser();
        private string imageFile = "";

        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            try
            {
                // Lấy tên đăng nhập từ biến static sau khi đăng nhập
                string username = Form1.name;


                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Không xác định được người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = $"SELECT * FROM Users WHERE UserName = N'{username}'";
                DataTable dt = dtbase.DocBang(query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow row = dt.Rows[0];

                txtID.Text = row["UserID"].ToString();
                txtHoTen.Text = row["Ten"].ToString();
                txtSDT.Text = row["SoDienThoai"].ToString();
                txtDiaChi.Text = row["DiaChi"].ToString();

                if (DateTime.TryParse(row["NgaySinh"].ToString(), out DateTime ns))
                    dtpNgaySinh.Value = ns;
                else
                    dtpNgaySinh.Value = DateTime.Now;

                string gt = row["GioiTinh"].ToString();
                rbNam.Checked = gt == "Nam";
                rbNu.Checked = gt == "Nữ";

                imageFile = row["Anh"].ToString();
                picAnh.Image = null;
                if (!string.IsNullOrEmpty(imageFile))
                {
                    string path = Path.Combine(Application.StartupPath, @"..\..\Images\", imageFile);
                    if (File.Exists(path))
                        picAnh.Image = Image.FromFile(path);
                }

                txtID.Enabled = false; // ID không sửa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Ảnh (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                dlg.Title = "Chọn ảnh cá nhân";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileName = Path.GetFileName(dlg.FileName);
                        string imgDir = Path.Combine(Application.StartupPath, @"..\..\Images");
                        Directory.CreateDirectory(imgDir);
                        string destPath = Path.Combine(imgDir, fileName);
                        File.Copy(dlg.FileName, destPath, true);

                        picAnh.Image = Image.FromFile(destPath);
                        imageFile = fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi chọn ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Không có ID người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ten = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string gioitinh = rbNam.Checked ? "Nam" : "Nữ";
            string ngaysinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            string anh = string.IsNullOrEmpty(imageFile) ? "NULL" : $"N'{imageFile}'";

            try
            {
                string sql = $@"
                    UPDATE Users
                    SET Ten = N'{ten}',
                        GioiTinh = N'{gioitinh}',
                        SoDienThoai = N'{sdt}',
                        DiaChi = N'{diachi}',
                        NgaySinh = '{ngaysinh}',
                        Anh = {anh}
                    WHERE UserID = {txtID.Text}";

                dtbase.CapNhatDuLieu(sql);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
