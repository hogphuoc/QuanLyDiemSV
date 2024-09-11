using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_QuanLyDiemSinhVien_5601
{
    public partial class FormKhoa : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=HONGPHUOC;Initial Catalog=QLDIEMSV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        BindingSource bdsource = new BindingSource();
        DataTable table = new DataTable();
        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = " select * from KHOA";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvKhoa.DataSource = table;
        }
        public FormKhoa()
        {
            InitializeComponent();
        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKhoa.CurrentRow.Index;
            txtmakhoa.Text = dgvKhoa.Rows[i].Cells[0].Value.ToString();
            txttenkhoa.Text = dgvKhoa.Rows[i].Cells[1].Value.ToString();
            txtsdtkhoa.Text = dgvKhoa.Rows[i].Cells[2].Value.ToString();
        }

        private void btnthemkhoa_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " insert into KHOA values ('" + txtmakhoa.Text + "', N'" + txttenkhoa.Text + "',  N'" + txtsdtkhoa.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                txtmakhoa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnsuakhoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " UPDATE KHOA SET TenKhoa = N'" + txttenkhoa.Text + "', SDTKhoa =N'" + txtsdtkhoa.Text + "' Where MaKhoa = '" + txtmakhoa.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmakhoa.Focus();
        }
        private void btnthoatkhoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemKhoa_Click(object sender, EventArgs e)
        {
            string query = "Select * from KHOA where MaKhoa = @MaKhoa";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("MaKhoa", txtTimKiemKhoa.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvKhoa.DataSource = dt;
        }

        private void btnReFreshKhoa_Click(object sender, EventArgs e)
        {
            loaddata();
            txtmakhoa.Clear();
            txtsdtkhoa.Clear();
            txttenkhoa.Clear();
            txtTimKiemKhoa.Clear();
        }
    }
}
