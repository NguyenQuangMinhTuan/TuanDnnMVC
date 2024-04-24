using DotNetNuke.Services.Exceptions;
using DotNetNuke.Web.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Threading.Tasks;
using Christoc.Modules.TuanMVC.Interface;
using Christoc.Modules.TuanMVC.Repository;
using Christoc.Modules.TuanMVC.Models;

namespace Christoc.Modules.TuanMVC.Services
{
    [AllowAnonymous]
    public class BooksApiController : ApiBaseController
    {
        private readonly IBooksRepository _repository;

        public BooksApiController()
        {
            _repository = new BooksRepository();
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Gets(Request data)
        {
            try
            {
                IEnumerable<Test_Books> lst = null;
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
                Test_Books item = new Test_Books();
                item = await _repository.Get(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Add(Test_Books data)
        {
            try
            {
                Test_Books item = new Test_Books();
                item = await _repository.Add(data);
                return Request.CreateResponse(HttpStatusCode.OK, item, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Edit(Test_Books data)
        {
            try
            {
                Test_Books item = new Test_Books();
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