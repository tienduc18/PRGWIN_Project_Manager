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

        public void SetErrorProvider()
        {
            if(string.IsNullOrEmpty(txtIDNhom.Text))
            {
                txtIDNhom.Focus();
                this.errorProvider1.SetError(txtIDNhom, "Phải có ID nhóm!");
            }    
            else
            {
                this.errorProvider1.SetError(txtIDNhom, null);
            }

            if (string.IsNullOrEmpty(txtTenDeAn.Text))
            {
                txtTenDeAn.Focus();
                this.errorProvider1.SetError(txtTenDeAn, "Phải nhập tên đề án!");
            }
            else
            {
                this.errorProvider1.SetError(txtTenDeAn, null);
            }

            if (string.IsNullOrEmpty(txtGVHD.Text))
            {
                txtGVHD.Focus();
                this.errorProvider1.SetError(txtGVHD, "Phải có giảng viên hướng dẫn!");
            }
            else
            {
                this.errorProvider1.SetError(txtGVHD, null);
            }

            if (string.IsNullOrEmpty(txtMoTa.Text))
            {
                txtMoTa.Focus();
                this.errorProvider1.SetError(txtMoTa, "Phải mô tả đề án!");
            }
            else
            {
                this.errorProvider1.SetError(txtMoTa, null);
            }

            if (dtpDateEnd.Value <= dtpDateStart.Value)
            {
                dtpDateEnd.Focus();
                this.errorProvider1.SetError(dtpDateEnd, "Ngày kết thúc phải lớn hơn ngày bắt đầu!");
            }
            else
            {
                this.errorProvider1.SetError(dtpDateEnd, null);
            }

            if (dtpDateStart.Value <= DateTime.Now)
            {
                dtpDateStart.Focus();
                this.errorProvider1.SetError(dtpDateStart, "Ngày bắt đầu phải lớn hơn thời gian hiện tại!");
            }
            else
            {
                this.errorProvider1.SetError(dtpDateStart, null);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            SetErrorProvider();
            if(txtIDNhom.Text != "" && txtTenDeAn.Text != "" && txtGVHD.Text != "" && txtMoTa.Text != ""
                && dtpDateStart.Value > DateTime.Now && dtpDateEnd.Value > dtpDateStart.Value)
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
                    type = "1";
                else if (cacthuoctinh[0] == "TLCN")
                    type = "2";
                else if (cacthuoctinh[0] == "DATN")
                    type = "3";

                DeAn DeAnDangKy = new DeAn();
                DeAnDangKy.IDDeAn = IDnhom;
                DeAnDangKy.TenDeAn = txtTenDeAn.Text.Trim();
                DeAnDangKy.Type = type;
                DeAnDangKy.IDNhomSV = IDnhom;
                DeAnDangKy.GVHD = txtGVHD.Text.Trim();
                DeAnDangKy.MoTa = txtMoTa.Text;
                if (type == "1")
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

                AddDeAnThanhCongEventArgs arg = new AddDeAnThanhCongEventArgs();
                OnAddDeAnThanhCong(arg);
                this.Close();
                #endregion
            }
        }

        private void btnDangKyNhom_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAddNhomSinhVien frmNhom = new FrmAddNhomSinhVien();
            frmNhom.Show();
            frmNhom.DangKyNhomThanhCong += FrmNhom_DangKyNhomThanhCong;
            frmNhom.FormClosed += FrmNhom_FormClosed;  
        }

        private void FrmNhom_DangKyNhomThanhCong(object sender, DangKyNhomThanhCongEventArgs e)
        {
            txtIDNhom.Text = e.IdNhom;
        }

        private void FrmNhom_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void txtGVHD_TextChanged(object sender, EventArgs e)
        {
            lstViewGVHD.Items.Clear();
            string s = txtGVHD.Text;
            using (var _context = new DBLapTrinhWin())
            {
                var x = from u in _context.GiangViens
                        where u.MSGV.Contains(s) && u.DaXoa == false
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

        public event EventHandler<AddDeAnThanhCongEventArgs> AddDeAnThanhCong;

        public virtual void OnAddDeAnThanhCong(AddDeAnThanhCongEventArgs e)
        {
            EventHandler<AddDeAnThanhCongEventArgs> handler = AddDeAnThanhCong;

            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

    public class AddDeAnThanhCongEventArgs : EventArgs
    {

    }
}
