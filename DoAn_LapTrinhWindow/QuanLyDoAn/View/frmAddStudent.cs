﻿using QuanLyDoAn.Controller;
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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
            txtMSSV.Select();
            cmbGioiTinh.Text = cmbGioiTinh.Items[0].ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text.Trim().Length <= 0)
            {
                erpAdd.SetError(txtMSSV, "Không được để trống trường MSSV!");
                return;
            }
            if (txtHoTen.Text.Trim().Length <= 0)
            {
                erpAdd.SetError(txtHoTen, "Không được để trống họ tên!");
                return;
            }
            if (DateTime.Now.Year - dtpNgaySinh.Value.Year < 18)
            {
                erpAdd.SetError(dtpNgaySinh, "Yêu cầu phải đủ 18 tuổi trở lên!");
                return;
            }
            if (cmbChuyenNganh.Text.Trim().Length <= 0)
            {
                erpAdd.SetError(cmbChuyenNganh, "Không được để trống chuyên ngành!");
                return;
            }
            erpAdd.Clear();
            SinhVien student = new SinhVien();
            student.Mssv = txtMSSV.Text;
            student.HoTen = txtHoTen.Text;
            student.GioiTinh = cmbGioiTinh.SelectedItem.ToString();
            student.NgaySinh = dtpNgaySinh.Value;
            student.QueQuan = txtQueQuan.Text;
            student.IDChuyenNganh = cmbChuyenNganh.Text;
            student.NamNhapHoc = txtNamNhapHoc.Text;
            student.DaXoa = false;
            if (StudentController.AddStudent(student) is false)
            {
                MessageBox.Show("Không thể thêm sinh viên!", "Cảnh báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            txtMSSV.Clear();
            txtHoTen.Clear();
            cmbGioiTinh.Text = cmbGioiTinh.Items[0].ToString();
            dtpNgaySinh.ResetText();
            txtQueQuan.Clear();
            txtNamNhapHoc.Clear();
            this.Close();
        }
    }
}
