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
                var model = _context.GiangViens;

                if(!string.IsNullOrEmpty(searchString))
                {
                    // search
                    // keys: lowercase
                    // foreach key in keys
                    // model = model.Where(x => x.MSGV == key || x.HoTen.ToLower().Contains(key))


                }

                var result = model.Select(x => new GiangVienViewModel
                {
                    MSGV = x.MSGV,
                    HoTen = x.HoTen,
                    NgaySinh = x.NgaySinh.HasValue ? x.NgaySinh.Value : DateTime.MinValue,
                    GioiTinh = x.GioiTinh,
                    Khoa = x.Khoa,
                    QueQuan = x.QueQuan,
                    ChuyenNganh = x.ChuyenNganh1.TenChuyenNganh
                }).ToList();

                return result;
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
