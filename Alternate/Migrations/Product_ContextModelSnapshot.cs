﻿// <auto-generated />
using Alternate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alternate.Migrations
{
    [DbContext(typeof(Product_Context))]
    partial class Product_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("Alternate.Models.Parent_Product", b =>
                {
                    b.Property<int>("Parent_ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<int>("CP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MRP")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PrintName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("SP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tax")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UnitId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Parent_ProductId");

                    b.HasIndex("UnitId");

                    b.ToTable("Parent_Products");
                });

            modelBuilder.Entity("Alternate.Models.Tax", b =>
                {
                    b.Property<int>("TaxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("TaxRate")
                        .HasColumnType("INTEGER");

                    b.HasKey("TaxId");

                    b.ToTable("Taxes");
                });

            modelBuilder.Entity("Alternate.Models.Unit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("UnitId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Alternate.Models.Unit_Conversion", b =>
                {
                    b.Property<int>("Unit_ConversionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ConFact")
                        .HasColumnType("TEXT");

                    b.Property<int>("MainUnitUnitId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubUnitUnitId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Unit_ConversionId");

                    b.HasIndex("MainUnitUnitId");

                    b.HasIndex("SubUnitUnitId");

                    b.ToTable("Unit_Conversions");
                });

            modelBuilder.Entity("Alternate.Models.Parent_Product", b =>
                {
                    b.HasOne("Alternate.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Alternate.Models.Unit_Conversion", b =>
                {
                    b.HasOne("Alternate.Models.Unit", "MainUnit")
                        .WithMany()
                        .HasForeignKey("MainUnitUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Alternate.Models.Unit", "SubUnit")
                        .WithMany()
                        .HasForeignKey("SubUnitUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainUnit");

                    b.Navigation("SubUnit");
                });
#pragma warning restore 612, 618
        }
    }
}
