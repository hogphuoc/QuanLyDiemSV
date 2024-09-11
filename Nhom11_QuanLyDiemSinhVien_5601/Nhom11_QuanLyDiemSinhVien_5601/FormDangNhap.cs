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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            {
                if (txtUser.Text == "phongdaotao" && txtPass.Text == "12345")
                {
                    MessageBox.Show(" Đăng nhập thành công", "Thông báo");
                    this.Hide();
                    FormMain f = new FormMain();
                    f.ShowDialog();
                }
                else if (txtUser.Text == "giangvien" && txtPass.Text == "12345")
                {
                    MessageBox.Show(" Đăng nhập thành công", "Thông báo");
                    this.Hide();
                    FormMainGV f = new FormMainGV();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show(" Sai tên đăng nhập hoặc mật khẩu ", "Thông báo");
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
