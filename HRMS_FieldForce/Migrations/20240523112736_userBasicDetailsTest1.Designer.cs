﻿// <auto-generated />
using System;
using HRMS_FieldForce.Models.DBcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRMS_FieldForce.Migrations
{
    [DbContext(typeof(UserDBContext))]
    [Migration("20240523112736_userBasicDetailsTest1")]
    partial class userBasicDetailsTest1
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

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
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

            modelBuilder.Entity("HRMS_FieldForce.Models.UserBasicDetails", b =>
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

            modelBuilder.Entity("HRMS_FieldForce.Models.UserBasicDetails", b =>
                {
                    b.HasOne("HRMS_FieldForce.Models.User", "User")
                        .WithMany("userBasicDetails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRMS_FieldForce.Models.User", b =>
                {
                    b.Navigation("userBasicDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
