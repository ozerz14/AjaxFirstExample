using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxFirst.Controllers
{
    public class AjaxUseController : Controller
    {
        //
        // GET: /AjaxUse/

        public ActionResult Index()
        {
            var isim = "isim";

            return View((object)isim);
        }

        public ActionResult KullaniciEkle(string isim)
        {
            return PartialView((object)isim);

        //    return Content("<h2>  ")
        }

        public ActionResult ShowList() {

            List<int> Sayi = new List<int> { 1, 2, 4, 5, 7, 8, 9 };
            return PartialView(Sayi);
            //return Json(Sayi, JsonRequestBehavior.AllowGet);
        }
    }
}
