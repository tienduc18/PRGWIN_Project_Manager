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
    public partial class frmUpdateGiangVien : Form
    {
        public frmUpdateGiangVien(GiangVien giangVien)
        {
            InitializeComponent();

            txtMSGV.Text = giangVien.MSGV;
            txtHoTen.Text = giangVien.HoTen;
            txtNgaySinh.Text = giangVien.NgaySinh;
            txtQueQuan.Text = giangVien.QueQuan;
            cbGioiTinh.Text = giangVien.GioiTinh;
            txtKhoa.Text = giangVien.Khoa;
            txtChuyenNganh.Text = giangVien.ChuyenNganh;
        }

        private void SetErrorProvider()
        {
            if (string.IsNullOrEmpty(txtMSGV.Text.Trim()))
            {
                txtMSGV.Focus();
                this.errorProvider1.SetError(txtMSGV, "Phải nhập mã số giảng viên!");
            }
            else
            {
                this.errorProvider1.SetError(txtMSGV, null);
            }

            //if(GiangVienController.GetGiangVien)
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetErrorProvider();
            if (txtMSGV.Text.Trim() != " ")
            {
                GiangVien giangvien = new GiangVien();
                giangvien.MSGV = txtMSGV.Text.Trim();
                giangvien.HoTen = txtHoTen.Text.Trim();
                giangvien.NgaySinh = txtNgaySinh.Text.Trim();
                giangvien.QueQuan = txtQueQuan.Text.Trim();
                giangvien.GioiTinh = cbGioiTinh.Text.Trim();
                giangvien.Khoa = txtKhoa.Text.Trim();
                giangvien.ChuyenNganh = txtChuyenNganh.Text.Trim();

                if (GiangVienController.UpdateGiangVien(giangvien) is false)
                {
                    MessageBox.Show("Không thể sửa giảng viên!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtMSGV.Clear();
                txtHoTen.Clear();
                txtNgaySinh.Clear();
                txtQueQuan.Clear();
                cbGioiTinh.Text = cbGioiTinh.Items[0].ToString();
                txtKhoa.Clear();
                txtChuyenNganh.Clear();
            }
            else
            {
                MessageBox.Show("Không sửa được giảng viên!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
