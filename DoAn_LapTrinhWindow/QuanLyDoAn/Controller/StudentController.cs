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
                                where s.Mssv == studentID && s.DaXoa == false
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
        public static bool DeleteStudent(string studentID)
        {
            using (var _context = new DBLapTrinhWin())
            {
                var dbStudent = (from s in _context.SinhViens
                                where s.Mssv == studentID && s.DaXoa == false
                                select s).FirstOrDefault();
                if (dbStudent == null)
                    return false;
                dbStudent.DaXoa = true;
                _context.SinhViens.AddOrUpdate(dbStudent);
                _context.SaveChanges();
                return true;
            }
        }
        public static List<SinhVienViewModel> GetListStudent()
        {
            using (var _context = new DBLapTrinhWin())
            {
                var model = (from t in _context.SinhViens
                            where t.DaXoa == false
                            select t)
                            .Select(x => new SinhVienViewModel
                            {
                                Mssv = x.Mssv,
                                HoTen = x.HoTen,
                                NgaySinh = x.NgaySinh ?? DateTime.MinValue,
                                QueQuan = x.QueQuan,
                                GioiTinh = x.GioiTinh,
                                NamNhapHoc = x.NamNhapHoc,
                                ChuyenNganh = x.ChuyenNganh.TenChuyenNganh
                            }).ToList();

                return model;
            }
        }
    }
}
