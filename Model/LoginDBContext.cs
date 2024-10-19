using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.Model
{
    internal class LoginDBContext : ConveStoreDBContext
    {
        public LoginDBContext()
        {

        }   
        
        public DbSet<CHUCVUNHANVIEN> CHUCVUNHANVIEN { get; set; }
        public DbSet<TAIKHOAN> TAIKHOAN { get; set; }
    }
}
