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
    public class SinhVienLopApiController : ApiBaseController
    {
        private readonly ISinhVienLopRepository _repository;

        public SinhVienLopApiController()
        {
            _repository = new SinhVienLopRepository();
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Gets(Request data)
        {
            try
            {
                IEnumerable<SinhVien_Lop> lst = null;
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