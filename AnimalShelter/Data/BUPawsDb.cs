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
        public DbSet<AnimalShelter.Data.PawArea> pawAreas { get; set; }
        public DbSet<AnimalShelter.Data.PawVaccine> pawVaccines { get; set; }
        public DbSet<AnimalShelter.Data.PawHealth> pawHealths { get; set; }
        public DbSet<AnimalShelter.Data.PawAnimal> pawAnimals { get; set; }
        public BUPawsDb() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating (ModelBuilder modelBuilder){
           // User verileri eklendi.
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

            //area verileri eklendi
            modelBuilder.Entity<AnimalShelter.Data.PawArea>().HasData(
                new Data.PawArea
                {
                    Id = 1,
                    Code = "GK",
                    Name = "Güney Kampüs"
                }) ;

            modelBuilder.Entity<AnimalShelter.Data.PawArea>().HasData(
                new Data.PawArea
                {
                    Id = 2,
                    Code = "KK",
                    Name = "Kuzey Kampüs"
                });
            modelBuilder.Entity<AnimalShelter.Data.PawArea>().HasData(
                new Data.PawArea
                {
                    Id = 3,
                    Code = "UK",
                    Name = "Uçaksavar Kampüs"
                });
            modelBuilder.Entity<AnimalShelter.Data.PawArea>().HasData(
                new Data.PawArea
                {
                    Id = 4,
                    Code = "HK",
                    Name = "Hisar Kampüs"
                });
            modelBuilder.Entity<AnimalShelter.Data.PawArea>().HasData(
                new Data.PawArea
                {
                    Id = 5,
                    Code = "SK",
                    Name = "Sarıtepe Kampüs"
                });
            modelBuilder.Entity<AnimalShelter.Data.PawArea>().HasData(
                new Data.PawArea
                {
                    Id = 6,
                    Code = "KAK",
                    Name = "Kandilli Kampüs"
                });
            
            //aşı verileri eklendi
            modelBuilder.Entity<AnimalShelter.Data.PawVaccine>().HasData(
                new Data.PawVaccine 
                {
                    Id=1,
                    VaccineName="Aşılı"
                }
                );
            modelBuilder.Entity<AnimalShelter.Data.PawVaccine>().HasData(
                new Data.PawVaccine
                {
                    Id = 2,
                    VaccineName = "Aşısız"
                }
                );
            modelBuilder.Entity<AnimalShelter.Data.PawVaccine>().HasData(
                new Data.PawVaccine
                {
                    Id = 3,
                    VaccineName = "Bilinmiyor"
                }
                );

            //healt verileri girildi.
            modelBuilder.Entity<AnimalShelter.Data.PawHealth>().HasData(
                new Data.PawHealth
                {
                    Id=1,
                    HealthyOrSick="Sağlıklı"
                });
            modelBuilder.Entity<AnimalShelter.Data.PawHealth>().HasData(
                new Data.PawHealth
                {
                    Id = 2,
                    HealthyOrSick = "Hasta"
                });

            modelBuilder.Entity<AnimalShelter.Data.PawAnimal>().HasData(
                new Data.PawAnimal 
                {
                    Id=1,
                    AnimalName="Harun",
                    Species="Köpek",
                    AnimalArea="KK Kuzey Kampüs",
                    Vaccine="Aşılı",
                    Health="Hasta"
                });
        }
    }
}
