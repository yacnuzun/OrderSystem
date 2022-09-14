﻿// <auto-generated />
using System;
using DataAccess.Concrete.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(OrderSystemDbContext))]
    partial class OrderSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Concrete.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Entities.Concrete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 123,
                            CompanyId = 1,
                            Date = new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalAmount = 40
                        },
                        new
                        {
                            Id = 124,
                            CompanyId = 1,
                            Date = new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalAmount = 100
                        });
                });

            modelBuilder.Entity("Entities.Concrete.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrderProducts");

                    b.HasData(
                        new
                        {
                            Id = 123,
                            OrderId = 123,
                            ProductId = 123
                        },
                        new
                        {
                            Id = 124,
                            OrderId = 123,
                            ProductId = 123
                        },
                        new
                        {
                            Id = 1234,
                            OrderId = 124,
                            ProductId = 1234
                        },
                        new
                        {
                            Id = 1235,
                            OrderId = 124,
                            ProductId = 1234
                        },
                        new
                        {
                            Id = 1236,
                            OrderId = 124,
                            ProductId = 124
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 123,
                            Amount = 20,
                            Name = "Elma",
                            ProductCode = "3007975"
                        },
                        new
                        {
                            Id = 124,
                            Amount = 40,
                            Name = "Armut",
                            ProductCode = "11"
                        },
                        new
                        {
                            Id = 1234,
                            Amount = 30,
                            Name = "Ayva",
                            ProductCode = "w-l-12532w2i"
                        },
                        new
                        {
                            Id = 1235,
                            Amount = 12,
                            Name = "Maydonoz",
                            ProductCode = "065781-31966"
                        },
                        new
                        {
                            Id = 1236,
                            Amount = 5,
                            Name = "Havuç",
                            ProductCode = "12321321"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
