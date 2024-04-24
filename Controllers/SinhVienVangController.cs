using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Christoc.Modules.TuanMVC.Controllers
{
    public class SinhVienVangController : DnnController
    {
        // GET: SinhVienVang
        public ActionResult Index()
        {
            return View();
        }
    }
}