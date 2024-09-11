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
    public partial class FormTinhDiemTB : Form
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
            command.CommandText = " SELECT SINHVIEN.MaSV, HovaTenSV,LOPMONHOC.MaLopMH, DiemGK, DiemCK FROM BANGDIEM,SINHVIEN,LOPMONHOC WHERE BANGDIEM.MaLopMH=LOPMONHOC.MaLopMH AND SINHVIEN.MaSV=BANGDIEM.MaSV";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvdiemtb.DataSource = table;
        }
        public FormTinhDiemTB()
        {
            InitializeComponent();
        }

        private void FormTinhDiemTB_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            if(rbtnmsv.Checked==true)
            {
                string query = "SELECT SINHVIEN.MaSV, HovaTenSV,LOPMONHOC.MaLopMH, DiemGK, DiemCK, (DiemCK+DiemGK)/2 AS N'Điểm hệ 10', ROUND(((DiemCK+DiemGK)/2)*4/10,0) AS N'Điểm hệ 4' FROM BANGDIEM,SINHVIEN,LOPMONHOC WHERE BANGDIEM.MaLopMH=LOPMONHOC.MaLopMH AND SINHVIEN.MaSV=BANGDIEM.MaSV AND SINHVIEN.MaSV = @MaSV";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("MaSV", txtmsvclick.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvdiemtb.DataSource = dt;
            }    
            else if (rbtnmlmh.Checked==true)
            {
                string query = "SELECT SINHVIEN.MaSV, HovaTenSV,LOPMONHOC.MaLopMH, DiemGK, DiemCK, (DiemCK+DiemGK)/2 AS N'Điểm hệ 10', ROUND(((DiemCK+DiemGK)/2)*4/10,0) AS N'Điểm hệ 4' FROM BANGDIEM,SINHVIEN,LOPMONHOC WHERE BANGDIEM.MaLopMH=LOPMONHOC.MaLopMH AND SINHVIEN.MaSV=BANGDIEM.MaSV AND BANGDIEM.MaLopMH = @MaLopMH";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("MaLopMH", txtmsvclick.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvdiemtb.DataSource = dt;
            }
        }

        private void btnReFreshLMH_Click(object sender, EventArgs e)
        {
            loaddata();
            rbtnmsv.Checked=false;
            rbtnmlmh.Checked = false;
            txtmsvclick.Clear();
            txtmlmhclick.Clear();
            rbtnhe10.Checked = false;
            rbtnhe4.Checked = false;
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            if (rbtnhe10.Checked == true)
            {              
                string query = "SELECT SINHVIEN.MaSV, HovaTenSV,LOPMONHOC.MaLopMH, DiemGK, DiemCK, (DiemCK+DiemGK)/2 AS N'Điểm hệ 10' FROM BANGDIEM,SINHVIEN,LOPMONHOC WHERE BANGDIEM.MaLopMH=LOPMONHOC.MaLopMH AND SINHVIEN.MaSV=BANGDIEM.MaSV";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvdiemtb.DataSource = dt;
            }
            else if (rbtnhe4.Checked == true)
            {
                string query = "SELECT SINHVIEN.MaSV, HovaTenSV,LOPMONHOC.MaLopMH, DiemGK, DiemCK, ROUND(((DiemCK+DiemGK)/2)*4/10,0) AS N'Điểm hệ 4' FROM BANGDIEM,SINHVIEN,LOPMONHOC WHERE BANGDIEM.MaLopMH=LOPMONHOC.MaLopMH AND SINHVIEN.MaSV=BANGDIEM.MaSV";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvdiemtb.DataSource = dt;
            }  
        }

        private void btnthoatBDCT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
