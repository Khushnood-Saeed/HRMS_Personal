﻿// <auto-generated />
using System;
using HRMS_FieldForce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRMS_FieldForce.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("HRMS_FieldForce.Models.Attendence+Attendance", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Date")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CheckInTime")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CheckOutTime")
                        .HasColumnType("longtext");

                    b.Property<string>("WorkFrom")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("UserId", "Date");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("HRMS_FieldForce.Models.GrantPermission", b =>
                {
                    b.Property<string>("Role")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Module")
                        .HasColumnType("int");

                    b.Property<int>("Permission")
                        .HasColumnType("int");

                    b.HasKey("Role", "Module", "Permission");

                    b.HasIndex("Module");

                    b.HasIndex("Permission");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("HRMS_FieldForce.Models.Module", b =>
                {
                    b.Property<int>("ModuleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ModuleID"));

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ModuleID");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("HRMS_FieldForce.Models.Permission", b =>
                {
                    b.Property<int>("PermissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PermissionID"));

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PermissionID");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("HRMS_FieldForce.Models.Role", b =>
                {
                    b.Property<string>("RoleID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

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
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId");

                    b.HasIndex("Role");

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

            modelBuilder.Entity("HRMS_FieldForce.Models.Attendence+Attendance", b =>
                {
                    b.HasOne("HRMS_FieldForce.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRMS_FieldForce.Models.GrantPermission", b =>
                {
                    b.HasOne("HRMS_FieldForce.Models.Module", "Modules")
                        .WithMany()
                        .HasForeignKey("Module")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRMS_FieldForce.Models.Permission", "Actions")
                        .WithMany()
                        .HasForeignKey("Permission")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRMS_FieldForce.Models.Role", "Roles")
                        .WithMany()
                        .HasForeignKey("Role")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actions");

                    b.Navigation("Modules");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("HRMS_FieldForce.Models.User", b =>
                {
                    b.HasOne("HRMS_FieldForce.Models.Role", "RoleAssigned")
                        .WithMany("Users")
                        .HasForeignKey("Role")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoleAssigned");
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

            modelBuilder.Entity("HRMS_FieldForce.Models.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
