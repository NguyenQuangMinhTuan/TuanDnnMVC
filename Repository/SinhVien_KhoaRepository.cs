using Christoc.Modules.TuanMVC.Interface;
using Christoc.Modules.TuanMVC.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Christoc.Modules.TuanMVC.Repository
{
    public class SinhVien_KhoaRepository : ConnectDatabase, ISinhVien_KhoaRepository
    {
        public async Task<IEnumerable<Demo_SinhVien_Khoa>> Gets(string TuKhoa)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@TuKhoa", TuKhoa);
                    IEnumerable<Demo_SinhVien_Khoa> list = conn.Query<Demo_SinhVien_Khoa>("spu_Demo_SinhVien_Khoa_Gets", parameters, commandType: CommandType.StoredProcedure);

                    return list;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}