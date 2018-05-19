﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using NewAttendanceChecker.Data;
using System;

namespace NewAttendanceChecker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewAttendanceChecker.Data.Models.Attendance", b =>
                {
                    b.Property<string>("AttendanceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SessionID");

                    b.Property<string>("StudentID");

                    b.HasKey("AttendanceID");

                    b.HasIndex("SessionID");

                    b.HasIndex("StudentID");

                    b.ToTable("AttendanceList");
                });

            modelBuilder.Entity("NewAttendanceChecker.Data.Models.Course", b =>
                {
                    b.Property<string>("CourseID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("NewAttendanceChecker.Data.Models.CourseTag", b =>
                {
                    b.Property<string>("CourseTagID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseID");

                    b.Property<string>("StudentID");

                    b.HasKey("CourseTagID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("CourseTags");
                });

            modelBuilder.Entity("NewAttendanceChecker.Data.Models.Lecturer", b =>
                {
                    b.Property<string>("LecturerID");

                    b.Property<string>("Name");

                    b.HasKey("LecturerID");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("NewAttendanceChecker.Data.Models.Session", b =>
                {
                    b.Property<string>("SessionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseID");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.HasKey("SessionID");

                    b.HasIndex("CourseID");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("NewAttendanceChecker.Data.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Points");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("NewAttendanceChecker.Data.Models.Attendance", b =>
                {
                    b.HasOne("NewAttendanceChecker.Data.Models.Session", "Session")
                        .WithMany("AttendanceList")
                        .HasForeignKey("SessionID");

                    b.HasOne("NewAttendanceChecker.Data.Models.Student", "Student")
                        .WithMany("AttendanceList")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("NewAttendanceChecker.Data.Models.CourseTag", b =>
                {
                    b.HasOne("NewAttendanceChecker.Data.Models.Course", "Course")
                        .WithMany("CourseTags")
                        .HasForeignKey("CourseID");

                    b.HasOne("NewAttendanceChecker.Data.Models.Student", "Student")
                        .WithMany("CourseTags")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("NewAttendanceChecker.Data.Models.Lecturer", b =>
                {
                    b.HasOne("NewAttendanceChecker.Data.Models.Course", "Course")
                        .WithOne("Lecturer")
                        .HasForeignKey("NewAttendanceChecker.Data.Models.Lecturer", "LecturerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewAttendanceChecker.Data.Models.Session", b =>
                {
                    b.HasOne("NewAttendanceChecker.Data.Models.Course", "Course")
                        .WithMany("Sessions")
                        .HasForeignKey("CourseID");
                });
#pragma warning restore 612, 618
        }
    }
}
