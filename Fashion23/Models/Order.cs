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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Products = new HashSet<Product>();
        }
    
        public string Ma_DH { get; set; }
        public string Ma_GH { get; set; }
        public string Tinhtrang_DH { get; set; }
        public Nullable<System.DateTime> Ngay_tao { get; set; }
        public string Nguoi_capnhat { get; set; }
        public string Diachi_nguoinhan { get; set; }
    
        public virtual GioHang GioHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}