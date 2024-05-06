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
    public class SinhVienVLopApiController : ApiBaseController
    {
        private readonly ISinhVienVLopRepository _repository;

        public SinhVienVLopApiController()
        {
            _repository = new SinhVienVLopRepository();
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Gets(Request data)
        {
            try
            {
                IEnumerable<SinhVien_VLop> lst = null;
                lst = await _repository.Gets(data.TuKhoa);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Gets3(Request3 data)
        {
            try
            {
                IEnumerable<SinhVien_VLop> lst = null;
                lst = await _repository.Gets3(data.TuKhoaSearch, data.TuKhoaMaLop, data.TuKhoaNgay);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}