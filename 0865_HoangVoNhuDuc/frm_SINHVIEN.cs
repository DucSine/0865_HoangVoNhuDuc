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
        
        public frm_SINHVIEN()
        {
            InitializeComponent();
        }

        private void frm_SINHVIEN_Load(object sender, EventArgs e)
        {
            Init_LB_BoxKhoa();
            DataTable dataTable = lopDungChung.GetAllSinhVien();
            gv_DsSinhvien.DataSource = dataTable;
        }

        protected void Init_LB_BoxKhoa()
        {
            DataTable dataTable = lopDungChung.GetAllKHoa();
            LB_BoxKhoa.DataSource = dataTable;
            LB_BoxKhoa.DisplayMember = "TENK";

        }

        private void LB_BoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = LB_BoxKhoa.SelectedValue.ToString().Trim();
            
           // DataTable tb = lopDungChung.ExecuteQuery(sql);
          // gv_DsSinhvien.DataSource = tb;

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
