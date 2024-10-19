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
    public partial class HomePage : Form
    {
        private CaLamViecModel viewModel;
        public HomePage(string roleCurrent)
        {
            InitializeComponent();
            viewModel = new CaLamViecModel();
            DisplayRoleCurrent(roleCurrent);
        }
        public HomePage()
        {
            InitializeComponent();
        }

        private void DisplayRoleCurrent(string roleCurrrent)
        {
            string text = "Bạn đang truy cập với quyền" + roleCurrrent;
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        private void caLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaLamViecUC userControl = new CaLamViecUC();
            panel1.Visible = true;
            panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
           
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void xuấtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCXuatHoaDon userControl2 = new UCXuatHoaDon();
            panel1.Visible = true;
            panel1.Controls.Clear();
            userControl2.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl2);
        }

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCListHoaDon userControl3 = new UCListHoaDon();
            panel1.Visible = true;
            panel1.Controls.Clear();
            userControl3.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl3);
        }
     

    }
}
