using QuanLyDoAn.Controller;
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
    public partial class frmUpdateStudent : Form
    {
        public frmUpdateStudent(SinhVien student)
        {
            InitializeComponent();
            txtMSSV.Text = student.Mssv;
            txtHoTen.Text = student.HoTen;
            txtKhoa.Text = student.Khoa;
            dtpNgaySinh.Value = student.NgaySinh.GetValueOrDefault();
            cmbGioiTinh.Text = student.GioiTinh;
            cmbChuyenNganh.Text = student.IDChuyenNganh;
            txtQueQuan.Text = student.QueQuan;
            txtNamNhapHoc.Text = student.NamNhapHoc;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text.Trim().Length <= 0)
            {
                erpUpdate.SetError(txtMSSV, "Không được để trống trường MSSV!");
                return;
            }
            if (txtHoTen.Text.Trim().Length <= 0)
            {
                erpUpdate.SetError(txtHoTen, "Không được để trống họ tên!");
                return;
            }
            if (DateTime.Now.Year - dtpNgaySinh.Value.Year < 18)
            {
                erpUpdate.SetError(dtpNgaySinh, "Yêu cầu phải đủ 18 tuổi trở lên!");
                return;
            }
            if (cmbChuyenNganh.Text.Trim().Length <= 0)
            {
                erpUpdate.SetError(cmbChuyenNganh, "Không được để trống chuyên ngành!");
                return;
            }
            erpUpdate.Clear();
            SinhVien tempStudent = new SinhVien();
            tempStudent.Mssv = txtMSSV.Text;
            tempStudent.HoTen = txtHoTen.Text;
            tempStudent.GioiTinh = cmbGioiTinh.SelectedItem.ToString();
            tempStudent.NgaySinh = dtpNgaySinh.Value;
            tempStudent.QueQuan = txtQueQuan.Text;
            tempStudent.Khoa = txtKhoa.Text;
            tempStudent.IDChuyenNganh = cmbChuyenNganh.Text;
            tempStudent.NamNhapHoc = txtNamNhapHoc.Text;
            if (StudentController.UpdateStudent(tempStudent) is false)
            {
                MessageBox.Show("Không thể thêm sinh viên!", "Cảnh báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            txtMSSV.Clear();
            txtHoTen.Clear();
            cmbGioiTinh.Text = cmbGioiTinh.Items[0].ToString();
            dtpNgaySinh.ResetText();
            txtQueQuan.Clear();
            txtKhoa.Clear();
            txtNamNhapHoc.Clear();
            this.Close();
        }

        //private void frmUpdateStudent_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    FrmSinhVien frmSinhVien = new FrmSinhVien();
        //    frmSinhVien.Show();
        //}
    }
}
