using CaseProcess.Core.DomainObjects;
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
            .HasMaxLength(Constants.FIELD_MAX_LENGTH_NAME)
            .HasColumnName("Name")
            .IsRequired();
            
        builder.Property(p => p.Description)
            .HasMaxLength(Constants.FIELD_MAX_LENGTH_DESCRIPTION)
            .HasColumnName("Description")
            .IsRequired();

        builder.ToTable("Area", "Company");
    }
}
