﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoAn.View
{
    public partial class FrmSinhVien : Form
    {
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            string name = txtHoTen.Text;
            string gioitinh = cbGioiTinh.Text;
            string quequan = txtQueQuan.Text;
            string chuyennganh = txtChuyenNganh.Text;
            string namnhaphoc = txtNamNhapHoc.Text;
            using (var _context = new DBQuanLyDoAn())
            {
                var x = from u in _context.SinhViens
                        where u.Mssv.Contains(mssv) && u.HoTen.Contains(name) && u.GioiTinh.Contains(gioitinh) && u.QueQuan.Contains(quequan) && u.IDChuyenNganh.Contains(chuyennganh) && u.NamNhapHoc.Contains(namnhaphoc)
                        select new { u.Mssv, u.HoTen, u.NgaySinh, u.GioiTinh, u.QueQuan, u.Khoa, u.ChuyenNganh.TenChuyenNganh, u.NamNhapHoc };
                if (x.Count()  == 0)
                {
                    MessageBox.Show("Không có kết quả");
                    return;
                }
                var i = x.First();
                
                this.cMSSV.DataPropertyName = nameof(i.Mssv);
                this.cHoTen.DataPropertyName = nameof(i.HoTen);
                this.cNgaySinh.DataPropertyName = nameof(i.NgaySinh);
                this.cGioiTinh.DataPropertyName = nameof(i.GioiTinh);
                
                this.cQueQuan.DataPropertyName = nameof(i.QueQuan);
                this.cKhoa.DataPropertyName = nameof(i.Khoa);
                this.cChuyenNganh.DataPropertyName = nameof(i.TenChuyenNganh);
                this.cNamNhapHoc.DataPropertyName = nameof(i.NamNhapHoc);
                
                this.dtgThongTinSinhVien.DataSource = x.ToList();

            }
        }
    }
}
