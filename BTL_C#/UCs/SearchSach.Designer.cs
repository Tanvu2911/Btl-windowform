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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSach = new System.Windows.Forms.Button();
            this.btTheLoai = new System.Windows.Forms.Button();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.rbtTacGia = new System.Windows.Forms.RadioButton();
            this.rbtNhaXuatBan = new System.Windows.Forms.RadioButton();
            this.rbtTenSach = new System.Windows.Forms.RadioButton();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.gbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btSach
            // 
            this.btSach.BackColor = System.Drawing.Color.Teal;
            this.btSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSach.Location = new System.Drawing.Point(63, 39);
            this.btSach.Name = "btSach";
            this.btSach.Size = new System.Drawing.Size(180, 59);
            this.btSach.TabIndex = 1;
            this.btSach.Text = "Sách";
            this.btSach.UseVisualStyleBackColor = false;
            this.btSach.Click += new System.EventHandler(this.btSach_Click);
            // 
            // btTheLoai
            // 
            this.btTheLoai.BackColor = System.Drawing.Color.DarkCyan;
            this.btTheLoai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTheLoai.Location = new System.Drawing.Point(301, 39);
            this.btTheLoai.Name = "btTheLoai";
            this.btTheLoai.Size = new System.Drawing.Size(174, 59);
            this.btTheLoai.TabIndex = 2;
            this.btTheLoai.Text = "Thể loại";
            this.btTheLoai.UseVisualStyleBackColor = false;
            this.btTheLoai.Click += new System.EventHandler(this.btTheLoai_Click);
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.BackColor = System.Drawing.Color.Teal;
            this.gbTimKiem.Controls.Add(this.btnReset);
            this.gbTimKiem.Controls.Add(this.cb1);
            this.gbTimKiem.Controls.Add(this.rbtTacGia);
            this.gbTimKiem.Controls.Add(this.rbtNhaXuatBan);
            this.gbTimKiem.Controls.Add(this.rbtTenSach);
            this.gbTimKiem.Controls.Add(this.tbTim);
            this.gbTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbTimKiem.Location = new System.Drawing.Point(66, 117);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(908, 135);
            this.gbTimKiem.TabIndex = 5;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(732, 51);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 31);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(542, 51);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(156, 28);
            this.cb1.TabIndex = 5;
            this.cb1.Text = "Thể loại";
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // rbtTacGia
            // 
            this.rbtTacGia.AutoSize = true;
            this.rbtTacGia.Location = new System.Drawing.Point(235, 52);
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
            this.rbtNhaXuatBan.Location = new System.Drawing.Point(380, 54);
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
            this.rbtTenSach.Location = new System.Drawing.Point(75, 52);
            this.rbtTenSach.Name = "rbtTenSach";
            this.rbtTenSach.Size = new System.Drawing.Size(102, 24);
            this.rbtTenSach.TabIndex = 1;
            this.rbtTenSach.TabStop = true;
            this.rbtTenSach.Text = "Tên Sách";
            this.rbtTenSach.UseVisualStyleBackColor = true;
            // 
            // tbTim
            // 
            this.tbTim.Location = new System.Drawing.Point(258, 95);
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
            this.dgvSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSach.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSach.Location = new System.Drawing.Point(66, 279);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 62;
            this.dgvSach.RowTemplate.Height = 28;
            this.dgvSach.Size = new System.Drawing.Size(908, 298);
            this.dgvSach.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Teal;
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcel.Location = new System.Drawing.Point(66, 583);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(257, 60);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // SearchSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.btTheLoai);
            this.Controls.Add(this.btSach);
            this.Controls.Add(this.dgvSach);
            this.Name = "SearchSach";
            this.Size = new System.Drawing.Size(1039, 659);
            this.Load += new System.EventHandler(this.SearchSach_Load);
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSach;
        private System.Windows.Forms.Button btTheLoai;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.RadioButton rbtTacGia;
        private System.Windows.Forms.RadioButton rbtNhaXuatBan;
        private System.Windows.Forms.RadioButton rbtTenSach;
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExcel;
    }
}
