namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETTHANHTOAN")]
    public partial class CHITIETTHANHTOAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaLTT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SoHD { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayThanhToan { get; set; }

        public double? SoTien { get; set; }

        public virtual PHUONGTHUCTHANHTOAN PHUONGTHUCTHANHTOAN { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
