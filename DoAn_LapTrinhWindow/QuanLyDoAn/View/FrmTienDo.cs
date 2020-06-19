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
    public partial class FrmTienDo : Form
    {
        string key;
        double tienDo;
        LinkLabel a = new LinkLabel();
        public FrmTienDo(string s)
        {
            InitializeComponent();
            this.cBuoi.DataPropertyName = nameof(TienDoBaoCao.Buoi);
            this.cNoiDungBaoCao.DataPropertyName = nameof(TienDoBaoCao.NoiDung);
            this.cLinkTaiLieu.DataPropertyName = nameof(TienDoBaoCao.Link);
            this.cHoanThanh.DataPropertyName = nameof(TienDoBaoCao.HoanThanh);
            this.cSoBuoi.DataPropertyName = nameof(TienDoBaoCao.SoBuoi);
            key = s.Trim();
            
            Khoitao();
            TaoDTG();
            
        }
        public void Khoitao()
        {
            using (var _context = new DBLapTrinhWin())
            {
                var x = (from u in _context.TienDoes
                        where u.IDDeAn == key
                        select u).FirstOrDefault();
                
                
                
                TienDoBaoCao present = new TienDoBaoCao();
                present.SoBuoi = x.SoBuoi;
                txtSoBuoi.Text = (present.SoBuoi).ToString();
                for (int i = 1; i <= present.SoBuoi; i++)
                {
                    cbSoBuoi.Items.Add(i);
                }
                

                var m = from u in _context.DeAns
                        where u.IDDeAn == key
                        select u;
                if (m.Count() != 0)
                {
                    var n = m.First();
                    if (!(n.Diem is null))
                        txtDiem.Text = n.Diem.ToString();
                    if (!(n.DateStart is  null || n.DateEnd is null))
                    {
                        dtpDateStart.Value = DateTime.Parse(n.DateStart.Value.ToString());
                        dtpDateEnd.Value = DateTime.Parse(n.DateEnd.Value.ToString());
                    }
                }

            }
            


        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            using (var _context = new DBLapTrinhWin())
            {
                var x = from u in _context.TienDoes
                        where u.IDDeAn == key
                        select u;
                if (x.Count() != 0)
                {
                    x.First().SoBuoi = int.Parse(txtSoBuoi.Text.Trim());
                }

                var y = from u in _context.DeAns
                        where u.IDDeAn == key
                        select u;
                if (y.Count() != 0)
                {
                    var z = y.First();

                    z.DateStart = dtpDateStart.Value;
                    z.DateEnd = dtpDateEnd.Value;
                    z.Diem = txtDiem.Text.Trim();
                }
                _context.SaveChanges();
                Khoitao();
                TaoDTG();
            }
        }





        public void TaoDTG()
        {
            using (var _context = new DBLapTrinhWin())
            {
                int sobuoi = 0;
                var x = from u in _context.TienDoes
                        where u.IDDeAn == key
                        select u;
                if (x.Count()!=0)
                {
                    if (x.First().SoBuoi != null)
                    {
                        sobuoi = (int)x.First().SoBuoi;
                    }
                }


                var sobuoihientai = from u in _context.TienDoes
                                    where u.HoanThanh == null && u.IDDeAn == key
                                    select u;
                if (sobuoihientai.Count() == 1)
                {
                    List<TienDoBaoCao> dtg = new List<TienDoBaoCao>();
                    for (int j = 0; j < sobuoi; j++)
                    {

                        TienDoBaoCao k = new TienDoBaoCao();
                        string buoi = "Buổi " + (j + 1).ToString();
                        
                        k.Buoi = buoi;
                        dtg.Add(k);
                    
                    }
                    dtgTienDo.DataSource = dtg;
                    return;

                }

                
                string xnd = "";
                string xlink = "";
                string xcheck = "";
                if ((x.First().BaoCao != null))
                    xnd = x.First().BaoCao;
                if ((x.First().LinkTaiLieu !=null))
                    xlink = x.First().LinkTaiLieu;
                if ((x.First().HoanThanh != null))
                    xcheck = x.First().HoanThanh;
                List<string> noidung = BaoCaoTienDoController.GetDanhSachNoiDungBaoCao(xnd);
                List<string> link = BaoCaoTienDoController.GetDanhSachLinkTaiLieu(xlink);
                List<bool> check = BaoCaoTienDoController.GetHoanThanh(xcheck);
                List<TienDoBaoCao> dtgsource = new List<TienDoBaoCao>();
                for (int i = 0; i < sobuoi; i++)
                {

                    TienDoBaoCao k = new TienDoBaoCao();
                    string buoi = "Buổi " + (i + 1).ToString();
                    k.Buoi = buoi;
                    if (i<noidung.Count())
                        k.NoiDung = noidung[i];
                    if(i<link.Count())
                        k.Link = link[i];
                    if (i<check.Count())
                        k.HoanThanh = check[i];
                    dtgsource.Add(k);
                }

                dtgTienDo.DataSource = dtgsource;
            }
        }

        
        
        
        
        private void checkboxHoanTat_CheckedChanged(object sender, EventArgs e)
        {
            using (var _context = new DBLapTrinhWin())
            {
                var get = (from u in _context.TienDoes
                          where u.IDDeAn == key
                          select u).FirstOrDefault();


                string noidung = get.BaoCao;
                string link = get.LinkTaiLieu;
                string check = get.HoanThanh;

                noidung = noidung + rtxtNoiDung.Text + "$";
                link = link + txtLinkTaiLieu.Text + ",";
                check = check + "true" + ",";

                get.BaoCao = noidung;
                get.LinkTaiLieu = link;
                get.HoanThanh = check;
                _context.SaveChanges();
                Khoitao();
                TaoDTG();
                tienDo = (double)(BaoCaoTienDoController.GetHoanThanh(check).Count() - 1) / int.Parse(txtSoBuoi.Text);
                tienDo = Math.Round(tienDo, 2);
                var get1 = (from u in _context.DeAns
                            where u.IDDeAn == key
                            select u).FirstOrDefault();
                get1.TienDo = tienDo;
                _context.SaveChanges();
            }
        }

        private void FrmTienDo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FrmQuanLyDeAn h = new FrmQuanLyDeAn();
            //h.Show();
        }

        private void dtgTienDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //a = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value as LinkLabel;
            //a.Click += A_Click;
            //a.LinkVisited = true;
            //string s = a.Text;
            System.Diagnostics.Process.Start((sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());


        }

        private void A_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmTienDo_Load(object sender, EventArgs e)
        {

        }
    }
}
