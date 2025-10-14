namespace BTL_C_
{
    partial class SearchSach
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
            this.components = new System.ComponentModel.Container();
            this.btSach = new System.Windows.Forms.Button();
            this.btTheLoai = new System.Windows.Forms.Button();
            this.btTacGia = new System.Windows.Forms.Button();
            this.btNhaXuatBan = new System.Windows.Forms.Button();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.rbtTacGia = new System.Windows.Forms.RadioButton();
            this.rbtNhaXuatBan = new System.Windows.Forms.RadioButton();
            this.rbtTenSach = new System.Windows.Forms.RadioButton();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.gbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btSach
            // 
            this.btSach.Location = new System.Drawing.Point(63, 39);
            this.btSach.Name = "btSach";
            this.btSach.Size = new System.Drawing.Size(122, 39);
            this.btSach.TabIndex = 1;
            this.btSach.Text = "Sách";
            this.btSach.UseVisualStyleBackColor = true;
            this.btSach.Click += new System.EventHandler(this.btSach_Click);
            // 
            // btTheLoai
            // 
            this.btTheLoai.Location = new System.Drawing.Point(201, 39);
            this.btTheLoai.Name = "btTheLoai";
            this.btTheLoai.Size = new System.Drawing.Size(122, 39);
            this.btTheLoai.TabIndex = 2;
            this.btTheLoai.Text = "Thể loại";
            this.btTheLoai.UseVisualStyleBackColor = true;
            // 
            // btTacGia
            // 
            this.btTacGia.Location = new System.Drawing.Point(349, 39);
            this.btTacGia.Name = "btTacGia";
            this.btTacGia.Size = new System.Drawing.Size(122, 39);
            this.btTacGia.TabIndex = 3;
            this.btTacGia.Text = "Tác giả";
            this.btTacGia.UseVisualStyleBackColor = true;
            // 
            // btNhaXuatBan
            // 
            this.btNhaXuatBan.Location = new System.Drawing.Point(505, 39);
            this.btNhaXuatBan.Name = "btNhaXuatBan";
            this.btNhaXuatBan.Size = new System.Drawing.Size(122, 39);
            this.btNhaXuatBan.TabIndex = 4;
            this.btNhaXuatBan.Text = "Nhà xuất bản";
            this.btNhaXuatBan.UseVisualStyleBackColor = true;
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.cb1);
            this.gbTimKiem.Controls.Add(this.rbtTacGia);
            this.gbTimKiem.Controls.Add(this.rbtNhaXuatBan);
            this.gbTimKiem.Controls.Add(this.rbtTenSach);
            this.gbTimKiem.Controls.Add(this.tbTim);
            this.gbTimKiem.Location = new System.Drawing.Point(66, 117);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(752, 136);
            this.gbTimKiem.TabIndex = 5;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(563, 58);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(156, 28);
            this.cb1.TabIndex = 5;
            this.cb1.Text = "Thể loại";
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // rbtTacGia
            // 
            this.rbtTacGia.AutoSize = true;
            this.rbtTacGia.Location = new System.Drawing.Point(209, 56);
            this.rbtTacGia.Name = "rbtTacGia";
            this.rbtTacGia.Size = new System.Drawing.Size(85, 24);
            this.rbtTacGia.TabIndex = 4;
            this.rbtTacGia.TabStop = true;
            this.rbtTacGia.Text = "Tác giả";
            this.rbtTacGia.UseVisualStyleBackColor = true;
            // 
            // rbtNhaXuatBan
            // 
            this.rbtNhaXuatBan.AutoSize = true;
            this.rbtNhaXuatBan.Location = new System.Drawing.Point(354, 58);
            this.rbtNhaXuatBan.Name = "rbtNhaXuatBan";
            this.rbtNhaXuatBan.Size = new System.Drawing.Size(134, 24);
            this.rbtNhaXuatBan.TabIndex = 3;
            this.rbtNhaXuatBan.TabStop = true;
            this.rbtNhaXuatBan.Text = "Nhà Xuất Bản";
            this.rbtNhaXuatBan.UseVisualStyleBackColor = true;
            // 
            // rbtTenSach
            // 
            this.rbtTenSach.AutoSize = true;
            this.rbtTenSach.Location = new System.Drawing.Point(49, 56);
            this.rbtTenSach.Name = "rbtTenSach";
            this.rbtTenSach.Size = new System.Drawing.Size(102, 24);
            this.rbtTenSach.TabIndex = 1;
            this.rbtTenSach.TabStop = true;
            this.rbtTenSach.Text = "Tên Sách";
            this.rbtTenSach.UseVisualStyleBackColor = true;
            // 
            // tbTim
            // 
            this.tbTim.Location = new System.Drawing.Point(188, 94);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(343, 26);
            this.tbTim.TabIndex = 0;
            this.tbTim.TextChanged += new System.EventHandler(this.tbTim_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(66, 279);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 62;
            this.dgvSach.RowTemplate.Height = 28;
            this.dgvSach.Size = new System.Drawing.Size(752, 218);
            this.dgvSach.TabIndex = 0;
            // 
            // SearchSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.btNhaXuatBan);
            this.Controls.Add(this.btTacGia);
            this.Controls.Add(this.btTheLoai);
            this.Controls.Add(this.btSach);
            this.Controls.Add(this.dgvSach);
            this.Name = "SearchSach";
            this.Size = new System.Drawing.Size(901, 543);
            this.Load += new System.EventHandler(this.SearchSach_Load);
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSach;
        private System.Windows.Forms.Button btTheLoai;
        private System.Windows.Forms.Button btTacGia;
        private System.Windows.Forms.Button btNhaXuatBan;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.RadioButton rbtTacGia;
        private System.Windows.Forms.RadioButton rbtNhaXuatBan;
        private System.Windows.Forms.RadioButton rbtTenSach;
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.ComboBox cb1;
    }
}
