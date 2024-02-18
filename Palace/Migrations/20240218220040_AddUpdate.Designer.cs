﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Palace.Models;

#nullable disable

namespace Palace.Migrations
{
    [DbContext(typeof(PalaceContext))]
    [Migration("20240218220040_AddUpdate")]
    partial class AddUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Palace.Models.Bouquet", b =>
                {
                    b.Property<int>("BouquetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BouquetId");

                    b.ToTable("Bouquets");
                });

            modelBuilder.Entity("Palace.Models.BouquetFlower", b =>
                {
                    b.Property<int>("BouquetFlowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BouquetId")
                        .HasColumnType("int");

                    b.Property<int>("FlowerId")
                        .HasColumnType("int");

                    b.HasKey("BouquetFlowerId");

                    b.HasIndex("BouquetId");

                    b.HasIndex("FlowerId");

                    b.ToTable("BouquetFlowers");
                });

            modelBuilder.Entity("Palace.Models.Flower", b =>
                {
                    b.Property<int>("FlowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("FlowerId");

                    b.ToTable("Flowers");
                });

            modelBuilder.Entity("Palace.Models.BouquetFlower", b =>
                {
                    b.HasOne("Palace.Models.Bouquet", "Bouquet")
                        .WithMany("BouquetFlowers")
                        .HasForeignKey("BouquetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Palace.Models.Flower", "Flower")
                        .WithMany("BouquetFlowers")
                        .HasForeignKey("FlowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bouquet");

                    b.Navigation("Flower");
                });

            modelBuilder.Entity("Palace.Models.Bouquet", b =>
                {
                    b.Navigation("BouquetFlowers");
                });

            modelBuilder.Entity("Palace.Models.Flower", b =>
                {
                    b.Navigation("BouquetFlowers");
                });
#pragma warning restore 612, 618
        }
    }
}