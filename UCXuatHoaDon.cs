using QuanLyCuaHang.Utilities;
using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class UCXuatHoaDon : UserControl
    {
        private HoaDonViewModel viewModel;
        private ConveStoreDBContext dbContext;
        private List<HoaDonViewModel> hoaDonList = new List<HoaDonViewModel>();
        public string MaNV { get; set; }

        public UCXuatHoaDon()
        {
            InitializeComponent();
            viewModel = new HoaDonViewModel();
            dbContext = new ConveStoreDBContext();
            
            LoadLoaiSanPhamToComboBox();
            LoadSanPhamToComboBox();

            cbbLoaiSP.SelectedItem = null;
            cbbSanPham.SelectedItem = null;

            dvgXuatHoaDon.RowHeadersVisible = false;
            dvgXuatHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgXuatHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadLoaiSanPhamToComboBox()
        {
            var loaiSanPhamList = dbContext.LOAISANPHAMs.ToList();

            cbbLoaiSP.DataSource = loaiSanPhamList;
            cbbLoaiSP.DisplayMember = "TenTheLoai"; 
            cbbLoaiSP.ValueMember = "MaTheLoai";     
        }
        private void LoadSanPhamToComboBox()
        {
            var sanPhamList = dbContext.SANPHAMs.ToList();

            cbbSanPham.DataSource = sanPhamList;
            cbbSanPham.DisplayMember = "TenSP";
            cbbSanPham.ValueMember = "MaSP";
        }
        private void cbbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiSP.SelectedItem == null || cbbLoaiSP.SelectedValue == null)
            {
                return; 
            }

            var selectedMaTheLoai = cbbLoaiSP.SelectedValue.ToString();

            var sanPhamList = dbContext.SANPHAMs
                .Where(sp => sp.MaTheLoai == selectedMaTheLoai)
                .ToList();

            cbbSanPham.DataSource = sanPhamList;
            cbbSanPham.DisplayMember = "TenSP";
            cbbSanPham.ValueMember = "MaSP";

            cbbSanPham.SelectedItem = null;
        }
        private void bttThemMon_Click(object sender, EventArgs e)
        {
            var selectedSanPham = cbbSanPham.SelectedItem as SANPHAM;
            int soLuong = (int)numericUpDownSoLuong.Value;

            if (selectedSanPham != null)
            {
                var khuyenMai = dbContext.CHITITETKHUYENMAIs.FirstOrDefault(km => km.MaSP == selectedSanPham.MaSP);

                double donGia = selectedSanPham.DonGiA ?? 0;

                double giaSauKhuyenMai = (khuyenMai != null) ? khuyenMai.MucGiaKhuyenMai ?? donGia : donGia;

                var existingItem = hoaDonList.FirstOrDefault(item => item.MaSP == selectedSanPham.MaSP);

                if (existingItem != null)
                {
                    existingItem.SoLuong += soLuong;
                    existingItem.ThanhTien = giaSauKhuyenMai * existingItem.SoLuong;
                }
                else
                {
                    var hoaDonItem = new HoaDonViewModel
                    {
                        MaSP = selectedSanPham.MaSP,
                        TenSP = selectedSanPham.TenSP,
                        SoLuong = soLuong,
                        DonGiA = donGia,
                        MucGiaKhuyenMai = khuyenMai?.MucGiaKhuyenMai.HasValue == true ? khuyenMai.MucGiaKhuyenMai.Value.ToString() : "0",
                        ThanhTien = giaSauKhuyenMai * soLuong
                    };

                    hoaDonList.Add(hoaDonItem);
                }
                dvgXuatHoaDon.DataSource = null;
                dvgXuatHoaDon.DataSource = hoaDonList;
                dvgXuatHoaDon.Columns["SoHD"].Visible = false;
                dvgXuatHoaDon.Columns["MaKH"].Visible = false;
                dvgXuatHoaDon.Columns["NgayLap"].Visible = false;
                dvgXuatHoaDon.Columns["PhuongThuc"].Visible = false;
                dvgXuatHoaDon.Columns["NgayThanhToan"].Visible = false;
                dvgXuatHoaDon.Columns["GhiChu"].Visible = false;
                dvgXuatHoaDon.Columns["MaNV"].Visible = false;
                dvgXuatHoaDon.Columns["MaPH"].Visible = false;
                dvgXuatHoaDon.Columns["TenKH"].Visible = false;
                dvgXuatHoaDon.Columns["Sdt"].Visible = false;
                numericUpDownSoLuong.Value = 0;
                TinhTongTien();
            }
        }
        private void ThemHoaDonMoi()
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                    {
                        MessageBox.Show("Số điện thoại không được để trống. Đang thêm hóa đơn mới...");
                        return;
                    }

                    var khachHang = dbContext.KHACHHANGs
                        .FirstOrDefault(kh => kh.Sdt == txtPhoneNumber.Text);

                    #region nào merge code thì mở
                    //if (khachHang != null)
                    //{
                    //    // Hiển thị tên khách hàng vào txtCustomerName
                    //    txtCustomerName.Text = khachHang.TenKH;
                    //}
                    //else
                    //{
                    //    // Nếu không tìm thấy khách hàng

                    //    var result = MessageBox.Show("Khách hàng không tồn tại. Bạn có muốn thêm khách hàng mới không?", "Thông báo", MessageBoxButtons.YesNo);

                    //    if (result == DialogResult.Yes)
                    //    {
                    //        // Hiển thị UserControl để thêm khách hàng mới
                    //        CustomerInfoUC customerInfo = new CustomerInfoUC();
                    //        var form = new Form
                    //        {
                    //            Text = "Thêm Khách Hàng Mới",
                    //            Size = new Size(400, 300),
                    //            StartPosition = FormStartPosition.CenterParent
                    //        };

                    //        customerInfo.Dock = DockStyle.Fill;
                    //        form.Controls.Add(customerInfo);
                    //        form.ShowDialog();

                    //        // Kiểm tra xem khách hàng đã được thêm hay chưa
                    //        if (customerInfo.IsCustomerAdded)
                    //        {
                    //            khachHang = new KHACHHANG
                    //            {
                    //                MaKH = customerInfo.MaKH,
                    //                TenKH = customerInfo.TenKhachHang,
                    //                Sdt = txtPhoneNumber.Text
                    //            };

                    //            dbContext.KHACHHANGs.Add(khachHang);
                    //            dbContext.SaveChanges();

                    //            // Cập nhật tên khách hàng vào txtCustomerName
                    //            txtCustomerName.Text = khachHang.TenKH;
                    //        }
                    //        else
                    //        {
                    //            MessageBox.Show("Không thêm khách hàng. Vui lòng thử lại.");
                    //            return; // Ngưng thêm hóa đơn
                    //        }
                    //    }
                    //    else
                    //    {
                    //        // Nếu chọn No, tạo hóa đơn mới không cần mã khách hàng
                    //        MessageBox.Show("Đang lưu hóa đơn mới mà không có khách hàng.");
                    //    }
                    //}
                    #endregion

                    var hoaDonMoi = new HOADON
                    {
                        SoHD = CreateNewSoHD(),
                        NgayLap = DateTime.Now,
                        TongTien = hoaDonList.Sum(hd => hd.ThanhTien),
                        MaKH = khachHang?.MaKH,
                        MaNV = UserSession.MaNhanVienDangNhap,
                    };

                    dbContext.HOADONs.Add(hoaDonMoi);
                    dbContext.SaveChanges();

                    foreach (var chiTiet in hoaDonList)
                    {
                        var sanPham = dbContext.SANPHAMs.FirstOrDefault(sp => sp.MaSP == chiTiet.MaSP);

                        if (sanPham != null)
                        {
                            var chiTietMoi = new CHITIETHOADON
                            {
                                SoHD = hoaDonMoi.SoHD,
                                MaSP = chiTiet.MaSP,
                                SoLuong = chiTiet.SoLuong,
                                ThanhTien = (sanPham.DonGiA ?? 0) * chiTiet.SoLuong
                            };

                            dbContext.CHITIETHOADONs.Add(chiTietMoi);
                        }
                        else
                        {
                            MessageBox.Show($"Không tìm thấy sản phẩm với mã {chiTiet.MaSP}");
                        }
                    }

                    dbContext.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Thêm hóa đơn mới thành công!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Lỗi khi thêm hóa đơn: {ex.Message}");
                }
            }
        }
        private void TinhTongTien()
        {
            double tongTien = hoaDonList.Sum(item => item.ThanhTien);
            lblTongTien.Text = tongTien.ToString("N0") + " VND";
        }
        private void bttThanhToan_Click(object sender, EventArgs e)
        {
            if (hoaDonList.Any())
            {
                ThemHoaDonMoi();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào trong hóa đơn để thêm.");
            }
        }
        private string CreateNewSoHD()
        {
            var maxSoHD = dbContext.HOADONs
                .OrderByDescending(hd => hd.SoHD)
                .FirstOrDefault()?.SoHD;

            if (string.IsNullOrEmpty(maxSoHD))
            {
                return "HD001"; 
            }

            int numberPart = int.Parse(maxSoHD.Substring(2)); 
            numberPart++; 

            return "HD" + numberPart.ToString("D3"); 
        }
    }
}
