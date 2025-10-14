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
            this.scoll = new System.Windows.Forms.Panel();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchSach1 = new BTL_C_.SearchSach();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.scoll);
            this.panel1.Controls.Add(this.btnDocGia);
            this.panel1.Controls.Add(this.btnMuonTra);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 746);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // scoll
            // 
            this.scoll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoll.Location = new System.Drawing.Point(3, 140);
            this.scoll.Name = "scoll";
            this.scoll.Size = new System.Drawing.Size(10, 49);
            this.scoll.TabIndex = 2;
            // 
            // btnDocGia
            // 
            this.btnDocGia.BackColor = System.Drawing.Color.DimGray;
            this.btnDocGia.FlatAppearance.BorderSize = 0;
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocGia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDocGia.Location = new System.Drawing.Point(3, 195);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(184, 49);
            this.btnDocGia.TabIndex = 8;
            this.btnDocGia.Text = "Độc giả";
            this.btnDocGia.UseVisualStyleBackColor = false;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.BackColor = System.Drawing.Color.DimGray;
            this.btnMuonTra.FlatAppearance.BorderSize = 0;
            this.btnMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuonTra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMuonTra.Location = new System.Drawing.Point(3, 250);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(184, 49);
            this.btnMuonTra.TabIndex = 7;
            this.btnMuonTra.Text = "Mượn-trả";
            this.btnMuonTra.UseVisualStyleBackColor = false;
            this.btnMuonTra.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.DimGray;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 305);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(184, 49);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DimGray;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThongKe.Location = new System.Drawing.Point(0, 360);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(184, 49);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.DimGray;
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSach.Location = new System.Drawing.Point(3, 140);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(184, 49);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchSach1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(194, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 597);
            this.panel2.TabIndex = 1;
            // 
            // searchSach1
            // 
            this.searchSach1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchSach1.Location = new System.Drawing.Point(0, 0);
            this.searchSach1.Name = "searchSach1";
            this.searchSach1.Size = new System.Drawing.Size(1053, 597);
            this.searchSach1.TabIndex = 0;
            // 
            // QLThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 746);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QLThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLThuVien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private SearchSach searchSach1;
    }
}