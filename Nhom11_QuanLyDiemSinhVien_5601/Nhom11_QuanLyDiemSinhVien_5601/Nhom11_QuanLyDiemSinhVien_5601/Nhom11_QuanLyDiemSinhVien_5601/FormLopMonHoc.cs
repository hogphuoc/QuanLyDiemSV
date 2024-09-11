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
    public partial class FormLopMonHoc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "HONGPHUOC;Initial Catalog=QLDIEMSV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        BindingSource bdsource = new BindingSource();
        DataTable table = new DataTable();
        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = " select * from LOPMONHOC";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvLopMonHoc.DataSource = table;
        }
        public FormLopMonHoc()
        {
            InitializeComponent();
        }

        private void FormLopMonHoc_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvLopMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvLopMonHoc.CurrentRow.Index;
            txtmlmh.Text = dgvLopMonHoc.Rows[i].Cells[0].Value.ToString();
            txtmmhLMH.Text = dgvLopMonHoc.Rows[i].Cells[1].Value.ToString();
            txtmgvLMH.Text = dgvLopMonHoc.Rows[i].Cells[2].Value.ToString();
            cbHocKy.SelectedItem = dgvLopMonHoc.Rows[i].Cells[3].Value.ToString();
            dtpbatdau.Value = (DateTime)dgvLopMonHoc.Rows[i].Cells[4].Value;
            dtpketthuc.Value = (DateTime)dgvLopMonHoc.Rows[i].Cells[5].Value;
        }

        private void btnthemlmh_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " insert into LOPMONHOC values ('" + txtmlmh.Text + "', N'" + txtmmhLMH.Text + "',  N'" + txtmgvLMH.Text + "', '" + cbHocKy.Text + "', '" + dtpbatdau.Text + "', '" + dtpketthuc.Text + "' )";
                command.ExecuteNonQuery();
                loaddata();
                txtmlmh.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnxoalmh_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM LOPMONHOC WHERE MaLopMH = '" + txtmlmh.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmlmh.Focus();
        }

        private void btnsualmh_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " UPDATE LOPMONHOC SET MaMH = N'" + txtmmhLMH.Text + "', MaGV =  N'" + txtmgvLMH.Text + "',MaHK = '" + cbHocKy.Text + "', NgayBD = '" + dtpbatdau.Value.ToString("yyyy/MM/dd") + "', NgayKT ='" + dtpketthuc.Value.ToString("yyyy/MM/dd") + "'  where MaLopMH = '" + txtmlmh.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmlmh.Focus();
        }

        private void btnthoatlmh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemLMH_Click(object sender, EventArgs e)
        {
            string query = "Select * from LOPMONHOC where MaLopMH = @MaLopMH";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("MaLopMH", txtTimKiemLMH.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvLopMonHoc.DataSource = dt;
        }

        private void btnReFreshLMH_Click(object sender, EventArgs e)
        {
            loaddata();
            txtmlmh.Clear();
            txtmmhLMH.Clear();
            txtmgvLMH.Clear();
            cbHocKy.Text = string.Empty;
            dtpbatdau.Value = DateTime.Today;
            dtpketthuc.Value = DateTime.Today;

        }
    }
}
