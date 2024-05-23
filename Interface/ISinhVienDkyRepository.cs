using Christoc.Modules.TuanMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Christoc.Modules.TuanMVC.Interface
{
    internal interface ISinhVienDkyRepository
    {
        Task<SinhVien_Dky> Add(SinhVien_Dky data);
    }
}