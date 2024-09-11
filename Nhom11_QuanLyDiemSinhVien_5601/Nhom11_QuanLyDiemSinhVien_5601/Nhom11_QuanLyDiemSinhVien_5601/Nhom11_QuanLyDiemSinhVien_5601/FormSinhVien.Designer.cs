namespace Nhom11_QuanLyDiemSinhVien_5601
{
    partial class FormSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSinhVien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpngaysinhsv = new System.Windows.Forms.DateTimePicker();
            this.cbgioitinhsv = new System.Windows.Forms.ComboBox();
            this.txtmakhoasv = new System.Windows.Forms.TextBox();
            this.txtsdtsv = new System.Windows.Forms.TextBox();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.txttensv = new System.Windows.Forms.TextBox();
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoatsv = new System.Windows.Forms.Button();
            this.btnsuasv = new System.Windows.Forms.Button();
            this.btnxoasv = new System.Windows.Forms.Button();
            this.btnthemsv = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.qLDIEMSVDataSet = new Nhom11_QuanLyDiemSinhVien_5601.QLDIEMSVDataSet();
            this.sINHVIENTableAdapter = new Nhom11_QuanLyDiemSinhVien_5601.QLDIEMSVDataSetTableAdapters.SINHVIENTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemSV = new System.Windows.Forms.Button();
            this.txtTimKiemSV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReFreshSV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDIEMSVDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpngaysinhsv);
            this.groupBox1.Controls.Add(this.cbgioitinhsv);
            this.groupBox1.Controls.Add(this.txtmakhoasv);
            this.groupBox1.Controls.Add(this.txtsdtsv);
            this.groupBox1.Controls.Add(this.txtquequan);
            this.groupBox1.Controls.Add(this.txttensv);
            this.groupBox1.Controls.Add(this.txtmsv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 423);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // dtpngaysinhsv
            // 
            this.dtpngaysinhsv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinhsv.Location = new System.Drawing.Point(227, 163);
            this.dtpngaysinhsv.Name = "dtpngaysinhsv";
            this.dtpngaysinhsv.Size = new System.Drawing.Size(241, 30);
            this.dtpngaysinhsv.TabIndex = 14;
            // 
            // cbgioitinhsv
            // 
            this.cbgioitinhsv.FormattingEnabled = true;
            this.cbgioitinhsv.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgioitinhsv.Location = new System.Drawing.Point(227, 270);
            this.cbgioitinhsv.Name = "cbgioitinhsv";
            this.cbgioitinhsv.Size = new System.Drawing.Size(242, 33);
            this.cbgioitinhsv.TabIndex = 13;
            // 
            // txtmakhoasv
            // 
            this.txtmakhoasv.Location = new System.Drawing.Point(227, 375);
            this.txtmakhoasv.Name = "txtmakhoasv";
            this.txtmakhoasv.Size = new System.Drawing.Size(244, 30);
            this.txtmakhoasv.TabIndex = 12;
            // 
            // txtsdtsv
            // 
            this.txtsdtsv.Location = new System.Drawing.Point(227, 327);
            this.txtsdtsv.Name = "txtsdtsv";
            this.txtsdtsv.Size = new System.Drawing.Size(244, 30);
            this.txtsdtsv.TabIndex = 11;
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(227, 216);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(244, 30);
            this.txtquequan.TabIndex = 10;
            // 
            // txttensv
            // 
            this.txttensv.Location = new System.Drawing.Point(227, 112);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(244, 30);
            this.txttensv.TabIndex = 8;
            // 
            // txtmsv
            // 
            this.txtmsv.Location = new System.Drawing.Point(227, 56);
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.Size = new System.Drawing.Size(244, 30);
            this.txtmsv.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số điện thoại: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quê quán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Họ tên sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã khoa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên:";
            // 
            // btnthoatsv
            // 
            this.btnthoatsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoatsv.Location = new System.Drawing.Point(1265, 711);
            this.btnthoatsv.Name = "btnthoatsv";
            this.btnthoatsv.Size = new System.Drawing.Size(111, 44);
            this.btnthoatsv.TabIndex = 10;
            this.btnthoatsv.Text = "Thoát";
            this.btnthoatsv.UseVisualStyleBackColor = true;
            this.btnthoatsv.Click += new System.EventHandler(this.btnthoatsv_Click);
            // 
            // btnsuasv
            // 
            this.btnsuasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuasv.Location = new System.Drawing.Point(1028, 711);
            this.btnsuasv.Name = "btnsuasv";
            this.btnsuasv.Size = new System.Drawing.Size(111, 44);
            this.btnsuasv.TabIndex = 9;
            this.btnsuasv.Text = "Sửa";
            this.btnsuasv.UseVisualStyleBackColor = true;
            this.btnsuasv.Click += new System.EventHandler(this.btnsuasv_Click);
            // 
            // btnxoasv
            // 
            this.btnxoasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoasv.Location = new System.Drawing.Point(789, 711);
            this.btnxoasv.Name = "btnxoasv";
            this.btnxoasv.Size = new System.Drawing.Size(111, 44);
            this.btnxoasv.TabIndex = 8;
            this.btnxoasv.Text = "Xóa";
            this.btnxoasv.UseVisualStyleBackColor = true;
            this.btnxoasv.Click += new System.EventHandler(this.btnxoasv_Click);
            // 
            // btnthemsv
            // 
            this.btnthemsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemsv.Location = new System.Drawing.Point(551, 711);
            this.btnthemsv.Name = "btnthemsv";
            this.btnthemsv.Size = new System.Drawing.Size(111, 44);
            this.btnthemsv.TabIndex = 7;
            this.btnthemsv.Text = "Thêm";
            this.btnthemsv.UseVisualStyleBackColor = true;
            this.btnthemsv.Click += new System.EventHandler(this.btnthemsv_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(508, 269);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(919, 410);
            this.dgvSinhVien.TabIndex = 11;
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(795, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // qLDIEMSVDataSet
            // 
            this.qLDIEMSVDataSet.DataSetName = "QLDIEMSVDataSet";
            this.qLDIEMSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnTimKiemSV);
            this.groupBox2.Controls.Add(this.txtTimKiemSV);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 695);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(481, 102);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimKiemSV
            // 
            this.btnTimKiemSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSV.Location = new System.Drawing.Point(317, 37);
            this.btnTimKiemSV.Name = "btnTimKiemSV";
            this.btnTimKiemSV.Size = new System.Drawing.Size(111, 44);
            this.btnTimKiemSV.TabIndex = 14;
            this.btnTimKiemSV.Text = "Tìm kiếm";
            this.btnTimKiemSV.UseVisualStyleBackColor = true;
            this.btnTimKiemSV.Click += new System.EventHandler(this.btnTimKiemSV_Click);
            // 
            // txtTimKiemSV
            // 
            this.txtTimKiemSV.Location = new System.Drawing.Point(147, 49);
            this.txtTimKiemSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemSV.Name = "txtTimKiemSV";
            this.txtTimKiemSV.Size = new System.Drawing.Size(132, 26);
            this.txtTimKiemSV.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã sinh viên:";
            // 
            // btnReFreshSV
            // 
            this.btnReFreshSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReFreshSV.Location = new System.Drawing.Point(1316, 230);
            this.btnReFreshSV.Name = "btnReFreshSV";
            this.btnReFreshSV.Size = new System.Drawing.Size(111, 33);
            this.btnReFreshSV.TabIndex = 14;
            this.btnReFreshSV.Text = "Refresh";
            this.btnReFreshSV.UseVisualStyleBackColor = true;
            this.btnReFreshSV.Click += new System.EventHandler(this.btnReFreshSV_Click);
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1451, 805);
            this.Controls.Add(this.btnReFreshSV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnthoatsv);
            this.Controls.Add(this.btnsuasv);
            this.Controls.Add(this.btnxoasv);
            this.Controls.Add(this.btnthemsv);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDIEMSVDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpngaysinhsv;
        private System.Windows.Forms.ComboBox cbgioitinhsv;
        private System.Windows.Forms.TextBox txtmakhoasv;
        private System.Windows.Forms.TextBox txtsdtsv;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoatsv;
        private System.Windows.Forms.Button btnsuasv;
        private System.Windows.Forms.Button btnxoasv;
        private System.Windows.Forms.Button btnthemsv;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label label1;
        private QLDIEMSVDataSet qLDIEMSVDataSet;
        private QLDIEMSVDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKiemSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTimKiemSV;
        private System.Windows.Forms.Button btnReFreshSV;
    }
}