namespace BTL_C_.UCs
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.group = new System.Windows.Forms.GroupBox();
            this.cbbKieu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTongSach = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDocGia = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTreHan = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbMuon = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lineMuon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pieMuon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineMuon)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieMuon)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.Transparent;
            this.group.Controls.Add(this.cbbKieu);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.btnReset);
            this.group.Controls.Add(this.btnLoc);
            this.group.Controls.Add(this.dtp2);
            this.group.Controls.Add(this.dtp1);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.label1);
            this.group.Location = new System.Drawing.Point(22, 179);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(986, 91);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            this.group.Text = "Lọc";
            this.group.Enter += new System.EventHandler(this.group_Enter);
            // 
            // cbbKieu
            // 
            this.cbbKieu.FormattingEnabled = true;
            this.cbbKieu.Location = new System.Drawing.Point(555, 27);
            this.cbbKieu.Name = "cbbKieu";
            this.cbbKieu.Size = new System.Drawing.Size(163, 28);
            this.cbbKieu.TabIndex = 7;
            this.cbbKieu.SelectedIndexChanged += new System.EventHandler(this.cbbKieu_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kiểu";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(858, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 32);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(753, 27);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(90, 32);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dtp2
            // 
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(357, 28);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(116, 26);
            this.dtp2.TabIndex = 3;
            this.dtp2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(129, 27);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(116, 26);
            this.dtp1.TabIndex = 2;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lbTongSach);
            this.groupBox1.Location = new System.Drawing.Point(19, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng sách";
            // 
            // lbTongSach
            // 
            this.lbTongSach.AutoSize = true;
            this.lbTongSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSach.Location = new System.Drawing.Point(66, 53);
            this.lbTongSach.Name = "lbTongSach";
            this.lbTongSach.Size = new System.Drawing.Size(85, 29);
            this.lbTongSach.TabIndex = 0;
            this.lbTongSach.Text = "label3";
            this.lbTongSach.Click += new System.EventHandler(this.lbTongSach_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.lbDocGia);
            this.groupBox2.Location = new System.Drawing.Point(274, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Độc giả";
            // 
            // lbDocGia
            // 
            this.lbDocGia.AutoSize = true;
            this.lbDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocGia.Location = new System.Drawing.Point(69, 53);
            this.lbDocGia.Name = "lbDocGia";
            this.lbDocGia.Size = new System.Drawing.Size(85, 29);
            this.lbDocGia.TabIndex = 1;
            this.lbDocGia.Text = "label4";
            this.lbDocGia.Click += new System.EventHandler(this.lbDocGia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.lbTreHan);
            this.groupBox3.Location = new System.Drawing.Point(785, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trễ hạn";
            // 
            // lbTreHan
            // 
            this.lbTreHan.AutoSize = true;
            this.lbTreHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTreHan.Location = new System.Drawing.Point(68, 53);
            this.lbTreHan.Name = "lbTreHan";
            this.lbTreHan.Size = new System.Drawing.Size(85, 29);
            this.lbTreHan.TabIndex = 3;
            this.lbTreHan.Text = "label6";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.lbMuon);
            this.groupBox4.Location = new System.Drawing.Point(523, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 115);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đang mượn";
            // 
            // lbMuon
            // 
            this.lbMuon.AutoSize = true;
            this.lbMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMuon.Location = new System.Drawing.Point(72, 53);
            this.lbMuon.Name = "lbMuon";
            this.lbMuon.Size = new System.Drawing.Size(85, 29);
            this.lbMuon.TabIndex = 2;
            this.lbMuon.Text = "label5";
            this.lbMuon.Click += new System.EventHandler(this.lbMuon_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lineMuon);
            this.groupBox5.Location = new System.Drawing.Point(22, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(473, 325);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mượn theo thời gian";
            // 
            // lineMuon
            // 
            chartArea9.Name = "ChartArea1";
            this.lineMuon.ChartAreas.Add(chartArea9);
            legend9.Enabled = false;
            legend9.Name = "Legend1";
            this.lineMuon.Legends.Add(legend9);
            this.lineMuon.Location = new System.Drawing.Point(19, 25);
            this.lineMuon.Name = "lineMuon";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.lineMuon.Series.Add(series9);
            this.lineMuon.Size = new System.Drawing.Size(438, 300);
            this.lineMuon.TabIndex = 0;
            this.lineMuon.Text = "chart1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pieMuon);
            this.groupBox6.Location = new System.Drawing.Point(535, 290);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(473, 319);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mượn theo thể loại";
            // 
            // pieMuon
            // 
            chartArea10.Name = "ChartArea1";
            this.pieMuon.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.pieMuon.Legends.Add(legend10);
            this.pieMuon.Location = new System.Drawing.Point(19, 25);
            this.pieMuon.Name = "pieMuon";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.CustomProperties = "PieLabelStyle=Disabled";
            series10.Legend = "Legend1";
            series10.LegendText = "#VALX";
            series10.Name = "Series1";
            series10.SmartLabelStyle.Enabled = false;
            this.pieMuon.Series.Add(series10);
            this.pieMuon.Size = new System.Drawing.Size(438, 288);
            this.pieMuon.TabIndex = 1;
            this.pieMuon.Text = "chart2";
            this.pieMuon.Click += new System.EventHandler(this.pieMuon_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.Controls.Add(this.groupBox4);
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Location = new System.Drawing.Point(22, 14);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(986, 148);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tổng";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.group);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1030, 682);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineMuon)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pieMuon)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbTongSach;
        private System.Windows.Forms.Label lbDocGia;
        private System.Windows.Forms.Label lbTreHan;
        private System.Windows.Forms.Label lbMuon;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineMuon;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieMuon;
        private System.Windows.Forms.ComboBox cbbKieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
