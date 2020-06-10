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
    public partial class frmAddGiangVien : Form
    {
        private string msgv;
        public frmAddGiangVien()
        {
            InitializeComponent();
            txtMSGV.Select();
            cbGioiTinh.Text = cbGioiTinh.Items[0].ToString();
        }

        private void SetErrorProvider()
        {
            if(string.IsNullOrEmpty(txtMSGV.Text.Trim()))
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
            if(txtMSGV.Text.Trim() != " ")
            {
                GiangVienController giangvien = new GiangVien();
                giangvien.MSGV = txtMSGV.Text.Trim();
                giangvien.HoTen = txtHoTen.Text.Trim();
                giangvien.NgaySinh = txtNgaySinh.Text.Trim();
                giangvien.QueQuan = txtQueQuan.Text.Trim();
                giangvien.GioiTinh = cbGioiTinh.Text.Trim();
                giangvien.Khoa = txtKhoa.Text.Trim();
                giangvien.ChuyenNganh = txtChuyenNganh.Text.Trim();

                if(GiangVienController.AddGiangVien(giangvien) is false)
                {
                    MessageBox.Show("Không thể thêm giảng viên!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Không thêm được giảng viên!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
