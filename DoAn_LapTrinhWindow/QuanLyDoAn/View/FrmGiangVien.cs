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
        public FrmGiangVien()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var _context = new DBQuanLyDoAn())
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
    }
}
