﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestXSIS.Data;

#nullable disable

namespace TestXSIS.Migrations
{
    [DbContext(typeof(MysqlDBContext))]
    [Migration("20230201025501_updateNullableImage")]
    partial class updateNullableImage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TestXSIS.Data.Movie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<string>("image")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<float?>("rating")
                        .HasColumnType("float");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.ToTable("movies");
                });
#pragma warning restore 612, 618
        }
    }
}