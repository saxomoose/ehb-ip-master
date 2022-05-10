﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UuidMasterApi;

#nullable disable

namespace UuidMasterApi.Migrations
{
    [DbContext(typeof(UuidMasterApiDbContext))]
    [Migration("20220509060609_ResourcesTableAlterColumnTypes")]
    partial class ResourcesTableAlterColumnTypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UuidMasterApi.Entities.Resource", b =>
                {
                    b.Property<Guid>("Uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntityType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EntityVersion")
                        .HasColumnType("int");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.Property<int>("SourceEntityId")
                        .HasColumnType("int");

                    b.HasKey("Uuid");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            Uuid = new Guid("6b084a13-3a05-4a0e-9464-5e6dd624b36b"),
                            EntityType = "user",
                            EntityVersion = 1,
                            Source = 2,
                            SourceEntityId = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}