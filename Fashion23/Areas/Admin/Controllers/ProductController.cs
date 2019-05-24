using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fashion23.Models;

namespace Fashion23.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        Fashion23Entities model = new Fashion23Entities();
        // GET: Admin/Product
        public ActionResult Index()
        {
            var product = model.Products.OrderByDescending(x => x.Id).ToList();
            return View(product);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var product = model.Products.FirstOrDefault(x => x.Id == Id);
            ViewBag.idsize_type = model.Sizes.OrderByDescending(x => x.IDSize).ToList();
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit (int Id, Product p)
        {
            var product = model.Products.FirstOrDefault(x => x.Id == Id);
            product.Ten_Sp = p.Ten_Sp;
            product.DonGia = p.DonGia;
            product.Image = p.Image;
            product.MoTa = p.MoTa;
            product.NgaySanPham = p.NgaySanPham;
            product.Size = p.Size;
            product.Soluong = p.Soluong;
            product.Supplier = p.Supplier;
            product.Views = p.Views;
            product.HangCoSan = p.HangCoSan;
            model.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}