using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAn.Controller
{
    public class DeAnController
    {
        public static List<string> TachIDNhom(string IDNhom)
        {
            List<string> ketqua = new List<string>();
            string[] s = IDNhom.Split('-');
            foreach(var x in s)
            {
                ketqua.Add(x);
            }
            return ketqua;
        }
      
    }

}
