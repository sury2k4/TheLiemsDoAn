namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CALAMVIEC")]
    public partial class CALAMVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CALAMVIEC()
        {
            CHITIETCALAMVIECs = new HashSet<CHITIETCALAMVIEC>();
        }

        [Key]
        [StringLength(20)]
        public string MaCa { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLam { get; set; }

        [StringLength(20)]
        public string MaLoaiCa { get; set; }

        public virtual LOAICALAMVIEC LOAICALAMVIEC { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETCALAMVIEC> CHITIETCALAMVIECs { get; set; }
    }
}
