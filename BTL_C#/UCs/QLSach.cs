using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;

namespace BTL_C_
{
    public partial class QLSach : System.Windows.Forms.UserControl
    {
        Classes.DataProcesser dtbase = new Classes.DataProcesser();
        Classes.Funtion ft = new Classes.Funtion();
        string image = "";
        public QLSach()
        {
            InitializeComponent();
        }
        

        private void QLSach_Load(object sender, EventArgs e)
        {
            DataTable dt = dtbase.DocBang("select * from TheLoai");
            ft.FillCombobox(cb1, dt, "TenTheLoai", "MaTheLoai");


            DataTable dtSanPham = dtbase.DocBang("select * from Sach");
            dgvSach.DataSource = dtSanPham;
            cb1.SelectedIndex = -1;

        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow currentRow = dgvSach.CurrentRow;

            tbMaSach.Text = currentRow.Cells[0].Value?.ToString() ?? string.Empty;
            tbTenSach.Text = currentRow.Cells[1].Value?.ToString() ?? string.Empty;
            tbTacGia.Text = currentRow.Cells[2].Value?.ToString() ?? string.Empty;
            tbNhaXuatBan.Text = currentRow.Cells[3].Value?.ToString() ?? string.Empty;
            tbSoLuong.Text = currentRow.Cells[6].Value?.ToString() ?? string.Empty;
            tbNamXuatBan.Text = currentRow.Cells[4].Value?.ToString() ?? string.Empty;

            object maTheLoaiValue = currentRow.Cells[5].Value;
            if (maTheLoaiValue != null && maTheLoaiValue != DBNull.Value)
            {
                cb1.SelectedValue = maTheLoaiValue.ToString();
            }
            else
            {
                cb1.SelectedIndex = -1;
            }
            object ngayNhapValue = currentRow.Cells[7].Value;
            if (ngayNhapValue != null && ngayNhapValue != DBNull.Value && DateTime.TryParse(ngayNhapValue.ToString(), out DateTime ngayNhap))
            {
                dtNgayNhap.Value = ngayNhap;
            }
            else
            {
                dtNgayNhap.Value = DateTime.Now;
            }
            try
            {
                ptAnh.Image = Image.FromFile("Images\\" + dgvSach.CurrentRow.Cells[8].Value.ToString());
            }
            catch
            {
                ptAnh.Image = null;
            }

            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetall();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTim.Enabled = true;
            btnLuu.Enabled = true;
        }
        public void resetall()
        {
            tbMaSach.Text = "";
            tbTenSach.Text = "";
            tbNhaXuatBan.Text = "";
            tbTacGia.Text = "";
            tbSoLuong.Text = "";
            tbNamXuatBan.Text = "";
            cb1.SelectedIndex = -1;
            ptAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled=false;
            btnTim.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dtbase.CapNhatDuLieu("delete from Sach where MaSach=N'"+tbMaSach.Text +"'");

            DataTable dt = dtbase.DocBang("select * from Sach");
            dgvSach.DataSource = dt;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {


            DataTable dt =  dtbase.DocBang("select * from Sach where MaSach=N'"+tbMaSach.Text+"'");
            if (dt.Rows.Count != 0)
            {
                dgvSach.DataSource=dt;
            }
            else {
                MessageBox.Show("khong tim thay");
                DataTable dt2 = dtbase.DocBang("select * from Sach");
                dgvSach.DataSource = dt2;
                resetall();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaSach.Text) ||
   string.IsNullOrWhiteSpace(tbTenSach.Text) ||
   cb1.SelectedIndex == -1 ||
   string.IsNullOrWhiteSpace(tbTacGia.Text) ||
   string.IsNullOrWhiteSpace(tbSoLuong.Text) ||
   string.IsNullOrWhiteSpace(tbNhaXuatBan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            try
            {
                // Lấy giá trị các control
                string maSach = tbMaSach.Text;
                string tenSach = tbTenSach.Text;
                string maTheLoai = cb1.SelectedValue.ToString();
                string tacGia = tbTacGia.Text;
                string nhaXuatBan = tbNhaXuatBan.Text;
                int soLuong = int.Parse(tbSoLuong.Text);
                int namXuatBan = int.Parse(tbNamXuatBan.Text);
                DateTime ngayNhap = dtNgayNhap.Value;

                // Kiểm tra sách đã tồn tại
                DataTable dtCheck = dtbase.DocBang("select * from Sach where MaSach=N'" + maSach + "'");
                if (dtCheck.Rows.Count == 0)
                {
                    // Thêm mới: THÊM CỘT ANHBIA
                    string insertQuery = $"insert into Sach(MaSach, TenSach, TacGia, NhaXuatBan, MaTheLoai, SoLuong, NamXuatBan, NgayNhap, Anh) " +
                                         $"values(N'{maSach}', N'{tenSach}', N'{tacGia}', N'{nhaXuatBan}', N'{maTheLoai}', {soLuong}, {namXuatBan}, '{ngayNhap:yyyy-MM-dd}',N'"+image+"')";
                    dtbase.CapNhatDuLieu(insertQuery);
                    MessageBox.Show("Thêm sách thành công!");
                }
                else
                {
                    // Cập nhật: THÊM CẬP NHẬT CỘT ANHBIA
                    string updateQuery = $"update Sach set TenSach=N'{tenSach}', TacGia=N'{tacGia}', NhaXuatBan=N'{nhaXuatBan}', " +
                                         $"MaTheLoai=N'{maTheLoai}', SoLuong={soLuong}, NamXuatBan={namXuatBan}, NgayNhap='{ngayNhap:yyyy-MM-dd}', Anh=N'{image}' " +
                                         $"where MaSach=N'{maSach}'";
                    dtbase.CapNhatDuLieu(updateQuery);
                    MessageBox.Show("Cập nhật sách thành công!");
                }

                // Load lại DataGridView
                DataTable dt = dtbase.DocBang("select * from Sach");
                dgvSach.DataSource = dt;

                // Reset form
                resetall();
                // Reset biến image sau khi lưu thành công
                image = "";
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnTim.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng hoặc năm xuất bản không hợp lệ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ptAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = Application.StartupPath;
            dlgOpen.FilterIndex = 3;
            dlgOpen.Title = "Chon hinh anh cho san pham";

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                ptAnh.Image = Image.FromFile(dlgOpen.FileName);
                //ptAnh.SizeMode = PictureBoxSizeMode.StretchImage;

                // Lấy tên file ảnh
                string[] parts = dlgOpen.FileName.Split('\\');
                image = parts[parts.Length - 1];

                // Copy ảnh vào thư mục bin\Debug\Images
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                string destPath = Path.Combine(imagesFolder, image);
                File.Copy(dlgOpen.FileName, destPath, true);
            }
        }
    }
}
