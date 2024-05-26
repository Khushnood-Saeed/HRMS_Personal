﻿using HRMS_FieldForce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRMS_FieldForce.Models.DBcontext
{
    public class UserDBContext : IdentityDbContext<User>
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }
        public override DbSet<User> Users { get; set; }
        public DbSet<UserBasicDetails> UserBasicDetails { get; set; }
        public DbSet<UserPersonalDetail> UserPersonalDetails { get; set; }
        public DbSet<UserAttendance> UserAttendances { get; set; }

    }
}