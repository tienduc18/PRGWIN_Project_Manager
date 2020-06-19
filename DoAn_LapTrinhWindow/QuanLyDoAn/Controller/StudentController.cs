using QuanLyDoAn.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAn.Controller
{
    public class StudentController
    {
        public static SinhVien GetStudent(string studentID)
        {
            using (var _context = new DBLapTrinhWin())
            {
                var dbStudent = (from s in _context.SinhViens
                                where s.Mssv == studentID
                                select s).FirstOrDefault();
                return dbStudent;
            }
        }
        public static bool AddStudent(SinhVien student)
        {
            using (var _context = new DBLapTrinhWin())
            {
                _context.SinhViens.Add(student);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool UpdateStudent(SinhVien student)
        {
            using (var _context = new DBLapTrinhWin())
            {
                _context.SinhViens.AddOrUpdate(student);                
                _context.SaveChanges();               
                return true;
            }
        }
        //public static List<SinhVienViewModel> GetListStudent()
        //{
        //    using(var _context = new DBLapTrinhWin())
        //    {
        //        var model = _context.SinhViens;              

        //        var result = model.Select(x => new SinhVienViewModel
        //        {
        //            Mssv = x.Mssv,
        //            HoTen = x.HoTen,
        //            NgaySinh = x.NgaySinh.HasValue ? x.NgaySinh.Value : DateTime.MinValue,
        //            QueQuan = x.QueQuan,
        //            GioiTinh = x.GioiTinh,
        //            Khoa = x.Khoa,
        //            ChuyenNganh = x.ChuyenNganh.TenChuyenNganh,
        //            NamNhapHoc = x.NamNhapHoc,
        //        }).ToList();

        //        return result;
        //    }
        //}
        public static List<SinhVien> GetListStudent()
        {
            using (var _context = new DBLapTrinhWin())
            {
                var task = (from t in _context.SinhViens.Include("ChuyenNganh").AsEnumerable()
                            select t)
                            .Select(x => new SinhVien
                            {
                                Mssv = x.Mssv,
                                HoTen = x.HoTen,
                                NgaySinh = x.NgaySinh,
                                QueQuan = x.QueQuan,
                                GioiTinh = x.GioiTinh,
                                Khoa = x.Khoa,
                                IDChuyenNganh = x.IDChuyenNganh,
                                NamNhapHoc = x.NamNhapHoc,
                                ChuyenNganh = x.ChuyenNganh
                            }).ToList();

                return task;
            }
        }
    }
}
