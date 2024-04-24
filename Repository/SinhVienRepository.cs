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
    public class SinhVienRepository : ConnectDatabase, ISinhVienRepository
    {
        public async Task<Demo_SinhVien> Add(Demo_SinhVien data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@HoTen", data.HoTen);
                    parameters.Add("@DiaChi", data.DiaChi);
                    parameters.Add("@NgaySinh", data.NgaySinh);
                    parameters.Add("@SoDienThoai", data.SoDienThoai);
                    parameters.Add("@MaKhoa", data.MaKhoa);
                    Demo_SinhVien item = conn.QueryFirstOrDefault<Demo_SinhVien>("spu_Demo_Module_SinhVien_Add", parameters, commandType: CommandType.StoredProcedure);

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
                    parameters.Add("@MaSinhVien", Data);
                    int item = conn.QueryFirstOrDefault<int>("spu_Demo_Module_SinhVien_Delete", parameters, commandType: CommandType.StoredProcedure);

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

        public async Task<Demo_SinhVien> Edit(Demo_SinhVien data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@MaSinhVien", data.MaSinhVien);
                    parameters.Add("@HoTen", data.HoTen);
                    parameters.Add("@DiaChi", data.DiaChi);
                    parameters.Add("@NgaySinh", data.NgaySinh);
                    parameters.Add("@SoDienThoai", data.SoDienThoai);
                    parameters.Add("@MaKhoa", data.MaKhoa);
                    Demo_SinhVien item = conn.QueryFirstOrDefault<Demo_SinhVien>("spu_Demo_Module_SinhVien_Edit", parameters, commandType: CommandType.StoredProcedure);

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

        public Task<Demo_SinhVien> Get(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Demo_SinhVien>> Gets(string TuKhoa)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@TuKhoa", TuKhoa);
                    IEnumerable<Demo_SinhVien> list = conn.Query<Demo_SinhVien>("spu_Demo_Module_SinhVien_Gets", parameters, commandType: CommandType.StoredProcedure);

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