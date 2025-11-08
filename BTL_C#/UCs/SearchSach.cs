

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BTL_C_
{
    public partial class SearchSach : System.Windows.Forms.UserControl
    {
        Classes.DataProcesser dtbase = new Classes.DataProcesser();
        Classes.Funtion ft = new Classes.Funtion();

        public SearchSach()
        {
            InitializeComponent();
        }

        private void SearchSach_Load(object sender, EventArgs e)
        {
            DataTable dt = dtbase.DocBang("select * from Sach");
            dgvSach.DataSource = dt;

            DataTable dttl = dtbase.DocBang("select * from TheLoai");
            ft.FillCombobox(cb1, dttl, "TenTheLoai", "MaTheLoai");

            rbtTenSach.Checked = false;
            rbtNhaXuatBan.Checked = false;
            rbtTacGia.Checked = false;
            cb1.SelectedIndex = -1;

            dgvSach.DefaultCellStyle.ForeColor = Color.Black;
            dgvSach.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void btSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.Show();
        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            string selectsql = "";
            if (rbtTenSach.Checked)
                selectsql = "TenSach";
            if (rbtTacGia.Checked)
                selectsql = "TacGia";
            if (rbtNhaXuatBan.Checked)
                selectsql = "NhaXuatBan";

            if (string.IsNullOrEmpty(selectsql) && cb1.SelectedIndex == -1)
            {
                DataTable dtAll = dtbase.DocBang("select * from Sach");
                dgvSach.DataSource = dtAll;
                return;
            }

            string sql = "select * from Sach where 1=1";

            if (cb1.SelectedIndex != -1 && cb1.SelectedValue != null && !(cb1.SelectedValue is DataRowView))
                sql += $" and MaTheLoai = N'{cb1.SelectedValue}'";

            if (!string.IsNullOrEmpty(selectsql) && !string.IsNullOrEmpty(tbTim.Text))
                sql += $" and {selectsql} LIKE N'%{tbTim.Text}%'";

            DataTable dt = dtbase.DocBang(sql);
            dgvSach.DataSource = dt;
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb1.SelectedValue != null && !(cb1.SelectedValue is DataRowView))
            {
                string sql = $"select * from Sach where MaTheLoai = N'{cb1.SelectedValue}'";

                string selectsql = "";
                if (rbtTenSach.Checked)
                    selectsql = "TenSach";
                if (rbtTacGia.Checked)
                    selectsql = "TacGia";
                if (rbtNhaXuatBan.Checked)
                    selectsql = "NhaXuatBan";

                if (!string.IsNullOrEmpty(selectsql) && !string.IsNullOrEmpty(tbTim.Text))
                    sql += $" and {selectsql} LIKE N'%{tbTim.Text}%'";

                DataTable dt = dtbase.DocBang(sql);
                dgvSach.DataSource = dt;
            }
        }

        private void btTheLoai_Click(object sender, EventArgs e)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataTable dttl = dtbase.DocBang("select * from TheLoai");
            ft.FillCombobox(cb1, dttl, "TenTheLoai", "MaTheLoai");
            rbtNhaXuatBan.Checked = false;
            rbtTacGia.Checked = false;
            rbtTenSach.Checked = false;
            cb1.SelectedIndex = -1;
            tbTim.Text = "";

            DataTable dt = dtbase.DocBang("select * from Sach");
            dgvSach.DataSource = dt;


            
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvSach.DataSource;
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất Excel!");
                    return;
                }

                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                Excel.Range tentruong = (Excel.Range)exSheet.Cells[1, 1];

                // Tiêu đề lớn
                tentruong.Range["B2"].Font.Size = 25;
                tentruong.Range["B2"].Font.Name = "Times New Roman";
                tentruong.Range["B2"].Font.Color = Color.Green;
                tentruong.Range["B2"].Value = "Danh Sách Sách";

                // Tiêu đề cột
                tentruong.Range["A4:I4"].Font.Size = 13;
                tentruong.Range["A4:I4"].Font.Name = "Times New Roman";
                tentruong.Range["A4:I4"].Font.Color = Color.Black;
                tentruong.Range["A4:I4"].Font.Bold = true;

                tentruong.Range["A4"].Value = "Mã Sách";
                tentruong.Range["B4"].Value = "Tên Sách";
                tentruong.Range["C4"].Value = "Tác Giả";
                tentruong.Range["D4"].Value = "Nhà XB";
                tentruong.Range["E4"].Value = "Năm XB";
                tentruong.Range["F4"].Value = "Thể Loại";
                tentruong.Range["G4"].Value = "Số Lượng";
                tentruong.Range["H4"].Value = "Ngày Nhập";
                tentruong.Range["I4"].Value = "Ảnh";

                DataTable dtTheLoai = dtbase.DocBang("SELECT MaTheLoai, TenTheLoai FROM TheLoai");
                var dicTheLoai = dtTheLoai.AsEnumerable()
                    .ToDictionary(row => row["MaTheLoai"].ToString(), row => row["TenTheLoai"].ToString());

                int hang = 5;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var row = dt.Rows[i];
                    tentruong.Range["A" + hang].Value = row["MaSach"].ToString();
                    tentruong.Range["B" + hang].Value = row["TenSach"].ToString();
                    tentruong.Range["C" + hang].Value = row["TacGia"].ToString();
                    tentruong.Range["D" + hang].Value = row["NhaXuatBan"].ToString();
                    tentruong.Range["E" + hang].Value = row["NamXuatBan"];
                    tentruong.Range["F" + hang].Value = dicTheLoai.ContainsKey(row["MaTheLoai"].ToString())
                        ? dicTheLoai[row["MaTheLoai"].ToString()] : row["MaTheLoai"].ToString();
                    tentruong.Range["G" + hang].Value = row["SoLuong"];
                    tentruong.Range["H" + hang].Value = Convert.ToDateTime(row["NgayNhap"]).ToString("dd/MM/yyyy");
                    tentruong.Range["I" + hang].Value = row["Anh"].ToString();

                    hang++;
                }

                exSheet.Name = "DSSach";

                Excel.Range dataRange = exSheet.Range["A4", "I" + (hang - 1)];
                dataRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                dataRange.Borders.Color = Color.Black;
                dataRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

                exSheet.Columns.AutoFit();

                exApp.Visible = true;
                exBook.Activate();

                SaveFileDialog dlFile = new SaveFileDialog();
                dlFile.Filter = "Excel Files|*.xlsx;*.xls";
                dlFile.Title = "Lưu danh sách sách";
                dlFile.FileName = "DanhSachSach_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (dlFile.ShowDialog() == DialogResult.OK)
                {
                    exBook.SaveAs(dlFile.FileName);
                    MessageBox.Show("Xuất Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message);
            }
        }
    }
    
}
