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
using System.Web.Mvc;

namespace Christoc.Modules.TuanMVC.Services
{
    [AllowAnonymous]

    public class SinhVienVThongKeApiController : ApiBaseController
    {
        // GET: SinhVienVThongKeApi
        private readonly ISinhVienVThongKeRepository _repository;

        public SinhVienVThongKeApiController()
        {
            _repository = new SinhVienVThongKeRepository();
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> GetsThongKe(Request_Thongke data)
        {
            try
            {
                IEnumerable<SinhVien_VThongKe> lst = null;
                lst = await _repository.Gets_ThongKe(data.TuKhoaNgayVang);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}