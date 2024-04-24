using Christoc.Modules.TuanMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christoc.Modules.TuanMVC.Interface
{
    internal interface IBooksRepository
    {
        Task<IEnumerable<Test_Books>> Gets(string TuKhoa);
        Task<Test_Books> Get(int ID);
        Task<Test_Books> Add(Test_Books data);
        Task<Test_Books> Edit(Test_Books data);
        Task<int> Delete(int ID);
    }
}
