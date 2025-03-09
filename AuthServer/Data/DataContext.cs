using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Data
{
    public class DataContext:DbContext
    {
        //public DataContext(DbContextOptions<DataContext> options) : base(options)
        //{
        //}
        public DbSet<User> Users { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Winner> Winners { get; set; }
        public DbSet<Image> Images { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Library_db");
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // הגדרת עמודות ייחודיות
        //    modelBuilder.Entity<User>()
        //        .HasIndex(u => u.Email)
        //        .IsUnique();
        //}
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // אם אתה רוצה לשמור על ההגדרה הקיימת של OnConfiguring, תוכל להשאיר אותה כמו שהיא, אחרת תוכל להוריד אותה.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AI_Battle_db");
        }
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql("server=localhost;database=competition;user=root;password=1qaz2wsx!QAZ@WSX",
        //        new MySqlServerVersion(new Version(8, 0, 21)));

        //}

    }

}

