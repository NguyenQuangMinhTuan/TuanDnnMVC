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
    public class SinhVienVThongKeRepository : ConnectDatabase, ISinhVienVThongKeRepository
    {
        public async Task<IEnumerable<SinhVien_VThongKe>> Gets_ThongKe(string TuKhoaNgayVang)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Ngay", TuKhoaNgayVang);
                    IEnumerable<SinhVien_VThongKe> list = conn.Query<SinhVien_VThongKe>("ThongKe_Vang_Hoc", parameters, commandType: CommandType.StoredProcedure);

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