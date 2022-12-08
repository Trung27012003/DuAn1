using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Context
{
    internal class QL_ThuVienDbContext:DbContext
    {
        public QL_ThuVienDbContext()
        {

        }
        public QL_ThuVienDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<TheThanhVien> theThanhViens { get; set; }
        public DbSet<TheNgay> theNgays { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<Sach> sachs { get; set; }
        public DbSet<PhieuMuon> phieuMuons { get; set; }
        public DbSet<PhieuMuonChiTiet> phieuMuonChiTiets { get; set; }
        public DbSet<TheLoai> theLoais { get; set; }
        public DbSet<PhieuTra> phieuTras { get; set; }
        public DbSet<PhieuTraChiTiet> phieuTraChiTiets { get; set; }
        public DbSet<ChucVu> chucVus { get; set; }
        public DbSet<Account> Accounts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.
<<<<<<< HEAD
              UseSqlServer("Data Source=VANHUNG;Initial Catalog=DuAn_QLThuVien;Integrated Security=True"));//User ID=trungtruong;Password=123456
=======
              UseSqlServer("Data Source=HOANGQUAN-GD\\SQLEXPRESS;Initial Catalog=DuAn_QLThuVien;Integrated Security=True"));//User ID=trungtruong;Password=123456
>>>>>>> 7b541b0adf41549488f0b212d9312afcd06e7857
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply cac config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Phương thức này sẽ áp dụng tất cả các config hiện có
        }
    }
}
