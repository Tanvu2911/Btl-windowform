using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace BTL_C_.UCs
{
    public partial class ThongKe : System.Windows.Forms.UserControl
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        DataTable dtThongKe;
        public ThongKe()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dtp2.CustomFormat = "dd/MM/yyyy";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void group_Enter(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            cbbKieu.Items.Add("Theo ngày");
            cbbKieu.Items.Add("Theo tháng");
            cbbKieu.Items.Add("Theo năm");
            cbbKieu.SelectedIndex = -1;

            dtp1.CustomFormat = " ";
            dtp1.Format = DateTimePickerFormat.Custom;

            dtp2.CustomFormat = " ";
            dtp2.Format = DateTimePickerFormat.Custom;

            LoadDashboard();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (dtp1.CustomFormat == " ")
            {
                MessageBox.Show("Bạn phải chọn ngày bắt đầu!", "Thông báo");
                return;
            }  
            if (dtp2.CustomFormat == " ")
            {
                MessageBox.Show("Bạn phải chọn ngày kết thúc!", "Thông báo");
                return;
            }           
            if (string.IsNullOrWhiteSpace(cbbKieu.Text))
            {
                MessageBox.Show("Bạn phải chọn kiểu hiển thị!", "Thông báo");
                return;
            }            
            if (dtp1.Value > dtp2.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Thông báo");
                return;
            }            
            if (cbbKieu.Text == "Theo ngày")
            {
                if (dtp1.Value.Month != dtp2.Value.Month || dtp1.Value.Year != dtp2.Value.Year)
                {
                    MessageBox.Show("Khi chọn theo ngày, ngày bắt đầu và kết thúc phải cùng tháng và năm!",
                        "Thông báo");
                    return;
                }
            }
            if (cbbKieu.Text == "Theo tháng")
            {
                if (dtp1.Value.Year != dtp2.Value.Year)
                {
                    MessageBox.Show("Khi chọn theo tháng, ngày bắt đầu và kết thúc phải cùng năm!",
                        "Thông báo");
                    return;
                }
            }

            string kieu = cbbKieu.Text;
            string sqlCheck = "";

            if (kieu == "Theo ngày")
            {
                sqlCheck = $@"
                SELECT COUNT(*) FROM PhieuMuon
                WHERE CONVERT(date, NgayMuon) BETWEEN '{dtp1.Value:yyyy-MM-dd}' AND '{dtp2.Value:yyyy-MM-dd}'";
            }
            else if (kieu == "Theo tháng")
            {
                sqlCheck = $@"
                SELECT COUNT(*) FROM PhieuMuon
                WHERE YEAR(NgayMuon) = {dtp1.Value.Year}
                AND MONTH(NgayMuon) BETWEEN {dtp1.Value.Month} AND {dtp2.Value.Month}";
            }
            else // Theo năm
            {
                sqlCheck = $@"
                SELECT COUNT(*) FROM PhieuMuon
                WHERE YEAR(NgayMuon) BETWEEN {dtp1.Value.Year} AND {dtp2.Value.Year}";
            }

            int count = Convert.ToInt32(dtBase.ExecuteScalar(sqlCheck));

            if (count == 0)
            {
                MessageBox.Show($"Không có dữ liệu mượn sách từ {dtp1.Value:dd/MM/yyyy} đến {dtp2.Value:dd/MM/yyyy}!", "Thông báo");
                lineMuon.Series.Clear();
                pieMuon.Series.Clear();
                return;
            }

            LoadDashboard();
            LoadChartLine();
            LoadChartPie();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtp1.CustomFormat = " ";
            dtp2.CustomFormat = " ";
            cbbKieu.SelectedIndex = -1;

            LoadDashboard();
            lineMuon.Series.Clear();
            pieMuon.Series.Clear();
        }
        private void LoadDashboard()
        {
            
            lbTongSach.Text = dtBase.ExecuteScalar("SELECT COUNT(*) FROM Sach").ToString();

            
            lbDocGia.Text = dtBase.ExecuteScalar("SELECT COUNT(*) FROM DocGia").ToString();

            
            lbMuon.Text = dtBase.ExecuteScalar(@"
            SELECT COUNT(DISTINCT MaPhieu)
            FROM ChiTietMuon
            WHERE TrangThai = N'Đang mượn'
            ").ToString();

            // Tổng trễ hạn
            lbTreHan.Text = dtBase.ExecuteScalar(@"
            SELECT COUNT(*) 
            FROM PhieuMuon 
            WHERE NgayHenTra < GETDATE()
            ").ToString();
        }
        private void LoadChartLine()
        {
            string sql = "";
            string kieu = cbbKieu.Text;

            if (kieu == "Theo ngày")
            {
                sql = $@"
                SELECT CONVERT(date, NgayMuon) AS Ngay, SUM(ct.SoLuong) AS SoLuong
                FROM ChiTietMuon ct
                JOIN PhieuMuon pm ON pm.MaPhieu = ct.MaPhieu
                WHERE CONVERT(date, NgayMuon) BETWEEN '{dtp1.Value:yyyy-MM-dd}' AND '{dtp2.Value:yyyy-MM-dd}'
                GROUP BY CONVERT(date, NgayMuon)
                ORDER BY Ngay";

            }
            else if (kieu == "Theo tháng")
            {
                sql = $@"
    SELECT MONTH(NgayMuon) AS Thang, SUM(ct.SoLuong) AS SoLuong
    FROM ChiTietMuon ct
    JOIN PhieuMuon pm ON pm.MaPhieu = ct.MaPhieu
    WHERE YEAR(NgayMuon) = {dtp1.Value.Year}
    AND MONTH(NgayMuon) BETWEEN {dtp1.Value.Month} AND {dtp2.Value.Month}
    GROUP BY MONTH(NgayMuon)
    ORDER BY Thang";

            }
            else
            {
                sql = $@"
    SELECT YEAR(NgayMuon) AS Nam, SUM(ct.SoLuong) AS SoLuong
    FROM ChiTietMuon ct
    JOIN PhieuMuon pm ON pm.MaPhieu = ct.MaPhieu
    GROUP BY YEAR(NgayMuon)
    ORDER BY Nam";

            }

            DataTable dt = dtBase.DocBang(sql);

            lineMuon.Series.Clear();
            Series s = new Series("Mượn");
            s.ChartType = SeriesChartType.Line;
            s.BorderWidth = 3;
            s.MarkerStyle = MarkerStyle.Circle;
            s.MarkerSize = 8;

            
            if (kieu == "Theo ngày")
            {
                foreach (DataRow r in dt.Rows)
                {
                    DateTime ngay = Convert.ToDateTime(r[0]);
                    s.Points.AddXY(ngay, r["SoLuong"]);
                }

                lineMuon.ChartAreas[0].AxisX.LabelStyle.Format = "dd";
            }
            else if (kieu == "Theo tháng")
            {
                foreach (DataRow r in dt.Rows)
                {
                    int thang = Convert.ToInt32(r[0]);
                    s.Points.AddXY(thang.ToString(), r["SoLuong"]);
                }

                
                lineMuon.ChartAreas[0].AxisX.LabelStyle.Format = "";
            }
            else
            {
                foreach (DataRow r in dt.Rows)
                {
                    int nam = Convert.ToInt32(r[0]);
                    s.Points.AddXY(nam.ToString(), r["SoLuong"]);
                }

                lineMuon.ChartAreas[0].AxisX.LabelStyle.Format = "";
            }

            lineMuon.Series.Add(s);
            lineMuon.Legends.Clear();

            
            
        }
        private void LoadChartPie()
        {            
            string sql = "";
            string kieu = cbbKieu.Text;

            if (kieu == "Theo ngày")
            {
                sql = $@"
    SELECT TheLoai.TenTheLoai, SUM(ct.SoLuong) AS Soluong
    FROM ChiTietMuon ct
    JOIN Sach s ON ct.MaSach = s.MaSach
    JOIN TheLoai ON s.MaTheLoai = TheLoai.MaTheLoai
    JOIN PhieuMuon pm ON pm.MaPhieu = ct.MaPhieu
    WHERE CONVERT(date, NgayMuon) BETWEEN '{dtp1.Value:yyyy-MM-dd}' AND '{dtp2.Value:yyyy-MM-dd}'
    GROUP BY TheLoai.TenTheLoai";

            }
            else if (kieu == "Theo tháng")
            {
                sql = $@"
    SELECT TheLoai.TenTheLoai, SUM(ct.SoLuong) AS Soluong
    FROM ChiTietMuon ct
    JOIN Sach s ON ct.MaSach = s.MaSach
    JOIN TheLoai ON s.MaTheLoai = TheLoai.MaTheLoai
    JOIN PhieuMuon pm ON pm.MaPhieu = ct.MaPhieu
    WHERE pm.NgayMuon >= '{dtp1.Value:yyyy-MM-dd}'
    AND pm.NgayMuon <= '{dtp2.Value:yyyy-MM-dd}'
    GROUP BY TheLoai.TenTheLoai
    ORDER BY TheLoai.TenTheLoai";

            }
            else
            {
                sql = $@"
    SELECT TheLoai.TenTheLoai, SUM(ct.SoLuong) AS Soluong
    FROM ChiTietMuon ct
    JOIN Sach s ON ct.MaSach = s.MaSach
    JOIN TheLoai ON s.MaTheLoai = TheLoai.MaTheLoai
    JOIN PhieuMuon pm ON pm.MaPhieu = ct.MaPhieu
    WHERE YEAR(NgayMuon) BETWEEN {dtp1.Value.Year} AND {dtp2.Value.Year}
    GROUP BY TheLoai.TenTheLoai";

            }

            DataTable dt = dtBase.DocBang(sql);

            pieMuon.Series.Clear();
            pieMuon.Legends.Clear();

            Series s = new Series("Thể loại");
            s.ChartType = SeriesChartType.Pie;

            s.IsValueShownAsLabel = false;
            s["PieLabelStyle"] = "Disabled";
            s.LegendText = "#VALX (#PERCENT{P1})";

            foreach (DataRow r in dt.Rows)
            {
                string ten = r[0].ToString();

                
                if (ten.Length > 12)
                    ten = ten.Insert(12, "\n");

                s.Points.AddXY(ten, r["Soluong"]);
            }

            pieMuon.Series.Add(s);

            Legend legend = new Legend("Legend1");
            legend.Docking = Docking.Right;
            legend.Font = new Font("Segoe UI", 9);
            legend.IsTextAutoFit = true;
            pieMuon.Legends.Add(legend);
        }

        private void cbbKieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbDocGia_Click(object sender, EventArgs e)
        {

        }

        private void lbTongSach_Click(object sender, EventArgs e)
        {

        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            dtp1.CustomFormat = "dd/MM/yyyy";
        }

        private void lbMuon_Click(object sender, EventArgs e)
        {

        }

        private void pieMuon_Click(object sender, EventArgs e)
        {

        }
    }
}
