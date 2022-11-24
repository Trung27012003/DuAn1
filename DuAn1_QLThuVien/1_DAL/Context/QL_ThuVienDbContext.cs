﻿using Microsoft.EntityFrameworkCore;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.
              UseSqlServer("Data Source=MINGGG\\SQLEXPRESS;Initial Catalog=DuAn_QLThuVien;Integrated Security=True;User ID = Ura; Password = minhanh321"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply cac config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Phương thức này sẽ áp dụng tất cả các config hiện có
        }
    }
}
