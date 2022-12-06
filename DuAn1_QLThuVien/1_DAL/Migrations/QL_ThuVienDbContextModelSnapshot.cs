﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL.Context;

#nullable disable

namespace _1_DAL.Migrations
{
    [DbContext(typeof(QL_ThuVienDbContext))]
    partial class QL_ThuVienDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1_DAL.Models.Account", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("UserName");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PassWord");

                    b.HasKey("UserName");

                    b.ToTable("Account", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenCV");

                    b.HasKey("Id");

                    b.ToTable("ChucVu", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("DiaChi");

                    b.Property<Guid?>("IdCV")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenNhanVien");

                    b.Property<DateTime?>("NgaySinh")
                        .IsRequired()
                        .HasColumnType("DateTime")
                        .HasColumnName("NgaySinh");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("char(10)")
                        .HasColumnName("SDT");

                    b.HasKey("Id");

                    b.HasIndex("IdCV");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.PhieuMuon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GhiChu");

                    b.Property<Guid?>("IdNV")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTheTV")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayMuon")
                        .IsRequired()
                        .HasColumnType("DateTime")
                        .HasColumnName("NgayMuon");

                    b.Property<DateTime?>("NgayTra")
                        .IsRequired()
                        .HasColumnType("DateTime")
                        .HasColumnName("NgayTra");

                    b.HasKey("Id");

                    b.HasIndex("IdNV");

                    b.HasIndex("IdTheTV");

                    b.ToTable("PhieuMuon", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.PhieuMuonChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DieuKien")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("DieuKien");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GhiChu");

                    b.Property<Guid?>("IdPM")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSach")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SoLuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SoLuong");

                    b.Property<decimal>("TienTheChan")
                        .HasColumnType("Money")
                        .HasColumnName("TienTheChan");

                    b.HasKey("Id");

                    b.HasIndex("IdPM");

                    b.HasIndex("IdSach");

                    b.ToTable("PhieuMuonChiTiet", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.PhieuTra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GhiChu");

                    b.Property<Guid?>("IdPM")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayTra")
                        .IsRequired()
                        .HasColumnType("DateTime")
                        .HasColumnName("NgayTra");

                    b.HasKey("Id");

                    b.HasIndex("IdPM");

                    b.ToTable("PhieuTra", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.PhieuTraChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GhiChu");

                    b.Property<Guid?>("IdPT")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSach")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SoLuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SoLuong");

                    b.Property<int?>("TinhTrang")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("TinhTrang");

                    b.HasKey("Id");

                    b.HasIndex("IdPT");

                    b.HasIndex("IdSach");

                    b.ToTable("PhieuTraChiTiet", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.Sach", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GhiChu");

                    b.Property<decimal>("GiaTien")
                        .HasColumnType("money")
                        .HasColumnName("GiaTien");

                    b.Property<Guid?>("IdTL")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NXB")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NXB");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenSach");

                    b.Property<int?>("SoLuong")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.Property<string>("TG")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TacGia");

                    b.HasKey("Id");

                    b.HasIndex("IdTL");

                    b.ToTable("Sach", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.TheLoai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenTL");

                    b.HasKey("Id");

                    b.ToTable("TheLoai", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.TheNgay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EndTime")
                        .IsRequired()
                        .HasColumnType("DateTime")
                        .HasColumnName("EndTime");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GhiChu");

                    b.Property<Guid?>("IdNV")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("StartTime")
                        .IsRequired()
                        .HasColumnType("DateTime")
                        .HasColumnName("StartTime");

                    b.HasKey("Id");

                    b.HasIndex("IdNV");

                    b.ToTable("TheNgay", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.TheThanhVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("DiaChi");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("GhiChu");

                    b.Property<DateTime?>("NgayDangKi")
                        .IsRequired()
                        .HasColumnType("DateTime")
                        .HasColumnName("NgayDangKi");

                    b.Property<DateTime?>("NgayHetHan")
                        .IsRequired()
                        .HasColumnType("DateTime")
                        .HasColumnName("NgayHetHan");

                    b.Property<DateTime?>("NgaySinh")
                        .IsRequired()
                        .HasColumnType("DateTime")
                        .HasColumnName("NgaySinh");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("char(10)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenThanhVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenThanhVien");

                    b.HasKey("Id");

                    b.ToTable("TheThanhVien", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVien", b =>
                {
                    b.HasOne("_1_DAL.Models.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("IdCV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("_1_DAL.Models.PhieuMuon", b =>
                {
                    b.HasOne("_1_DAL.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.TheThanhVien", "TheThanhVien")
                        .WithMany()
                        .HasForeignKey("IdTheTV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");

                    b.Navigation("TheThanhVien");
                });

            modelBuilder.Entity("_1_DAL.Models.PhieuMuonChiTiet", b =>
                {
                    b.HasOne("_1_DAL.Models.PhieuMuon", "PhieuMuon")
                        .WithMany()
                        .HasForeignKey("IdPM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.Sach", "Sach")
                        .WithMany()
                        .HasForeignKey("IdSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuMuon");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("_1_DAL.Models.PhieuTra", b =>
                {
                    b.HasOne("_1_DAL.Models.PhieuMuon", "PhieuMuon")
                        .WithMany()
                        .HasForeignKey("IdPM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuMuon");
                });

            modelBuilder.Entity("_1_DAL.Models.PhieuTraChiTiet", b =>
                {
                    b.HasOne("_1_DAL.Models.PhieuTra", "PhieuTra")
                        .WithMany()
                        .HasForeignKey("IdPT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.Sach", "Sach")
                        .WithMany()
                        .HasForeignKey("IdSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuTra");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("_1_DAL.Models.Sach", b =>
                {
                    b.HasOne("_1_DAL.Models.TheLoai", "TheLoai")
                        .WithMany()
                        .HasForeignKey("IdTL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TheLoai");
                });

            modelBuilder.Entity("_1_DAL.Models.TheNgay", b =>
                {
                    b.HasOne("_1_DAL.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });
#pragma warning restore 612, 618
        }
    }
}
