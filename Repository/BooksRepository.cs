using Christoc.Modules.TuanMVC.Interface;
using Christoc.Modules.TuanMVC.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Christoc.Modules.TuanMVC.Repository
{
    public class BooksRepository : ConnectDatabase, IBooksRepository
    {

        public async Task<IEnumerable<Test_Books>> Gets(string TuKhoa)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@TuKhoa", TuKhoa);
                    IEnumerable<Test_Books> list = conn.Query<Test_Books>("spu_TestBooks_Gets", parameters, commandType: CommandType.StoredProcedure);

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

        public async Task<Test_Books> Get(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@ID", id);
                    Test_Books item = conn.QueryFirstOrDefault<Test_Books>("spu_TestBooks_Get", parameters, commandType: CommandType.StoredProcedure);

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

        public async Task<Test_Books> Add(Test_Books data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Name", data.Name);
                    parameters.Add("@Code", data.Code);
                    parameters.Add("@AuthorID", data.AuthorID);
                    Test_Books item = conn.QueryFirstOrDefault<Test_Books>("spu_TestBooks_Add", parameters, commandType: CommandType.StoredProcedure);

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

        public async Task<Test_Books> Edit(Test_Books data)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@ID", data.ID);
                    parameters.Add("@Name", data.Name);
                    parameters.Add("@Code", data.Code);
                    parameters.Add("@AuthorID", data.AuthorID);
                    Test_Books item = conn.QueryFirstOrDefault<Test_Books>("spu_TestBooks_Edit", parameters, commandType: CommandType.StoredProcedure);

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

        public async Task<int> Delete(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                try
                {
                    await conn.OpenAsync();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@ID", id);
                    int item = conn.QueryFirstOrDefault<int>("spu_TestBooks_Delete", parameters, commandType: CommandType.StoredProcedure);

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