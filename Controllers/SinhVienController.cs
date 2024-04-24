using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Christoc.Modules.TuanMVC.Controllers
{
    [DnnHandleError]
    public class SinhVienController : DnnController
    {
        // GET: SinhVien
        public ActionResult Index()
        {
            return View();
        }
    }
}