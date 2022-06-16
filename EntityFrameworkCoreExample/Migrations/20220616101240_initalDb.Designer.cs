﻿// <auto-generated />
using EntityFrameworkCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkCoreExample.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20220616101240_initalDb")]
    partial class initalDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFrameworkCoreExample.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("department_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LocationRefId")
                        .HasColumnType("int")
                        .HasColumnName("department_location");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("department_name");

                    b.HasKey("Id");

                    b.ToTable("department");
                });

            modelBuilder.Entity("EntityFrameworkCoreExample.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Address")
                        .HasColumnType("int")
                        .HasColumnName("adrees");

                    b.Property<int>("DepartmentRefId")
                        .HasColumnType("int")
                        .HasColumnName("department_ref_id");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("employee_name");

                    b.Property<int>("Salary")
                        .HasColumnType("int")
                        .HasColumnName("salary");

                    b.HasKey("Id");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("EntityFrameworkCoreExample.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("location_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("location_name");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("location_pincode");

                    b.HasKey("Id");

                    b.ToTable("location");
                });
#pragma warning restore 612, 618
        }
    }
}
