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
        private List<SinhVien> sinhViens;
        public FrmSinhVien(ref List<SinhVien> dsSV)
        {
            InitializeComponent();

            this.sinhViens = dsSV;
            this.cMSSV.DataPropertyName = nameof(SinhVienViewModel.Mssv);
            this.cHoTen.DataPropertyName = nameof(SinhVienViewModel.HoTen);
            this.cNgaySinh.DataPropertyName = nameof(SinhVienViewModel.NgaySinh);
            this.cGioiTinh.DataPropertyName = nameof(SinhVienViewModel.GioiTinh);

            this.cQueQuan.DataPropertyName = nameof(SinhVienViewModel.QueQuan);
            this.cKhoa.DataPropertyName = nameof(SinhVienViewModel.Khoa);
            this.cChuyenNganh.DataPropertyName = nameof(SinhVien.IDChuyenNganh);
            this.cNamNhapHoc.DataPropertyName = nameof(SinhVienViewModel.NamNhapHoc);
            cKhoa.Visible = false;
            dtgThongTinSinhVien.AutoGenerateColumns = false;
            dtgThongTinSinhVien.DataSource = StudentController.GetListStudent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            string name = txtHoTen.Text;
            string gioitinh = cbGioiTinh.Text;
            string quequan = txtQueQuan.Text;
            string chuyennganh = cmbChuyenNganh.Text;
            string namnhaphoc = txtNamNhapHoc.Text;
            using (var _context = new DBLapTrinhWin())
            {
                var x = from u in _context.SinhViens
                        where u.Mssv.Contains(mssv) && u.HoTen.Contains(name) && u.GioiTinh.Contains(gioitinh) && u.QueQuan.Contains(quequan) && u.IDChuyenNganh.Contains(chuyennganh) && u.NamNhapHoc.Contains(namnhaphoc) && u.DaXoa == false
                        select new { u.Mssv, u.HoTen, u.NgaySinh, u.GioiTinh, u.QueQuan, u.Khoa, u.IDChuyenNganh, u.NamNhapHoc };
                if (x.Count()  == 0)
                {
                    MessageBox.Show("Không có kết quả");
                    return;
                }
                var i = x.First();
                dtgThongTinSinhVien.AutoGenerateColumns = true;
                
                this.dtgThongTinSinhVien.DataSource = x.ToList();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStudent formAdd = new frmAddStudent();
            formAdd.ShowDialog();
            dtgThongTinSinhVien.AutoGenerateColumns = false;
            dtgThongTinSinhVien.DataSource = StudentController.GetListStudent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SinhVien student = StudentController.GetStudent(dtgThongTinSinhVien.CurrentRow.Cells[0].Value.ToString());
            frmUpdateStudent formUpdate = new frmUpdateStudent(student);
            formUpdate.ShowDialog();
            dtgThongTinSinhVien.AutoGenerateColumns = false;
            dtgThongTinSinhVien.DataSource = StudentController.GetListStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dtgThongTinSinhVien.CurrentRow.Cells[0].Value.ToString();
            if (StudentController.DeleteStudent(id) == false)
            {
                MessageBox.Show("Sinh viên không tồn tại!", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            dtgThongTinSinhVien.AutoGenerateColumns = false;
            dtgThongTinSinhVien.DataSource = StudentController.GetListStudent();
        }
    }
}
