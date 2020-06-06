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
    public partial class FrmQuanLyDoAn : Form
    {
        public FrmQuanLyDoAn()
        {
            InitializeComponent();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var _context = new QuanLyDeTaiEntities())
            {
                var x = from u in _context.SinhViens

                        select new { u.Mssv, u.HoTen, u.TieuLuanChuyenNganh.MaTLCN, u.TieuLuanChuyenNganh.TenDeTai, u.ChuyenNganh.TenChuyenNganh, u.TieuLuanChuyenNganh.TienDo, u.TieuLuanChuyenNganh.Check };
                var i = x.First();
                this.cMSSV.DataPropertyName = nameof(i.Mssv);
                this.cHoTen.DataPropertyName = nameof(i.HoTen);
                this.cType.DataPropertyName = nameof(i.MaTLCN);
                this.cTenDoAn.DataPropertyName = nameof(i.TenDeTai);
                this.cChuyenNganh.DataPropertyName = nameof(i.TenChuyenNganh);
                this.cTienDo.DataPropertyName = nameof(i.TienDo);
                this.cHoanThanh.DataPropertyName = nameof(i.Check);
                this.dtgListQLDA.DataSource = x.ToList();


            }
        }
    }
}
