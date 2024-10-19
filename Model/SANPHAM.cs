namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETDONDATHANGs = new HashSet<CHITIETDONDATHANG>();
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
            CHITITETKHUYENMAIs = new HashSet<CHITITETKHUYENMAI>();
        }

        [Key]
        [StringLength(20)]
        public string MaSP { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        public double? DonGiA { get; set; }

        [StringLength(20)]
        public string MaNCC { get; set; }

        [StringLength(20)]
        public string MaTheLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONDATHANG> CHITIETDONDATHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITITETKHUYENMAI> CHITITETKHUYENMAIs { get; set; }

        public virtual LOAISANPHAM LOAISANPHAM { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        public virtual TONKHO TONKHO { get; set; }
    }
}
