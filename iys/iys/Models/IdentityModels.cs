﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace iys.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<ANSWER> ANSWERS { get; set; }
        public DbSet<ANSWER_RESULT> ANSWER_RESULTS { get; set; }
        public DbSet<CHAPTER> CHAPTERS { get; set; }
        public DbSet<COURSE> COURSES { get; set; }
        public DbSet<DOCUMENT> DOCUMENTS { get; set; }
        public DbSet<LESSON> LESSONS { get; set; }
        public DbSet<QUESTION> QUESTIONS { get; set; }

    }
}