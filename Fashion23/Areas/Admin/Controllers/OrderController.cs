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
        [HttpGet]
        public ActionResult Creat()
        {
           // var order = model1.OrderDetails.OrderByDescending(x => x.Id).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(int Id , OrderDetail or)
        {
            var orders = new OrderDetail();

            orders.DonGia = or.DonGia;
            orders.Id = or.Id;
            //orders.IDSanPham = or.IDSanPham;
            orders.Order = or.Order;
            orders.Product = or.Product;
            orders.SoLuong = or.SoLuong;
            orders.GiamGia = or.GiamGia;
            model1.OrderDetails.Add(orders);
            model1.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}