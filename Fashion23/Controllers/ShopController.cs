using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fashion23.Models;
using PagedList;
using PagedList.Mvc;
namespace Fashion23.Controllers
{
    public class ShopController : Controller
    {
        Fashion23Entities db = new Fashion23Entities();
        // GET: Shop
        public ActionResult Index(int? page)
        {
            //Tao bien so san pham tren trang
            int pageSize = 10;
            //Tao bien so trang
            int pageNumber = (page ?? 1);
            
            return View(db.Products.ToList().OrderBy(n => n.DonGia).ToPagedList(pageNumber,pageSize));
        }
        
    }
}