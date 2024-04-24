using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Christoc.Modules.TuanMVC.Models
{
    public class Demo_SinhVien
    {
        public int MaSinhVien { get; set; }

        public string HoTen { get; set; }

        public string DiaChi { get; set; }

        public DateTime NgaySinh { get; set; }

        public string SoDienThoai { get; set; }

        public int MaKhoa { get; set; }
    }
}