using Christoc.Modules.TuanMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christoc.Modules.TuanMVC.Interface
{
    interface ISinhVienRepository
    {
        Task<IEnumerable<Demo_SinhVien>> Gets(string TuKhoa);
        Task<Demo_SinhVien> Get(int ID);
        Task<Demo_SinhVien> Add(Demo_SinhVien data);
        Task<Demo_SinhVien> Edit(Demo_SinhVien data);
        Task<int> Delete(int ID);
    }
}
