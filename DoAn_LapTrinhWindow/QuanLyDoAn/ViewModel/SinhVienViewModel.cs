using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAn.ViewModel
{
    public class SinhVienViewModel
    {
        public string Mssv { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; }
        public string ChuyenNganh { get; set; }
        public string NamNhapHoc { get; set; }
    }
}
