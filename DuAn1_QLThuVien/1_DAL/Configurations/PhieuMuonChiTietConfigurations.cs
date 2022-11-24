﻿using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Configurations
{
    public class PhieuMuonChiTietConfigurations: IEntityTypeConfiguration<PhieuMuonChiTiet>
    {
        public void Configure(EntityTypeBuilder<PhieuMuonChiTiet> buider)
        {
            buider.ToTable("PhieuMuonChiTiet");
            buider.HasKey(x => x.Id);

            buider.Property(p => p.IdPM).IsRequired();
            buider.Property(p => p.IdSach).IsRequired();

            buider.Property(p => p.SoLuong).HasColumnName("SoLuong").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.DieuKien).HasColumnName("DieuKien").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.GhiChu).HasColumnName("GhiChu").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.TienTheChan).HasColumnName("TienTheChan").HasColumnType("Money").IsRequired();

            buider.HasOne(p => p.Sach).WithMany().HasForeignKey(p => p.IdSach);
            buider.HasOne(p=>p.PhieuMuon).WithMany().HasForeignKey(p => p.IdPM);
        }
    }
}
