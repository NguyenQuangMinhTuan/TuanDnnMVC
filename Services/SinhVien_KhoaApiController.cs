using Christoc.Modules.TuanMVC.Interface;
using Christoc.Modules.TuanMVC.Models;
using Christoc.Modules.TuanMVC.Repository;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Christoc.Modules.TuanMVC.Services
{
    public class SinhVien_KhoaApiController : ApiBaseController
    {
        private readonly ISinhVien_KhoaRepository _repository;

        public SinhVien_KhoaApiController()
        {
            _repository = new SinhVien_KhoaRepository();
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Gets(Request data)
        {
            try
            {
                IEnumerable<Demo_SinhVien_Khoa> lst = null;
                lst = await _repository.Gets(data.TuKhoa);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}