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
           // ViewBag.MatKhau_Type = model.Customers.OrderByDescending(x => x.Id).ToList();
               ViewBag.NhaCungCap_Type = model.Products.OrderByDescending(x => x.Id).ToList();
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
            product.Id_NhaCungCap= p.Id_NhaCungCap;
            product.Soluong = p.Soluong;
          // product.Supplier = p.Supplier;
            //product.Views = p.Views;
            product.HangCoSan = p.HangCoSan;
            model.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Create ()
        {
           // var product = model.Products.FirstOrDefault(x => x.Id == Id);
           // var product = model.Products.OrderByDescending(x => x.Id).ToList();
           // ViewBag.NhaCungCap_Type = model.Products.OrderByDescending(x => x.Id).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            var product = new Product();
            product.Id = p.Id;
            product.Ten_Sp = p.Ten_Sp;
            product.DonGia = p.DonGia;
            product.Image = p.Image;
            product.MoTa = p.MoTa;
            product.NgaySanPham = p.NgaySanPham;
           // product.Id_NhaCungCap= p.Id_NhaCungCap;
            product.Soluong = p.Soluong;
           // product.Supplier = p.Supplier;
            //product.Views = p.Views;
            product.HangCoSan = p.HangCoSan;
            model.Products.Add(product);
            model.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var product = model.Products.FirstOrDefault(x => x.Id == Id);
            return View(product);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int Id)
        {
            var product = model.Products.FirstOrDefault(x => x.Id == Id);
            model.Products.Remove(product);
            model.SaveChanges();
            return View(product);
        }
        [HttpGet]
        public ActionResult Details(int Id)
        {
            var product = model.Products.FirstOrDefault(x => x.Id == Id);
            return View(product);
        }
        

    }
}