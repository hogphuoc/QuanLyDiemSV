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
    public partial class FormMonHoc : Form
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
            command.CommandText = " select * from MONHOC";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvMonHoc.DataSource = table;
        }
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvMonHoc.CurrentRow.Index;
            txtmmh.Text = dgvMonHoc.Rows[i].Cells[0].Value.ToString();
            txttenmh.Text = dgvMonHoc.Rows[i].Cells[1].Value.ToString();
            txtsotinchi.Text = dgvMonHoc.Rows[i].Cells[2].Value.ToString();
            txtsolythuyet.Text = dgvMonHoc.Rows[i].Cells[3].Value.ToString();
            txtsothuchanh.Text = dgvMonHoc.Rows[i].Cells[4].Value.ToString();
        }

        private void btnthemmh_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " insert into MONHOC values ('" + txtmmh.Text + "', N'" + txttenmh.Text + "',  N'" + txtsotinchi.Text + "', '" + txtsolythuyet.Text + "', '" + txtsothuchanh.Text + "' )";
                command.ExecuteNonQuery();
                loaddata();
                txtmmh.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }


        private void btnsuamh_Click(object sender, EventArgs e)
        {
            txtmmh.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = " UPDATE MONHOC SET TenMH = N'" + txttenmh.Text + "', SoTinChi = N'" + txtsotinchi.Text + "', SoTietLT = '" + txtsolythuyet.Text + "', SoTietTH = '" + txtsothuchanh.Text + "' where MaMH = '" + txtmmh.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmmh.Focus();
        }

        private void btnthoatmh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemMH_Click(object sender, EventArgs e)
        {
            string query = "Select * from MONHOC where MaMH = @MaMH";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("MaMH", txtTimKiemMH.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvMonHoc.DataSource = dt;
        }

        private void btnReFreshMH_Click(object sender, EventArgs e)
        {
            loaddata();
            txtmmh.Clear();
            txttenmh.Clear();
            txtsotinchi.Clear();
            txtsolythuyet.Clear();
            txtsothuchanh.Clear();
        }

        private void btnxoamh_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM MONHOC WHERE MaMH = '" + txtmmh.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmmh.Focus();
        }
    }
}
