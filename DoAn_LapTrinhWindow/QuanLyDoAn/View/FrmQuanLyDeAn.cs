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
    public partial class FrmQuanLyDeAn : Form
    {
       
        public FrmQuanLyDeAn()
        {
            InitializeComponent();

            //this.cbType.Text = "";
            //this.cIDDeAn.DataPropertyName = nameof(DeAn.IDDeAn);
            //this.cTenDeAn.DataPropertyName = nameof(DeAn.TenDeAn);
            //this.cTenNhom.DataPropertyName = nameof(DeAn.NhomSinhVien.TenNhom);
            //this.cType.DataPropertyName = nameof(DeAn.Type1.LoaiDeAn);
            //this.cMoTa.DataPropertyName = nameof(DeAn.MoTa);
            //this.cMonHoc.DataPropertyName = nameof(DeAn.MonHoc1.TenMonHoc);
            //this.cChuyenNganh.DataPropertyName = nameof(DeAn.ChuyenNganh1.TenChuyenNganh);

            ////this.cCacThanhVien.DataPropertyName = nameof(List<string>);

            //this.cThanhVien.DataPropertyName = nameof(DeAn.NhomSinhVien.ThanhVien);
            //this.cGVHD.DataPropertyName = nameof(DeAn.GiangVien.HoTen);
            //this.cDateStart.DataPropertyName = nameof(DeAn.DateStart);
            //this.cDateEnd.DataPropertyName = nameof(DeAn.DateEnd);
            //this.cTienDo.DataPropertyName = nameof(DeAn.TienDo);
            //this.cDiem.DataPropertyName = nameof(DeAn.Diem);
            this.cbType.Text = "";
            this.cIDDeAn.DataPropertyName = nameof(DanhSachDeAn.IDDeAn);
            this.cTenDeAn.DataPropertyName = nameof(DanhSachDeAn.TenDeAn);
            this.cTenNhom.DataPropertyName = nameof(DanhSachDeAn.TenNhom);
            this.cType.DataPropertyName = nameof(DanhSachDeAn.LoaiDeAn);
            this.cMoTa.DataPropertyName = nameof(DanhSachDeAn.MoTa);
            this.cMonHoc.DataPropertyName = nameof(DanhSachDeAn.TenMonHoc);
            this.cChuyenNganh.DataPropertyName = nameof(DanhSachDeAn.TenChuyenNganh);

           // this.cCacThanhVien.DataPropertyName = nameof(DanhSachDeAn.DanhSachThanhVien);

            this.cThanhVien.DataPropertyName = nameof(DanhSachDeAn.StringThanhVien);
            this.cGVHD.DataPropertyName = nameof(DanhSachDeAn.HoTenGV);
            this.cDateStart.DataPropertyName = nameof(DanhSachDeAn.DateStart);
            this.cDateEnd.DataPropertyName = nameof(DanhSachDeAn.DateEnd);
            this.cTienDo.DataPropertyName = nameof(DanhSachDeAn.TienDo);
            this.cDiem.DataPropertyName = nameof(DanhSachDeAn.Diem);
        }

        private void FrmQuanLyDeAn_Load(object sender, EventArgs e)
        {
            
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
                
                List<DanhSachDeAn> y = new List<DanhSachDeAn>();
                foreach (var  i in x)
                {
                    DanhSachDeAn k = new DanhSachDeAn();
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
                    k.TienDo = i.TienDo;
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
            string s = this.dtgDeAn.SelectedRows[0].Cells[1].Value.ToString();
            FrmTienDo k = new FrmTienDo(s);
            k.Show();
        }
    }
}
