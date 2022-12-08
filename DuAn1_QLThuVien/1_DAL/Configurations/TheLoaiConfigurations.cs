using _1_DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Configurations
{
    internal class TheLoaiConfigurations : IEntityTypeConfiguration<TheLoai>
    {


            public void Configure(EntityTypeBuilder<TheLoai> buider)
            {
                buider.ToTable("TheLoai");
                buider.HasKey(x => x.Id);

                buider.Property(p => p.Name).HasColumnName("TenTL").HasColumnType("nvarchar(100)").IsRequired();


        }
    }
}
