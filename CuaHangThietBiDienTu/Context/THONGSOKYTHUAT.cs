//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuaHangThietBiDienTu.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class THONGSOKYTHUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THONGSOKYTHUAT()
        {
            this.SANPHAMs = new HashSet<SANPHAM>();
        }
    
        public string MATSKT { get; set; }
        public string HEDIEUHANH { get; set; }
        public Nullable<int> RAM { get; set; }
        public string ROM { get; set; }
        public Nullable<double> KICHCOMANHINH { get; set; }
        public string VIXULY { get; set; }
        public Nullable<int> PIN { get; set; }
        public string CAMERA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}
