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
    public class SinhVienVLopRepository : ConnectDatabase, ISinhVienVLopRepository
    {
        public Task<SinhVien_VLop> Add(SinhVien_VLop data)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<SinhVien_VLop> Edit(SinhVien_VLop data)
        {
            throw new NotImplementedException();
        }

        public Task<SinhVien_VLop> Get(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SinhVien_VLop>> Gets(string TuKhoa)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@TuKhoa", TuKhoa);
                    IEnumerable<SinhVien_VLop> list = conn.Query<SinhVien_VLop>("spu_Demo_SinhVien_VLop_Gets", parameters, commandType: CommandType.StoredProcedure);

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