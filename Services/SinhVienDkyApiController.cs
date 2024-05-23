using Christoc.Modules.TuanMVC.Interface;
using Christoc.Modules.TuanMVC.Models;
using Christoc.Modules.TuanMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Christoc.Modules.TuanMVC.Services
{
    public class SinhVienDkyApiController : ApiBaseController
    {
        private readonly ISinhVienDkyRepository _repository;

        public SinhVienDkyApiController()
        {
            _repository = new SinhVienDkyRepository();
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Add(SinhVien_Dky data)
        {
            try
            {
                SinhVien_Dky item = new SinhVien_Dky();
                item = await _repository.Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}