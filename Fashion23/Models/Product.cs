//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fashion23.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.GioHangs = new HashSet<GioHang>();
            this.GioiTinhs = new HashSet<GioiTinh>();
            this.Shopping_Cart_Details = new HashSet<Shopping_Cart_Details>();
        }
    
        public string Ma_SP { get; set; }
        public string Ten_sp { get; set; }
        public Nullable<decimal> Giaban { get; set; }
        public Nullable<int> Soluong_sp { get; set; }
        public Nullable<System.DateTime> Ngay_tao { get; set; }
        public string Ma_Loai { get; set; }
        public string Hang_sx { get; set; }
        public string Mota_sp { get; set; }
        public string Ma_Size { get; set; }
        public string Ma_mau { get; set; }
        public byte[] Avatar { get; set; }
        public string Ma_DH { get; set; }
        public string Ma_NCC { get; set; }
    
        public virtual Category_Product Category_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioiTinh> GioiTinhs { get; set; }
        public virtual Mau_sac Mau_sac { get; set; }
        public virtual Order Order { get; set; }
        public virtual Size Size { get; set; }
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shopping_Cart_Details> Shopping_Cart_Details { get; set; }
    }
}
