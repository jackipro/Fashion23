using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fashion23.Models;

namespace Fashion23.Controllers
{
    public class FilaController : Controller
    {
        Fashion23Entities db = new Fashion23Entities();
        // GET: Fila
        public ActionResult Index()
        {
            return View(db.Products.Where(n => n.Id_NhaCungCap == 3).ToList());
        }
    }
}