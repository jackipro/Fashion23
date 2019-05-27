using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fashion23.Models
{
    public class GioHang
    {
        Fashion23Entities db = new Fashion23Entities();
        public int iMaSP { get; set; }
        public string sTenSP { get; set; }
        public string sHinhAnh { get; set; }
        public double dDonGia { get; set; }
        public int iSoLuong { get; set; }
        public double ThanhTien
        {
            get { return dDonGia * iSoLuong; }
        }
        public GioHang (int MaSP)
        {
            iMaSP = MaSP;
            Product sp = db.Products.SingleOrDefault(n => n.Id == iMaSP);
            sTenSP = sp.Ten_Sp;
            sHinhAnh = sp.Image;
            dDonGia = double.Parse(sp.DonGia.ToString());
            iSoLuong = 1;

        }
    }
}