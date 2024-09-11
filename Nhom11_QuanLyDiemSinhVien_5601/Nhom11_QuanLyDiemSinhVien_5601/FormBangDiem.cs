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
    public partial class FormBangDiem : Form
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
            command.CommandText = " select * from BANGDIEM";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvBangDiem.DataSource = table;
        }
        public FormBangDiem()
        {
            InitializeComponent();
        }

        private void FormBangDiem_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvBangDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvBangDiem.CurrentRow.Index;
            txtmsvDiem.Text = dgvBangDiem.Rows[i].Cells[0].Value.ToString();
            txtmlmhDiem.Text = dgvBangDiem.Rows[i].Cells[1].Value.ToString();
            txtdiemgk.Text = dgvBangDiem.Rows[i].Cells[2].Value.ToString();
            txtdiemck.Text = dgvBangDiem.Rows[i].Cells[3].Value.ToString();
        }

        private void btnthemdiem_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " insert into BANGDIEM values ('" + txtmsvDiem.Text + "', N'" + txtmlmhDiem.Text + "',  N'" + txtdiemgk.Text + "', '" + txtdiemck.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                txtmsvDiem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnxoadiem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM BANGDIEM WHERE MaSV = '" + txtmsvDiem.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmsvDiem.Focus();
        }

        private void btnsuadiem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " UPDATE BANGDIEM SET MaLopMH= N'" + txtmlmhDiem.Text + "', DiemGK=  N'" + txtdiemgk.Text + "', DiemCK = '" + txtdiemck.Text + "' where MaSV = '" + txtmsvDiem.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmsvDiem.Focus();
        }

        private void btnthoatdiem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnReFreshBD_Click(object sender, EventArgs e)
        {
            loaddata();
            txtmsvDiem.Clear();
            txtmlmhDiem.Clear();
            txtdiemgk.Clear();
            txtdiemck.Clear();
        }

        private void btnTimKiemBD_Click(object sender, EventArgs e)
        {
            string query = "Select * from BANGDIEM where MaSV = @MaSV";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("MaSV", txtTimKiemBD.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvBangDiem.DataSource = dt;
        }

        private void btnbangdiemct_Click(object sender, EventArgs e)
        {
            FormTinhDiemTB f = new FormTinhDiemTB();
            f.ShowDialog();
        }
    }
}
