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
using QuanLyDoAn.ViewModel;

namespace QuanLyDoAn.View
{
    public partial class FrmQuanLyDeAn : Form
    {
        public FrmQuanLyDeAn()
        {
            InitializeComponent();

            this.cbType.Text = "";
            this.cIDDeAn.DataPropertyName = nameof(DeAnViewModel.IDDeAn);
            this.cTenDeAn.DataPropertyName = nameof(DeAnViewModel.TenDeAn);
            this.cTenNhom.DataPropertyName = nameof(DeAnViewModel.TenNhom);
            this.cType.DataPropertyName = nameof(DeAnViewModel.LoaiDeAn);
            this.cMoTa.DataPropertyName = nameof(DeAnViewModel.MoTa);
            this.cMonHoc.DataPropertyName = nameof(DeAnViewModel.TenMonHoc);
            this.cChuyenNganh.DataPropertyName = nameof(DeAnViewModel.TenChuyenNganh);

            //this.cCacThanhVien.DataPropertyName = nameof(DanhSachDeAn.DanhSachThanhVien);

            this.cThanhVien.DataPropertyName = nameof(DeAnViewModel.StringThanhVien);
            this.cGVHD.DataPropertyName = nameof(DeAnViewModel.HoTenGV);
            this.cDateStart.DataPropertyName = nameof(DeAnViewModel.DateStart);
            this.cDateEnd.DataPropertyName = nameof(DeAnViewModel.DateEnd);
            this.cTienDo.DataPropertyName = nameof(DeAnViewModel.TienDo);
            this.cDiem.DataPropertyName = nameof(DeAnViewModel.Diem);
            DoDuLieu();
            
        }

        private void FrmQuanLyDeAn_Load(object sender, EventArgs e)
        {
            DoDuLieu();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string IDdean = txtIDDeAn.Text.Trim();
            string tendean = txtTenDeAn.Text.Trim();
            string loaidean = cbType.Text;
            string idnhom = txtIDNhom.Text.Trim();
            string gvhd = txtGVHD.Text.Trim();
            string idchuyennganh = txtMaChuyenNganh.Text.Trim();
            string idmonhoc = txtMaMonHoc.Text.Trim();
            List<string> a = new List<string>();
            string type = "";
            if (loaidean == cbType.Items[0].ToString())
                type = "0";
            else if (loaidean == cbType.Items[1].ToString())
                type = "1";
            else if(loaidean == cbType.Items[2].ToString())
                type = "2";
            using (var _context = new DBLapTrinhWin())
            {
                var x = from u in _context.DeAns
                        where u.IDDeAn.Contains(IDdean) && u.TenDeAn.Contains(tendean) && u.Type.Contains(type)
                        && u.IDNhomSV.Contains(idnhom) && u.GiangVien.HoTen.Contains(gvhd) && u.IDDeAn.Contains(idchuyennganh)
                        && u.IDDeAn.Contains(idmonhoc)
                        select new
                        {
                            u.IDDeAn,
                            u.TenDeAn,
                            u.NhomSinhVien.TenNhom,
                            u.MoTa,
                            u.MonHoc1.TenMonHoc,
                            u.Type1.LoaiDeAn,
                            
                            u.NhomSinhVien.ThanhVien,
                            u.ChuyenNganh1.TenChuyenNganh,
                            u.GiangVien.HoTen,
                            u.DateStart,
                            u.DateEnd,
                            u.TienDo,
                            u.Diem
                        };
                
                List<DeAnViewModel> y = new List<DeAnViewModel>();
                foreach (var  i in x)
                {
                    DeAnViewModel k = new DeAnViewModel();
                    k.IDDeAn = i.IDDeAn;
                    k.TenDeAn = i.TenDeAn;
                    
                    k.TenNhom = i.TenNhom;
                    k.MoTa = i.MoTa;
                    k.TenMonHoc = i.TenMonHoc;
                    k.LoaiDeAn = i.LoaiDeAn;
                    k.StringThanhVien = i.ThanhVien;
                    k.TenChuyenNganh = i.TenChuyenNganh;
                    k.HoTenGV = i.HoTen;
                    k.DateStart = i.DateStart;
                    k.DateEnd = i.DateEnd;
                    k.TienDo = i.TienDo.HasValue ? (i.TienDo * 100).ToString() + "%" : "0%";
                    k.Diem = i.Diem;
                    k.DanhSachThanhVien = NhomController.GetDanhSachThanhVien(k.StringThanhVien);
                    
                    y.Add(k);
                }
                
                this.dtgDeAn.DataSource = y;

                ComboBox test = new ComboBox();
                
                
               


                // Xử lý cột combobox trong datagridview
                
               

            }
        }

        private void btnTienDo_Click(object sender, EventArgs e)
        {
            if(dtgDeAn.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn phải chọn đề án.","Thông báo!", MessageBoxButtons.OK);
                return;
            }

            string s = this.dtgDeAn.SelectedRows[0].Cells[1].Value.ToString();
            FrmTienDo k = new FrmTienDo(s);
            k.Show();
            DoDuLieu();
        }

        private void btnDangKyDeAn_Click(object sender, EventArgs e)
        {
            FrmAddDeAn frmDeAn = new FrmAddDeAn("");
            frmDeAn.Show();
            frmDeAn.AddDeAnThanhCong += FrmDeAn_AddDeAnThanhCong;
        }

        private void FrmDeAn_AddDeAnThanhCong(object sender, AddDeAnThanhCongEventArgs e)
        {
            DoDuLieu();
        }

        private void dtgDeAn_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView data = sender as DataGridView;
            List<DeAnViewModel> source =(sender as DataGridView).DataSource as List<DeAnViewModel>;
            for(int i=0;i< data.Rows.Count;i++)
            
            {
                 for (int j=0;j<source[i].DanhSachThanhVien.Count;j++)
                    (data.Rows[i].Cells[0] as DataGridViewComboBoxCell).Items.Add(source[i].DanhSachThanhVien[j]);
                
                //(data.Rows[i].Cells[0] as DataGridViewComboBoxCell).Items.Add(source[i].DanhSachThanhVien);


            }
            
            
        }

        private void DoDuLieu()
        {
            string IDdean = txtIDDeAn.Text.Trim();
            string tendean = txtTenDeAn.Text.Trim();
            string loaidean = cbType.Text;
            string idnhom = txtIDNhom.Text.Trim();
            string gvhd = txtGVHD.Text.Trim();
            string idchuyennganh = txtMaChuyenNganh.Text.Trim();
            string idmonhoc = txtMaMonHoc.Text.Trim();
            List<string> a = new List<string>();
            string type = "";
            if (loaidean == cbType.Items[0].ToString())
                type = "0";
            else if (loaidean == cbType.Items[1].ToString())
                type = "1";
            else if (loaidean == cbType.Items[2].ToString())
                type = "2";
            using (var _context = new DBLapTrinhWin())
            {
                var x = (from u in _context.DeAns
                         where u.IDDeAn.Contains(IDdean) && u.TenDeAn.Contains(tendean) && u.Type.Contains(type)
                         && u.IDNhomSV.Contains(idnhom) && u.GiangVien.HoTen.Contains(gvhd) && u.IDDeAn.Contains(idchuyennganh)
                         && u.IDDeAn.Contains(idmonhoc)
                         select new DeAnViewModel
                         {
                             IDDeAn = u.IDDeAn,
                             TenDeAn = u.TenDeAn,
                             TenNhom = u.NhomSinhVien.TenNhom,
                             MoTa = u.MoTa,
                             TenMonHoc = u.MonHoc1.TenMonHoc,
                             LoaiDeAn = u.Type1.LoaiDeAn,
                             StringThanhVien = u.NhomSinhVien.ThanhVien,
                             TenChuyenNganh = u.ChuyenNganh1.TenChuyenNganh,
                             HoTenGV = u.GiangVien.HoTen,
                             DateStart = u.DateStart,
                             DateEnd = u.DateEnd,
                             Diem = u.Diem,
                             TienDo = u.TienDo.HasValue ? (u.TienDo * 100).ToString() + "%" : "0%"
                         }).ToList();

                foreach(var deAn in x)
                {
                    deAn.DanhSachThanhVien = NhomController.GetDanhSachThanhVien(deAn.StringThanhVien);
                }

                this.dtgDeAn.DataSource = x;






                // Xử lý cột combobox trong datagridview



            }
        }
    }
}
