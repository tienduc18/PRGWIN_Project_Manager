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
                var dbStudent = (from s in _context.GiangViens
                                 where s.DaXoa == false
                                 select s);

                var model = _context.GiangViens;

                if(!string.IsNullOrEmpty(searchString))
                {
                    // search
                    // keys: lowercase
                    // foreach key in keys
                    // model = model.Where(x => x.MSGV == key || x.HoTen.ToLower().Contains(key))


                }

                //var result = model.Select(x => new GiangVienViewModel
                List<GiangVienViewModel> gv = new List<GiangVienViewModel>();
                foreach(var x in dbStudent)
                {
                    GiangVienViewModel gVien = new GiangVienViewModel();
                    gVien.MSGV = x.MSGV;
                    gVien.HoTen = x.HoTen;
                    gVien.NgaySinh = x.NgaySinh.HasValue ? x.NgaySinh.Value : DateTime.MinValue;
                    gVien.GioiTinh = x.GioiTinh;
                    gVien.Khoa = x.Khoa;
                    gVien.QueQuan = x.QueQuan;
                    gVien.ChuyenNganh = x.ChuyenNganh1.TenChuyenNganh;
                    gv.Add(gVien);
                    
                }

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
        public static List<GiangVien> GetListGiangVien()
        {
            using (var _context = new DBLapTrinhWin())
            {
                var task = (from t in _context.GiangViens.Include("ChuyenNganh1").AsEnumerable()
                            select t)
                            .Select(x => new GiangVien
                            {
                                MSGV = x.MSGV,
                                HoTen = x.HoTen,
                                NgaySinh = x.NgaySinh,
                                QueQuan = x.QueQuan,
                                GioiTinh = x.GioiTinh,
                                Khoa = x.Khoa,
                                ChuyenNganh = x.ChuyenNganh,
                                ChuyenNganh1 = x.ChuyenNganh1
                            }).ToList();

                return task;
            }
        }
    }
}
