using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fashion23.Models;
namespace Fashion23.Controllers
{
    public class NguoiDungController : Controller
    {
        Fashion23Entities model = new Fashion23Entities();
        // GET: NguoiDung
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(Customer cus)
        {
            
            return View();
        }
    }
}