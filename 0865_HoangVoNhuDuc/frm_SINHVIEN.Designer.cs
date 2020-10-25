namespace _0865_HoangVoNhuDuc
{
    partial class frm_SINHVIEN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gv_DsSinhvien = new System.Windows.Forms.DataGridView();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Khoa = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_Msv = new System.Windows.Forms.TextBox();
            this.lb_Msv = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_TenKhoa = new System.Windows.Forms.Label();
            this.LB_BoxKhoa = new System.Windows.Forms.ListBox();
            this.lb_DsSinhVien = new System.Windows.Forms.Label();
            this.lb_DsKhoa = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DsSinhvien)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Dong);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LB_BoxKhoa);
            this.panel1.Controls.Add(this.lb_DsSinhVien);
            this.panel1.Controls.Add(this.lb_DsKhoa);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 583);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gv_DsSinhvien);
            this.panel3.Location = new System.Drawing.Point(38, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 217);
            this.panel3.TabIndex = 11;
            // 
            // gv_DsSinhvien
            // 
            this.gv_DsSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DsSinhvien.Location = new System.Drawing.Point(1, 0);
            this.gv_DsSinhvien.Name = "gv_DsSinhvien";
            this.gv_DsSinhvien.Size = new System.Drawing.Size(720, 217);
            this.gv_DsSinhvien.TabIndex = 0;
            this.gv_DsSinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_DsSinhvien_CellClick);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(518, 218);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(75, 23);
            this.btn_Dong.TabIndex = 10;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(354, 218);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(198, 218);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(38, 218);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.ButtonClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Khoa);
            this.panel2.Controls.Add(this.txt_HoTen);
            this.panel2.Controls.Add(this.txt_Msv);
            this.panel2.Controls.Add(this.lb_Msv);
            this.panel2.Controls.Add(this.lb_HoTen);
            this.panel2.Controls.Add(this.lb_TenKhoa);
            this.panel2.Location = new System.Drawing.Point(313, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 129);
            this.panel2.TabIndex = 6;
            // 
            // txt_Khoa
            // 
            this.txt_Khoa.Location = new System.Drawing.Point(100, 88);
            this.txt_Khoa.Name = "txt_Khoa";
            this.txt_Khoa.Size = new System.Drawing.Size(317, 20);
            this.txt_Khoa.TabIndex = 6;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(100, 48);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(317, 20);
            this.txt_HoTen.TabIndex = 5;
            // 
            // txt_Msv
            // 
            this.txt_Msv.Location = new System.Drawing.Point(100, 9);
            this.txt_Msv.Name = "txt_Msv";
            this.txt_Msv.Size = new System.Drawing.Size(317, 20);
            this.txt_Msv.TabIndex = 4;
            // 
            // lb_Msv
            // 
            this.lb_Msv.AutoSize = true;
            this.lb_Msv.Location = new System.Drawing.Point(15, 12);
            this.lb_Msv.Name = "lb_Msv";
            this.lb_Msv.Size = new System.Drawing.Size(70, 13);
            this.lb_Msv.TabIndex = 1;
            this.lb_Msv.Text = "Mã sinh viên:";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(15, 55);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(42, 13);
            this.lb_HoTen.TabIndex = 2;
            this.lb_HoTen.Text = "Họ tên:";
            // 
            // lb_TenKhoa
            // 
            this.lb_TenKhoa.AutoSize = true;
            this.lb_TenKhoa.Location = new System.Drawing.Point(15, 95);
            this.lb_TenKhoa.Name = "lb_TenKhoa";
            this.lb_TenKhoa.Size = new System.Drawing.Size(56, 13);
            this.lb_TenKhoa.TabIndex = 3;
            this.lb_TenKhoa.Text = "Tên khoa:";
            // 
            // LB_BoxKhoa
            // 
            this.LB_BoxKhoa.FormattingEnabled = true;
            this.LB_BoxKhoa.Location = new System.Drawing.Point(38, 68);
            this.LB_BoxKhoa.Name = "LB_BoxKhoa";
            this.LB_BoxKhoa.Size = new System.Drawing.Size(207, 95);
            this.LB_BoxKhoa.TabIndex = 5;
            this.LB_BoxKhoa.SelectedIndexChanged += new System.EventHandler(this.LB_BoxKhoa_SelectedIndexChanged);
            // 
            // lb_DsSinhVien
            // 
            this.lb_DsSinhVien.AutoSize = true;
            this.lb_DsSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DsSinhVien.Location = new System.Drawing.Point(35, 276);
            this.lb_DsSinhVien.Name = "lb_DsSinhVien";
            this.lb_DsSinhVien.Size = new System.Drawing.Size(199, 24);
            this.lb_DsSinhVien.TabIndex = 4;
            this.lb_DsSinhVien.Text = "Danh sách sinh viên";
            // 
            // lb_DsKhoa
            // 
            this.lb_DsKhoa.AutoSize = true;
            this.lb_DsKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DsKhoa.Location = new System.Drawing.Point(34, 21);
            this.lb_DsKhoa.Name = "lb_DsKhoa";
            this.lb_DsKhoa.Size = new System.Drawing.Size(160, 24);
            this.lb_DsKhoa.TabIndex = 0;
            this.lb_DsKhoa.Text = "Danh sách khoa";
            // 
            // frm_SINHVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.panel1);
            this.Name = "frm_SINHVIEN";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frm_SINHVIEN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_DsSinhvien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gv_DsSinhvien;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Khoa;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_Msv;
        private System.Windows.Forms.Label lb_Msv;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label lb_TenKhoa;
        private System.Windows.Forms.ListBox LB_BoxKhoa;
        private System.Windows.Forms.Label lb_DsSinhVien;
        private System.Windows.Forms.Label lb_DsKhoa;
    }
}