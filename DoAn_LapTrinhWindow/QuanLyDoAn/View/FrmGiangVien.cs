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
    public partial class FrmGiangVien : Form
    {
        private List<GiangVien> giangViens;

        public FrmGiangVien()
        {
            InitializeComponent();
        }
        public FrmGiangVien(List<GiangVien> giangViens)
        {
            InitializeComponent();

            this.giangViens = giangViens;
            DoDuLieu();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var _context = new DBLapTrinhWin())
            {
                string msgv = txtMSGV.Text;
                string name = txtHoTen.Text;
                string gioitinh = cbGioiTinh.Text;
                string quequan = txtQueQuan.Text;
                string chuyennganh = txtChuyenNganh.Text;
                var x = from u in _context.GiangViens
                        where u.MSGV.Contains(msgv) && u.HoTen.Contains(name) && u.GioiTinh.Contains(gioitinh) && u.QueQuan.Contains(quequan) && u.ChuyenNganh.Contains(chuyennganh)

                        select new { u.MSGV, u.HoTen, u.NgaySinh, u.GioiTinh, u.QueQuan, u.Khoa, u.ChuyenNganh };
                var i = x.First();

                this.cMSGV.DataPropertyName = nameof(i.MSGV);
                this.cHoTen.DataPropertyName = nameof(i.HoTen);
                this.cNgaySinh.DataPropertyName = nameof(i.NgaySinh);
                this.cGioiTinh.DataPropertyName = nameof(i.GioiTinh);

                this.cQueQuan.DataPropertyName = nameof(i.QueQuan);
                this.cKhoa.DataPropertyName = nameof(i.Khoa);
                this.cChuyenNganh.DataPropertyName = nameof(i.ChuyenNganh);
                this.dtgThongTinGiangVien.DataSource = x.ToList();
            }
        }

        private void DoDuLieu()
        {
            dtgThongTinGiangVien.DataSource = giangViens;
            dtgThongTinGiangVien.Refresh();
        }

        private void DoLaiDuLieu()
        {
            DBLapTrinhWin db = new DBLapTrinhWin();
            string msgv = giangViens[0].MSGV;
            giangViens = db.GiangViens.Where(x => x.MSGV == msgv).ToList();
            DoDuLieu();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddGiangVien gv = new frmAddGiangVien(giangViens[0].MSGV);
            gv.ShowDialog();

            DoLaiDuLieu();
        }
    }
}
