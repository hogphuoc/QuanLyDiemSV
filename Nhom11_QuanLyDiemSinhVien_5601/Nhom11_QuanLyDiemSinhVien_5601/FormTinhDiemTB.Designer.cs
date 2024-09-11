namespace Nhom11_QuanLyDiemSinhVien_5601
{
    partial class FormTinhDiemTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTinhDiemTB));
            this.dgvdiemtb = new System.Windows.Forms.DataGridView();
            this.rbtnmsv = new System.Windows.Forms.RadioButton();
            this.rbtnmlmh = new System.Windows.Forms.RadioButton();
            this.txtmsvclick = new System.Windows.Forms.TextBox();
            this.txtmlmhclick = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReFreshLMH = new System.Windows.Forms.Button();
            this.btnloc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.rbtnhe4 = new System.Windows.Forms.RadioButton();
            this.rbtnhe10 = new System.Windows.Forms.RadioButton();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemtb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdiemtb
            // 
            this.dgvdiemtb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiemtb.Location = new System.Drawing.Point(398, 214);
            this.dgvdiemtb.Name = "dgvdiemtb";
            this.dgvdiemtb.RowHeadersWidth = 51;
            this.dgvdiemtb.RowTemplate.Height = 24;
            this.dgvdiemtb.Size = new System.Drawing.Size(842, 391);
            this.dgvdiemtb.TabIndex = 0;
            // 
            // rbtnmsv
            // 
            this.rbtnmsv.AutoSize = true;
            this.rbtnmsv.BackColor = System.Drawing.Color.Transparent;
            this.rbtnmsv.Location = new System.Drawing.Point(48, 32);
            this.rbtnmsv.Name = "rbtnmsv";
            this.rbtnmsv.Size = new System.Drawing.Size(79, 24);
            this.rbtnmsv.TabIndex = 1;
            this.rbtnmsv.TabStop = true;
            this.rbtnmsv.Text = "MaSV";
            this.rbtnmsv.UseVisualStyleBackColor = false;
            // 
            // rbtnmlmh
            // 
            this.rbtnmlmh.AutoSize = true;
            this.rbtnmlmh.BackColor = System.Drawing.Color.Transparent;
            this.rbtnmlmh.Location = new System.Drawing.Point(48, 129);
            this.rbtnmlmh.Name = "rbtnmlmh";
            this.rbtnmlmh.Size = new System.Drawing.Size(115, 24);
            this.rbtnmlmh.TabIndex = 2;
            this.rbtnmlmh.TabStop = true;
            this.rbtnmlmh.Text = "MaLopMH";
            this.rbtnmlmh.UseVisualStyleBackColor = false;
            // 
            // txtmsvclick
            // 
            this.txtmsvclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsvclick.Location = new System.Drawing.Point(48, 58);
            this.txtmsvclick.Name = "txtmsvclick";
            this.txtmsvclick.Size = new System.Drawing.Size(254, 27);
            this.txtmsvclick.TabIndex = 3;
            // 
            // txtmlmhclick
            // 
            this.txtmlmhclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmlmhclick.Location = new System.Drawing.Point(48, 155);
            this.txtmlmhclick.Name = "txtmlmhclick";
            this.txtmlmhclick.Size = new System.Drawing.Size(254, 27);
            this.txtmlmhclick.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnReFreshLMH);
            this.groupBox1.Controls.Add(this.btnloc);
            this.groupBox1.Controls.Add(this.txtmlmhclick);
            this.groupBox1.Controls.Add(this.txtmsvclick);
            this.groupBox1.Controls.Add(this.rbtnmlmh);
            this.groupBox1.Controls.Add(this.rbtnmsv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 391);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // btnReFreshLMH
            // 
            this.btnReFreshLMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReFreshLMH.Location = new System.Drawing.Point(194, 239);
            this.btnReFreshLMH.Name = "btnReFreshLMH";
            this.btnReFreshLMH.Size = new System.Drawing.Size(108, 44);
            this.btnReFreshLMH.TabIndex = 32;
            this.btnReFreshLMH.Text = "Refresh";
            this.btnReFreshLMH.UseVisualStyleBackColor = true;
            this.btnReFreshLMH.Click += new System.EventHandler(this.btnReFreshLMH_Click);
            // 
            // btnloc
            // 
            this.btnloc.Location = new System.Drawing.Point(35, 239);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(109, 44);
            this.btnloc.TabIndex = 5;
            this.btnloc.Text = "Lọc";
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnhienthi);
            this.groupBox2.Controls.Add(this.rbtnhe4);
            this.groupBox2.Controls.Add(this.rbtnhe10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(670, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 64);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bảng điểm chi tiết";
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(471, 20);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(93, 38);
            this.btnhienthi.TabIndex = 7;
            this.btnhienthi.Text = "Xem";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // rbtnhe4
            // 
            this.rbtnhe4.AutoSize = true;
            this.rbtnhe4.BackColor = System.Drawing.Color.Transparent;
            this.rbtnhe4.Location = new System.Drawing.Point(297, 26);
            this.rbtnhe4.Name = "rbtnhe4";
            this.rbtnhe4.Size = new System.Drawing.Size(115, 24);
            this.rbtnhe4.TabIndex = 34;
            this.rbtnhe4.TabStop = true;
            this.rbtnhe4.Text = "Điểm hệ 4";
            this.rbtnhe4.UseVisualStyleBackColor = false;
            // 
            // rbtnhe10
            // 
            this.rbtnhe10.AutoSize = true;
            this.rbtnhe10.BackColor = System.Drawing.Color.Transparent;
            this.rbtnhe10.Location = new System.Drawing.Point(102, 26);
            this.rbtnhe10.Name = "rbtnhe10";
            this.rbtnhe10.Size = new System.Drawing.Size(125, 24);
            this.rbtnhe10.TabIndex = 33;
            this.rbtnhe10.TabStop = true;
            this.rbtnhe10.Text = "Điểm hệ 10";
            this.rbtnhe10.UseVisualStyleBackColor = false;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(116, 302);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(109, 44);
            this.btnthoat.TabIndex = 33;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FormTinhDiemTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 651);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvdiemtb);
            this.DoubleBuffered = true;
            this.Name = "FormTinhDiemTB";
            this.Text = "FormTinhDiemTB";
            this.Load += new System.EventHandler(this.FormTinhDiemTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemtb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdiemtb;
        private System.Windows.Forms.RadioButton rbtnmsv;
        private System.Windows.Forms.RadioButton rbtnmlmh;
        private System.Windows.Forms.TextBox txtmsvclick;
        private System.Windows.Forms.TextBox txtmlmhclick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Button btnReFreshLMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.RadioButton rbtnhe4;
        private System.Windows.Forms.RadioButton rbtnhe10;
        private System.Windows.Forms.Button btnthoat;
    }
}