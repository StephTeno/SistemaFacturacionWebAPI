﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(FacturationSystemContext))]
    partial class FacturationSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPI.Models.Clases.Categories", b =>
                {
                    b.Property<int>("CategoriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriesId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriesId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Description", b =>
                {
                    b.Property<int>("DescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DescriptionId"));

                    b.Property<int>("Cant")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("DescriptionId");

                    b.ToTable("Description");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Historical", b =>
                {
                    b.Property<int>("HistoricalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoricalId"));

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.HasKey("HistoricalId");

                    b.ToTable("Historical");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HistoricalId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<int>("WaitersId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId");

                    b.HasIndex("HistoricalId");

                    b.HasIndex("TableId");

                    b.HasIndex("WaitersId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.InvoiceDescription", b =>
                {
                    b.Property<int>("InDeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InDeId"));

                    b.Property<int>("DescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.HasKey("InDeId");

                    b.HasIndex("DescriptionId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("InvoiceDescription");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Products", b =>
                {
                    b.Property<int>("ProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductsId"));

                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("DescriptionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NombreDelProducto");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PrecioUnitario");

                    b.HasKey("ProductsId");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("DescriptionId")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Tables", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableId"));

                    b.Property<int>("WaitersId")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.HasIndex("WaitersId");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            TableId = 1,
                            WaitersId = 1
                        },
                        new
                        {
                            TableId = 2,
                            WaitersId = 2
                        },
                        new
                        {
                            TableId = 3,
                            WaitersId = 1
                        },
                        new
                        {
                            TableId = 4,
                            WaitersId = 2
                        },
                        new
                        {
                            TableId = 5,
                            WaitersId = 1
                        },
                        new
                        {
                            TableId = 6,
                            WaitersId = 2
                        });
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Waiters", b =>
                {
                    b.Property<int>("WaitersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WaitersId"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateAdmission")
                        .HasColumnType("datetime2");

                    b.Property<string>("WaitersFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WaitersId");

                    b.ToTable("Waiters");

                    b.HasData(
                        new
                        {
                            WaitersId = 1,
                            Birthday = new DateTime(2005, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateAdmission = new DateTime(2023, 6, 8, 8, 42, 55, 206, DateTimeKind.Local).AddTicks(6850),
                            WaitersFullName = "Stephanie Tenorio"
                        },
                        new
                        {
                            WaitersId = 2,
                            Birthday = new DateTime(2005, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateAdmission = new DateTime(2023, 6, 8, 8, 42, 55, 206, DateTimeKind.Local).AddTicks(6944),
                            WaitersFullName = "Carolina Orozco"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Invoice", b =>
                {
                    b.HasOne("WebAPI.Models.Clases.Historical", "Historical")
                        .WithMany("Invoices")
                        .HasForeignKey("HistoricalId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Clases.Tables", "Tables")
                        .WithMany("Invoices")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Clases.Waiters", "Waiters")
                        .WithMany("Invoices")
                        .HasForeignKey("WaitersId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Historical");

                    b.Navigation("Tables");

                    b.Navigation("Waiters");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.InvoiceDescription", b =>
                {
                    b.HasOne("WebAPI.Models.Clases.Description", "Description")
                        .WithMany("InvoicesDescription")
                        .HasForeignKey("DescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Clases.Invoice", "Invoice")
                        .WithMany("InvoicesDescription")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Description");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Products", b =>
                {
                    b.HasOne("WebAPI.Models.Clases.Categories", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Clases.Description", "Description")
                        .WithOne("Products")
                        .HasForeignKey("WebAPI.Models.Clases.Products", "DescriptionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Description");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Tables", b =>
                {
                    b.HasOne("WebAPI.Models.Clases.Waiters", null)
                        .WithMany("Tables")
                        .HasForeignKey("WaitersId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Description", b =>
                {
                    b.Navigation("InvoicesDescription");

                    b.Navigation("Products")
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Historical", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Invoice", b =>
                {
                    b.Navigation("InvoicesDescription");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Tables", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("WebAPI.Models.Clases.Waiters", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("Tables");
                });
#pragma warning restore 612, 618
        }
    }
}
