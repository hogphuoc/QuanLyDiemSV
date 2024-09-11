using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_QuanLyDiemSinhVien_5601
{
    public partial class FormMainGV : Form
    {
        public FormMainGV()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(" Bạn có chắc chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap f = new FormDangNhap();
                f.ShowDialog();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBangDiem f = new FormBangDiem();
            f.ShowDialog();
        }

        private void FormMainGV_Load(object sender, EventArgs e)
        {

        }
    }
}
