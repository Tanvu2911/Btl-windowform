using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace BTL_C_.UCs
{
    public partial class PhieuMuon : UserControl
    {
        public PhieuMuon()
        {
            InitializeComponent();
        }

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
    }
}
