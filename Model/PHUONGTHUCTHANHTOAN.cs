namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHUONGTHUCTHANHTOAN")]
    public partial class PHUONGTHUCTHANHTOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHUONGTHUCTHANHTOAN()
        {
            CHITIETTHANHTOANs = new HashSet<CHITIETTHANHTOAN>();
        }

        [Key]
        [StringLength(20)]
        public string MaLTT { get; set; }

        [StringLength(50)]
        public string PhuongThuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTHANHTOAN> CHITIETTHANHTOANs { get; set; }
    }
}
