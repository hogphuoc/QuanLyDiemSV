namespace Nhom11_QuanLyDiemSinhVien_5601
{
    partial class FormKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            this.txtsdtkhoa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.btnthoatkhoa = new System.Windows.Forms.Button();
            this.btnsuakhoa = new System.Windows.Forms.Button();
            this.btnthemkhoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemKhoa = new System.Windows.Forms.Button();
            this.txtTimKiemKhoa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReFreshKhoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtmakhoa);
            this.groupBox1.Controls.Add(this.txttenkhoa);
            this.groupBox1.Controls.Add(this.txtsdtkhoa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 290);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1605, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(154, 69);
            this.txtmakhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(274, 35);
            this.txtmakhoa.TabIndex = 12;
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Location = new System.Drawing.Point(658, 71);
            this.txttenkhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(320, 35);
            this.txttenkhoa.TabIndex = 11;
            // 
            // txtsdtkhoa
            // 
            this.txtsdtkhoa.Location = new System.Drawing.Point(1245, 69);
            this.txtsdtkhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsdtkhoa.Name = "txtsdtkhoa";
            this.txtsdtkhoa.Size = new System.Drawing.Size(313, 35);
            this.txtsdtkhoa.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên khoa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1090, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "SDT Khoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã khoa:";
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Location = new System.Drawing.Point(620, 492);
            this.dgvKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.RowHeadersWidth = 51;
            this.dgvKhoa.RowTemplate.Height = 24;
            this.dgvKhoa.Size = new System.Drawing.Size(987, 457);
            this.dgvKhoa.TabIndex = 4;
            this.dgvKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellContentClick);
            // 
            // btnthoatkhoa
            // 
            this.btnthoatkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoatkhoa.Location = new System.Drawing.Point(364, 860);
            this.btnthoatkhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoatkhoa.Name = "btnthoatkhoa";
            this.btnthoatkhoa.Size = new System.Drawing.Size(125, 55);
            this.btnthoatkhoa.TabIndex = 28;
            this.btnthoatkhoa.Text = "Thoát";
            this.btnthoatkhoa.UseVisualStyleBackColor = true;
            this.btnthoatkhoa.Click += new System.EventHandler(this.btnthoatkhoa_Click);
            // 
            // btnsuakhoa
            // 
            this.btnsuakhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuakhoa.Location = new System.Drawing.Point(87, 860);
            this.btnsuakhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsuakhoa.Name = "btnsuakhoa";
            this.btnsuakhoa.Size = new System.Drawing.Size(125, 55);
            this.btnsuakhoa.TabIndex = 27;
            this.btnsuakhoa.Text = "Sửa";
            this.btnsuakhoa.UseVisualStyleBackColor = true;
            this.btnsuakhoa.Click += new System.EventHandler(this.btnsuakhoa_Click);
            // 
            // btnthemkhoa
            // 
            this.btnthemkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemkhoa.Location = new System.Drawing.Point(87, 738);
            this.btnthemkhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthemkhoa.Name = "btnthemkhoa";
            this.btnthemkhoa.Size = new System.Drawing.Size(125, 55);
            this.btnthemkhoa.TabIndex = 25;
            this.btnthemkhoa.Text = "Thêm";
            this.btnthemkhoa.UseVisualStyleBackColor = true;
            this.btnthemkhoa.Click += new System.EventHandler(this.btnthemkhoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnTimKiemKhoa);
            this.groupBox2.Controls.Add(this.txtTimKiemKhoa);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 562);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 127);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimKiemKhoa
            // 
            this.btnTimKiemKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemKhoa.Location = new System.Drawing.Point(357, 46);
            this.btnTimKiemKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiemKhoa.Name = "btnTimKiemKhoa";
            this.btnTimKiemKhoa.Size = new System.Drawing.Size(125, 55);
            this.btnTimKiemKhoa.TabIndex = 14;
            this.btnTimKiemKhoa.Text = "Tìm kiếm";
            this.btnTimKiemKhoa.UseVisualStyleBackColor = true;
            this.btnTimKiemKhoa.Click += new System.EventHandler(this.btnTimKiemKhoa_Click);
            // 
            // txtTimKiemKhoa
            // 
            this.txtTimKiemKhoa.Location = new System.Drawing.Point(126, 61);
            this.txtTimKiemKhoa.Name = "txtTimKiemKhoa";
            this.txtTimKiemKhoa.Size = new System.Drawing.Size(200, 30);
            this.txtTimKiemKhoa.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã khoa:";
            // 
            // btnReFreshKhoa
            // 
            this.btnReFreshKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReFreshKhoa.Location = new System.Drawing.Point(364, 738);
            this.btnReFreshKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReFreshKhoa.Name = "btnReFreshKhoa";
            this.btnReFreshKhoa.Size = new System.Drawing.Size(125, 55);
            this.btnReFreshKhoa.TabIndex = 27;
            this.btnReFreshKhoa.Text = "Refresh";
            this.btnReFreshKhoa.UseVisualStyleBackColor = true;
            this.btnReFreshKhoa.Click += new System.EventHandler(this.btnReFreshKhoa_Click);
            // 
            // FormKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1632, 1008);
            this.Controls.Add(this.btnReFreshKhoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthoatkhoa);
            this.Controls.Add(this.btnsuakhoa);
            this.Controls.Add(this.btnthemkhoa);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "FormKhoa";
            this.Text = "FormKhoa";
            this.Load += new System.EventHandler(this.FormKhoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.TextBox txttenkhoa;
        private System.Windows.Forms.TextBox txtsdtkhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.Button btnthoatkhoa;
        private System.Windows.Forms.Button btnsuakhoa;
        private System.Windows.Forms.Button btnthemkhoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiemKhoa;
        private System.Windows.Forms.TextBox txtTimKiemKhoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReFreshKhoa;
    }
}