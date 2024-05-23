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
    public class SinhVienDkyRepository : ConnectDatabase, ISinhVienDkyRepository
    {
        public async Task<SinhVien_Dky> Add(SinhVien_Dky data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaSinhVien", data.MaSinhVien);
                    parameters.Add("@NgayDangKy", data.NgayDangKy);
                    parameters.Add("@MaLop", data.MaLop);
                    SinhVien_Dky item = conn.QueryFirstOrDefault<SinhVien_Dky>("spu_Demo_SinhVienDky_Add", parameters, commandType: CommandType.StoredProcedure);

                    return item;
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