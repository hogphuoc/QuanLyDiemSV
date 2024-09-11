namespace Nhom11_QuanLyDiemSinhVien_5601
{
    partial class FormBangDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBangDiem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdiemck = new System.Windows.Forms.TextBox();
            this.txtdiemgk = new System.Windows.Forms.TextBox();
            this.txtmlmhDiem = new System.Windows.Forms.TextBox();
            this.txtmsvDiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBangDiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoatdiem = new System.Windows.Forms.Button();
            this.btnsuadiem = new System.Windows.Forms.Button();
            this.btnxoadiem = new System.Windows.Forms.Button();
            this.btnthemdiem = new System.Windows.Forms.Button();
            this.btnReFreshBD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemBD = new System.Windows.Forms.Button();
            this.txtTimKiemBD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbangdiemct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtdiemck);
            this.groupBox1.Controls.Add(this.txtdiemgk);
            this.groupBox1.Controls.Add(this.txtmlmhDiem);
            this.groupBox1.Controls.Add(this.txtmsvDiem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 423);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bảng điểm";
            // 
            // txtdiemck
            // 
            this.txtdiemck.Location = new System.Drawing.Point(231, 341);
            this.txtdiemck.Name = "txtdiemck";
            this.txtdiemck.Size = new System.Drawing.Size(244, 30);
            this.txtdiemck.TabIndex = 10;
            // 
            // txtdiemgk
            // 
            this.txtdiemgk.Location = new System.Drawing.Point(231, 252);
            this.txtdiemgk.Name = "txtdiemgk";
            this.txtdiemgk.Size = new System.Drawing.Size(244, 30);
            this.txtdiemgk.TabIndex = 9;
            // 
            // txtmlmhDiem
            // 
            this.txtmlmhDiem.Location = new System.Drawing.Point(231, 161);
            this.txtmlmhDiem.Name = "txtmlmhDiem";
            this.txtmlmhDiem.Size = new System.Drawing.Size(244, 30);
            this.txtmlmhDiem.TabIndex = 8;
            // 
            // txtmsvDiem
            // 
            this.txtmsvDiem.Location = new System.Drawing.Point(231, 77);
            this.txtmsvDiem.Name = "txtmsvDiem";
            this.txtmsvDiem.Size = new System.Drawing.Size(244, 30);
            this.txtmsvDiem.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Điểm cuối kì:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Điểm giữa kì";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã lớp môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên:";
            // 
            // dgvBangDiem
            // 
            this.dgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiem.Location = new System.Drawing.Point(501, 266);
            this.dgvBangDiem.Name = "dgvBangDiem";
            this.dgvBangDiem.RowHeadersWidth = 51;
            this.dgvBangDiem.RowTemplate.Height = 24;
            this.dgvBangDiem.Size = new System.Drawing.Size(939, 414);
            this.dgvBangDiem.TabIndex = 19;
            this.dgvBangDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangDiem_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(756, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "QUẢN LÝ BẢNG ĐIỂM";
            // 
            // btnthoatdiem
            // 
            this.btnthoatdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoatdiem.Location = new System.Drawing.Point(1261, 714);
            this.btnthoatdiem.Name = "btnthoatdiem";
            this.btnthoatdiem.Size = new System.Drawing.Size(111, 44);
            this.btnthoatdiem.TabIndex = 33;
            this.btnthoatdiem.Text = "Thoát";
            this.btnthoatdiem.UseVisualStyleBackColor = true;
            this.btnthoatdiem.Click += new System.EventHandler(this.btnthoatdiem_Click);
            // 
            // btnsuadiem
            // 
            this.btnsuadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuadiem.Location = new System.Drawing.Point(1023, 714);
            this.btnsuadiem.Name = "btnsuadiem";
            this.btnsuadiem.Size = new System.Drawing.Size(111, 44);
            this.btnsuadiem.TabIndex = 32;
            this.btnsuadiem.Text = "Sửa";
            this.btnsuadiem.UseVisualStyleBackColor = true;
            this.btnsuadiem.Click += new System.EventHandler(this.btnsuadiem_Click);
            // 
            // btnxoadiem
            // 
            this.btnxoadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoadiem.Location = new System.Drawing.Point(785, 714);
            this.btnxoadiem.Name = "btnxoadiem";
            this.btnxoadiem.Size = new System.Drawing.Size(111, 44);
            this.btnxoadiem.TabIndex = 31;
            this.btnxoadiem.Text = "Xóa";
            this.btnxoadiem.UseVisualStyleBackColor = true;
            this.btnxoadiem.Click += new System.EventHandler(this.btnxoadiem_Click);
            // 
            // btnthemdiem
            // 
            this.btnthemdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemdiem.Location = new System.Drawing.Point(547, 714);
            this.btnthemdiem.Name = "btnthemdiem";
            this.btnthemdiem.Size = new System.Drawing.Size(111, 44);
            this.btnthemdiem.TabIndex = 30;
            this.btnthemdiem.Text = "Thêm";
            this.btnthemdiem.UseVisualStyleBackColor = true;
            this.btnthemdiem.Click += new System.EventHandler(this.btnthemdiem_Click);
            // 
            // btnReFreshBD
            // 
            this.btnReFreshBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReFreshBD.Location = new System.Drawing.Point(1329, 227);
            this.btnReFreshBD.Name = "btnReFreshBD";
            this.btnReFreshBD.Size = new System.Drawing.Size(111, 33);
            this.btnReFreshBD.TabIndex = 34;
            this.btnReFreshBD.Text = "Refresh";
            this.btnReFreshBD.UseVisualStyleBackColor = true;
            this.btnReFreshBD.Click += new System.EventHandler(this.btnReFreshBD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnTimKiemBD);
            this.groupBox2.Controls.Add(this.txtTimKiemBD);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 695);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(481, 102);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimKiemBD
            // 
            this.btnTimKiemBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemBD.Location = new System.Drawing.Point(317, 37);
            this.btnTimKiemBD.Name = "btnTimKiemBD";
            this.btnTimKiemBD.Size = new System.Drawing.Size(111, 44);
            this.btnTimKiemBD.TabIndex = 14;
            this.btnTimKiemBD.Text = "Tìm kiếm";
            this.btnTimKiemBD.UseVisualStyleBackColor = true;
            this.btnTimKiemBD.Click += new System.EventHandler(this.btnTimKiemBD_Click);
            // 
            // txtTimKiemBD
            // 
            this.txtTimKiemBD.Location = new System.Drawing.Point(158, 49);
            this.txtTimKiemBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemBD.Name = "txtTimKiemBD";
            this.txtTimKiemBD.Size = new System.Drawing.Size(132, 26);
            this.txtTimKiemBD.TabIndex = 1;
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
            // btnbangdiemct
            // 
            this.btnbangdiemct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbangdiemct.Location = new System.Drawing.Point(1101, 227);
            this.btnbangdiemct.Name = "btnbangdiemct";
            this.btnbangdiemct.Size = new System.Drawing.Size(209, 33);
            this.btnbangdiemct.TabIndex = 35;
            this.btnbangdiemct.Text = "Bảng điểm chi tiết";
            this.btnbangdiemct.UseVisualStyleBackColor = true;
            this.btnbangdiemct.Click += new System.EventHandler(this.btnbangdiemct_Click);
            // 
            // FormBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1451, 806);
            this.Controls.Add(this.btnbangdiemct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReFreshBD);
            this.Controls.Add(this.btnthoatdiem);
            this.Controls.Add(this.btnsuadiem);
            this.Controls.Add(this.btnxoadiem);
            this.Controls.Add(this.btnthemdiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBangDiem);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBangDiem";
            this.Text = "FormBangDiem";
            this.Load += new System.EventHandler(this.FormBangDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdiemck;
        private System.Windows.Forms.TextBox txtdiemgk;
        private System.Windows.Forms.TextBox txtmlmhDiem;
        private System.Windows.Forms.TextBox txtmsvDiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBangDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoatdiem;
        private System.Windows.Forms.Button btnsuadiem;
        private System.Windows.Forms.Button btnxoadiem;
        private System.Windows.Forms.Button btnthemdiem;
        private System.Windows.Forms.Button btnReFreshBD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiemBD;
        private System.Windows.Forms.TextBox txtTimKiemBD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnbangdiemct;
    }
}