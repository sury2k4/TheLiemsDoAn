using QuanLyCuaHang.Model;
using QuanLyCuaHang.Utilities;
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
    public partial class Login : Form
    {
        ConveStoreDBContext db = new ConveStoreDBContext();
        public event Action<string> OnLoginSuccess;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        #region Method Button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            string roleCurrent = IsLogin(username, password);

            if (!string.IsNullOrEmpty(roleCurrent))
            {
                HomePage formHomePage = new HomePage(roleCurrent);
                formHomePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 

        public string IsLogin(string username, string password)
        {
            var accountCurrent = db.TAIKHOANs.FirstOrDefault
                (u => u.TenTK == username && u.MatKhau == password);

            if (accountCurrent != null)
            {
                UserSession.MaNhanVienDangNhap = accountCurrent.MaNV;
                OnLoginSuccess?.Invoke(accountCurrent.MaNV);
                return accountCurrent.CHUCVUNHANVIEN.TenChucVu;
            }
            else
            {
                return null;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
