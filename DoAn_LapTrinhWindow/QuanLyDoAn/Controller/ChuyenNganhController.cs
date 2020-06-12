using QuanLyDoAn.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoAn.Controller
{
    public class ChuyenNganhController
    {
        public static List<ChuyenNganhViewModel> GetAllChuyenNganh()
        {
            using (var _context = new DBLapTrinhWin())
            {
                var model = _context.ChuyenNganhs;

                var result = model.Select(x => new ChuyenNganhViewModel
                {
                    IDChuyenNganh = x.IDChuyenNganh,
                    TenChuyenNganh = x.TenChuyenNganh
                }).ToList();

                return result;
            }
        }
    }
}
