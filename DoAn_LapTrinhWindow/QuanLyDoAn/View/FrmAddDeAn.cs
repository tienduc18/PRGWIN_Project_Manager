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
    public partial class FrmAddDeAn : Form
    {
        public FrmAddDeAn(string s)
        {
            InitializeComponent();
            this.txtIDNhom.Text = s;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string IDnhom = txtIDNhom.Text.Trim();
            #region Tên nhóm hoặc giảng viên không tồn tại
            using (var _context = new DBLapTrinhWin())
            {
                var nhom = from u in _context.NhomSinhViens
                           where u.IDNhom == IDnhom
                           select u;
                if (nhom.Count() == 0)
                {
                    MessageBox.Show("Nhóm không tồn tại!");
                    this.ActiveControl = txtIDNhom;
                    return;
                }

                string gvhd = txtGVHD.Text.Trim();
                var gv = from u in _context.GiangViens
                         where u.MSGV == gvhd
                         select u;
                if (gv.Count() == 0)
                {
                    MessageBox.Show("Giảng viên không tồn tại");
                    this.ActiveControl = txtGVHD;
                    return;
                }
            }
            #endregion

            #region Xử lý lưu các thuộc tính vào database
            List<string> cacthuoctinh = new List<string>();
            cacthuoctinh = DeAnController.TachIDNhom(IDnhom);
            string type = "";
            
            if (cacthuoctinh[0] == "DAMH")
                type = "0";
            else if (cacthuoctinh[0] == "TLCN")
                type = "1";
            else if (cacthuoctinh[0] == "DATN")
                type = "2";
           
            DeAn DeAnDangKy = new DeAn();
            DeAnDangKy.IDDeAn = IDnhom;
            DeAnDangKy.TenDeAn = txtTenDeAn.Text.Trim();
            DeAnDangKy.Type = type;
            DeAnDangKy.IDNhomSV = IDnhom;
            DeAnDangKy.GVHD = txtGVHD.Text.Trim();
            DeAnDangKy.MoTa = txtMoTa.Text;
            if (type == "0")
                DeAnDangKy.MonHoc = cacthuoctinh[1];
            else
                DeAnDangKy.ChuyenNganh = cacthuoctinh[1];
            using (var _context = new DBLapTrinhWin())
            {
                _context.DeAns.Add(DeAnDangKy);
                _context.SaveChanges();
            }
            txtIDDeAn.Text = IDnhom;
            TienDo tienDo = new TienDo();
            tienDo.IDDeAn = DeAnDangKy.IDDeAn;
            using (var _context = new DBLapTrinhWin())
            {
                _context.TienDoes.Add(tienDo);
                _context.SaveChanges();
            }
            MessageBox.Show("Thêm đề án thành công!");
            #endregion
        }

        private void btnDangKyNhom_Click(object sender, EventArgs e)
        {
            FrmAddNhomSinhVien frmNhom = new FrmAddNhomSinhVien();
            
            frmNhom.Show();
            this.Close();

        }

        private void txtGVHD_TextChanged(object sender, EventArgs e)
        {
            lstViewGVHD.Items.Clear();
            string s = txtGVHD.Text;
            using (var _context = new DBLapTrinhWin())
            {
                var x = from u in _context.GiangViens
                        where u.MSGV.Contains(s)
                        select u;
                foreach(var i in x)
                {
                    string noi = i.MSGV + ": " + i.HoTen;
                    lstViewGVHD.Items.Add(noi);
                }
                
            }
            if (s == string.Empty)
                this.lstViewGVHD.Visible = false;
            else
                this.lstViewGVHD.Visible = true;
        }

        private void lstViewGVHD_DoubleClick(object sender, EventArgs e)
        {
            string[] cat;
            cat = this.lstViewGVHD.SelectedItems[0].Text.Split(':');
            txtGVHD.Text = cat[0];
            lstViewGVHD.Visible = false;
        }
    }
}
