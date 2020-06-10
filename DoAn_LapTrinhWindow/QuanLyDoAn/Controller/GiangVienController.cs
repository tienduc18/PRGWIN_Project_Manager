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

        public static bool AddGiangVien(GiangVien giangvien)
        {
            using (var _context = new DBLapTrinhWin())
            {
                _context.GiangViens.Add(giangvien);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool UpdateGiangVien(GiangVien giangvien)
        {
            using (var _context = new DBLapTrinhWin())
            {
                _context.GiangViens.AddOrUpdate(giangvien);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
