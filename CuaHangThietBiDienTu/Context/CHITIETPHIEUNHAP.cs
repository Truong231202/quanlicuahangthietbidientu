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
    
    public partial class CHITIETPHIEUNHAP
    {
        public string MAPN { get; set; }
        public string MASP { get; set; }
        public int SOLUONG { get; set; }
        public int DONGIANHAP { get; set; }
    
        public virtual PHIEUNHAP PHIEUNHAP { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
