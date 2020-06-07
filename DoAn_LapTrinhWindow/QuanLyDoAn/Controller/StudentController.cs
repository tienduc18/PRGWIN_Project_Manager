using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAn.Controller
{
    public class StudentController
    {
        public static bool AddStudent(SinhVien student)
        {
            using (var _context = new QuanLyDeTaiEntities())
            {
                _context.SinhViens.Add(student);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool UpdateStudent(SinhVien student)
        {
            using (var _context = new QuanLyDeTaiEntities())
            {
                _context.SinhViens.AddOrUpdate(student);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
