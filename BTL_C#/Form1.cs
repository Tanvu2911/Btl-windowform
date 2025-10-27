using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_
{
    public partial class Form1 : Form
    {
        Classes.DataProcesser dtbase = new Classes.DataProcesser();
        public static string LoggedInRole { get; private set; }
        public static string name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                MessageBox.Show("Nhap ten dang nhap");
                return;
            }
            if (tbPassword.Text == "")
            {
                MessageBox.Show("Nhap mat khau");
                return;
            }

            // Kiểm tra tài khoản
            string sqlTk = "SELECT UserID FROM dbo.Users WHERE UserName = N'" + tbUserName.Text + "'";
            DataTable dttk = dtbase.DocBang(sqlTk);
            if (dttk.Rows.Count != 0)
            {
                // Kiểm tra mật khẩu
                string sqlMk = "SELECT UserID FROM dbo.Users WHERE UserName = N'" + tbUserName.Text + "' AND Password = N'" + tbPassword.Text + "'";
                DataTable dtmk = dtbase.DocBang(sqlMk);
                if (dtmk.Rows.Count != 0)
                {
                    //MessageBox.Show("Dang nhap thanh cong");
                    //DialogResult = DialogResult.OK;
                    //string sqlareas = ("select Role from dbo.Users where UserName = N'" + tbUserName.Text + "'");
                    //DataTable dtAreas = dtbase.DocBang(sqlareas);

                    //LoggedInRole = dtAreas.Rows[0]["Role"].ToString();
                    //name = tbUserName.Text;
                    //DialogResult = DialogResult.OK;
                    //Close();

                    

                    MessageBox.Show("Đăng nhập thành công!");

                    string sqlareas = "SELECT Role FROM dbo.Users WHERE UserName = N'" + tbUserName.Text + "'";
                    DataTable dtAreas = dtbase.DocBang(sqlareas);

                    LoggedInRole = dtAreas.Rows[0]["Role"].ToString();
                    name = tbUserName.Text;

                    // Đặt DialogResult = OK SAU KHI xử lý xong dữ liệu
                    this.DialogResult = DialogResult.OK;
                    this.Close();


                    return;
                }
                else
                {
                    MessageBox.Show("sai mat khau");
                    tbPassword.Text = "";
                    tbPassword.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Sai tai khoan");
                tbUserName.Text = "";
                tbPassword.Text = "";
                tbUserName.Focus();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
