using Christoc.Modules.TuanMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christoc.Modules.TuanMVC.Interface
{
    interface ISinhVienLopRepository
    {
        Task<IEnumerable<SinhVien_Lop>> Gets(string TuKhoa);
    }
}
