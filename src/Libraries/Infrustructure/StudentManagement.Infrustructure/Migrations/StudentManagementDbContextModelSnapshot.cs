﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagement.Infrustructure;

#nullable disable

namespace StudentManagement.Infrustructure.Migrations
{
    [DbContext(typeof(StudentManagementDbContext))]
    partial class StudentManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentManagement.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AddmissionFee")
                        .HasColumnType("float");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stutus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddmissionFee = 32000.0,
                            CourseName = "DotNet",
                            Created = new DateTimeOffset(new DateTime(2023, 8, 10, 16, 0, 44, 874, DateTimeKind.Unspecified).AddTicks(7618), new TimeSpan(0, 6, 0, 0, 0)),
                            CreatedBy = "1",
                            StudentName = "Rabbi",
                            Stutus = 1
                        });
                });

            modelBuilder.Entity("StudentManagement.Model.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("Stutus")
                        .HasColumnType("int");

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teacher", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTimeOffset(new DateTime(2023, 8, 10, 16, 0, 44, 876, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 6, 0, 0, 0)),
                            CreatedBy = "1",
                            Department = "IT",
                            Salary = 40000.0,
                            Stutus = 1,
                            TeacherName = "Santanu"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
