﻿// <auto-generated />
using System;
using HRMS_FieldForce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRMS_FieldForce.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240523113737_MadeUserBasicDetailsModule")]
    partial class MadeUserBasicDetailsModule
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("HRMS_FieldForce.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CompanyEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PersonalEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HRMS_FieldForce.Models.UserBasicDetail", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AccountNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Benefits")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EOBI")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ExperienceInFieldForce")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("GrossSalary")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ReportingTo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TotalExperience")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("WorkingHours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("UserBasicDetails");
                });

            modelBuilder.Entity("HRMS_FieldForce.Models.UserPersonalDetail", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CNIC")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmergencyContact")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmployeeStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobGrade")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PermanentAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("UserPersonalDetails");
                });

            modelBuilder.Entity("HRMS_FieldForce.Models.UserBasicDetail", b =>
                {
                    b.HasOne("HRMS_FieldForce.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRMS_FieldForce.Models.UserPersonalDetail", b =>
                {
                    b.HasOne("HRMS_FieldForce.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
