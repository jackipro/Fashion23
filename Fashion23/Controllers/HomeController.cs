using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fashion23.Models;

namespace Fashion23.Controllers
{
    public class HomeController : Controller
    {
        Fashion23Entities db = new Fashion23Entities();
        // GET: Home
        public ActionResult Index()
        {
            var lstPro = db.Products.Take(6).ToList();

            return View(lstPro);
        }
    }
}