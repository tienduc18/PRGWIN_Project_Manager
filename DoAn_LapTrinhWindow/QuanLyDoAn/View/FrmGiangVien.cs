using QuanLyDoAn.Controller;
using QuanLyDoAn.ViewModel;
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
        private List<GiangVienViewModel> giangViens;
        private List<GiangVien> gViens;
        private List<ChuyenNganh> chuyenNganhs;

        public FrmGiangVien(ref List<GiangVien> dsGV, List<ChuyenNganh> dsCN)
        {
            InitializeComponent();

            this.gViens = dsGV;
            this.chuyenNganhs = dsCN;

            DoThuocTinh();
            DoDuLieu();
        }

        private void DoThuocTinh()
        {
            var i = new GiangVienViewModel();

            this.cMSGV.DataPropertyName = nameof(i.MSGV);
            this.cHoTen.DataPropertyName = nameof(i.HoTen);
            this.cNgaySinh.DataPropertyName = nameof(i.NgaySinh);
            this.cGioiTinh.DataPropertyName = nameof(i.GioiTinh);
            this.cQueQuan.DataPropertyName = nameof(i.QueQuan);
            this.cKhoa.DataPropertyName = nameof(i.Khoa);
            this.cChuyenNganh.DataPropertyName = nameof(i.ChuyenNganh);
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

                        select new { u.MSGV, u.HoTen, u.NgaySinh, u.GioiTinh, u.QueQuan, u.ChuyenNganh1.TenChuyenNganh };
                
                this.dtgThongTinGiangVien.DataSource = x.ToList();
            }
        }

        private void DoDuLieu()
        {
            giangViens = GiangVienController.GetAllGiangVien("");
            dtgThongTinGiangVien.DataSource = giangViens;
            dtgThongTinGiangVien.Refresh();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateGiangVien gv = new frmAddOrUpdateGiangVien();
            gv.ShowDialog();
            DoDuLieu();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dtgThongTinGiangVien.SelectedRows.Count <= 0)
            {
                return;
            }

            frmAddOrUpdateGiangVien updategv = new frmAddOrUpdateGiangVien(dtgThongTinGiangVien.SelectedRows[0].Cells[0].Value.ToString());
            updategv.ShowDialog();
            DoDuLieu();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgThongTinGiangVien.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Phải chọn giảng viên muốn xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                
            }
        }
    }
}
