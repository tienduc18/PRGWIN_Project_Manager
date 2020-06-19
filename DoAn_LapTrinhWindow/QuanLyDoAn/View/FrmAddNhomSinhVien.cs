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

            FrmAddDeAn frm = new FrmAddDeAn(this.txtIDNhom.Text);
            frm.Show();
            this.Close();
        }

        private void txtFindMSSV_TextChanged(object sender, EventArgs e)
        {
            lstViewThanhVienNhom.Items.Clear();
            using (var _context = new DBLapTrinhWin())
            {
                string s = txtFindMSSV.Text;
                var x = (from u in _context.SinhViens
                         where u.Mssv.Contains(s)
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
            string s = txtThanhVienNhom.Text + "," + tach[0]; ;
            s = s.TrimStart(',');
            txtThanhVienNhom.Text = s;
            
        }
    }
}
