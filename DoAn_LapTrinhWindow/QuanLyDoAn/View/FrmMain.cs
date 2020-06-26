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
    public partial class FrmMain : Form
    {
        FrmSinhVien frmSinhVien;
        FrmGiangVien frmGiangVien;
        FrmQuanLyDeAn frmDeAn;
        private List<ChuyenNganh> chuyenNganhs;
        private List<DeAn> deAns;
        private List<MonHoc> monHocs;
        private List<NhomSinhVien> nhomSinhViens;
        private List<TienDo> tienDos;
        private List<Type> types;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void MenuSinhVien_Click(object sender, EventArgs e)
        {
            if(this.frmSinhVien is null || this.frmSinhVien.IsDisposed)
            {
                this.frmSinhVien = new FrmSinhVien();
                this.frmSinhVien.MdiParent = this;
                this.frmSinhVien.Show();
            }
            else
            {
                this.frmSinhVien.Select();
            }
        }

        private void MenuGiangVien_Click(object sender, EventArgs e)
        {
            if(this.frmGiangVien is null || this.frmGiangVien.IsDisposed)
            {
                this.frmGiangVien = new FrmGiangVien();
                this.frmGiangVien.MdiParent = this;
                this.frmGiangVien.Show();
            }
            else
            {
                this.frmGiangVien.Select();
            }
        }

        private void MenuQuanLyDeTai_Click(object sender, EventArgs e)
        {
            if(this.frmDeAn is null || this.frmDeAn.IsDisposed)
            {
                this.frmDeAn = new FrmQuanLyDeAn();
                this.frmDeAn.MdiParent = this;
                this.frmDeAn.Show();
            }
            else
            {
                this.frmDeAn.Select();
            }
        }

        private void FrmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild == null)
            {
                return;
            }

            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;

            if(this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tctTabMain;
                this.tctTabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tctTabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tctTabMain.SelectedTab != null && this.tctTabMain.SelectedTab.Tag != null)
            {
                (this.tctTabMain.SelectedTab.Tag as Form).Select();
            }
        }
    }
}
