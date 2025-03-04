﻿// <auto-generated />
using System;
using BarNegro.Dishes.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BarNegro.Dishes.Infrastructure.Migrations
{
    [DbContext(typeof(DishContext))]
    [Migration("20250304180238_initialDish")]
    partial class initialDish
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("BarNegro.Dishes.Domain.Entities.Dish", b =>
                {
                    b.Property<string>("DishId")
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("DishId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("BarNegro.Dishes.Domain.Entities.DishCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("DishesCategory");
                });

            modelBuilder.Entity("BarNegro.Dishes.Domain.Entities.PriceHistory", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("DishId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("NewPrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserFullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "Date", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("PriceHistory");
                });

            modelBuilder.Entity("BarNegro.Dishes.Domain.Entities.Dish", b =>
                {
                    b.HasOne("BarNegro.Dishes.Domain.Entities.DishCategory", "Category")
                        .WithMany("Dishes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BarNegro.Dishes.Domain.Entities.PriceHistory", b =>
                {
                    b.HasOne("BarNegro.Dishes.Domain.Entities.Dish", "Dish")
                        .WithMany("PriceHistory")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("BarNegro.Dishes.Domain.Entities.Dish", b =>
                {
                    b.Navigation("PriceHistory");
                });

            modelBuilder.Entity("BarNegro.Dishes.Domain.Entities.DishCategory", b =>
                {
                    b.Navigation("Dishes");
                });
#pragma warning restore 612, 618
        }
    }
}
