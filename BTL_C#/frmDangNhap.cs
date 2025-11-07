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

namespace BTL_C_
{
    public partial class frmDangNhap : Form
    {
        private readonly DataProcesser dtbase = new DataProcesser();


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            cboRole.Items.Clear();
            cboRole.Items.Add("NhanVien");
            cboRole.Items.Add("Admin");
            cboRole.SelectedIndex = 0;
            txtPassword.PasswordChar = '*';
            txtUserName.Focus();

        }
        public frmDangNhap()
        {
            InitializeComponent();
            this.Text = "Đăng Ký Tài Khoản";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Size = new Size(380, 280);
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            cboRole.Items.Clear();
            cboRole.Items.Add("NhanVien");
            cboRole.Items.Add("Admin");
            cboRole.SelectedIndex = 0; 

            txtPassword.PasswordChar = '*';
            txtUserName.Focus();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cboRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string checkQuery = $"SELECT UserName FROM Users WHERE UserName = N'{userName}'";
            DataTable dt = dtbase.DocBang(checkQuery);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!\nVui lòng chọn tên khác.", "Trùng lặp",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUserName.Focus();
                return;
            }

            string maxIdQuery = "SELECT ISNULL(MAX(UserID), 0) + 1 FROM Users";
            DataTable dtMax = dtbase.DocBang(maxIdQuery);
            int newUserID = Convert.ToInt32(dtMax.Rows[0][0]);

            string insertQuery = $@"
                INSERT INTO Users (UserID, UserName, Password, Role, Ten, GioiTinh, SoDienThoai, DiaChi, Anh, NgaySinh)
                VALUES ({newUserID}, N'{userName}', N'{password}', N'{role}', 
                        N'{userName}', N'Nam', N'', N'', NULL, GETDATE())";

            try
            {
                dtbase.CapNhatDuLieu(insertQuery);

                MessageBox.Show(
                    $"Đăng ký thành công!\n\n" +
                    $"Tên đăng nhập: {userName}\n" +
                    $"Vai trò: {role}\n" ,
                    "THÀNH CÔNG!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng ký:\n" + ex.Message, "Lỗi SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
