﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mvc_project.Models;

namespace mvc_project.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("mvc_project.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("Varchar(25)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("mvc_project.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("mvc_project.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("PersonCity")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PersonName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PersonSurname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PersonId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("mvc_project.Models.Person", b =>
                {
                    b.HasOne("mvc_project.Models.Department", "Department")
                        .WithMany("Persons")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("mvc_project.Models.Department", b =>
                {
                    b.Navigation("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
