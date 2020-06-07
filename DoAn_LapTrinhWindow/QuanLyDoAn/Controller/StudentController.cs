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
            using (var _context = new QuanLyDeTaiEntities())
            {
                var dbStudent = (from s in _context.SinhViens
                                where s.Mssv == studentID
                                select s).FirstOrDefault();
                return dbStudent;
            }
        }
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
                //try
                //{
                _context.SaveChanges();
                //}
                //catch (DbEntityValidationException ex)
                //{
                //    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                //    {
                //        foreach (var validationError in entityValidationErrors.ValidationErrors)
                //        {
                //            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                //        }
                //    }
                //}
                return true;
            }
        }
    }
}
