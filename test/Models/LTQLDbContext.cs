using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace test.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext () : base ("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);
            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID)
                .IsUnicode(false);
        }


    }
}