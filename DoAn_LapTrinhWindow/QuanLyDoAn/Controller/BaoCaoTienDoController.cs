using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAn.Controller
{
    public class BaoCaoTienDoController
    {
        public static List<string> GetDanhSachNoiDungBaoCao(string s)
        {
            List<string> ketqua = new List<string>();
            if (s[s.Length - 1] == '&')
            {
                s.TrimEnd('&');
            }
            string[] phantach = s.Split('$');
            foreach (var i in phantach)
            {
                ketqua.Add(i);
            }
            return ketqua;

        }
        public static List<string> GetDanhSachLinkTaiLieu(string s)
        {
            List<string> ketqua = new List<string>();
            if (s[s.Length - 1] == ',')
            {
                s.TrimEnd(',');
            }
            string[] phantach = s.Split(',');
            foreach (var i in phantach)
            {
                ketqua.Add(i);
            }
            return ketqua;
        }

        public static List<bool> GetHoanThanh(string s)
        {
            List<bool> ketqua = new List<bool>();
            if (s[s.Length - 1] == ',')
            {
                s.TrimEnd(',');
            }
            string[] phantach = s.Split(',');
            foreach (var i in phantach)
            {
                if (i == "true")
                    ketqua.Add(true);
                else
                    ketqua.Add(false);
            }
            return ketqua;
        }
    }
}
