﻿
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings {
    public class UserMap : IEntityTypeConfiguration<User> {
        public void Configure(EntityTypeBuilder<User> builder) {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(80).HasColumnName("Name").HasColumnType("VARCHAR(80)");
            builder.Property(x => x.Password).IsRequired().HasMaxLength(30).HasColumnName("Password").HasColumnType("VARCHAR(30)");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(180).HasColumnName("Email").HasColumnType("VARCHAR(180)");
        }
    }
}
