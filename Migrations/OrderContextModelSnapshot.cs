﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cineweb_orders_api.Context;

namespace cineweb_orders_api.Migrations
{
    [DbContext(typeof(OrderContext))]
    partial class OrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("cineweb_orders_api.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("MovieId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<decimal>("OrderAmount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<byte[]>("UserId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("Id");

                    b.ToTable("order");
                });
#pragma warning restore 612, 618
        }
    }
}
