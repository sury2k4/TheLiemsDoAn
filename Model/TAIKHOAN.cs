namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [StringLength(20)]
        public string MaTK { get; set; }

        [StringLength(50)]
        public string TenTK { get; set; }

        [StringLength(25)]
        public string MatKhau { get; set; }

        [StringLength(20)]
        public string MaChucVu { get; set; }

        [StringLength(20)]
        public string MaNV { get; set; }

        public virtual CHUCVUNHANVIEN CHUCVUNHANVIEN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
