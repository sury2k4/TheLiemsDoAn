namespace QuanLyCuaHang.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETCALAMVIEC")]
    public partial class CHITIETCALAMVIEC
    {
        [Key]
        [StringLength(20)]
        public string MaCa { get; set; }  // Khóa chính hoặc khóa ngoại cho CALAMVIEC

        [StringLength(20)]
        public string MaNV { get; set; }

        public bool? TrangThai { get; set; }

        [ForeignKey("MaCa")]  // Chỉ định cột khóa ngoại cho bảng CALAMVIEC
        public virtual CALAMVIEC CALAMVIEC { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
