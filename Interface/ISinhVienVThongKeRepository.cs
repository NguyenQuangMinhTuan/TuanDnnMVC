using Christoc.Modules.TuanMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christoc.Modules.TuanMVC.Interface
{
    interface ISinhVienVThongKeRepository
    {
        Task<IEnumerable<SinhVien_VThongKe>> Gets_ThongKe(string TuKhoaNgayVang);
    }
}
