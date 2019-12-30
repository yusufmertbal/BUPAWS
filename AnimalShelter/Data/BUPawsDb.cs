using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter
{
    public class BUPawsDb : DbContext
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=BUPawsDb;Trusted_Connection=True;";
        public DbSet<PawUser> PawUsers { get; set; }
        public BUPawsDb() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating (ModelBuilder modelBuilder){
           // User is added.
            modelBuilder.Entity<PawUser>().HasData(
                new PawUser
                {
                    Id = 1,
                    Name = "YMB",
                    Surname = "Bal",
                    UserName = "admin",
                    Password = "admin",
                    CreatedDate = DateTime.Now

                }) ;
        }
    }
}
