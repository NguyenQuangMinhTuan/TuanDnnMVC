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
    public class SinhVienVangRepository : ConnectDatabase, ISinhVienVangRepository
    {
        public async Task<SinhVien_Vang> Add(SinhVien_Vang data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaSinhVien", data.MaSinhVien);
                    parameters.Add("@HoTen", data.HoTen);
                    parameters.Add("@NgayVang", data.NgayVang);
                    parameters.Add("@LyDo", data.LyDo);
                    SinhVien_Vang item = conn.QueryFirstOrDefault<SinhVien_Vang>("spu_Demo_SinhVien_Vang_Add", parameters, commandType: CommandType.StoredProcedure);

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

        public async Task<int> Delete(int Data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaVang", Data);
                    int item = conn.QueryFirstOrDefault<int>("spu_Demo_SinhVien_Vang_Delete", parameters, commandType: CommandType.StoredProcedure);

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

        public async Task<SinhVien_Vang> Edit(SinhVien_Vang data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaVang", data.MaVang);
                    parameters.Add("@MaSinhVien", data.MaSinhVien);
                    parameters.Add("@HoTen", data.HoTen);
                    parameters.Add("@NgayVang", data.NgayVang);
                    parameters.Add("@LyDo", data.LyDo);
                    SinhVien_Vang item = conn.QueryFirstOrDefault<SinhVien_Vang>("spu_Demo_SinhVien_Vang_Edit", parameters, commandType: CommandType.StoredProcedure);

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

        public Task<SinhVien_Vang> Get(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SinhVien_Vang>> Gets(string TuKhoa)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@TuKhoa", TuKhoa);
                    IEnumerable<SinhVien_Vang> list = conn.Query<SinhVien_Vang>("spu_Demo_SinhVien_Vang_Gets", parameters, commandType: CommandType.StoredProcedure);

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