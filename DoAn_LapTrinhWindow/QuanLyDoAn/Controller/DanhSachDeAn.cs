using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoAn.Controller
{
    public class DanhSachDeAn
    {
        public string IDDeAn { get; set; }
        
        public string TenDeAn { get; set; }
        public string TenNhom { get; set; }
        public string MoTa { get; set; }
        public string TenMonHoc { get; set; }

        public List<string> DanhSachThanhVien { get; set; }
        
        
        public string LoaiDeAn { get; set; }
        public string StringThanhVien { get; set; }
        public string TenChuyenNganh { get; set; }
        public string HoTenGV { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public double? TienDo { get; set; }
        public string Diem { get; set; }
        


    }
}
