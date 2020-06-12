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

        private void btnAddNhom_Click(object sender, EventArgs e)
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
                else if(cbLoaiDoAn.SelectedIndex == 1) /// tạo ID nhóm tiểu luận chuyên ngành
                {
                    string s = "TLCN" + "-" + cbMaChuyenNganh.Text;
                    var stt = from u in _context.NhomSinhViens
                              where u.IDNhom.Contains(s)
                              select u;
                    int sttcuoicung = stt.Count();
                    string Stt = NhomController.SoThuTuTiepTheo(sttcuoicung);
                    txtIDNhom.Text = NhomController.CreateIDNhom("TLCN", cbMaChuyenNganh.Text,Stt);

                }
                else if(cbLoaiDoAn.SelectedIndex == 2)
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
        }
    }
}
