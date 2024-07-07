using CaseProcess.Core.Entities;
﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaseProcess.Infra.Context;

public class ProcessConfiguration : IEntityTypeConfiguration<Process>
{
    public void Configure(EntityTypeBuilder<Process> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .HasMaxLength(150)
            .HasColumnName("Name")
            .IsRequired();

        builder.Property(p => p.Name)
            .HasMaxLength(150)
            .HasColumnName("Name")
            .IsRequired();

        builder.HasOne(u => u.Parent)
            .WithMany(v => v.SubProcesses)
            .HasForeignKey(u => u.ParentId);

        builder.HasOne(p => p.CompanyArea)
            .WithMany(p => p.Processes)
            .HasForeignKey(p => p.CompanyAreaId);

        builder.ToTable("Process", "Company");
    }
}