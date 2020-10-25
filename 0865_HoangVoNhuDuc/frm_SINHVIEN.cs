using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0865_HoangVoNhuDuc
{
    public partial class frm_SINHVIEN : Form
    {
        LopDungChung_HoangVoNhuDuc lopDungChung = new LopDungChung_HoangVoNhuDuc();
        DataTable dataTable;
        public frm_SINHVIEN()
        {
            InitializeComponent();
        }

        private void frm_SINHVIEN_Load(object sender, EventArgs e)
        {
            InitLB_BoxKhoa();
            LoadDataSinhVien();
        }
        private void gv_DsSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Msv.Text = gv_DsSinhvien[0, e.RowIndex].Value.ToString();
            txt_HoTen.Text = gv_DsSinhvien[1, e.RowIndex].Value.ToString();
            txt_Khoa.Text = gv_DsSinhvien[2, e.RowIndex].Value.ToString();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            string sql = " ";
            string[] SV = { txt_Msv.Text, txt_HoTen.Text, txt_Khoa.Text }; 
            string[] message = { "Thành công", "Thất bại", "Sinh viên đã tồn tại" };

            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btn_Them":
                    sql = string.Format("INSERT INTO SINHVIEN VALUES (N'{0}', N'{1}', N'{2}')",SV);
                    break;
                case "btn_Sua":
                    sql = string.Format("UPDATE SINHVIEN SET HOTEN = N'{1}', TENK = N'{2}' WHERE MSSV = N'{0}'", SV);
                    message[1] = "Sinh viên không tồn tại";
                    break;
                case "btn_Xoa":
                    sql = string.Format("DELETE FROM SINHVIEN WHERE MSSV = N'{0}'", SV[0]);
                    message[1] = "Sinh viên không tồn tại";
                    break;
                case "btn_Dong":
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        this.Close();
                    break;
            }
            try
            {
                bool check = lopDungChung.ExecuteUpdate(sql);
                if (check)
                    MessageBox.Show(message[0]);
                else
                    MessageBox.Show(message[1]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(message[2]);
            }
            

            LoadDataSinhVien();
            
        }

        protected void InitLB_BoxKhoa()
        {
            string sql = "SELECT * FROM KHOA";
            dataTable = new DataTable();
            dataTable = lopDungChung.ExecuteQuery(sql);
            LB_BoxKhoa.DataSource = dataTable;
            LB_BoxKhoa.ValueMember = "TENK";
        }

        protected void LoadDataSinhVien()
        {
            string sql = "SELECT * FROM SINHVIEN";
            dataTable = new DataTable();
            dataTable = lopDungChung.ExecuteQuery(sql);
            gv_DsSinhvien.DataSource = dataTable;
        }

        private void LB_BoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = LB_BoxKhoa.SelectedValue.ToString();
            string sql = string.Format("SELECT * FROM SINHVIEN WHERE TENK = N'{0}'", value);
            dataTable = new DataTable();
            dataTable = lopDungChung.ExecuteQuery(sql);
            gv_DsSinhvien.DataSource = dataTable;
        }
    }
}
