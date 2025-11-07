using BTL_C_.UCs;
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

namespace BTL_C_
{
    public partial class QLThuVien : Form
    {
        string image = "";
        public QLThuVien()
        {
            InitializeComponent();
            searchSach1.BringToFront();
        }

        private void qlSach1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            scoll.Height= btnSach.Height;
            scoll.Top = btnSach.Top;
            searchSach1.BringToFront();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            scoll.Height = btnDocGia.Height;
            scoll.Top = btnDocGia.Top;
            docGia1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            scoll.Height = btnMuonTra.Height;
            scoll.Top = btnMuonTra.Top;
            phieuMuon2.BringToFront();




        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if(Form1.LoggedInRole == "NhanVien")
            {
                MessageBox.Show("Chỉ có Admin mới có quyền truy cập");
                return;
            }
            scoll.Height = btnNhanVien.Height;
            scoll.Top = btnNhanVien.Top;
            ucQuanLyNhanVien1.BringToFront();

        }


        private void button6_Click(object sender, EventArgs e)
        {

            if (Form1.LoggedInRole == "NhanVien")
            {
                MessageBox.Show("Chỉ có Admin mới có quyền truy cập");
                return;
            }
            scoll.Height = btnThongKe.Height;
            scoll.Top = btnThongKe.Top;
            thongKe1.BringToFront();
        }

        private void QLThuVien_Load(object sender, EventArgs e)
        {
            lbTen.Text += Form1.name;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            scoll.Height = btnTaiKhoan.Height;
            scoll.Top = btnTaiKhoan.Top;
        }

        private void ptLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        

        //private void ptLogo_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dlgOpen = new OpenFileDialog();
        //    dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|gif(*.gif)|*.gif|All files(*.*)|*.*";
        //    dlgOpen.InitialDirectory = Application.StartupPath;
        //    dlgOpen.FilterIndex = 3;
        //    dlgOpen.Title = "Chon hinh anh cho san pham";

        //    if (dlgOpen.ShowDialog() == DialogResult.OK)
        //    {
        //        ptLogo.Image = Image.FromFile(dlgOpen.FileName);

        //        string[] parts = dlgOpen.FileName.Split('\\');
        //        image = parts[parts.Length - 1];

        //        string imagesFolder = Path.Combine(Application.StartupPath, "Images");
        //        if (!Directory.Exists(imagesFolder))
        //        {
        //            Directory.CreateDirectory(imagesFolder);
        //        }

        //        string destPath = Path.Combine(imagesFolder, image);
        //        File.Copy(dlgOpen.FileName, destPath, true);
        //    }
        //}
    }
}
