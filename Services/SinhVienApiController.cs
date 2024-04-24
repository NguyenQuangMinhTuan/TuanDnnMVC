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
using System.Web.Http;

namespace Christoc.Modules.TuanMVC.Services
{
    [AllowAnonymous]
    public class SinhVienApiController : ApiBaseController
    {
        private readonly ISinhVienRepository _repository;

        public SinhVienApiController()
        {
            _repository = new SinhVienRepository();
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Gets(Request data)
        {
            try
            {
                IEnumerable<Demo_SinhVien> lst = null;
                lst = await _repository.Gets(data.TuKhoa);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Get(int data)
        {
            try
            {
                Demo_SinhVien item = new Demo_SinhVien();
                item = await _repository.Get(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Add(Demo_SinhVien data)
        {
            try
            {
                Demo_SinhVien item = new Demo_SinhVien();
                item = await _repository.Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Edit(Demo_SinhVien data)
        {
            try
            {
                Demo_SinhVien item = new Demo_SinhVien();
                item = await _repository.Edit(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Delete(int data)
        {
            try
            {
                int item = await _repository.Delete(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}