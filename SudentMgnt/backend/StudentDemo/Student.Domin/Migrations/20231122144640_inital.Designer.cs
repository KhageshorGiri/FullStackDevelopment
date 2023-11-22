﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student.Domin.DataContext;

#nullable disable

namespace Student.Domin.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20231122144640_inital")]
    partial class inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Student.Entities.Entities.Courses", b =>
                {
                    b.Property<Guid>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("CourseTitle")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Student.Entities.Entities.Enroll", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CoursesCourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EnrolledBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EnrolledDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StudentsStudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CoursesCourseId");

                    b.HasIndex("StudentsStudentId");

                    b.ToTable("Enrolls");
                });

            modelBuilder.Entity("Student.Entities.Entities.Students", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Student.Entities.Entities.Enroll", b =>
                {
                    b.HasOne("Student.Entities.Entities.Courses", "Courses")
                        .WithMany("Enrolls")
                        .HasForeignKey("CoursesCourseId");

                    b.HasOne("Student.Entities.Entities.Students", "Students")
                        .WithMany("Enrolls")
                        .HasForeignKey("StudentsStudentId");

                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Student.Entities.Entities.Courses", b =>
                {
                    b.Navigation("Enrolls");
                });

            modelBuilder.Entity("Student.Entities.Entities.Students", b =>
                {
                    b.Navigation("Enrolls");
                });
#pragma warning restore 612, 618
        }
    }
}