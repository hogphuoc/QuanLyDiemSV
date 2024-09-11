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
    public partial class FormGiangVien : Form
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
            command.CommandText = " select * from GIANGVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvGiangVien.DataSource = table;
        }
        public FormGiangVien()
        {
            InitializeComponent();
        }

        private void btnthemgv_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " insert into GIANGVIEN values ('" + txtmgv.Text + "', N'" + txttengv.Text + "' , N'" + cbgioitinhgv.Text + "' , '" + dtpngaysinhgv.Text + "' ,  N'" + txtsdtgv.Text + "',N'" + txtdiachi.Text + "',  N'" + txtmakhoagv.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                txtmgv.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnxoagv_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM GIANGVIEN WHERE MaGV = '" + txtmgv.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmgv.Focus();
        }

        private void btnsuagv_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " UPDATE GIANGVIEN SET HovaTenGV = N'" + txttengv.Text + "', GioiTinhGV = N'" + cbgioitinhgv.Text + "', NgaySinh = '" + dtpngaysinhgv.Value.ToString("yyyy/MM/dd") + "',SDTGV =N'" + txtsdtgv.Text + "', DiaChiGV = N'" + txtdiachi.Text + "',MaKhoa= N'" + txtmakhoagv.Text + "' Where MaGV = '" + txtmgv.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmgv.Focus();
        }

        private void btnthoatgv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {
            string query = "Select * from GIANGVIEN where MaGV = @MaGV";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("MaGV", txtTimKiemGV.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvGiangVien.DataSource = dt;
        }

        private void btnReFreshGV_Click(object sender, EventArgs e)
        {
            loaddata();
            txtmgv.Clear();
            txttengv.Clear();
            dtpngaysinhgv.Value = DateTime.Today;
            txtdiachi.Clear();
            cbgioitinhgv.Text = string.Empty;
            txtsdtgv.Clear();
            txtmakhoagv.Clear();
            txtTimKiemGV.Clear();
        }

        private void dgvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvGiangVien.CurrentRow.Index;
            txtmgv.Text = dgvGiangVien.Rows[i].Cells[0].Value.ToString();
            txttengv.Text = dgvGiangVien.Rows[i].Cells[1].Value.ToString();
            cbgioitinhgv.SelectedItem = dgvGiangVien.Rows[i].Cells[2].Value.ToString();
            dtpngaysinhgv.Value = (DateTime)dgvGiangVien.Rows[i].Cells[3].Value;
            txtsdtgv.Text = dgvGiangVien.Rows[i].Cells[4].Value.ToString();
            txtdiachi.Text = dgvGiangVien.Rows[i].Cells[5].Value.ToString();
            txtmakhoagv.Text = dgvGiangVien.Rows[i].Cells[6].Value.ToString();
        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
    }
}
