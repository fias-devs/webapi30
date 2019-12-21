using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiCore30.Models;

namespace WebApiCore30
{
    public class DLWMSContext : DbContext
    {

        public DLWMSContext(DbContextOptions<DLWMSContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studenti>().HasData(
                new Studenti() { Id=1, Ime = "Denis", Prezime = "Music", Indeks = "IB150051"},
                new Studenti() { Id = 2, Ime = "Jasmin", Prezime = "Azemovic", Indeks = "IB150052" }
            );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Studenti> Studentis { get; set; }
    }
}
