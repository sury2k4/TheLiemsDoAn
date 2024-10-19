namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADON")]
    public partial class CHITIETHOADON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SoHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaSP { get; set; }

        public int? SoLuong { get; set; }

        public double? ThanhTien { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
