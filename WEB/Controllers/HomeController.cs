using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB.Data;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SwapPart()
        {
            SwapServices swapServices = new SwapServices(); 

            return View(swapServices.GetSwaps());
        }

        public ActionResult SwapPartDetail(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("SwapPart");
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}