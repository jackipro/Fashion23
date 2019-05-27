using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fashion23.Models;
namespace Fashion23.Controllers
{
    public class GioHangController : Controller
    {
        
                // GET: GioHang

        public List<GioHang> LayGioHang()
        {
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang == null)
            {
                // Neu Gio hang chua ton tai thi tien hanh khoi tao list gio hang 
                lstGioHang = new List<GioHang>(); 

                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
            }

                    //Them gio hang
            Fashion23Entities db = new Fashion23Entities();
            public ActionResult ThemGioHang(int iMaSP, string strURL)
            {
            Product sp = db.Products.SingleOrDefault(n => n.Id == iMaSP);
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.Find(n => n.iMaSP == iMaSP);
            if (sanpham == null)
            {
                sanpham = new GioHang(iMaSP);
                //Add san pham moi them vao list
                lstGioHang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoLuong++;
                return Redirect(strURL);
            }
        }
                 //Cap nhat gio hang
        public ActionResult CapNhatGioHang(int iMaSP, FormCollection f)
        {
            Product sp = db.Products.SingleOrDefault(n => n.Id == iMaSP);
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.Find(n => n.iMaSP == iMaSP );
            if (sp != null)
            {
                sanpham.iSoLuong = int.Parse(f["txtSoLuong"].ToString());
            }
            return View("GioHang"); 
        }
        public ActionResult XoaGioHang(int iMaSP, string strURL)
        {

                //Kiem tra MaSP
            Product sp = db.Products.SingleOrDefault(n => n.Id == iMaSP);
            //Neu get sai MaSP thi tra ve trang loi 404
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Lay gio hang ra tu session
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.Find(n => n.iMaSP == iMaSP);
            //Neu ma ton tai thi chung ta cho xoa so luong
            if (sp != null)
            {
                lstGioHang.RemoveAll(n => n.iMaSP == iMaSP);
                lstGioHang.Remove(sanpham);
                return Redirect(strURL);
            }
            if (lstGioHang.Count == 0)
            {
                return RedirectToAction("Index","Home");
            }
            return RedirectToAction("GioHang");
        }
        //Xay dung trang gio hang
        public ActionResult GioHang()
        {
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<GioHang> lstGioHang = LayGioHang();
            return View(lstGioHang);
        }
        //Tinh tong so luong
        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                iTongSoLuong = lstGioHang.Sum(n => n.iSoLuong);
            }
            return iTongSoLuong;
        }
        //Tinh tong so luong va tong tien
        private double TongTien()
        {
            double dTongTien = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                dTongTien = lstGioHang.Sum(n => n.ThanhTien);
            }
            return dTongTien;
        }
       
        public ActionResult GioHangPartial()
        {
            if (TongSoLuong() == 0)
            {
                return PartialView();
            }
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return PartialView();
        }
        }
}