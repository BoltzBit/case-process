﻿// <auto-generated />
using System;
using CaseProcess.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(ProcessDbContext))]
    [Migration("20240707040049_initial-process-context")]
    partial class initialprocesscontext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CaseProcess.Core.Entities.CompanyArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Area", "Company");
                });

            modelBuilder.Entity("CaseProcess.Core.Entities.Process", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyAreaId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("Name");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CompanyAreaId");

                    b.HasIndex("ParentId");

                    b.ToTable("Process", "Company");
                });

            modelBuilder.Entity("CaseProcess.Core.Entities.Process", b =>
                {
                    b.HasOne("CaseProcess.Core.Entities.CompanyArea", "CompanyArea")
                        .WithMany("Processes")
                        .HasForeignKey("CompanyAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaseProcess.Core.Entities.Process", "Parent")
                        .WithMany("SubProcesses")
                        .HasForeignKey("ParentId");

                    b.Navigation("CompanyArea");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("CaseProcess.Core.Entities.CompanyArea", b =>
                {
                    b.Navigation("Processes");
                });

            modelBuilder.Entity("CaseProcess.Core.Entities.Process", b =>
                {
                    b.Navigation("SubProcesses");
                });
#pragma warning restore 612, 618
        }
    }
}
