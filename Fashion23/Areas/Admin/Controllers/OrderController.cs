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
            var orders = model1.OrderDetails.OrderByDescending(x => x.Id).ToList();
            return View(orders);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var orders = model1.OrderDetails.FirstOrDefault(x => x.Id == Id);
            // ViewBag.MatKhau_Type = model.Customers.OrderByDescending(x => x.Id).ToList();
            // ViewBag.NhaCungCap_Type = model.Products.OrderByDescending(x => x.Id).ToList();
            //ViewBag.OrderId_Type = model1.OrderDetails.OrderByDescending(x => x.Id).ToList();
            return View(orders);
        }
        [HttpPost]
        public ActionResult Edit(int Id, OrderDetail or)
        {
            var orders = model1.OrderDetails.FirstOrDefault(x => x.Id == Id);
            orders.DonGia = or.DonGia;
            //orders.Id = or.Id;
            //orders.IDSanPham = or.IDSanPham;
           // orders.OrderId = or.OrderId;
            orders.SoLuong = or.SoLuong;
            orders.GiamGia = or.GiamGia;
            model1.SaveChanges();
            //dbo.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Create()
        {
           // var order = model1.OrderDetails.OrderByDescending(x => x.Id).ToList();
          // ViewBag.OrderId_Type = model1.OrderDetails.OrderByDescending(x => x.Id).ToList();
            return View();

        }
        [HttpPost]
        public ActionResult Create(OrderDetail or)
        {
            var orders = new OrderDetail();

            orders.DonGia = or.DonGia;
            //orders.Id = or.Id;
           // orders.IDSanPham = or.IDSanPham;
           // orders.OrderId = or.OrderId;
            orders.SoLuong = or.SoLuong;
            orders.GiamGia = or.GiamGia;
            model1.OrderDetails.Add(orders);
            model1.SaveChanges();
            //dbo.Save();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var orders = model1.OrderDetails.FirstOrDefault(x => x.Id == Id);
            return View(orders);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int Id)
        {
            var orders = model1.OrderDetails.FirstOrDefault(x => x.Id == Id);
            model1.OrderDetails.Remove(orders);
            model1.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int Id)
        {
            var orders = model1.OrderDetails.FirstOrDefault(x => x.Id == Id);
            return View(orders);
        }

    }
}