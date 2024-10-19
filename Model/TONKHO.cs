namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TONKHO")]
    public partial class TONKHO
    {
        [Key]
        [StringLength(20)]
        public string MaSP { get; set; }

        public int? SoLuongTonKho { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
