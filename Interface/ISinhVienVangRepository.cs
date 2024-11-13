using Christoc.Modules.TuanMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christoc.Modules.TuanMVC.Interface
{
    interface ISinhVienVangRepository
    {
        Task<IEnumerable<SinhVien_Vang>> Gets(string TuKhoa);
        Task<SinhVien_Vang> Get (int ID);
        Task<SinhVien_Vang> Add (SinhVien_Vang data);
        Task<SinhVien_Vang> Check (int MaSinhVien);
        Task<SinhVien_Vang> Edit (SinhVien_Vang data);
        Task<int> Delete (int ID);
    }
}
