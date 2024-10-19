using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyCuaHang.ViewModel
{
    public partial class ConveStoreDBContext : DbContext
    {
        public ConveStoreDBContext()
            : base("name=ConveStoreDBContext")
        {
        }

        public virtual DbSet<CALAMVIEC> CALAMVIECs { get; set; }
        public virtual DbSet<CHITIETCALAMVIEC> CHITIETCALAMVIECs { get; set; }
        public virtual DbSet<CHITIETDONDATHANG> CHITIETDONDATHANGs { get; set; }
        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<CHITIETTHANHTOAN> CHITIETTHANHTOANs { get; set; }
        public virtual DbSet<CHITITETKHUYENMAI> CHITITETKHUYENMAIs { get; set; }
        public virtual DbSet<CHUCVUNHANVIEN> CHUCVUNHANVIENs { get; set; }
        public virtual DbSet<DONDATHANG> DONDATHANGs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<LOAICALAMVIEC> LOAICALAMVIECs { get; set; }
        public virtual DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHANHOIKHACHHANG> PHANHOIKHACHHANGs { get; set; }
        public virtual DbSet<PHUONGTHUCTHANHTOAN> PHUONGTHUCTHANHTOANs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<TONKHO> TONKHOes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CALAMVIEC>()
                .Property(e => e.MaCa)
                .IsUnicode(false);

            modelBuilder.Entity<CALAMVIEC>()
                .Property(e => e.MaLoaiCa)
                .IsUnicode(false);

            modelBuilder.Entity<CALAMVIEC>()
                .HasMany(e => e.CHITIETCALAMVIECs)
                .WithRequired(e => e.CALAMVIEC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHITIETCALAMVIEC>()
                .Property(e => e.MaCa)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETCALAMVIEC>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDONDATHANG>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDONDATHANG>()
                .Property(e => e.MaDH)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.SoHD)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETTHANHTOAN>()
                .Property(e => e.MaLTT)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETTHANHTOAN>()
                .Property(e => e.SoHD)
                .IsUnicode(false);

            modelBuilder.Entity<CHITITETKHUYENMAI>()
                .Property(e => e.MaKM)
                .IsUnicode(false);

            modelBuilder.Entity<CHITITETKHUYENMAI>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVUNHANVIEN>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<DONDATHANG>()
                .Property(e => e.MaDH)
                .IsUnicode(false);

            modelBuilder.Entity<DONDATHANG>()
                .HasMany(e => e.CHITIETDONDATHANGs)
                .WithRequired(e => e.DONDATHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.SoHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaPH)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETTHANHTOANs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<KHUYENMAI>()
                .Property(e => e.MaKM)
                .IsUnicode(false);

            modelBuilder.Entity<KHUYENMAI>()
                .HasMany(e => e.CHITITETKHUYENMAIs)
                .WithRequired(e => e.KHUYENMAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAICALAMVIEC>()
                .Property(e => e.MaLoaiCa)
                .IsUnicode(false);

            modelBuilder.Entity<LOAISANPHAM>()
                .Property(e => e.MaTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.CHITIETCALAMVIECs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHANHOIKHACHHANG>()
                .Property(e => e.MaPH)
                .IsUnicode(false);

            modelBuilder.Entity<PHANHOIKHACHHANG>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<PHANHOIKHACHHANG>()
                .Property(e => e.NoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<PHUONGTHUCTHANHTOAN>()
                .Property(e => e.MaLTT)
                .IsUnicode(false);

            modelBuilder.Entity<PHUONGTHUCTHANHTOAN>()
                .HasMany(e => e.CHITIETTHANHTOANs)
                .WithRequired(e => e.PHUONGTHUCTHANHTOAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETDONDATHANGs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITITETKHUYENMAIs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasOptional(e => e.TONKHO)
                .WithRequired(e => e.SANPHAM);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MaTK)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<TONKHO>()
                .Property(e => e.MaSP)
                .IsUnicode(false);
        }
    }
}
