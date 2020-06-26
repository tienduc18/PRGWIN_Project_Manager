using QuanLyDoAn.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAn.Controller
{
    public class GiangVienController
    {
        public static GiangVien GetGiangVien(string IDGiangVien)
        {
            using (var _context = new DBLapTrinhWin())
            {
                var dbGiangVien = (from s in _context.GiangViens
                                 where s.MSGV == IDGiangVien
                                   select s).FirstOrDefault();

                return dbGiangVien;
            } 
        }

        public static List<GiangVienViewModel> GetAllGiangVien(string searchString)
        {
            using (var _context = new DBLapTrinhWin())
            {
                var dbGiangVien = (from s in _context.GiangViens
                                 where s.DaXoa == false
                                 select s);

                List<GiangVienViewModel> gv = dbGiangVien.Select(x => new GiangVienViewModel()
                {
                    MSGV = x.MSGV,
                    HoTen = x.HoTen,
                    NgaySinh = x.NgaySinh.HasValue ? x.NgaySinh.Value : DateTime.MinValue,
                    GioiTinh = x.GioiTinh,
                    QueQuan = x.QueQuan,
                    ChuyenNganh = x.ChuyenNganh1.TenChuyenNganh
                }).ToList();
                
                return gv;
            }
        }

        public static bool DeleteGiangVien(string ID)
        {
            using (var _context = new DBLapTrinhWin())
            {
                var dbGiangVien = (from s in _context.GiangViens
                                 where s.MSGV == ID && s.DaXoa == false
                                 select s).FirstOrDefault();
                if (dbGiangVien == null)
                    return false;
                dbGiangVien.DaXoa = true;
                _context.GiangViens.AddOrUpdate(dbGiangVien);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
