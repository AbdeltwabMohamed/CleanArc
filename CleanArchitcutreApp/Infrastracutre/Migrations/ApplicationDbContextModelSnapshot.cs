﻿// <auto-generated />
using System;
using Infrastracutre.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastracutre.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Entites.Department", b =>
                {
                    b.Property<int>("DID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DID"));

                    b.Property<string>("DNameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNameEn")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("InsManager")
                        .HasColumnType("int");

                    b.HasKey("DID");

                    b.HasIndex("InsManager")
                        .IsUnique()
                        .HasFilter("[InsManager] IS NOT NULL");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Data.Entites.DepartmetSubject", b =>
                {
                    b.Property<int>("SubID")
                        .HasColumnType("int");

                    b.Property<int>("DID")
                        .HasColumnType("int");

                    b.HasKey("SubID", "DID");

                    b.HasIndex("DID");

                    b.ToTable("departmetSubjects");
                });

            modelBuilder.Entity("Data.Entites.Student", b =>
                {
                    b.Property<int>("StudID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudID"));

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("DID")
                        .HasColumnType("int");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("StudID");

                    b.HasIndex("DID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Data.Entites.StudentSubject", b =>
                {
                    b.Property<int>("SubID")
                        .HasColumnType("int");

                    b.Property<int>("StudID")
                        .HasColumnType("int");

                    b.Property<decimal?>("grade")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SubID", "StudID");

                    b.HasIndex("StudID");

                    b.ToTable("studentSubjects");
                });

            modelBuilder.Entity("Data.Entites.Subject", b =>
                {
                    b.Property<int>("SubID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubID"));

                    b.Property<DateTime?>("Period")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectNameAr")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SubjectNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubID");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.Ins_Subject", b =>
                {
                    b.Property<int>("SubId")
                        .HasColumnType("int");

                    b.Property<int>("InsId")
                        .HasColumnType("int");

                    b.HasKey("SubId", "InsId");

                    b.HasIndex("InsId");

                    b.ToTable("Ins_Subject");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.Instructor", b =>
                {
                    b.Property<int>("InsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InsId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DID")
                        .HasColumnType("int");

                    b.Property<string>("ENameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SupervisorId")
                        .HasColumnType("int");

                    b.HasKey("InsId");

                    b.HasIndex("DID");

                    b.HasIndex("SupervisorId");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("Data.Entites.Department", b =>
                {
                    b.HasOne("SchoolProject.Data.Entities.Instructor", "Instructor")
                        .WithOne("departmentManager")
                        .HasForeignKey("Data.Entites.Department", "InsManager");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Data.Entites.DepartmetSubject", b =>
                {
                    b.HasOne("Data.Entites.Department", "Department")
                        .WithMany("DepartmentSubjects")
                        .HasForeignKey("DID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entites.Subject", "Subject")
                        .WithMany("DepartmetsSubjects")
                        .HasForeignKey("SubID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Data.Entites.Student", b =>
                {
                    b.HasOne("Data.Entites.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Data.Entites.StudentSubject", b =>
                {
                    b.HasOne("Data.Entites.Student", "Student")
                        .WithMany("StudentSubject")
                        .HasForeignKey("StudID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entites.Subject", "Subject")
                        .WithMany("StudentSubject")
                        .HasForeignKey("SubID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.Ins_Subject", b =>
                {
                    b.HasOne("SchoolProject.Data.Entities.Instructor", "instructor")
                        .WithMany("Ins_Subjects")
                        .HasForeignKey("InsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entites.Subject", "Subject")
                        .WithMany("Ins_Subjects")
                        .HasForeignKey("SubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("instructor");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.Instructor", b =>
                {
                    b.HasOne("Data.Entites.Department", "department")
                        .WithMany("Instructors")
                        .HasForeignKey("DID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolProject.Data.Entities.Instructor", "Supervisor")
                        .WithMany("Instructors")
                        .HasForeignKey("SupervisorId");

                    b.Navigation("Supervisor");

                    b.Navigation("department");
                });

            modelBuilder.Entity("Data.Entites.Department", b =>
                {
                    b.Navigation("DepartmentSubjects");

                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Data.Entites.Student", b =>
                {
                    b.Navigation("StudentSubject");
                });

            modelBuilder.Entity("Data.Entites.Subject", b =>
                {
                    b.Navigation("DepartmetsSubjects");

                    b.Navigation("Ins_Subjects");

                    b.Navigation("StudentSubject");
                });

            modelBuilder.Entity("SchoolProject.Data.Entities.Instructor", b =>
                {
                    b.Navigation("Ins_Subjects");

                    b.Navigation("Instructors");

                    b.Navigation("departmentManager");
                });
#pragma warning restore 612, 618
        }
    }
}
