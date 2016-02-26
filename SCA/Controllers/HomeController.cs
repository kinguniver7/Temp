using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCA.Controllers
{
    public class HomeController : Controller
    {
        
        #region ctr

        public HomeController()
        {
        }

        #endregion

        public ActionResult Index()
        {
            return View();
        }
        
        public JsonResult Test([DataSourceRequest]DataSourceRequest request)
        {
            var response = new DataSourceResult();
            return Json(response, JsonRequestBehavior.AllowGet);
        }

    }
}