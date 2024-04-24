using Christoc.Modules.TuanMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christoc.Modules.TuanMVC.Interface
{
    internal interface ISinhVien_KhoaRepository
    {
        Task<IEnumerable<Demo_SinhVien_Khoa>> Gets(string TuKhoa);
    }
}
