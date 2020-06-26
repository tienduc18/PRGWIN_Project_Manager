using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAn.ViewModel
{
    public class GiangVienViewModel
    {
        [Key]
        [DisplayName("MSGV")]
        public string MSGV { get; set; }

        [DisplayName("Họ tên")]
        public string HoTen { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        [DisplayName("Quê quán")]
        public string QueQuan { get; set; }

        [DisplayName("Giới tính")]
        public string GioiTinh { get; set; }

        [DisplayName("Chuyên ngành")]
        public string ChuyenNganh { get; set; }
    }
}
