namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANHOIKHACHHANG")]
    public partial class PHANHOIKHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHANHOIKHACHHANG()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(20)]
        public string MaPH { get; set; }

        [StringLength(20)]
        public string MaKH { get; set; }

        [Column(TypeName = "text")]
        public string NoiDung { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayPhanHoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
