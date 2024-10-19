using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class UCListHoaDon : UserControl
    {
        private HoaDonViewModel viewModel;
        private DateTime? selectedDate = null;

        public UCListHoaDon()
        {
            InitializeComponent();
            viewModel = new HoaDonViewModel();
            LoadListHoaDon();

            dateTimePickerNgayLap.CustomFormat = " ";
            dateTimePickerNgayLap.Format = DateTimePickerFormat.Custom;

            dvgListHoaDon.RowHeadersVisible = false;
            dvgListHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgListHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgListHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void LoadListHoaDon()
        {
            var hoaDonList = viewModel.LoadHoaDon();
            dvgListHoaDon.DataSource = hoaDonList;

            dvgListHoaDon.Columns["MaSP"].Visible = false;
            dvgListHoaDon.Columns["TenSP"].Visible = false;
            dvgListHoaDon.Columns["SoLuong"].Visible = false;
            dvgListHoaDon.Columns["DonGiA"].Visible = false;
            dvgListHoaDon.Columns["MucGiaKhuyenMai"].Visible = false;
            dvgListHoaDon.Columns["ThanhTien"].Visible = false;
            dvgListHoaDon.Columns["TenKH"].Visible = false;
            dvgListHoaDon.Columns["Sdt"].Visible = false;

        }
        private void dateTimePickerNgayLap_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerNgayLap.CustomFormat = "dd/MM/yyyy";
            selectedDate = dateTimePickerNgayLap.Value;
        }
        private void dvgListHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  
            {
                DataGridViewRow row = dvgListHoaDon.Rows[e.RowIndex];
                string soHD = row.Cells["SoHD"].Value?.ToString();  
                string maKH = row.Cells["MaKH"].Value?.ToString(); 

                if (!string.IsNullOrEmpty(soHD) && !string.IsNullOrEmpty(maKH))
                {
                    string customerName = GetCustomerNameByMaKH(maKH);

                    if (!string.IsNullOrEmpty(customerName))
                    {
                        ChiTietHoaDonForm chiTietForm = new ChiTietHoaDonForm(soHD, customerName);
                        chiTietForm.ShowDialog();  
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tên khách hàng cho Mã Khách Hàng này.");
                    }
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn hoặc mã khách hàng không hợp lệ.");
                }
            }
        }
        private string GetCustomerNameByMaKH(string maKH)
        {
            using (var dbContext = new ConveStoreDBContext())
            {
                var customerName = (from khachHang in dbContext.KHACHHANGs
                                    where khachHang.MaKH == maKH
                                    select khachHang.TenKH).FirstOrDefault();  
                return customerName;
            }
        }
        private void ResetSearchFields()
        {
            txtSoHD.Clear();
            txtCustomerPhoneNumer.Clear();
            dateTimePickerNgayLap.CustomFormat = " ";
            dateTimePickerNgayLap.Format = DateTimePickerFormat.Custom;
        }
        private void bttFind_Click(object sender, EventArgs e)
        {
            string maHD = txtSoHD.Text.Trim();
            string customerPhoneNumber = txtCustomerPhoneNumer.Text.Trim();
            DateTime? ngayLap = dateTimePickerNgayLap.Value != null && dateTimePickerNgayLap.CustomFormat != " "
                                ? dateTimePickerNgayLap.Value.Date
                                : (DateTime?)null;

            List<HoaDonViewModel> hoaDonList = viewModel.LoadHoaDon();
            ResetSearchFields();


            if (!string.IsNullOrEmpty(maHD))
            {
                hoaDonList = hoaDonList.Where(hd => hd.SoHD.Contains(maHD)).ToList();
            }

            if (!string.IsNullOrEmpty(customerPhoneNumber))
            {
                using (var dbContext = new ConveStoreDBContext())
                {
                    var maKH = (from khachHang in dbContext.KHACHHANGs
                                where khachHang.Sdt == customerPhoneNumber
                                select khachHang.MaKH).FirstOrDefault();

                    if (!string.IsNullOrEmpty(maKH))
                    {
                        hoaDonList = hoaDonList.Where(hd => hd.MaKH == maKH).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Khách hàng với số điện thoại này.");
                        return;
                    }
                }
            }

            if (ngayLap.HasValue)
            {
                hoaDonList = hoaDonList.Where(hd => hd.NgayLap.HasValue && hd.NgayLap.Value.Date == ngayLap.Value).ToList();
            }

            if (hoaDonList.Any())
            {
                dvgListHoaDon.DataSource = hoaDonList;
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào.");
            }
        }
        private void bttRefresh_Click(object sender, EventArgs e)
        {
            ResetSearchFields();
            LoadListHoaDon();
        }

        
    }
}
