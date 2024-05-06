using Christoc.Modules.TuanMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christoc.Modules.TuanMVC.Interface
{
    interface ISinhVienVLopRepository
    {
        Task<IEnumerable<SinhVien_VLop>> Gets(string TuKhoa);
        Task<IEnumerable<SinhVien_VLop>> Gets3(string TuKhoa, int MaLop, string NgayVang);
        Task<SinhVien_VLop> Get(int ID);
        Task<SinhVien_VLop> Add(SinhVien_VLop data);
        Task<SinhVien_VLop> Edit(SinhVien_VLop data);
        Task<int> Delete(int ID);
    }
}
