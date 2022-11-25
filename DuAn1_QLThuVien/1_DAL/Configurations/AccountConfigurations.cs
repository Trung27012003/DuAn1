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
        public class AccountConfigurations : IEntityTypeConfiguration<Account>
        {
            public void Configure(EntityTypeBuilder<Account> buider)
            {
                buider.ToTable("Account");
                buider.HasKey(x => x.UserName);
                buider.Property(p => p.UserName).HasColumnName("UserName").HasColumnType("nvarchar(100)").IsRequired();
                buider.Property(p => p.PassWord).HasColumnName("PassWord").HasColumnType("nvarchar(100)").IsRequired();
            }
        }
}
