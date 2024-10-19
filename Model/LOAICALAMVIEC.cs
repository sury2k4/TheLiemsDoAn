namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAICALAMVIEC")]
    public partial class LOAICALAMVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAICALAMVIEC()
        {
            CALAMVIECs = new HashSet<CALAMVIEC>();
        }

        [Key]
        [StringLength(20)]
        public string MaLoaiCa { get; set; }

        [StringLength(50)]
        public string TenCa { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? GioBatDau { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? GioKetThuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CALAMVIEC> CALAMVIECs { get; set; }
    }
}
