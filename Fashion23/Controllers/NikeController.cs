﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fashion23.Models;


namespace Fashion23.Controllers
{

    public class NikeController : Controller
    {

        Fashion23Entities db = new Fashion23Entities();
        // GET: Nike
        public ActionResult Index()
        {
            return View(db.Products.Where(n => n.Id_NhaCungCap == 1).ToList());            
            
        }
    }
}