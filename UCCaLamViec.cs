using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class CaLamViecUC : UserControl
    {
        private CaLamViecModel viewModel;
        private ConveStoreDBContext dbContext;
        List<CaLamViecModel> CaLamViecs;
        private DateTime? selectedDate = null;

        public CaLamViecUC()
        {  
            InitializeComponent();
            dbContext = new ConveStoreDBContext();
            viewModel = new CaLamViecModel();
            LoadCaLamViecData();
            LoadTenCaVaoComboBox();
            LoadNhanVienVaoComboBox();

            dateTimePickerNgayLam.CustomFormat = " ";
            dateTimePickerNgayLam.Format = DateTimePickerFormat.Custom;

            cbbCaLam.SelectedItem = null;
            cbbChooseNV.SelectedItem = null;

            dvgCaLamViec.CellFormatting += dvgCaLamViec_CellFormatting;
            dvgCaLamViec.RowHeadersVisible = false;
            dvgCaLamViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgCaLamViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgCaLamViec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void dateTimePickerNgayLam_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerNgayLam.CustomFormat = "dd/MM/yyyy";
            selectedDate = dateTimePickerNgayLam.Value;
        }
        public void LoadCaLamViecData()
        {
            var caLamViecList = viewModel.LoadData();
            dvgCaLamViec.DataSource = caLamViecList;

            dvgCaLamViec.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
            dvgCaLamViec.Columns["TenCa"].HeaderText = "Ca Làm Việc";
            dvgCaLamViec.Columns["MaLoaiCa"].Visible = false;
            dvgCaLamViec.Columns["MaCa"].Visible = false;
            dvgCaLamViec.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
            dvgCaLamViec.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
            dvgCaLamViec.Columns["NgayLam"].HeaderText = "Ngày Làm";
            dvgCaLamViec.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }
        private void LoadTenCaVaoComboBox()
        {
            CaLamViecs = dbContext.LOAICALAMVIECs.Select(k => new CaLamViecModel
            {   
                MaLoaiCa = k.MaLoaiCa,
                TenCa = k.TenCa,               
            }).ToList();
            BindCaLamToComboBox(CaLamViecs);
        }
        private void LoadNhanVienVaoComboBox()
        {
            var nhanViens = dbContext.NHANVIENs
                .Select(nv => new
                {
                    MaNV = nv.MaNV,  
                    TenNV = nv.TenNV,  
                    HienThiNV = nv.TenNV + " - " + nv.MaNV  
                })
                .ToList();

          
            cbbChooseNV.DataSource = nhanViens;
            cbbChooseNV.DisplayMember = "HienThiNV";  
            cbbChooseNV.ValueMember = "MaNV"; 
        }
        private void BindCaLamToComboBox(List<CaLamViecModel> caLamViecViewModels)
        {
            cbbCaLam.DataSource = caLamViecViewModels;
            cbbCaLam.DisplayMember = "TenCa";
            cbbCaLam.ValueMember = "MaLoaiCa";
        }
        private void dvgCaLamViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dvgCaLamViec.Rows[e.RowIndex];

                string maNV = row.Cells["MaNV"].Value.ToString();
                string tenNV = row.Cells["TenNV"].Value.ToString();

                foreach (var item in cbbChooseNV.Items)
                {
                    dynamic nv = item; 
                    if (nv.MaNV == maNV)
                    {
                        cbbChooseNV.SelectedItem = item;
                        break;
                    }
                }

                txtMaCa.Text = row.Cells["MaCa"].Value.ToString();
                cbbCaLam.Text = row.Cells["TenCa"].Value.ToString();
                dateTimePickerNgayLam.Value = DateTime.Parse(row.Cells["NgayLam"].Value.ToString());
            }
        }
        private void dvgCaLamViec_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dvgCaLamViec.Columns[e.ColumnIndex].Name == "GioBatDau" ||
                dvgCaLamViec.Columns[e.ColumnIndex].Name == "GioKetThuc")
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    e.Value = ((DateTime)e.Value).ToString("HH:mm");
                    e.FormattingApplied = true; 
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maNhanVien = cbbChooseNV.SelectedValue?.ToString() ?? string.Empty;

            string tenCa = cbbCaLam.Text.Trim();

            string ngayLam = dateTimePickerNgayLam.CustomFormat == " " ? string.Empty : dateTimePickerNgayLam.Value.ToString("yyyy-MM-dd");

            List<CaLamViecModel> ketQuaTimKiem = viewModel.TimKiemTheoTieuChi(ngayLam, maNhanVien, tenCa);

            dvgCaLamViec.DataSource = ketQuaTimKiem;
            ResetSearchFields();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var CaLamViecHienTai = dbContext.CHITIETCALAMVIECs.FirstOrDefault(c => c.MaCa.Trim() == txtMaCa.Text.Trim());

                if (CaLamViecHienTai != null)
                {
                    string maNhanVien = cbbChooseNV.SelectedValue?.ToString() ?? "NV000"; // Lấy mã NV hoặc "NV000" nếu không có lựa chọn

                    if (CaLamViecHienTai.MaNV == "NV000")
                    {
                        CaLamViecHienTai.MaNV = maNhanVien;
                        dbContext.SaveChanges();

                        MessageBox.Show("Thêm ca làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CaLamViecHienTai.MaNV = maNhanVien;
                        dbContext.SaveChanges();

                        MessageBox.Show("Sửa ca làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadCaLamViecData();
                    ResetSearchFields();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ca làm việc với mã ca này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetSearchFields();
            LoadCaLamViecData();
        }
        private void ResetSearchFields()
        {
            cbbChooseNV.SelectedIndex = -1;

            cbbCaLam.SelectedIndex = -1;

            dateTimePickerNgayLam.CustomFormat = " ";
            dateTimePickerNgayLam.Format = DateTimePickerFormat.Custom;
        }
       
    }
}
