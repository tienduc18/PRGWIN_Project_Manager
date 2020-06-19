using QuanLyDoAn.Controller;
using QuanLyDoAn.ViewModel;
using System;
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
            this.cMSSV.DataPropertyName = nameof(SinhVienViewModel.Mssv);
            this.cHoTen.DataPropertyName = nameof(SinhVienViewModel.HoTen);
            this.cNgaySinh.DataPropertyName = nameof(SinhVienViewModel.NgaySinh);
            this.cGioiTinh.DataPropertyName = nameof(SinhVienViewModel.GioiTinh);

            this.cQueQuan.DataPropertyName = nameof(SinhVienViewModel.QueQuan);
            this.cKhoa.DataPropertyName = nameof(SinhVienViewModel.Khoa);
            this.cChuyenNganh.DataPropertyName = nameof(SinhVienViewModel.ChuyenNganh);
            this.cNamNhapHoc.DataPropertyName = nameof(SinhVienViewModel.NamNhapHoc);
            this.cKhoa.Visible = false;
            dtgThongTinSinhVien.DataSource = StudentController.GetListStudent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            string name = txtHoTen.Text;
            string gioitinh = cbGioiTinh.Text;
            string quequan = txtQueQuan.Text;
            string chuyennganh = txtChuyenNganh.Text;
            string namnhaphoc = txtNamNhapHoc.Text;
            using (var _context = new DBLapTrinhWin())
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
                
                //this.cMSSV.DataPropertyName = nameof(i.Mssv);
                //this.cHoTen.DataPropertyName = nameof(i.HoTen);
                //this.cNgaySinh.DataPropertyName = nameof(i.NgaySinh);
                //this.cGioiTinh.DataPropertyName = nameof(i.GioiTinh);
                
                //this.cQueQuan.DataPropertyName = nameof(i.QueQuan);
                //this.cKhoa.DataPropertyName = nameof(i.Khoa);
                //this.cChuyenNganh.DataPropertyName = nameof(i.TenChuyenNganh);
                //this.cNamNhapHoc.DataPropertyName = nameof(i.NamNhapHoc);
                
                this.dtgThongTinSinhVien.DataSource = x.ToList();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStudent formAdd = new frmAddStudent();
            formAdd.Show();
            dtgThongTinSinhVien.DataSource = StudentController.GetListStudent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SinhVien student = StudentController.GetStudent(dtgThongTinSinhVien.CurrentRow.Cells[0].Value.ToString());
            frmUpdateStudent formUpdate = new frmUpdateStudent(student);
            formUpdate.Show();
            dtgThongTinSinhVien.DataSource = StudentController.GetListStudent();
        }
    }
}
