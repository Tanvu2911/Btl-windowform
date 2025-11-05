using BTL_C_.UCs;

namespace BTL_C_
{
    partial class QLThuVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.scoll = new System.Windows.Forms.Panel();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTen = new System.Windows.Forms.Label();
            this.ptAvartar = new System.Windows.Forms.PictureBox();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.NhanVien1 = new BTL_C_.UCs.NhanVien();
            this.thongKe1 = new BTL_C_.UCs.ThongKe();
            this.phieuMuon2 = new BTL_C_.UCs.PhieuMuon();
            this.docGia1 = new BTL_C_.UCs.DocGia();
            this.searchSach1 = new BTL_C_.SearchSach();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAvartar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.scoll);
            this.panel1.Controls.Add(this.btnDocGia);
            this.panel1.Controls.Add(this.btnMuonTra);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 602);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "LIBRARY";
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.Teal;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaiKhoan.Location = new System.Drawing.Point(11, 331);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(156, 39);
            this.btnTaiKhoan.TabIndex = 10;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Teal;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(-3, 540);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(167, 58);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // scoll
            // 
            this.scoll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoll.Location = new System.Drawing.Point(3, 111);
            this.scoll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoll.Name = "scoll";
            this.scoll.Size = new System.Drawing.Size(9, 39);
            this.scoll.TabIndex = 2;
            // 
            // btnDocGia
            // 
            this.btnDocGia.BackColor = System.Drawing.Color.Teal;
            this.btnDocGia.FlatAppearance.BorderSize = 0;
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDocGia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDocGia.Location = new System.Drawing.Point(3, 155);
            this.btnDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(164, 39);
            this.btnDocGia.TabIndex = 8;
            this.btnDocGia.Text = "Độc giả";
            this.btnDocGia.UseVisualStyleBackColor = false;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.BackColor = System.Drawing.Color.Teal;
            this.btnMuonTra.FlatAppearance.BorderSize = 0;
            this.btnMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMuonTra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMuonTra.Location = new System.Drawing.Point(3, 199);
            this.btnMuonTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(164, 39);
            this.btnMuonTra.TabIndex = 7;
            this.btnMuonTra.Text = "Mượn-trả";
            this.btnMuonTra.UseVisualStyleBackColor = false;
            this.btnMuonTra.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Teal;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 244);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(164, 39);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Teal;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(0, 287);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(164, 39);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.Teal;
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSach.Location = new System.Drawing.Point(3, 111);
            this.btnSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(164, 39);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NhanVien1);
            this.panel2.Controls.Add(this.thongKe1);
            this.panel2.Controls.Add(this.phieuMuon2);
            this.panel2.Controls.Add(this.docGia1);
            this.panel2.Controls.Add(this.searchSach1);
            this.panel2.Location = new System.Drawing.Point(172, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 528);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.ptAvartar);
            this.panel3.Controls.Add(this.lbTen);
            this.panel3.Controls.Add(this.ptLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(167, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 71);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTen.Location = new System.Drawing.Point(628, 28);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(108, 17);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Xin chào :";
            // 
            // ptAvartar
            // 
            this.ptAvartar.Location = new System.Drawing.Point(567, 10);
            this.ptAvartar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptAvartar.Name = "ptAvartar";
            this.ptAvartar.Size = new System.Drawing.Size(56, 47);
            this.ptAvartar.TabIndex = 2;
            this.ptAvartar.TabStop = false;
            // 
            // ptLogo
            // 
            this.ptLogo.Image = global::BTL_C_.Properties.Resources.images_Photoroom;
            this.ptLogo.Location = new System.Drawing.Point(0, 0);
            this.ptLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(80, 68);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 9;
            this.ptLogo.TabStop = false;
            this.ptLogo.Click += new System.EventHandler(this.ptLogo_Click);
            // 
            // NhanVien1
            // 
            this.NhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NhanVien1.Location = new System.Drawing.Point(0, 0);
            this.NhanVien1.Name = "NhanVien1";
            this.NhanVien1.Size = new System.Drawing.Size(897, 528);
            this.NhanVien1.TabIndex = 4;
            // 
            // thongKe1
            // 
            this.thongKe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongKe1.Location = new System.Drawing.Point(0, 0);
            this.thongKe1.Margin = new System.Windows.Forms.Padding(1);
            this.thongKe1.Name = "thongKe1";
            this.thongKe1.Size = new System.Drawing.Size(897, 528);
            this.thongKe1.TabIndex = 3;
            // 
            // phieuMuon2
            // 
            this.phieuMuon2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phieuMuon2.Location = new System.Drawing.Point(0, 0);
            this.phieuMuon2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.phieuMuon2.Name = "phieuMuon2";
            this.phieuMuon2.Size = new System.Drawing.Size(897, 528);
            this.phieuMuon2.TabIndex = 2;
            // 
            // docGia1
            // 
            this.docGia1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docGia1.Location = new System.Drawing.Point(0, 0);
            this.docGia1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.docGia1.Name = "docGia1";
            this.docGia1.Size = new System.Drawing.Size(897, 528);
            this.docGia1.TabIndex = 1;
            // 
            // searchSach1
            // 
            this.searchSach1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchSach1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchSach1.Location = new System.Drawing.Point(0, 0);
            this.searchSach1.Margin = new System.Windows.Forms.Padding(1);
            this.searchSach1.Name = "searchSach1";
            this.searchSach1.Size = new System.Drawing.Size(897, 528);
            this.searchSach1.TabIndex = 0;
            // 
            // QLThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLThuVien";
            this.Load += new System.EventHandler(this.QLThuVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAvartar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel scoll;
        private QLSach qlsach1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.PictureBox ptAvartar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptLogo;
        private SearchSach searchSach1;
        private PhieuMuon PhieuMuon1;
        private PhieuMuon phieuMuon2;
        private DocGia docGia1;
        private ThongKe thongKe1;
        private NhanVien NhanVien1;
    }
}