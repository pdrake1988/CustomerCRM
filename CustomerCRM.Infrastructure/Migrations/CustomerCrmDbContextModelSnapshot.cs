﻿// <auto-generated />
using System;
using CustomerCRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerCrm.Infrastructure.Migrations
{
    [DbContext(typeof(CustomerCrmDbContext))]
    partial class CustomerCrmDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CustomerCrm.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("Varchar(80)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("Varchar");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("Varchar(200)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("Varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("Varchar(80)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("Varchar(15)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("Varchar(MAX)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("ReportsTo")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("TitleOfCourtesy")
                        .IsRequired()
                        .HasColumnType("Varchar(5)");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(30)");

                    b.Property<int>("QuantityPerUnit")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.Property<int>("UnitsOnOrder")
                        .HasColumnType("int");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("VendorId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Shipper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("Varchar(15)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Shipper");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Category", b =>
                {
                    b.HasOne("CustomerCrm.Core.Entities.Category", null)
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Customer", b =>
                {
                    b.HasOne("CustomerCrm.Core.Entities.Region", "Region")
                        .WithMany("Customers")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Employee", b =>
                {
                    b.HasOne("CustomerCrm.Core.Entities.Region", "Region")
                        .WithMany("Employees")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Product", b =>
                {
                    b.HasOne("CustomerCrm.Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerCrm.Core.Entities.Vendor", "Vendor")
                        .WithMany("Products")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Shipper", b =>
                {
                    b.HasOne("CustomerCrm.Core.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Category", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Region", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CustomerCrm.Core.Entities.Vendor", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
