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
            this.cMSSV.DataPropertyName = nameof(SinhVien.Mssv);
            this.cHoTen.DataPropertyName = nameof(SinhVien.HoTen);
            this.cNgaySinh.DataPropertyName = nameof(SinhVien.NgaySinh);
            this.cGioiTinh.DataPropertyName = nameof(SinhVien.GioiTinh);

            this.cQueQuan.DataPropertyName = nameof(SinhVien.QueQuan);
            this.cKhoa.DataPropertyName = nameof(SinhVien.Khoa);
            this.cChuyenNganh.DataPropertyName = nameof(ChuyenNganh.TenChuyenNganh);
            this.cNamNhapHoc.DataPropertyName = nameof(SinhVien.NamNhapHoc);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            string name = txtHoTen.Text;
            string gioitinh = cbGioiTinh.Text;
            string quequan = txtQueQuan.Text;
            string chuyennganh = txtChuyenNganh.Text;
            string namnhaphoc = txtNamNhapHoc.Text;
            using (var _context = new QuanLyDeTaiEntities())
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
            frmAdd formAdd = new frmAdd();
            formAdd.Show();                         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SinhVien student = new SinhVien();
            student.Mssv = dtgThongTinSinhVien.CurrentRow.Cells[0].Value.ToString();
            student.HoTen = dtgThongTinSinhVien.CurrentRow.Cells[1].Value.ToString();
            student.NgaySinh = DateTime.Parse(dtgThongTinSinhVien.CurrentRow.Cells[2].Value.ToString());
            student.GioiTinh = dtgThongTinSinhVien.CurrentRow.Cells[3].Value.ToString();
            student.QueQuan = dtgThongTinSinhVien.CurrentRow.Cells[4].Value.ToString();
            student.Khoa = dtgThongTinSinhVien.CurrentRow.Cells[5].Value.ToString();
            student.IDChuyenNganh = dtgThongTinSinhVien.CurrentRow.Cells[6].Value.ToString();
            student.NamNhapHoc = dtgThongTinSinhVien.CurrentRow.Cells[7].Value.ToString();
            frmUpdate formUpdate = new frmUpdate(student);
            formUpdate.Show();
        }
    }
}
