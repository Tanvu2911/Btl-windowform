namespace BTL_C_.UCs
{
    partial class PhieuMuon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimDocGia = new System.Windows.Forms.TextBox();
            this.btnTimDocGia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dgvSachDangMuon = new System.Windows.Forms.DataGridView();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimSach = new System.Windows.Forms.Button();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSachKhaDung = new System.Windows.Forms.DataGridView();
            this.btnMuonSach = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDangMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachKhaDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Location = new System.Drawing.Point(854, 589);
            this.btnInPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(100, 36);
            this.btnInPhieu.TabIndex = 0;
            this.btnInPhieu.Text = "In phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm độc giả ";
            // 
            // txtTimDocGia
            // 
            this.txtTimDocGia.Location = new System.Drawing.Point(183, 34);
            this.txtTimDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimDocGia.Name = "txtTimDocGia";
            this.txtTimDocGia.Size = new System.Drawing.Size(242, 26);
            this.txtTimDocGia.TabIndex = 2;
            // 
            // btnTimDocGia
            // 
            this.btnTimDocGia.Location = new System.Drawing.Point(458, 32);
            this.btnTimDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimDocGia.Name = "btnTimDocGia";
            this.btnTimDocGia.Size = new System.Drawing.Size(84, 29);
            this.btnTimDocGia.TabIndex = 3;
            this.btnTimDocGia.Text = "Tìm";
            this.btnTimDocGia.UseVisualStyleBackColor = true;
            this.btnTimDocGia.Click += new System.EventHandler(this.btnTimDocGia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin độc giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã ĐG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Họ Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sinh Nhật";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Enabled = false;
            this.txtMaDG.Location = new System.Drawing.Point(132, 102);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(119, 26);
            this.txtMaDG.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Enabled = false;
            this.txtDienThoai.Location = new System.Drawing.Point(342, 139);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(186, 26);
            this.txtDienThoai.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(342, 102);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(186, 26);
            this.txtHoTen.TabIndex = 11;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(132, 139);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(119, 26);
            this.dtpNgaySinh.TabIndex = 12;
            // 
            // dgvSachDangMuon
            // 
            this.dgvSachDangMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachDangMuon.Location = new System.Drawing.Point(7, 21);
            this.dgvSachDangMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSachDangMuon.Name = "dgvSachDangMuon";
            this.dgvSachDangMuon.RowHeadersWidth = 51;
            this.dgvSachDangMuon.RowTemplate.Height = 24;
            this.dgvSachDangMuon.Size = new System.Drawing.Size(488, 189);
            this.dgvSachDangMuon.TabIndex = 13;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(567, 400);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(98, 29);
            this.btnThemSach.TabIndex = 14;
            this.btnThemSach.Text = "Thêm Sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(166, 596);
            this.btnXoaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(84, 29);
            this.btnXoaSach.TabIndex = 15;
            this.btnXoaSach.Text = "Xóa Sách";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(740, 590);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 35);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimSach
            // 
            this.btnTimSach.Location = new System.Drawing.Point(839, 141);
            this.btnTimSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(84, 29);
            this.btnTimSach.TabIndex = 19;
            this.btnTimSach.Text = "Tìm";
            this.btnTimSach.UseVisualStyleBackColor = true;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // txtTimSach
            // 
            this.txtTimSach.Location = new System.Drawing.Point(558, 142);
            this.txtTimSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(242, 26);
            this.txtTimSach.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tìm sách để mượn:";
            // 
            // dgvSachKhaDung
            // 
            this.dgvSachKhaDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachKhaDung.Location = new System.Drawing.Point(7, 22);
            this.dgvSachKhaDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSachKhaDung.Name = "dgvSachKhaDung";
            this.dgvSachKhaDung.RowHeadersWidth = 51;
            this.dgvSachKhaDung.RowTemplate.Height = 24;
            this.dgvSachKhaDung.Size = new System.Drawing.Size(469, 188);
            this.dgvSachKhaDung.TabIndex = 20;
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.Location = new System.Drawing.Point(52, 596);
            this.btnMuonSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.Size = new System.Drawing.Size(98, 29);
            this.btnMuonSach.TabIndex = 21;
            this.btnMuonSach.Text = "Mượn Sách";
            this.btnMuonSach.UseVisualStyleBackColor = true;
            this.btnMuonSach.Click += new System.EventHandler(this.btnMuonSach_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(52, 392);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(119, 29);
            this.btnTraSach.TabIndex = 22;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuon.Location = new System.Drawing.Point(7, 26);
            this.dgvSachMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.RowHeadersWidth = 51;
            this.dgvSachMuon.RowTemplate.Height = 24;
            this.dgvSachMuon.Size = new System.Drawing.Size(488, 102);
            this.dgvSachMuon.TabIndex = 24;
            this.dgvSachMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSachMuon_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSachDangMuon);
            this.groupBox1.Location = new System.Drawing.Point(40, 174);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(502, 218);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sách đang mượn: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSachKhaDung);
            this.groupBox2.Location = new System.Drawing.Point(560, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(483, 218);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm sách khả dụng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSachMuon);
            this.groupBox3.Location = new System.Drawing.Point(47, 428);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(502, 141);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sách sẽ mượn (giỏ hàng tạm) :";
            // 
            // PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.btnMuonSach);
            this.Controls.Add(this.btnTimSach);
            this.Controls.Add(this.txtTimSach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtMaDG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimDocGia);
            this.Controls.Add(this.txtTimDocGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInPhieu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PhieuMuon";
            this.Size = new System.Drawing.Size(1065, 641);
            this.Load += new System.EventHandler(this.PhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDangMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachKhaDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimDocGia;
        private System.Windows.Forms.Button btnTimDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridView dgvSachDangMuon;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimSach;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvSachKhaDung;
        private System.Windows.Forms.Button btnMuonSach;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
