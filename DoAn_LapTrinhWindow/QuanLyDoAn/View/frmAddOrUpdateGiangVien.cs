using QuanLyDoAn.Controller;
using QuanLyDoAn.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoAn.View
{
    public partial class frmAddOrUpdateGiangVien : Form
    {
        private string msgv;
        private List<ChuyenNganhViewModel> chuyenNganhs;
        public frmAddOrUpdateGiangVien()
        {
            InitializeComponent();
            DoChuyenNganh();
        }

        public frmAddOrUpdateGiangVien(string msgv)
        {
            InitializeComponent();
            this.msgv = msgv;
            txtMSGV.ReadOnly = true;
            DoChuyenNganh();
            DoGiangVien();
        }

        private void DoGiangVien()
        {
            var giangVien = GiangVienController.GetGiangVien(this.msgv);
            txtMSGV.Text = giangVien.MSGV;
            txtHoTen.Text = giangVien.HoTen;
           
            try
            {
                dtpNgaySinh.Value = giangVien.NgaySinh.Value;
            }
            catch
            {
                dtpNgaySinh.Value = DateTime.Now;
            }

            txtQueQuan.Text = giangVien.QueQuan;
            cbGioiTinh.Text = giangVien.GioiTinh;
            //txtKhoa.Text = giangVien.Khoa;
            cbxChuyenNganh.SelectedIndex = chuyenNganhs.IndexOf(chuyenNganhs.Where(x => x.IDChuyenNganh == giangVien.ChuyenNganh).FirstOrDefault());
        }

        private void DoChuyenNganh()
        {
            chuyenNganhs = ChuyenNganhController.GetAllChuyenNganh();
            cbxChuyenNganh.DisplayMember = "TenChuyenNganh";
            cbxChuyenNganh.DataSource = chuyenNganhs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSGV.Text.Trim()))
            {
                txtMSGV.Focus();
                this.errorProvider1.SetError(txtMSGV, "Phải nhập mã số giảng viên!");
            }
            else
            {
                this.errorProvider1.SetError(txtMSGV, null);

                DBLapTrinhWin db = new DBLapTrinhWin();

                if(this.msgv == null)
                {
                    GiangVien addOrUpdateGV = new GiangVien()
                    {
                        MSGV = txtMSGV.Text,
                        HoTen = txtHoTen.Text,
                        NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString()), 
                        QueQuan = txtQueQuan.Text,
                        GioiTinh = cbGioiTinh.Text,
                        //Khoa = txtKhoa.Text,
                        ChuyenNganh = ((ChuyenNganhViewModel)cbxChuyenNganh.SelectedItem).IDChuyenNganh,
                        DaXoa = false
                    };

                    if(addOrUpdateGV.MSGV.Length > 4)
                    {
                        txtMSGV.Focus();
                        this.errorProvider1.SetError(txtMSGV, "Mã số giảng viên chỉ gồm 4 kí tự!");
                        return;
                    }    
                    else
                    {
                        this.errorProvider1.SetError(txtMSGV, null);
                    }    

                    if(GiangVienController.GetGiangVien(txtMSGV.Text) != null)
                    {
                        txtMSGV.Focus();
                        this.errorProvider1.SetError(txtMSGV, "Mã số giảng viên này đã tồn tại!");
                        return;
                    }
                    else
                    {
                        this.errorProvider1.SetError(txtMSGV, null);
                    }

                    db.GiangViens.Add(addOrUpdateGV);
                }
                else
                {
                    GiangVien updateGV = db.GiangViens.Where(x => x.MSGV == msgv).SingleOrDefault();
                    updateGV.HoTen = txtHoTen.Text;
                    updateGV.NgaySinh = dtpNgaySinh.Value;
                    updateGV.QueQuan = txtQueQuan.Text;
                    updateGV.GioiTinh = cbGioiTinh.Text;
                    //updateGV.Khoa = txtKhoa.Text;
                    updateGV.ChuyenNganh = ((ChuyenNganhViewModel)cbxChuyenNganh.SelectedItem).IDChuyenNganh;
                    updateGV.DaXoa = false;
                }
                db.SaveChanges();

                this.Close();
            }
        }
    }
}
