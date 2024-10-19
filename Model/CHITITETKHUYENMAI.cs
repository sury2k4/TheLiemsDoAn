namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITITETKHUYENMAI")]
    public partial class CHITITETKHUYENMAI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaKM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaSP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayKetThuc { get; set; }

        public double? MucGiaKhuyenMai { get; set; }

        public virtual KHUYENMAI KHUYENMAI { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
