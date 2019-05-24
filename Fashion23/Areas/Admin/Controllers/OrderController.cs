using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fashion23.Models;

namespace Fashion23.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        Fashion23Entities model1 = new Fashion23Entities();
        // GET: Admin/Order
        public ActionResult Index()
        {
            var order = model1.OrderDetails.OrderByDescending(x => x.Id).ToList();
            return View(order);
        }
    }
}