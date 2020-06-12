using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDoAn.View;


namespace QuanLyDoAn.Controller
{
    public class NhomController
    {
        public static string CreateIDNhom(string type, string subject, string stt)
        {
            string ID;
            ID = type + "-" + subject + "-" + stt;

            return ID;
        }
        public static string SoThuTuTiepTheo(int x)
        {
            x = x + 1;
            string s = x.ToString();
            while(s.Length<3)
            {
                s = "0" + s;
            }
            return s;
        }
        public static List<SinhVien> GetListThanhVienNhom(string s)
        {
            List<SinhVien> thanhviennhom = new List<SinhVien>();
            string[] phantach = s.Split(',');
            using (var _context = new DBLapTrinhWin())
            {
                foreach (var x in phantach)
                {
                    var sinhvien = (from u in _context.SinhViens
                                   where u.Mssv == x
                                   select u).FirstOrDefault();
                    thanhviennhom.Add(sinhvien);
                }
            }
            return thanhviennhom;
        }

        public static List<string> GetDanhSachThanhVien(string s)
        {
            List<string> a = new List<string>();
            string[] tam = s.Split(',');
            using (var _context = new DBLapTrinhWin())
            {
                foreach (var i in tam) 
                {
                    var x = (from u in _context.SinhViens
                            where u.Mssv == i
                            select u).First();
                    string y = x.Mssv + ": " + x.HoTen;
                    a.Add(y);
                }
            }
            return a;
        }
    }
}
