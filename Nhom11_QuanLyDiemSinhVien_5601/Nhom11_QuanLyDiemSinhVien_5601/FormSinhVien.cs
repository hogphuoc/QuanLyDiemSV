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
    public partial class FormSinhVien : Form
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
            command.CommandText = " select * from SINHVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvSinhVien.DataSource = table;
        }
        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnthemsv_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " insert into SINHVIEN values ('" + txtmsv.Text + "', N'" + txttensv.Text + "' , N'" + cbgioitinhsv.Text + "' , '" + dtpngaysinhsv.Value.ToString("yyyy/MM/dd") + "' , N'" + txtquequan.Text + "',  N'" + txtsdtsv.Text + "', N'" + txtmakhoasv.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                txtmsv.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnxoasv_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM SINHVIEN WHERE MaSV = '" + txtmsv.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmsv.Focus();
        }

        private void btnsuasv_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " UPDATE SINHVIEN SET HovaTenSV = N'" + txttensv.Text + "', GioiTinhSV = N'" + cbgioitinhsv.Text + "', NgaySinh = '" + dtpngaysinhsv.Text + "', QueQuan = N'" + txtquequan.Text + "', SDTSV =N'" + txtsdtsv.Text + "',MaKhoa= N'" + txtmakhoasv.Text + "' Where MaSV = '" + txtmsv.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmsv.Focus();
        }

        private void btnthoatsv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtmsv.ReadOnly = true;
            int i;
            i = dgvSinhVien.CurrentRow.Index;
            txtmsv.Text = dgvSinhVien.Rows[i].Cells[0].Value.ToString();
            txttensv.Text = dgvSinhVien.Rows[i].Cells[1].Value.ToString();
            cbgioitinhsv.SelectedItem = dgvSinhVien.Rows[i].Cells[2].Value.ToString();
            dtpngaysinhsv.Value = (DateTime)dgvSinhVien.Rows[i].Cells[3].Value;
            txtquequan.Text = dgvSinhVien.Rows[i].Cells[4].Value.ToString();
            txtsdtsv.Text = dgvSinhVien.Rows[i].Cells[5].Value.ToString();
            txtmakhoasv.Text = dgvSinhVien.Rows[i].Cells[6].Value.ToString();
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            string query = "Select * from SINHVIEN where MaSV = @MaSV";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("MaSV", txtTimKiemSV.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvSinhVien.DataSource= dt;

        }

        private void btnReFreshSV_Click(object sender, EventArgs e)
        {
            loaddata();
            txtmsv.Clear();
            txttensv.Clear();
            dtpngaysinhsv.Value = DateTime.Today;
            txtquequan.Clear();
            cbgioitinhsv.Text = string.Empty;
            txtsdtsv.Clear();
            txtmakhoasv.Clear();
            txtTimKiemSV.Clear();
        }
    }
}
