//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDoAn
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeAn
    {
        public string IDDeAn { get; set; }
        public string TenDeAn { get; set; }
        public string Type { get; set; }
        public string IDNhomSV { get; set; }
        public string GVHD { get; set; }
        public string MonHoc { get; set; }
        public string ChuyenNganh { get; set; }
        public string MoTa { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<double> TienDo { get; set; }
        public string TaiLieu { get; set; }
        public string Diem { get; set; }
    
        public virtual ChuyenNganh ChuyenNganh1 { get; set; }
        public virtual GiangVien GiangVien { get; set; }
        public virtual MonHoc MonHoc1 { get; set; }
        public virtual NhomSinhVien NhomSinhVien { get; set; }
        public virtual Type Type1 { get; set; }
        public virtual TienDo TienDo1 { get; set; }
    }
}
