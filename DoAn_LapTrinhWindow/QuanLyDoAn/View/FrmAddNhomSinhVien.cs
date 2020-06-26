using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDoAn.Controller;

namespace QuanLyDoAn.View
{
    public partial class FrmAddNhomSinhVien : Form
    {
        public FrmAddNhomSinhVien()
        {
            InitializeComponent();
        }

        private void FrmAddNhomSinhVien_Load(object sender, EventArgs e)
        {
            using (var _context = new DBLapTrinhWin())
            {
                var monhoc = from u in _context.MonHocs
                             select new { u.MaMonHoc };
                foreach (var x in monhoc)
                {
                    cbMaMonHoc.Items.Add(x.MaMonHoc.Trim());
                }

                var chuyennganh = from u in _context.ChuyenNganhs
                                  select new { u.IDChuyenNganh };
                foreach (var x in chuyennganh)
                {
                    cbMaChuyenNganh.Items.Add(x.IDChuyenNganh.Trim());
                }
            }
        }

        public void SetErrorProvider()
        {
            if(string.IsNullOrEmpty(cbLoaiDoAn.Text))
            {
                cbLoaiDoAn.Focus();
                this.errorProvider1.SetError(cbLoaiDoAn, "Bạn phải chọn loại đồ án!");
            }
            else
            {
                this.errorProvider1.SetError(cbLoaiDoAn, null);
            }    

            if(string.IsNullOrEmpty(txtTenNhom.Text))
            {
                txtTenNhom.Focus();
                this.errorProvider1.SetError(txtTenNhom, "Bạn phải nhập tên nhóm!");
            }
            else
            {
                this.errorProvider1.SetError(txtTenNhom, null);
            }    

            if(string.IsNullOrEmpty(txtThanhVienNhom.Text))
            {
                txtThanhVienNhom.Focus();
                this.errorProvider1.SetError(txtThanhVienNhom, "Bạn phải nhập thành viên nhóm!");
            }
            else
            {
                this.errorProvider1.SetError(txtThanhVienNhom, null);
            }

            if (string.IsNullOrEmpty(cbMaMonHoc.Text))
            {
                cbMaMonHoc.Focus();
                this.errorProvider1.SetError(cbMaMonHoc, "Bạn phải chọn mã môn học!");
            }
            else
            {
                this.errorProvider1.SetError(cbMaMonHoc, null);
            }

            if (string.IsNullOrEmpty(cbMaChuyenNganh.Text))
            {
                cbMaChuyenNganh.Focus();
                this.errorProvider1.SetError(cbMaChuyenNganh, "Bạn phải chọn mã chuyên ngành!");
            }
            else
            {
                this.errorProvider1.SetError(cbMaChuyenNganh, null);
            }
        }

        private void btnAddNhom_Click(object sender, EventArgs e)
        {
            SetErrorProvider();
            if(cbLoaiDoAn.Text != "" && txtTenNhom.Text != "" && txtThanhVienNhom.Text != "" 
                && cbMaMonHoc.Text != "" && cbMaChuyenNganh.Text != "")
            {
                using (var _context = new DBLapTrinhWin())
                {
                    if (cbLoaiDoAn.SelectedIndex == 0) ///  Tạo ID nhóm đồ án môn học
                    {
                        string s = "DAMH" + "-" + cbMaMonHoc.Text;
                        var stt = from u in _context.NhomSinhViens
                                  where u.IDNhom.Contains(s)
                                  select u;
                        int sttcuoicung = stt.Count();
                        string Stt = NhomController.SoThuTuTiepTheo(sttcuoicung);
                        txtIDNhom.Text = NhomController.CreateIDNhom("DAMH", cbMaMonHoc.Text, Stt);
                    }
                    else if (cbLoaiDoAn.SelectedIndex == 1) /// tạo ID nhóm tiểu luận chuyên ngành
                    {
                        string s = "TLCN" + "-" + cbMaChuyenNganh.Text;
                        var stt = from u in _context.NhomSinhViens
                                  where u.IDNhom.Contains(s)
                                  select u;
                        int sttcuoicung = stt.Count();
                        string Stt = NhomController.SoThuTuTiepTheo(sttcuoicung);
                        txtIDNhom.Text = NhomController.CreateIDNhom("TLCN", cbMaChuyenNganh.Text, Stt);

                    }
                    else if (cbLoaiDoAn.SelectedIndex == 2)
                    {
                        string s = "DATN" + "-" + cbMaChuyenNganh.Text;
                        var stt = from u in _context.NhomSinhViens
                                  where u.IDNhom.Contains(s)
                                  select u;
                        int sttcuoicung = stt.Count();
                        string Stt = NhomController.SoThuTuTiepTheo(sttcuoicung);
                        txtIDNhom.Text = NhomController.CreateIDNhom("DATN", cbMaChuyenNganh.Text, Stt);
                    }
                }

                NhomSinhVien nhom = new NhomSinhVien();
                nhom.IDNhom = txtIDNhom.Text;
                nhom.TenNhom = txtTenNhom.Text;
                nhom.ThanhVien = txtThanhVienNhom.Text;
                using (var _context = new DBLapTrinhWin())
                {
                    _context.NhomSinhViens.Add(nhom);
                    _context.SaveChanges();
                }

                DangKyNhomThanhCongEventArgs arg = new DangKyNhomThanhCongEventArgs { IdNhom = txtIDNhom.Text };
                OnDangKyNhomThanhCong(arg);
                this.Close();
            }
        }

        private void txtFindMSSV_TextChanged(object sender, EventArgs e)
        {
            lstViewThanhVienNhom.Items.Clear();
            using (var _context = new DBLapTrinhWin())
            {
                string s = txtFindMSSV.Text;
                var x = (from u in _context.SinhViens
                         where u.Mssv.Contains(s) && u.DaXoa == false
                         select u);
                foreach(var i in x)
                {
                    string noiten = i.Mssv + ": " + i.HoTen;
                    lstViewThanhVienNhom.Items.Add(noiten);
                }
                
            }
            if (txtFindMSSV.Text == string.Empty)
                this.lstViewThanhVienNhom.Visible = false;
            else
                this.lstViewThanhVienNhom.Visible = true;
        }

        private void lstViewThanhVienNhom_DoubleClick(object sender, EventArgs e)
        {
            string[] tach;
            tach = lstViewThanhVienNhom.SelectedItems[0].Text.Split(':');
            string s = txtThanhVienNhom.Text + "," + tach[0];
            s = s.TrimStart(',');
            txtThanhVienNhom.Text = s;
        }

        //khai báo 1 sự kiện có kiểu tham số là DangKyNhomThanhCongEventArgs
        public event EventHandler<DangKyNhomThanhCongEventArgs> DangKyNhomThanhCong;

        protected virtual void OnDangKyNhomThanhCong(DangKyNhomThanhCongEventArgs e)
        {
            //thông báo cho biết là sự kiện đã được kích hoạt
            EventHandler<DangKyNhomThanhCongEventArgs> handler = DangKyNhomThanhCong;
            
            if(handler != null)
            {
                handler(this, e);
            }
        }
    }

    public class DangKyNhomThanhCongEventArgs : EventArgs  //tham số sự kiện dùng để truyền dữ liệu 
    {
        public string IdNhom { get; set; }
    }
}
