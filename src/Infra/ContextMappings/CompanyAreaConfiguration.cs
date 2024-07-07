using CaseProcess.Core.Entities;
﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaseProcess.Infra.Context;

public class CompanyConfiguration : IEntityTypeConfiguration<CompanyArea>
{
    public void Configure(EntityTypeBuilder<CompanyArea> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .HasMaxLength(150)
            .HasColumnName("Name")
            .IsRequired();

        builder.ToTable("Area", "Company");
    }
}
