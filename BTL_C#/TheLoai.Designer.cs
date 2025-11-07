namespace BTL_C_
{
    partial class TheLoai
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
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaTheLoai = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.Location = new System.Drawing.Point(35, 158);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.RowHeadersWidth = 62;
            this.dgvTheLoai.RowTemplate.Height = 28;
            this.dgvTheLoai.Size = new System.Drawing.Size(728, 270);
            this.dgvTheLoai.TabIndex = 0;
            this.dgvTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 95);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 46);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm\r\n";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(190, 95);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(126, 46);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(342, 95);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 46);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(637, 95);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 46);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(637, 20);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(126, 46);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // tbTim
            // 
            this.tbTim.Location = new System.Drawing.Point(268, 56);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(280, 26);
            this.tbTim.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã thể loại";
            // 
            // tbMaTheLoai
            // 
            this.tbMaTheLoai.Location = new System.Drawing.Point(268, 20);
            this.tbMaTheLoai.Name = "tbMaTheLoai";
            this.tbMaTheLoai.Size = new System.Drawing.Size(280, 26);
            this.tbMaTheLoai.TabIndex = 8;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(491, 95);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(126, 46);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaTheLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvTheLoai);
            this.Name = "TheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheLoai";
            this.Load += new System.EventHandler(this.TheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaTheLoai;
        private System.Windows.Forms.Button btnLamMoi;
    }
}