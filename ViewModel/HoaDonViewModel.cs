using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.ViewModel
{
    internal class HoaDonViewModel
    {
        public string SoHD { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string Sdt { get; set; }
        public DateTime? NgayLap { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string PhuongThuc { get; set; }
        public string GhiChu { get; set; }
        public string MaNV { get; set; }
        public string MaPH { get; set; }


        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public double DonGiA { get; set; }
        public string MucGiaKhuyenMai { get; set; }
        public double ThanhTien { get; set; }

        
        private ConveStoreDBContext dbContext;
        public HoaDonViewModel()
        {
            dbContext = new ConveStoreDBContext();  
        }
        public List<HoaDonViewModel> LoadChiTietHoaDon(string soHD)
        {
            var list = (from ctHoaDon in dbContext.CHITIETHOADONs.AsNoTracking()
                        join ctKhuyenMai in dbContext.CHITITETKHUYENMAIs.AsNoTracking()
                        on ctHoaDon.MaSP equals ctKhuyenMai.MaSP into khuyenMaiJoin
                        from km in khuyenMaiJoin.DefaultIfEmpty()
                        where ctHoaDon.SoHD == soHD  // So sánh với SoHD là chuỗi
                        select new HoaDonViewModel
                        {
                            MaSP = ctHoaDon.SANPHAM.MaSP,
                            TenSP = ctHoaDon.SANPHAM.TenSP,
                            SoLuong = ctHoaDon.SoLuong ?? 0,
                            DonGiA = ctHoaDon.SANPHAM.DonGiA ?? 0,
                            MucGiaKhuyenMai = km != null ? (km.MucGiaKhuyenMai.HasValue ? km.MucGiaKhuyenMai.Value.ToString() : "0") : "0",
                            ThanhTien = (km != null ? (km.MucGiaKhuyenMai ?? 0) : (ctHoaDon.SANPHAM.DonGiA ?? 0)) * (ctHoaDon.SoLuong ?? 0)
                        }).ToList();
            return list;
        }
        public List<HoaDonViewModel> LoadHoaDon()
        {
            var list = (from hoaDon in dbContext.HOADONs.AsNoTracking()
                        join chiTietThanhToan in dbContext.CHITIETTHANHTOANs.AsNoTracking()
                        on hoaDon.SoHD equals chiTietThanhToan.SoHD
                        join phuongThucThanhToan in dbContext.PHUONGTHUCTHANHTOANs.AsNoTracking()
                        on chiTietThanhToan.MaLTT equals phuongThucThanhToan.MaLTT
                        select new HoaDonViewModel
                        {
                            SoHD = hoaDon.SoHD,
                            NgayLap = hoaDon.NgayLap,
                            GhiChu = hoaDon.GhiChu,
                            MaKH = hoaDon.MaKH,
                            MaNV = hoaDon.MaNV,
                            MaPH = hoaDon.MaPH,
                            PhuongThuc = phuongThucThanhToan.PhuongThuc,  
                            NgayThanhToan = chiTietThanhToan.NgayThanhToan,
                        }).ToList();
            return list;
        }
        


    }
}
