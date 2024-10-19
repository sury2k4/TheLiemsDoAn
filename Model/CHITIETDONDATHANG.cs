namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONDATHANG")]
    public partial class CHITIETDONDATHANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaSP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaDH { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public virtual DONDATHANG DONDATHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
