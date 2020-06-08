using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoAn
{
    public partial class FrmTestDB : Form
    {
        public FrmTestDB()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            using (var _context = new DBLapTrinhWin())
            {
                var sinhvien = (from u in _context.SinhViens
                               select u).Single();
                txtNameTest.Text = sinhvien.HoTen;
            }
        }
    }
}
