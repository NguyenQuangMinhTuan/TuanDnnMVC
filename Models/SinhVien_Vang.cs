using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Christoc.Modules.TuanMVC.Models
{
    public class SinhVien_Vang
    {
        public int MaVang { get; set; }

        public int MaSinhVien { get; set; }

        public string HoTen { get; set; }

        public DateTime NgayVang { get; set; }

        public string LyDo { get; set; }
    }
}